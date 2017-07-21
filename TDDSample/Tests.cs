using System;
using NUnit.Framework;
using TDDSample.Rentals;

namespace TDDSample
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var movie = new Movie("スターウォーズⅦ", MovieRentalType.NewRelease);
            var rental = new Rental(movie, 3);
            var customer = new Customer("taro");

            customer.AddRental(rental);

            Assert.AreEqual("900円", customer.Statement());
        }
        [Test]
        public void Test2()
        {
            var movie = new Movie("スターウォーズⅦ", MovieRentalType.NewRelease);
            var rental = new Rental(movie, 5);
            var customer = new Customer("taro");

            customer.AddRental(rental);

            Assert.AreEqual("1500円", customer.Statement());
        }
        [Test]
        public void Test3()
        {
            var movie = new Movie("機関車トーマス", MovieRentalType.Childrens);
            var rental = new Rental(movie, 3);
            var customer = new Customer("childtaro");

            customer.AddRental(rental);

            Assert.AreEqual("150円", customer.Statement());
        }
        [Test]
        public void Test4()
        {
            var movie = new Movie("機関車トーマス", MovieRentalType.Childrens);
            var rental = new Rental(movie, 5);
            var customer = new Customer("childtaro");

            customer.AddRental(rental);

            Assert.AreEqual("450円", customer.Statement());
        }

        [Test]
        public void Test5()
        {
            var movie = new Movie("機関車トーマス", MovieRentalType.Childrens);
            var rental = new Rental(movie, 2);
            var customer = new Customer("childtaro");

            customer.AddRental(rental);

            Assert.AreEqual("150円", customer.Statement());
        }
        [Test]
        public void Test6()
        {
            var movie = new Movie("SPEED2", MovieRentalType.Regular);
            var rental = new Rental(movie, 2);
            var customer = new Customer("oya");

            customer.AddRental(rental);

            Assert.AreEqual("200円", customer.Statement());
        }
        [Test]
        public void Test7()
        {
            var movie = new Movie("SPEED2", MovieRentalType.Regular);
            var rental = new Rental(movie, 4);
            var customer = new Customer("oya");

            customer.AddRental(rental);

            Assert.AreEqual("600円", customer.Statement());
        }
        [Test]
        public void Test8()
        {
            var movie = new Movie("SPEED2", MovieRentalType.Regular);
            var rental = new Rental(movie, 4);
            var movie2 = new Movie("SPEED3",MovieRentalType.Regular);
            var rental2 = new Rental(movie2, 4);

            var customer = new Customer("oya");

            customer.AddRental(rental);
            customer.AddRental(rental2);

            Assert.AreEqual("1200円", customer.Statement());
        }
        [Test]
        public void Test9()
        {
            var movie = new Movie("SPEED2", MovieRentalType.Regular);
            var rental = new Rental(movie, 4);
            var movie2 = new Movie("スターウォーズⅦ",MovieRentalType.NewRelease);
            var rental2 = new Rental(movie2, 5);

            var customer = new Customer("oya");

            customer.AddRental(rental);
            customer.AddRental(rental2);

            Assert.AreEqual("2100円", customer.Statement());
        }


    }
}