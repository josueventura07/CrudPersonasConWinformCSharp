using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsersCrudWithCShard_MVC.Views;
using System.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UsersCrudWithCShard_MVC.Controllers;
using UsersCrudWithCShard_MVC.Repositories;
using UsersCrudWithCShard_MVC.Services;

namespace UsersCrudWithCShard_MVC
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);

            

            using ( var serviceProvider = services.BuildServiceProvider())
            {
                
                               
                var mainForm = serviceProvider.GetRequiredService<MainView>();

                Application.Run(mainForm);

            }
                
                        
        }

        public static void ConfigureServices(ServiceCollection services)
        {

            services.AddScoped<IUsersRepository, UsersRepository>();
            
            services.AddScoped<IServices, Service>();

            services.AddScoped<IUsersControllers, UsersControllers>()
                .AddScoped<MainView>();

        }
    }
}
