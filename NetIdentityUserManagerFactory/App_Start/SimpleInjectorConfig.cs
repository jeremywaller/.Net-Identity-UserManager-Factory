using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dotNetIdentityUserManagerFactory.DAL;
using dotNetIdentityUserManagerFactory.DAL.Interfaces;
using dotNetIdentityUserManagerFactory.Factories;
using dotNetIdentityUserManagerFactory.Interfaces;
using SimpleInjector;
using SimpleInjector.Diagnostics;

namespace dotNetIdentityUserManagerFactory.App_Start
{
    public class SimpleInjectorConfig
    {
        internal static void RegisterServices(Container container)
        {
            container.Register<IApplicationContext>(() => new ApplicationContext());

            //resgister application factories
            var registration =
                Lifestyle.Transient.CreateRegistration(typeof(UserManagerFactory), container);
            container.AddRegistration(typeof(IUserManagerFactory), registration);
            registration.SuppressDiagnosticWarning(DiagnosticType.DisposableTransientComponent,
                "Entity Framework handles disposal.");
        }

        public static void RegisterDependencyInjections()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = Lifestyle.Scoped;

            RegisterServices(container);

            container.Verify();

            //Register dependency resolver
        }
    }
}
