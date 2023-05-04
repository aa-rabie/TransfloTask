using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transflo.Driver.Application.Dto;

namespace Transflo.Driver.Application.Interfaces
{
    public interface IDriverService
    {
        Task<List<DriverDto>> GetAllAsync();
        Task<DriverDto?> GetByIdAsync(int id);
        Task<DriverDto> InsertAsync(PostDriverDto dto);
        Task<int> DeleteByIdAsync(int id);
        Task<int> UpdateAsync(UpdateDriverDto dto);
        Task<List<AlphabetizedDriverDto>> GetAllAlphabetizedAsync();
    }
}
