using LearningApp.Data.Contexts;
using LearningApp.Data.Entities;
using LearningApp.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly LearningContext context;

        public UserRepository(LearningContext context)
        {
            this.context = context;
        }


        public AppUser AddUser(AppUser appUser)
        {
            this.context.Add(appUser);
            this.context.SaveChanges();
            return appUser;
        }

        public AppUser? GetUser(Expression<Func<AppUser,bool>> filter){
            var user = this.context.AppUsers.SingleOrDefault(filter);
            return user;
        }
    }
}
