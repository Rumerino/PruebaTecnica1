using Prueba2020.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prueba2020.Service.Service
{
    public class StockService : IStock
    {
        public int prueba1(int n1, int n2)
        {
            return n1 + n2;
        }

        public void prueba2(int n1, int n2)
        {
            
        }
    }
}