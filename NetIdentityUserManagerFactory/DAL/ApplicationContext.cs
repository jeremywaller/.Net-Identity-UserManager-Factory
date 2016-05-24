using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dotNetIdentityUserManagerFactory.DAL.Interfaces;
using Microsoft.AspNet.Identity.EntityFramework;

namespace dotNetIdentityUserManagerFactory.DAL
{
    public class ApplicationContext : IdentityDbContext<User>, IApplicationContext
    {
        public ApplicationContext() : base("ApplicationContext")
        {

        }
    }
}
