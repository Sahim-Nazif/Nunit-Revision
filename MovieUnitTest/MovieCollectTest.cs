using NUnit.Framework;
using NunitRevision;
using System;

namespace MovieUnitTest
{
    public class Tests
    {
        private MovieCollection movie;

        [SetUp]
        public void Setup()
        {

            movie = new MovieCollection(500);
        }

        [Test]
        public void Adding_Collection_Updates_Inventory()
        {
           

            //Act
            movie.Add(350);

            //Assert
            Assert.AreEqual(850, movie.Inventory);
        }

        [Test]
        public void Removing_Collection_updates_Inventory()
        {
            //Act
            movie.SoldOrRent(300);
            //Assert
            Assert.AreEqual(200, movie.Inventory);
        }
        [Test]
        public void Transfer_Movies_To_OtherStore_UpdatesBothAccount()
        {

            var otherStore = new MovieCollection();
            //Act
            movie.TransferToOtherStores(otherStore,200);

            //Assert
            Assert.AreEqual(300, movie.Inventory);
            Assert.AreEqual(200, otherStore.Inventory);


        }
        [Test]
        public void SellingOrRenting_More_Than_Inventory_Throws()
        {
            //Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => movie.SoldOrRent(600));

        }
        [Test]
        public void Add_Negative_Number_Throws()
        {
            
            //Act + Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => movie.Add(-100));


        }
        [Test]
        public void Transfer_ToOtherStores_IfStoreIsNull_Throws()
        {
           Assert.Throws<ArgumentNullException>(() => movie.TransferToOtherStores(null, 600));
        }

    }
}