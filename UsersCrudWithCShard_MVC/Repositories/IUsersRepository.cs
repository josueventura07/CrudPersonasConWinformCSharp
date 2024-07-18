using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersCrudWithCShard_MVC.Models;
using UsersCrudWithCShard_MVC.DTOs;
using UsersCrudWithCShard_MVC.UserDTO;

namespace UsersCrudWithCShard_MVC.Repositories
{
    public interface IUsersRepository
    {
        bool AddNewUser(UserInsertDto userInsertDto);
        bool UpdateUser(UserDto userDto);
        bool DeleteUser(int id);
        UserDto FindUserById(int id);
        IEnumerable<UserDto> FindAllUsers();
        IEnumerable<UserDto> FindUserLikeValue(String value);
    }
}
