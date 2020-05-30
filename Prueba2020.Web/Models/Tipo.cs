using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prueba2020.Web.Models
{
    public class Tipo
    {
        public int CodigoTipo { get; set; }
        public string Nombre { get; set; }
        
        public Tipo()
        {

        }
        public Tipo (int codigoTipo,string nombre)
        {
            CodigoTipo = codigoTipo;
            Nombre = nombre;
        }
    }
}