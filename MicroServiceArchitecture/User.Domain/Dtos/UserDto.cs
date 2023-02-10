using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.Domain.Dtos
{
    public class UserDto
    {
        public string Username { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? Age => BirthDate.HasValue ? DateTime.Now.Year - BirthDate.Value.Year : (int?)null;
    }
}
