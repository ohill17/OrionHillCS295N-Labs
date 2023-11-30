using AllAboutWeezer.Models;
using Microsoft.EntityFrameworkCore;

namespace AllAboutWeezer.Data
{
    public class ForumRepository : IForumRepository
    {
        AppDbContext context;
        public ForumRepository(AppDbContext c)
        {
            context = c;
        }

        public Message GetMessageById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Message> GetMessages()
        {
            return context.Message
            .ToList();
        }

        public int StoreMessage(Message message)
        {
            context.Add(message);
            // Returns the number of objects saved
            return context.SaveChanges();
        }
    }
}
