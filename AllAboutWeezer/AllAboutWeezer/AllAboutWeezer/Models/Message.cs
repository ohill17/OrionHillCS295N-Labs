using System.ComponentModel.DataAnnotations;

namespace AllAboutWeezer.Models
{


    public class Message
    {
        [Key]
        public int MessageId { get; set; }
        public string Title { get; set; }
        public string Topic { get; set; }
        public int YearDate { get; set; }
        public string StoryBody { get; set; }
        public string Username { get; set; }
        public DateOnly Date { get; set; }
    }
}