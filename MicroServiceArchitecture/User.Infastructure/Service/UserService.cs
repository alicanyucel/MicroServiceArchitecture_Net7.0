using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Domain.Dtos;
using User.Domain.Service;

namespace User.Infastructure.Service
{
    public class UserService : IUserService
    {
        public UserDto GetUserByUsername(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                return null;
            }
            else
            {
                var user = new UserDto
                {
                    Username = "ali can yücel"
                };
            return user;
            }

        }
    }
}