
namespace UsersCrudWithCShard_MVC.Views
{
    partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.btn_newUser = new System.Windows.Forms.Button();
            this.btn_editUser = new System.Windows.Forms.Button();
            this.btn_deleteUser = new System.Windows.Forms.Button();
            this.btn_searchUser = new System.Windows.Forms.Button();
            this.txt_searchUser = new System.Windows.Forms.TextBox();
            this.lbl_titleMainForm = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsers.ColumnHeadersHeight = 30;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsers.EnableHeadersVisualStyles = false;
            this.dgvUsers.Location = new System.Drawing.Point(12, 120);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvUsers.Size = new System.Drawing.Size(833, 243);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);
            // 
            // btn_newUser
            // 
            this.btn_newUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_newUser.Location = new System.Drawing.Point(854, 120);
            this.btn_newUser.Name = "btn_newUser";
            this.btn_newUser.Size = new System.Drawing.Size(161, 45);
            this.btn_newUser.TabIndex = 1;
            this.btn_newUser.Text = "Nuevo";
            this.btn_newUser.UseVisualStyleBackColor = true;
            this.btn_newUser.Click += new System.EventHandler(this.btn_newUser_Click);
            // 
            // btn_editUser
            // 
            this.btn_editUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_editUser.Location = new System.Drawing.Point(854, 171);
            this.btn_editUser.Name = "btn_editUser";
            this.btn_editUser.Size = new System.Drawing.Size(161, 45);
            this.btn_editUser.TabIndex = 1;
            this.btn_editUser.Text = "Editar";
            this.btn_editUser.UseVisualStyleBackColor = true;
            this.btn_editUser.Click += new System.EventHandler(this.btn_editUser_Click);
            // 
            // btn_deleteUser
            // 
            this.btn_deleteUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_deleteUser.Location = new System.Drawing.Point(854, 222);
            this.btn_deleteUser.Name = "btn_deleteUser";
            this.btn_deleteUser.Size = new System.Drawing.Size(161, 45);
            this.btn_deleteUser.TabIndex = 1;
            this.btn_deleteUser.Text = "Borrar";
            this.btn_deleteUser.UseVisualStyleBackColor = true;
            this.btn_deleteUser.Click += new System.EventHandler(this.btn_deleteUser_Click);
            // 
            // btn_searchUser
            // 
            this.btn_searchUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_searchUser.Location = new System.Drawing.Point(701, 80);
            this.btn_searchUser.Name = "btn_searchUser";
            this.btn_searchUser.Size = new System.Drawing.Size(144, 34);
            this.btn_searchUser.TabIndex = 1;
            this.btn_searchUser.Text = "Buscar";
            this.btn_searchUser.UseVisualStyleBackColor = true;
            this.btn_searchUser.Click += new System.EventHandler(this.btn_searchUser_Click);
            // 
            // txt_searchUser
            // 
            this.txt_searchUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_searchUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_searchUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_searchUser.Location = new System.Drawing.Point(11, 87);
            this.txt_searchUser.Name = "txt_searchUser";
            this.txt_searchUser.Size = new System.Drawing.Size(691, 22);
            this.txt_searchUser.TabIndex = 2;
            this.txt_searchUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_searchUser_KeyPress);
            // 
            // lbl_titleMainForm
            // 
            this.lbl_titleMainForm.AutoSize = true;
            this.lbl_titleMainForm.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titleMainForm.Location = new System.Drawing.Point(12, 25);
            this.lbl_titleMainForm.Name = "lbl_titleMainForm";
            this.lbl_titleMainForm.Size = new System.Drawing.Size(247, 32);
            this.lbl_titleMainForm.TabIndex = 3;
            this.lbl_titleMainForm.Text = "CRUD de Usuarios";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(11, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(691, 1);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1027, 371);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_titleMainForm);
            this.Controls.Add(this.txt_searchUser);
            this.Controls.Add(this.btn_deleteUser);
            this.Controls.Add(this.btn_editUser);
            this.Controls.Add(this.btn_searchUser);
            this.Controls.Add(this.btn_newUser);
            this.Controls.Add(this.dgvUsers);
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.SizeChanged += new System.EventHandler(this.MainView_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Button btn_newUser;
        private System.Windows.Forms.Button btn_editUser;
        private System.Windows.Forms.Button btn_deleteUser;
        private System.Windows.Forms.Button btn_searchUser;
        private System.Windows.Forms.TextBox txt_searchUser;
        private System.Windows.Forms.Label lbl_titleMainForm;
        private System.Windows.Forms.Label label1;
    }
}