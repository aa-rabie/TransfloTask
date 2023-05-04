using Microsoft.EntityFrameworkCore;
using Transflo.Driver.Application.Dto;
using Transflo.Driver.Application.Interfaces;
using Transflo.Driver.Data;
using Mapster;
using Microsoft.Data.Sqlite;

namespace Transflo.Driver.Application.Services
{
    public class DriverService : IDriverService
    {
        private readonly DriverDbContext _context;
        public DriverService(DriverDbContext context) { 
            _context = context;
        }
        public async Task<List<DriverDto>> GetAllAsync()
        {
            var data = await _context.Drivers.ToListAsync();
           return data.Adapt<List<DriverDto>>();

        }

        public async Task<DriverDto?> GetByIdAsync(int id)
        {
            var model = await _context.Drivers.AsNoTracking()
                .FirstOrDefaultAsync(model => model.Id == id);

            return model != null ? model.Adapt<DriverDto>() : null;
        }

        public async Task<DriverDto> InsertAsync(PostDriverDto dto)
        {
            if(dto == null)
            {
                throw new ArgumentNullException(nameof(dto));
            }

            var model = dto.Adapt<Models.Driver>();

            _context.Drivers.Add(model);
            await _context.SaveChangesAsync();

            return model.Adapt<DriverDto>();
        }

        public async Task<int> UpdateAsync(UpdateDriverDto dto)
        {
            if (dto == null)
            {
                throw new ArgumentNullException(nameof(dto));
            }

            var affected = await _context.Drivers
                    .Where(model => model.Id == dto.GetDriverId())
                    .ExecuteUpdateAsync(setters => setters
                      .SetProperty(m => m.FirstName, dto.FirstName)
                      .SetProperty(m => m.LastName, dto.LastName)
                      .SetProperty(m => m.Email, dto.Email)
                      .SetProperty(m => m.Phone, dto.Phone)
                    );

            return affected;
        }

        public async Task<int> DeleteByIdAsync(int id)
        {
            var affected = await _context.Drivers
                .Where(model => model.Id == id)
                .ExecuteDeleteAsync();

            return affected;
        }

        public async Task<List<AlphabetizedDriverDto>> GetAllAlphabetizedAsync()
        {
            var data = await _context.Drivers.ToListAsync();
            var dtos = data.Adapt<List<AlphabetizedDriverDto>>();
            dtos.Sort((x,y) => String.Compare(x.FullName!.ToLowerInvariant(),y.FullName!.ToLowerInvariant()));
            return dtos;
        }
    }
}
