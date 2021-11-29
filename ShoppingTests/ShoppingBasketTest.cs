using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shopping;
using System.Collections.Generic;

namespace ShoppingTests
{
    [TestClass]
    public class ShoppingBasketTest
    {
       
        [TestMethod]
        public void TotalOfEmptyBastket()
        {
            //Arrange
            
            //Act
            Basket basket = new Basket(new List<Item>());
            
            //What's the least to do to get it to pass.
            //Does test fail?
            //Assert (start here!!)
            Assert.AreEqual(expected: 0.0, actual: basket.Total);

        }

        [TestMethod]
        public void TotalOfSingleItem()
        {
            var items = new List<Item>() { new Item(price: 100.00, quantity:1) };
            Basket basket = new Basket(items);
            Assert.AreEqual(expected: 100.0, actual: basket.Total);
        }

        [TestMethod]
        public void TotalOfTwoItems()
        {
            var items = new List<Item>() { new Item(price: 100.00, quantity: 1), new Item(price: 100.00, quantity:1) };
            Basket basket = new Basket(items);
            Assert.AreEqual(expected: 200.0, actual: basket.Total);
        }

        [TestMethod]
        public void TotalOfItemWithQuantityOfTwo()
        {
            var items = new List<Item>() { new Item(price: 100.00, quantity: 2) };
            Basket basket = new Basket(items);
            Assert.AreEqual(expected: 200.0, actual: basket.Total);
        }
    }




}