namespace Services
{
    public class Services : IServices
    {
        public string ConnectionString(string connectionString)
        {
            connectionString = "server=localhost;user=user_remoto;database=UsersCrud;port=3306;password=root;";

            return connectionString;
        }
    }
}
