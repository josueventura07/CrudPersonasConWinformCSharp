using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsersCrudWithCShard_MVC.Models;
using UsersCrudWithCShard_MVC.Controllers;


namespace UsersCrudWithCShard_MVC.Views
{
    public partial class MainView : Form
    {

        private IUsersControllers _usersControllers;
        private int userId = 0;
        

        public MainView(IUsersControllers usersControllers)
        {
            InitializeComponent();

            _usersControllers = usersControllers;

            this.dgvUsers.DataSource = _usersControllers.GetAllUsers();
            userId = int.Parse(this.dgvUsers.Rows[dgvUsers.CurrentCell.RowIndex].Cells[0].Value.ToString());
        }
         

        public void UsersListBindingSource(UsersModel userModel)
        {
            
            this.dgvUsers.DataSource = _usersControllers.GetAllUsers();
        }

        private void btn_newUser_Click(object sender, EventArgs e)
        {
            userId = 0;

            var userView = new UserView(_usersControllers);

            userView.ShowDialog();
            
        }

        static UserView userView;
        private void btn_editUser_Click(object sender, EventArgs e)
        {
            
            if(userId > 0)
            {
                userView = new UserView(_usersControllers, userId);

                userView.ShowDialog();
               
                
            } else
            {
                MessageBox.Show("Debe seleccionar un usuario de la lista!", "Editar usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            userId = int.Parse(this.dgvUsers.Rows[dgvUsers.CurrentCell.RowIndex].Cells[0].Value.ToString());
            
        }

        private void btn_deleteUser_Click(object sender, EventArgs e)
        {
            if (userId > 0)
            {
                var respuesta = MessageBox.Show("Eliminará el usuario con id: " + userId, "Eliminar usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    _usersControllers.DestroyUserById(userId);

                    this.dgvUsers.DataSource = _usersControllers.GetAllUsers();
                }
            }
            else 
            {
                MessageBox.Show("Debe seleccionar un usuario de la lista!","Eliminar usuario",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            DgvRowsAndColumnsAdjustment();
        }
                
        private void btn_searchUser_Click(object sender, EventArgs e)
        {
            this.dgvUsers.DataSource = "";
            this.dgvUsers.DataSource = _usersControllers.GetAllUsersLikeValue(this.txt_searchUser.Text);
            this.txt_searchUser.Clear();
        }

        private void txt_searchUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.btn_searchUser_Click(sender, e);
            }
        }

        private void MainView_SizeChanged(object sender, EventArgs e)
        {
            DgvRowsAndColumnsAdjustment();
        }

        private void DgvRowsAndColumnsAdjustment()
        {
            this.dgvUsers.Columns[0].Width = 60;
            this.dgvUsers.Columns[0].MinimumWidth = 60;
            this.dgvUsers.Columns[1].Width = 150;
            this.dgvUsers.Columns[2].Width = 150;
            this.dgvUsers.Columns[3].Width = 150;
            this.dgvUsers.Columns[4].Width = 120;
            this.dgvUsers.Columns[5].Width = this.dgvUsers.Width - 630;
        }
    }
}
