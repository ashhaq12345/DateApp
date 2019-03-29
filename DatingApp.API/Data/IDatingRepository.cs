using System.Collections.Generic;
using System.Threading.Tasks;
using DatingApp.API.Helpers;
using DatingApp.API.Models;

namespace DatingApp.API.Data
{
    public interface IDatingRepository
    {
         void Add<T>(T entity) where T : class;
         void Delete<T>(T entity) where T : class;
         Task<bool> SaveAll();
         Task<PagedList<User>> GetUsers(UserParams userParams);
         Task<User> GetUser(long id);
         Task<Photo> GetPhoto(long id);
         Task<Photo> GetMainPhotoForUser(long userId);
         Task<Like> GetLike(long userId, long recipientId);
    }
}