﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;
namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            // -- Arrange
            //create new instance and assign to object vairable 
           // implicitly typed local variable ,strongly typed

            var customer = new Customer();
            customer.FirstName = "Bilbo";
            customer.LastName = "Baggins";

            string expected = "Baggins, Bilbo";

            // -- Act
            string actual = customer.FullName;

            // -- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            // -- Arrange
            Customer customer = new Customer();
            customer.LastName = "Baggins";
            string expected = "Baggins";
            
            // Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            // -- Arrange
            Customer customer = new Customer();
            customer.FirstName = "Bilbo";
            string expected = "Bilbo";

            // Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IntegerTypeTest()
        {
            //-- Arrange
            int i1;
            i1 = 42;

            //-- Act
            int i2 = i1;
            i2 = 2;

            //-- Assert
            Assert.AreEqual(42, i1);
        }


        [TestMethod]
        public void ObjectTypeTest()
        {
            //-- Arrange
            var c1 = new Customer();
            c1.FirstName = "Bilbo";

            //-- Act
            var c2 = c1;
            c2.FirstName = "Frodo";

            //-- Assert
            Assert.AreEqual("Frodo", c1.FirstName);
        }
        [TestMethod]
        public void StaticTest()
        {
            // // arrange
            var c1 = new Customer();
            c1.FirstName = "Bilbo";
            Customer.InstanceCount += 1;
            var c2 = new Customer();
            c2.FirstName = "Frodo";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Rosie";
            Customer.InstanceCount += 1;

            // -- act

            // -- assert

            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateValid()
        {
           // arrange
            var customer = new Customer();
            customer.LastName = "Baggins";
            customer.EmailAddress = "fbaggins@hobbiton.me";

            var expected = true;

            //act
            var actual = customer.Validate();

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidateMissingLastName()
        {
            // arrange
            var customer = new Customer();
            customer.EmailAddress = "fbaggins@hobbiton.me";
            var expected = false;

            // act
            var actual = customer.Validate();

            // assert 
            Assert.AreEqual(expected, actual);
        }

    }
}
