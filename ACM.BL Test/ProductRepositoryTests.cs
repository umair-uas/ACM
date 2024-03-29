﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace ACM.BL.Tests
{
    [TestClass()]
    public class ProductRepositoryTests
    {
        [TestMethod()]
        public void RetrieveTest()
        {
            //-- Arrange
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
                CurrentPrice = 15.96M,
                ProductDescription = "Assorted size set of 4 bright yello mini sunflowers",
                ProductName = "Sunflowers"
            };

            //-- Act
            var actual = productRepository.Retrieve(2);

            //-- Assert
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
        }
    }
}
