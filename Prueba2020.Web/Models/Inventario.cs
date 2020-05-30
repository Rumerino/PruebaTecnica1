using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prueba2020.Web.Models
{
    public class Inventario
    {
        public int CodigoProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Tipo Tipo { get; set; }
        public int Stock { get; set; }

        public Inventario()
        {

        }
        public Inventario(int codigoProducto, string nombre, string descripcion, Tipo tipo, int stock)
        {
            CodigoProducto = codigoProducto;
            Nombre = nombre;
            Descripcion = descripcion;
            Tipo = tipo;
            Stock = stock;
        }
    }
}