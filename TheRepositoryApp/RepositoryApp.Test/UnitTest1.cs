using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheRepository.ViewModel;

namespace RepositoryApp.Test
{
    [TestClass]
    public class dfjkajflkaj
    {
        [TestMethod]
        public void kiphetmeestveelzijdigestukjevlees()
        {
            
            //Arrange
            CarVM carVM = new CarVM(new Car());
            carVM.Prijs = 100;
            carVM.Bijtelling = 10;

            //Act
            var result = carVM.LeaseKostenPerJaar;

            //Assert
            Assert.AreEqual(20, result);
            //LeaseKostenPerMaand = Prijs / Bijtelling * 2

        }
    }
}
