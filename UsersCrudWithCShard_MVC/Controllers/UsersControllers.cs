using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsersCrudWithCShard_MVC.DTOs;
using UsersCrudWithCShard_MVC.Models;
using UsersCrudWithCShard_MVC.Repositories;
using UsersCrudWithCShard_MVC.Repositories.Common;
using UsersCrudWithCShard_MVC.UserDTO;
using UsersCrudWithCShard_MVC.Services;


namespace UsersCrudWithCShard_MVC.Controllers
{
    public class UsersControllers : IUsersControllers
    {

        private IUsersRepository _usersRepository;

        public UsersControllers(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

      
        public bool CreateUser(UserInsertDto userInsertDto)
        {
            try
            {
              

                new ModelDataValidation().Validate(userInsertDto);

                if (_usersRepository.AddNewUser(userInsertDto))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex) 
            {
                
                MessageBox.Show(ex.Message, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        bool IUsersControllers.PatchUser(UserDto userDto)
        {
            try
            {
               
                new ModelDataValidation().Validate(userDto);

                if (_usersRepository.UpdateUser(userDto))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        UserDto IUsersControllers.GetUserById(int id)
        {
            try
            {
                var userDto = new UserDto();

                userDto = _usersRepository.FindUserById(id);

                return userDto;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        bool IUsersControllers.DestroyUserById(int id)
        {
            try
            {
                bool isUserDeleted = _usersRepository.DeleteUser(id);
                
                if (isUserDeleted) { 
                    return true;
                }  else
                {
                    return false;
                }  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        IEnumerable<UserDto> IUsersControllers.GetAllUsers()
        {
            IEnumerable<UserDto> userList;

            userList = _usersRepository.FindAllUsers();

            return userList;
        }

        IEnumerable<UserDto> IUsersControllers.GetAllUsersLikeValue(string value)
        {
            IEnumerable<UserDto> userList;

            userList = _usersRepository.FindUserLikeValue(value);

            return userList;
        }

       
    }
}
