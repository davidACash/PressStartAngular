using System.Collections.Generic;
using System.Threading.Tasks;
using PressStart.API.Models;

namespace PressStart.API.Data
{
    public interface IPressStartRepository
    {
         void Add<T>(T entity) where T: class;
         void Delete<T>(T entity) where T: class;
         Task<bool> SaveAll();
         Task<IEnumerable<User>> GetUsers();
         Task<User> GetUser(int id);
    }
}