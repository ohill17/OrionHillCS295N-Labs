using AllAboutWeezer.Controllers;
using AllAboutWeezer.Models;

namespace WeezerTests
{
    public class QuizTests
    {
        [Fact]
        public void TestLoadQuestions()
        {
            //Arrange
            var controller = new QuizController();
            var model = new WeezyTests();

            //Act
           var loadedModel = controller.LoadQuestions(model);

            //Assert
            Assert.Equal(controller.Questions, loadedModel.Questions);
            Assert.Equal(controller.Answers, loadedModel.Answers);
            Assert.NotNull(loadedModel.Questions);
            Assert.NotNull(loadedModel.Answers);
            Assert.NotNull(controller.Questions);
            Assert.NotNull(controller.Answers);
        }
    }
}