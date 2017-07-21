using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication2.Controllers;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrang 

            var conntroller = new ValuesController();

            //Act

            var result = conntroller.CalculBMI(1, 1);



            //Assert
            Assert.AreEqual(1, result);





        }

        [TestMethod]
        public void TestMethod2()
        {


            var conntroller = new ValuesController();

            var result2 = conntroller.CalculBMI(2, 2);
            Assert.AreEqual(0.5, result2);


        }


        [TestMethod]
        public void TestMethod3()
        {


            var conntroller = new ValuesController();
            var result3 = conntroller.CalculBMI(0, 0);
            Assert.AreEqual(0, result3);


        }
    }
}
