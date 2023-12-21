using LearningApp.Data.Contexts;
using LearningApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Data.Repositories
{
    public class UserRepository
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
    }
}
