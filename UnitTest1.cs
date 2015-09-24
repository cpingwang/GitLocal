using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace PotterShoppingCart.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Buy_Book1x1()
        {
            var shoppingCart = new ShoppingCart();

            shoppingCart.Items.Add(new ShoppingItem() { BookType = 1, Num = 1, UnitPrice = 100 });

            shoppingCart.CalTotalPrice();
            Assert.AreEqual(shoppingCart.TotalPrice, 100);
        }

        [TestMethod]
        public void Test_Buy_Book1x1_Book2x1()
        {
            var shoppingCart = new ShoppingCart();

            shoppingCart.Items.Add(new ShoppingItem() { BookType = 1, Num = 1, UnitPrice = 100 });
            shoppingCart.Items.Add(new ShoppingItem() { BookType = 2, Num = 1, UnitPrice = 100 });

            shoppingCart.CalTotalPrice();
            Assert.AreEqual(shoppingCart.TotalPrice, 190);
        }

        [TestMethod]
        public void Test_Buy_Book1x1_Book2x1_Book3x1()
        {
            var shoppingCart = new ShoppingCart();

            shoppingCart.Items.Add(new ShoppingItem() { BookType = 1, Num = 1, UnitPrice = 100 });
            shoppingCart.Items.Add(new ShoppingItem() { BookType = 2, Num = 1, UnitPrice = 100 });
            shoppingCart.Items.Add(new ShoppingItem() { BookType = 3, Num = 1, UnitPrice = 100 });

            shoppingCart.CalTotalPrice();
            Assert.AreEqual(shoppingCart.TotalPrice, 270);
        }

        [TestMethod]
        public void Test_Buy_Book1x1_Book2x1_Book3x1_Book4x1()
        {
            var shoppingCart = new ShoppingCart();

            shoppingCart.Items.Add(new ShoppingItem() { BookType = 1, Num = 1, UnitPrice = 100 });
            shoppingCart.Items.Add(new ShoppingItem() { BookType = 2, Num = 1, UnitPrice = 100 });
            shoppingCart.Items.Add(new ShoppingItem() { BookType = 3, Num = 1, UnitPrice = 100 });
            shoppingCart.Items.Add(new ShoppingItem() { BookType = 4, Num = 1, UnitPrice = 100 });

            shoppingCart.CalTotalPrice();
            Assert.AreEqual(shoppingCart.TotalPrice, 320);
        }

        [TestMethod]
        public void Test_Buy_Book1x1_Book2x1_Book3x1_Book4x1_Book5x1()
        {
            var shoppingCart = new ShoppingCart();

            shoppingCart.Items.Add(new ShoppingItem() { BookType = 1, Num = 1, UnitPrice = 100 });
            shoppingCart.Items.Add(new ShoppingItem() { BookType = 2, Num = 1, UnitPrice = 100 });
            shoppingCart.Items.Add(new ShoppingItem() { BookType = 3, Num = 1, UnitPrice = 100 });
            shoppingCart.Items.Add(new ShoppingItem() { BookType = 4, Num = 1, UnitPrice = 100 });
            shoppingCart.Items.Add(new ShoppingItem() { BookType = 5, Num = 1, UnitPrice = 100 });

            shoppingCart.CalTotalPrice();
            Assert.AreEqual(shoppingCart.TotalPrice, 375);
        }

        [TestMethod]
        public void Test_Buy_Book1x1_Book2x1_Book3x2()
        {
            var shoppingCart = new ShoppingCart();

            shoppingCart.Items.Add(new ShoppingItem() { BookType = 1, Num = 1, UnitPrice = 100 });
            shoppingCart.Items.Add(new ShoppingItem() { BookType = 2, Num = 1, UnitPrice = 100 });
            shoppingCart.Items.Add(new ShoppingItem() { BookType = 3, Num = 2, UnitPrice = 100 });

            shoppingCart.CalTotalPrice();
            Assert.AreEqual(shoppingCart.TotalPrice, 370);
        }

        [TestMethod]
        public void Test_Buy_Book1x1_Book2x2_Book3x2()
        {
            var shoppingCart = new ShoppingCart();

            shoppingCart.Items.Add(new ShoppingItem() { BookType = 1, Num = 1, UnitPrice = 100 });
            shoppingCart.Items.Add(new ShoppingItem() { BookType = 2, Num = 2, UnitPrice = 100 });
            shoppingCart.Items.Add(new ShoppingItem() { BookType = 3, Num = 2, UnitPrice = 100 });

            shoppingCart.CalTotalPrice();
            Assert.AreEqual(shoppingCart.TotalPrice, 460);
        }

    }

    public class ShoppingCart
    {
        public decimal TotalPrice { get; set; }

        public List<ShoppingItem> Items { get; set; }

        public void CalTotalPrice()
        {
            decimal result = 0;

            //TODO: calculate result....

            this.TotalPrice = result;
        }
    }

    public class ShoppingItem
    {
        public int BookType { get; set; }

        public int Num { get; set; }

        public decimal UnitPrice { get; set; }
    }

}
