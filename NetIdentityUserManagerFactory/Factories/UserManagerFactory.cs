using System.Data.Entity;
using dotNetIdentityUserManagerFactory.DAL;
using dotNetIdentityUserManagerFactory.DAL.Interfaces;
using dotNetIdentityUserManagerFactory.Interfaces;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace dotNetIdentityUserManagerFactory.Factories
{
    public class UserManagerFactory : UserManager<User>, IUserManagerFactory
    {
        private readonly IApplicationContext _applicationContext;

        public UserManagerFactory(IApplicationContext applicationContext) : base(new UserStore<User>(applicationContext as DbContext))
        {
            _applicationContext = applicationContext;
        }

        public UserManager<User> Create()
        {
            return new UserManager<User>(new UserStore<User>(_applicationContext as DbContext));
        }

    }
}
