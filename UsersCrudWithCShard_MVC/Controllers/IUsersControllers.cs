using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsersCrudWithCShard_MVC.Models;
using UsersCrudWithCShard_MVC.Repositories.Common;
using UsersCrudWithCShard_MVC.Repositories;
using UsersCrudWithCShard_MVC.UserDTO;
using UsersCrudWithCShard_MVC.DTOs;

namespace UsersCrudWithCShard_MVC.Controllers
{
    public interface IUsersControllers
    {
        bool CreateUser(UserInsertDto userInsertDto);

        bool PatchUser(UserDto userDto);

        UserDto GetUserById(int id);

        bool DestroyUserById(int id);

        IEnumerable<UserDto> GetAllUsers();

        IEnumerable<UserDto> GetAllUsersLikeValue(string value);
        
    }
}
