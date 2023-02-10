using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Domain.Dtos;

namespace User.Domain.Service
{
    public interface IUserService
    {
        UserDto GetUserByUsername(string username);
    }
}
