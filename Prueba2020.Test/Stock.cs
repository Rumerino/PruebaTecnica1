using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using Prueba2020.Service.Interface;

namespace Prueba2020.Test
{
    [TestClass]
    public class Stock
    {
        IStock _iStock;

        public Stock()
        {
            _iStock = new Mock<IStock>().Object;
        }
        [TestMethod]
        public void prueba1()
        {
            //arrange
            int n1 = 2;
            int n2 = 2;
            //act
            int returnTest = _iStock.prueba1(n1, n2);
            //assert
            Assert.IsNotNull(returnTest);
        }
        [TestMethod]
        public void prueba2()
        {
            //arrange
            int n1 = 1;
            int n2 = 1;

            //act
            _iStock.prueba2(n1, n2);
        }
    }
}


