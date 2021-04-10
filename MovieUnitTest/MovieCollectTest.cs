using NUnit.Framework;
using NunitRevision;
using System;

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
        [Test]
        public void Transfer_Movies_To_OtherStore_UpdatesBothAccount()
        {

            //Arrange
            var movie = new MovieCollection(500);
            var otherStore = new MovieCollection();
            //Act
            movie.TransferToOtherStores(otherStore,200);

            //Assert
            Assert.AreEqual(300, movie.Inventory);
            Assert.AreEqual(200, otherStore.Inventory);


        }
        [Test]
        public void SellingRent_More_Than_Inventory_Throws()
        {
            //Arrange
            var movieInventory = new MovieCollection(500);
            //Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => movieInventory.SoldOrRent(600));

        }
        [Test]
        public void Add_Negative_Number_Throws()
        {
            //Arrange
            var movie = new MovieCollection(500);
            //Act + Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => movie.Add(-100));


        }

    }
}