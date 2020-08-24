using System.Collections.Generic;
using System.Threading.Tasks;
using SocialApp.API.Helpers;
using SocialApp.API.Models;

namespace SocialApp.API.Data
{
    public interface ISocialRepository
    {
         void Add<T>(T entity) where T: class;
         void Delete<T>(T entity) where T: class;
         Task<bool> SaveAll();
         Task<PagedList<User>> GetUsers(UserParams userParams);
         Task<User> GetUser(long id);
         Task<Photo> GetPhoto(long id);
         Task<Photo> GetMainPhotoForUser(long userId);
         Task<Like> GetLike(long userId, long recepientId);
         Task<Message> GetMessage(long id);
         Task<PagedList<Message>> GetMessagesForUser(MessageParams messageParams);
         Task<IEnumerable<Message>> GetMessageThread(long userId, long recipientId);
    }
}