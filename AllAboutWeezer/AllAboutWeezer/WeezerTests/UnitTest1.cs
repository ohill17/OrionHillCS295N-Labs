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
            Assert.NotEmpty(controller.Questions);
            Assert.NotEmpty(loadedModel.Answers);
        }
        [Fact]
        public void TestCheckQuizAnswers()
        {
            // Arrange
            // create model, put in some right and wrong answer
            var model = new WeezyTests();
            var controller = new QuizController();
            var loadedModel = controller.LoadQuestions(model);
            loadedModel.UserAnswers[1] = "yes"; // true
            loadedModel.UserAnswers[2] = "Yes"; // true
     

            // Act
            var result = controller.checkQuizAnswers(model);

            // Assert
            Assert.True(result.Results[1]);
            Assert.True(result.Results[2]);
  
        }
    }
}