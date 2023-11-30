using AllAboutWeezer.Models;

namespace AllAboutWeezer.Data
{
    public interface IForumRepository
    {
        public List<Message> GetMessages();
        public Message GetMessageById(int id);
        public int StoreMessage(Message message);
    }
}

