using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestGenerator.Data.Database.Entitites;

namespace TestGenerator.Data.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> Search(string text);
        Task<IEnumerable<User>> GetAll();
        Task Add(User user);
        Task<User> Remove(int user_id);
        Task Update(User user); 
    }
}
