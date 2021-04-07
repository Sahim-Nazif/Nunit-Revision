using NUnit.Framework;
using NunitRevision;

namespace MovieUnitTest
{
    public class Tests
    {

        [Test]
        public void Adding_Collection_Updates_Inventory()
        {
            //Arrange
            var movie = new MovieCollection(500);

            //Act
            movie.Add(350);

            //Assert
            Assert.AreEqual(850, movie.Inventory);
        }

        [Test]
        public void Removing_Collection_updates_Inventory()
        {
            //Arrange
            var movie = new MovieCollection(500);

            //Act
            movie.SoldOrRent(300);
            //Assert
            Assert.AreEqual(200, movie.Inventory);
        }

    }
}