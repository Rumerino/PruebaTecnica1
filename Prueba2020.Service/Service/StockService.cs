using Prueba2020.Service.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Pogo = Prueba2020.Web.Models;
namespace Prueba2020.Service.Service
{
    public class StockService : IStock
    {
        Prueba2020Entities dbo = new Prueba2020Entities();

        public StockService()
        {

        }

        public int prueba1(int n1, int n2)
        {
            return n1 + n2;
        }

        public void prueba2(int n1, int n2)
        {
            
        }

        public List<Pogo.Inventario> GetAll()
        {
            List<Inventario> inventarios = dbo.Inventario.ToList();

            List<Pogo.Inventario> returnInventario = new List<Pogo.Inventario>();

            foreach (Inventario inventario in inventarios)
            {
                int auxStock =0;
                if (inventario.Stock != null)
                    auxStock = int.Parse(inventario.Stock.ToString());

                Pogo.Inventario auxInventario = new Pogo.Inventario( inventario.CodigoProducto, inventario.Nombre.Trim(), inventario.Descripcion.Trim(), new Pogo.Tipo(), auxStock);
                returnInventario.Add(auxInventario);
            }


            return returnInventario;
        }

        public Pogo.Inventario Get(int codigoProducto)
        {
            Inventario inventario = dbo.Inventario.Where(s => s.CodigoProducto == codigoProducto).First();

            int auxStock = 0;
            if (inventario.Stock != null)
                    auxStock = int.Parse(inventario.Stock.ToString());

            Pogo.Inventario returnInventario = new Pogo.Inventario(inventario.CodigoProducto, inventario.Nombre.Trim(), inventario.Descripcion.Trim(), new Pogo.Tipo(), auxStock);

            return returnInventario;
        }
    }
}