using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersCrudWithCShard_MVC.Models;

namespace UsersCrudWithCShard_MVC.Views
{
    public interface IUserView
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
        string Email { get; set; }


        string SearchValue { get; set; }
        bool GetIsEdit { get; set; }
        bool IsSuccessfull { get; set; }
        string Message { get; set; }
        
        void UsersListBindingSource(UsersModel userModel);

    }
}
