using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsersCrudWithCShard_MVC.Controllers;
using UsersCrudWithCShard_MVC.DTOs;
using UsersCrudWithCShard_MVC.UserDTO;

namespace UsersCrudWithCShard_MVC.Views
{
    public partial class UserView : Form
    {

        private int userId;
        private IUsersControllers _userController;
        

        public UserView(IUsersControllers usersControllers, [Optional] int userId)
        {
            InitializeComponent();
            
            this.userId = userId;
            _userController = usersControllers;

            if (this.userId <= 0)
            {
                this.lbl_titleForm.Text = "Nuevo Usuario";
            }
            else 
            {
                this.lbl_titleForm.Text = "Editar Usuario";
            }

            this.txt_id.Enabled = false;
            this.StartPosition = FormStartPosition.CenterParent;

            txt_nombre.TextChanged += (s, e) =>
            {
                if (txt_nombre.Text != "")
                {
                    btn_cancel.Text = "Cancelar";
                }
            };

            txt_apellido.TextChanged += (s, e) =>
            {
                if (txt_apellido.Text != "")
                {
                    btn_cancel.Text = "Cancelar";
                }
            };

            txt_nombreUsuario.TextChanged += (s, e) =>
            {
                if (txt_nombreUsuario.Text != "")
                {
                    btn_cancel.Text = "Cancelar";
                }
            };

            txt_contrasenia.TextChanged += (s, e) =>
            {
                if (txt_contrasenia.Text != "")
                {
                    btn_cancel.Text = "Cancelar";
                }
            };

            txt_correo.TextChanged += (s, e) =>
            {
                if (txt_correo.Text != "")
                {
                    btn_cancel.Text = "Cancelar";
                }
            };

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (userId <= 0)
                {

                    var userDto = new UserInsertDto();

                    userDto.firstName = this.txt_nombre.Text.Trim();
                    userDto.lastName = this.txt_apellido.Text.Trim();
                    userDto.userName = this.txt_nombreUsuario.Text.Trim();
                    userDto.password = this.txt_contrasenia.Text.Trim();
                    userDto.email = this.txt_correo.Text.Trim();

                    bool userIsCreated = _userController.CreateUser(userDto);
                    
                    if (userIsCreated)
                    {
                        MessageBox.Show("Usuario creado satisfactoriamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                    }
                }
                else 
                {
                    var userDto = new UserDto();

                    userDto.userId = int.Parse(this.txt_id.Text);
                    userDto.firstName = this.txt_nombre.Text.Trim();
                    userDto.lastName = this.txt_apellido.Text.Trim();
                    userDto.userName = this.txt_nombreUsuario.Text.Trim();
                    userDto.password = this.txt_contrasenia.Text.Trim();
                    userDto.email = this.txt_correo.Text.Trim();

                    bool userIsUpdated = _userController.PatchUser(userDto);

                    if (userIsUpdated)
                    {
                        MessageBox.Show("Usuario actualizado satisfactoriamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                    }
                }

               
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UserView_Load(object sender, EventArgs e)
        {

           
            if (userId >= 0) 
            {
                UserDto userDto = new UserDto();

                userDto = _userController.GetUserById(userId);

                if (userDto != null)
                {


                    this.txt_id.Text = userDto.userId.ToString();
                    this.txt_nombre.Text = userDto.firstName;
                    this.txt_apellido.Text = userDto.lastName;
                    this.txt_nombreUsuario.Text = userDto.userName;
                    this.txt_contrasenia.Text = userDto.password;
                    this.txt_correo.Text = userDto.email;

                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            
            if (AllInputsAreEmpty(this))
            {
                this.btn_cancel.Text = "Cerrar";  
            }
            else
            {
                this.btn_cancel.Text = "Cancelar";
            }

            if (this.btn_cancel.Text == "Cancelar")
            {
                CleanInputs();
                this.txt_nombre.Focus();
                this.btn_cancel.Text = "Cerrar";
            }
            else if (this.btn_cancel.Text == "Cerrar")
            {
                this.Dispose();
            }

        }

        private void CleanInputs()
        {
            if(userId <= 0) { 
                this.txt_id.Text = "0";
            }
            this.txt_nombre.Clear();
            this.txt_apellido.Clear();
            this.txt_nombreUsuario.Clear();
            this.txt_contrasenia.Clear();
            this.txt_correo.Clear();
        }

       
       private bool AllInputsAreEmpty(UserView userView)
        {
            bool response = false;
            
            foreach (Control ctrl in userView.Controls)
            {
               
                if (ctrl is TextBox && ctrl.Name != "txt_id") 
                {

                    if (ctrl.Text != "")
                    {
                        response = false;
                        break; 
                    }
                    else
                    {
                        response = true;
                    }
                } 
            }
            
            return response;    
            
        }

    }
}
