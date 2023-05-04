using Bogus;
using Transflo.Driver.Models;

namespace Transflo.Driver.Data
{
    internal class DataSeedGenerator
    {
        public static List<Models.Driver> GenerateDriverData(int startId = 1,int dataSize = 100, bool initId = true)
        {
            var ids = startId;
            var generator = new Faker<Models.Driver>()
                .RuleFor(m => m.Id, f => initId ? ids++ : 0)
                .RuleFor(u => u.FirstName, (f, u) => f.Name.FirstName())
                .RuleFor(u => u.LastName, (f, u) => f.Name.LastName())
                .RuleFor(u => u.Email, (f, u) => f.Internet.Email(u.FirstName, u.LastName))
                .RuleFor(u => u.Phone, (f, u) => f.Phone.PhoneNumber());

            if (dataSize == 1)
            {
                var data = generator.Generate();
                return new List<Models.Driver>() { data };
            }
            return generator.GenerateBetween(dataSize, dataSize);

        }
    }
}