using Autofac;
using BalanceLockApp.Application.Interfaces;
using BalanceLockApp.Application.Services;
using BalanceLockApp.Domain.Interfaces;
using BalanceLockApp.Infrastructure.Repositories;
using System;
using System.Windows.Forms;

namespace BalanceLock.Presenter
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<AccountRepository>().As<IAccountRepository>();
            builder.RegisterType<AccountService>().As<IAccountService>();
            var container = builder.Build();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(container.Resolve<IAccountService>()));
        }
    }
}
