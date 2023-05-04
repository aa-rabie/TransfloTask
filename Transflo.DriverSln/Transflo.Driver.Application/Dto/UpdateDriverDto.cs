using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transflo.Driver.Application.Dto
{
    public class UpdateDriverDto
    {
        private int id { get; set; }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }

        public int GetDriverId () { return id; }
        public void SetDriverId(int id) { this.id = id; }
    }
}
