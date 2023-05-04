using Mapster;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using Transflo.Driver.Application.Dto;
using Transflo.Driver.Data;

namespace Transflo.Driver.Api.IntegrationTests
{
    public class CustomWebApplicationFactory<TProgram>
    : WebApplicationFactory<TProgram> where TProgram : class
    {
        protected List<Models.Driver> _testData = new List<Models.Driver>();

        internal List<Models.Driver> TestData
        {
            get
            {
                return _testData;
            }
        }

        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {
                var dbContextDescriptor = services.SingleOrDefault(
                    d => d.ServiceType ==
                        typeof(DbContextOptions<DriverDbContext>));

                services.Remove(dbContextDescriptor);

                var dbConnectionDescriptor = services.SingleOrDefault(
                    d => d.ServiceType ==
                        typeof(DbConnection));

                services.Remove(dbConnectionDescriptor);

                // Create open SqliteConnection so EF won't automatically close it.
                services.AddSingleton<DbConnection>(container =>
                {
                    var connection = new SqliteConnection("Data Source=InMemoryTest;Mode=Memory;Cache=Shared");
                    connection.Open();

                    return connection;
                });

                services.AddDbContext<DriverDbContext>((container, options) =>
                {
                    var connection = container.GetRequiredService<DbConnection>();
                    options.UseSqlite(connection);
                });

                var sp = services.BuildServiceProvider();
                using (var scope = sp.CreateScope())
                {
                    var scopedServices = scope.ServiceProvider;
                    var context = scopedServices.GetRequiredService<DriverDbContext>();
                    context.Database.EnsureCreated();
                }

            });

            builder.UseEnvironment("Test");
        }

        public void InitTestDb(DriverDbContext cx)
        {
            _testData = new List<Models.Driver>();
            var data = DataSeedGenerator.GenerateDriverData(1000,5, false);

            foreach (var driver in data)
            {
                cx.Drivers.Add(driver);
            }

            cx.SaveChanges();

            _testData.AddRange(cx.Drivers.ToList());
        }

        public void CleanupDb(DriverDbContext db)
        {
            if (db != null && db.Drivers.Any())
            {
                db.Drivers.RemoveRange(db.Drivers);
                db.SaveChanges();
            }
            
        }

        public int GetDriverMaxId()
        {
            using var cx = this.Services.GetRequiredService<DriverDbContext>();
            return cx.Database
               .SqlQuery<int>($"select max(id) as maxid from drivers")
               .First();
        }

        public DriverDto GetLastDriverObject()
        {
            using var cx = this.Services.GetRequiredService<DriverDbContext>();
            var entity = (from d in cx.Drivers orderby d.Id descending select d).Take(1).FirstOrDefault();
            return entity == null ? null : entity.Adapt<DriverDto>();
        }
    }
}   