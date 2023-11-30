using AllAboutWeezer.Data;
using AllAboutWeezer.Models;
using AllAboutWeezer.Controllers;


namespace WeezerTests
{
    public class ForumRepoTests
    {
        [Fact]
        public void ForumPostTest()
        {
            // Arrange: create a controller object and model object
            var repo = new FakeForumRepository();
            var controller = new HomeController(repo);
            var model = new Message()
            {
            Title = "Intresting Title",
            Topic = "Intresting Topic",
            YearDate = 2020,
            StoryBody = "Cool Intresting Story",
            Username = "Intresting Name"
            };


            // Act: pass a model to the controller ForumPost method
            controller.Stories(model);

            // Assert: Id, date, and rating got added to the model
            Assert.True(model.MessageId > 0);
      
        }
    }
}
