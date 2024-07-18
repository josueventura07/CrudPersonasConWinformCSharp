using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersCrudWithCShard_MVC.Models;
using UsersCrudWithCShard_MVC.Repositories;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using UsersCrudWithCShard_MVC.DTOs;
using UsersCrudWithCShard_MVC.UserDTO;
using UsersCrudWithCShard_MVC.Services;


namespace UsersCrudWithCShard_MVC.Repositories
{
    public class UsersRepository : BaseRepository, IUsersRepository
    {
        
        public UsersRepository(IServices service)
        {
            
            this.connectionString = service.ConnectionString();
        }

        bool IUsersRepository.AddNewUser(UserInsertDto userInsertDto)
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand command = new MySqlCommand())
                    {
                        conexion.Open();
                        command.Connection = conexion;
                        command.CommandText = "Insert Into Users(first_name, last_name, user_name, pass, email) Values(@first_name, @last_name, @user_name, @pass, @email)";
                        command.Parameters.Add("@first_name", MySqlDbType.VarChar).Value = userInsertDto.firstName;
                        command.Parameters.Add("@last_name", MySqlDbType.VarChar).Value = userInsertDto.lastName;
                        command.Parameters.Add("@user_name", MySqlDbType.VarChar).Value = userInsertDto.userName;
                        command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = userInsertDto.password;
                        command.Parameters.Add("@email", MySqlDbType.VarChar).Value = userInsertDto.email;
                        command.ExecuteNonQuery();

                        return true;
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        bool IUsersRepository.UpdateUser(UserDto userDto)
        {

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand command = new MySqlCommand())
                    {
                        conexion.Open();
                        command.Connection = conexion;
                        command.CommandText = "Update Users set first_name = @first_name, last_name = @last_name, user_name = @user_name, pass = @pass, email = @email where id = @id";
                        command.Parameters.Add("@id", MySqlDbType.VarChar).Value = userDto.userId;
                        command.Parameters.Add("@first_name", MySqlDbType.VarChar).Value = userDto.firstName;
                        command.Parameters.Add("@last_name", MySqlDbType.VarChar).Value = userDto.lastName;
                        command.Parameters.Add("@user_name", MySqlDbType.VarChar).Value = userDto.userName;
                        command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = userDto.password;
                        command.Parameters.Add("@email", MySqlDbType.VarChar).Value = userDto.email;
                        command.ExecuteNonQuery();

                        return true;
                    }
                }
            } catch (Exception ex){
                MessageBox.Show(ex.Message, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
                     
        }

        bool IUsersRepository.DeleteUser(int id)
        {
            try 
            { 
                using (MySqlConnection conexion = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand command = new MySqlCommand())
                    {
                        conexion.Open();
                        command.Connection = conexion;
                        command.CommandText = "Delete from Users where id = @id";
                        command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                        command.ExecuteNonQuery (); 
                        
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
}

        IEnumerable<UserDto> IUsersRepository.FindAllUsers()
        {
            
            try 
            { 
                var userList = new List<UserDto>();

                using (MySqlConnection conexion = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand command = new MySqlCommand())
                    { 
                        conexion.Open();
                        command.Connection = conexion;
                        command.CommandText = "Select u.id, u.first_name, u.last_name, u.user_name, u.pass, u.email from Users u order by id desc";
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var userDto = new UserDto();

                                userDto.userId = reader.GetInt32(0);
                                userDto.firstName = reader.GetString(1);
                                userDto.lastName = reader.GetString(2);
                                userDto.userName = reader.GetString(3);
                                userDto.password = reader.GetString(4);
                                userDto.email = reader.GetString(5);
                                userList.Add(userDto);
                            }
                        }

                    }
                }

                return userList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }

        UserDto IUsersRepository.FindUserById(int id)
        {
            try
            {
                var userDto = new UserDto();

                using (MySqlConnection conexion = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand command = new MySqlCommand())
                    {
                        conexion.Open();
                        command.Connection = conexion;
                        command.CommandText = "Select * from Users where id = @id";
                        command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                userDto.userId = reader.GetInt32(0);
                                userDto.firstName = reader.GetString(1);
                                userDto.lastName = reader.GetString(2);
                                userDto.userName = reader.GetString(3);
                                userDto.password = reader.GetString(4);
                                userDto.email = reader.GetString(5);
                                                       
                            }
                        }

                        return userDto;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        IEnumerable<UserDto> IUsersRepository.FindUserLikeValue(string value)
        {
            try
            {
                var userList = new List<UserDto>();
                
                using (MySqlConnection conexion = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand command = new MySqlCommand())
                    {
                        conexion.Open();
                        command.Connection = conexion;
                        command.CommandText = "Select u.id, u.first_name, u.last_name, u.user_name, u.pass, u.email from Users u where concat(u.id, ' ', u.first_name, ' ', u.last_name) like concat('%', @value,'%') order by id desc";
                        command.Parameters.Add("@value", MySqlDbType.VarChar).Value = value;
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var userDto = new UserDto();

                                userDto.userId = reader.GetInt32(0);
                                userDto.firstName = reader.GetString(1);
                                userDto.lastName = reader.GetString(2);
                                userDto.userName = reader.GetString(3);
                                userDto.password = reader.GetString(4);
                                userDto.email = reader.GetString(5);
                                userList.Add(userDto);
                            }
                        }

                    }
                }

                return userList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

    
    }
}
