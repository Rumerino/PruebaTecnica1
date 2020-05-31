using Prueba2020.Service.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Pogo = Prueba2020.Web.Models;
namespace Prueba2020.Service.Service
{
    public class StockService
    {
        Prueba2020Entities dbo = new Prueba2020Entities();

        public StockService()
        {

        }

        public List<Pogo.Inventario> DetailsAll()
        {
            List<Inventario> inventarios = dbo.Inventario.ToList();
            if (inventarios == null)
            {
                return null;
            }

            List<Pogo.Inventario> returnInventario = new List<Pogo.Inventario>();

            foreach (Inventario inventario in inventarios)
            {
                returnInventario.Add(convertInventario(inventario));
            }

            return returnInventario;
        }

        public Pogo.Inventario Details(int codigoProducto)
        {
            Inventario inventario = dbo.Inventario.Where(s => s.CodigoProducto == codigoProducto).First();

            return convertInventario(inventario);
        }

        public int Get(string nombre)
        {
            Inventario inventario = dbo.Inventario.Where(s => s.Nombre == nombre).First();

            if (inventario == null)
            {
                return 0;
            }

            inventario.Stock -= 1;
            dbo.SaveChanges();

            return 1;
        }

        public Pogo.Inventario Details(string nombre)
        {
            Inventario inventario = dbo.Inventario.Where(s => s.Nombre == nombre).First();

            return convertInventario(inventario);
        }

        public int Add(string nombre, string descripcion, string tipo, string stock)
        {

            Inventario inventario = new Inventario();
            inventario.Nombre = nombre;
            inventario.Descripcion = descripcion;
            inventario.Tipo = int.Parse(tipo);
            inventario.Stock = int.Parse(stock);

            dbo.Inventario.Add(inventario);

            dbo.SaveChanges();

            return 1;
        }

        private Pogo.Inventario convertInventario(Inventario inventario)
        {

            if (inventario == null)
            {
                return null;
            }

            int auxStock = 0;
            if (inventario.Stock != null)
                auxStock = int.Parse(inventario.Stock.ToString());

            Tipo tipo = dbo.Tipo.Where(s => s.CodigoTipo == inventario.Tipo).First();

            if (tipo == null)
            {
                return null;
            }

            Pogo.Tipo returntipo = new Pogo.Tipo();

            returntipo.CodigoTipo = tipo.CodigoTipo;
            returntipo.Nombre = tipo.Nombre.Trim();

            return new Pogo.Inventario(inventario.CodigoProducto, inventario.Nombre.Trim(), inventario.Descripcion.Trim(), returntipo, auxStock);
        }
    }
}