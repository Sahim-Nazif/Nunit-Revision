using NUnit.Framework;
using NunitRevision;

namespace MovieUnitTest
{
    public class Tests
    {

        [Test]
        public void Adding_Collection_Update_Inventory()
        {
            //Arrange
            var movie = new MovieCollection(500);

            //Act
            movie.Add(350);

            //Assert
            Assert.AreEqual(850, movie.Inventory);
        }


    }
}