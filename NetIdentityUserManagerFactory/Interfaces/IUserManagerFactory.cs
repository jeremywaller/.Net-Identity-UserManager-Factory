using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dotNetIdentityUserManagerFactory.DAL;
using Microsoft.AspNet.Identity;

namespace dotNetIdentityUserManagerFactory.Interfaces
{
    public interface IUserManagerFactory
    {
        UserManager<User> Create();
    }
}
