using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestGenerator.Data.Database;
using TestGenerator.Data.Database.Entitites;

namespace TestGenerator.Data.Repositories
{
    public class UserRepository: IUserRepository
    {
        public Task<IEnumerable<User>> Search(string text)
        {
            return Task<IEnumerable<User>>.Factory.StartNew(() => {
                using (var context = new TestGeneratorDb())
                {
                    var result = context.Users.ToList().Where(
                        user =>
                            user.UserCI.StartsWith(text, StringComparison.CurrentCultureIgnoreCase) ||
                            user.Names.StartsWith(text, StringComparison.CurrentCultureIgnoreCase) ||
                            user.LastName.StartsWith(text, StringComparison.CurrentCultureIgnoreCase) || 
                            user.FirstName.StartsWith(text, StringComparison.CurrentCultureIgnoreCase));
                    return result.AsEnumerable();
                }
            });
        }
        public Task<IEnumerable<User>> GetAll()
        {
            return Task<IEnumerable<User>>.Factory.StartNew(() =>
            {
                using (var context = new TestGeneratorDb())
                {
                    return context.Users.ToList();
                }
            });
        }

        public Task Add(User user)
        {
            return Task.Factory.StartNew(() => {
                using (var context = new TestGeneratorDb())
                {
                    var result = context.Users.ToList().First(item => user.UserCI.Equals(item.UserCI));
                    if (result == null)
                    {
                        context.Users.Add(user);
                        context.SaveChanges();
                    }
                }
            });
        }

        public Task<User> Remove(int user_id)
        {
            return Task<User>.Factory.StartNew(() => {
                using (var context = new TestGeneratorDb())
                {
                    var user = context.Users.ToList().First(item => item.UserID == user_id);
                    if (user != null)
                    {
                        context.Users.Remove(user);
                        context.SaveChanges();
                    }
                    return user;
                }
            });
        }

        public Task Update(User user)
        {
            return Task.Factory.StartNew(() => {
                using (var context = new TestGeneratorDb())
                {
                    var original = context.Users.Find(user.UserID);
                    if (original != null)
                    {
                        context.Entry<User>(original).CurrentValues.SetValues(user);
                        context.SaveChanges();
                    }
                }
            });
        }

        
    }
}
