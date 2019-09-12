using CatManagement.Domain.CatObject;
using CatManagement.Domain.ValueObjects.Score;
using CatManagement.Domain.ValueObjects.Url;
using Xunit;

namespace CatManagement.UnitTests.Domain
{
    public class CatTest
    {
        public CatTest()
        { }

        [Fact]
        public void create_cat_success()
        {
            //Arrange
            string id = "this is my id";
            Url url = "this is an url";
            Score score = 5;

            //Act
            var fakeCat = new Cat(id, url, score);

            //Assert
            Assert.NotNull(fakeCat);
        }

        [Fact]
        public void cat_like_success()
        {
            //Arrange
            string id = "this is my id";
            Url url = "this is an url";
            Score score = 0;
            Score expectedScore = 1;

            //Act
            var fakeCat = new Cat(id, url, score);
            fakeCat.Like();

            //Assert
            Assert.Equal(expectedScore, fakeCat.Score);
        }


    }
}
