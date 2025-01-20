using HumanResource.DAL.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace HumanResourceApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            IUserRepository userRepository = new UserRepositoryImp();
           
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Register(userRepository));
        }
    }
}