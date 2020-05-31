using Prueba2020.Service.Interface;
using Prueba2020.Service.Service;
using Prueba2020.Web.Models;
using Prueba2020.Web.Models.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prueba2020.Controllers
{
    public class StockController : Controller
    {
        // GET: Stock
        public JsonResult DetailsAll()
        {
            StockService ss = new StockService();

            List<Inventario> inventario = ss.DetailsAll();

            JsonResponse response = new JsonResponse();
            if (inventario == null)
            {
                response.code = JsonResponse.ERROR;
                response.value = null;
            }
            else
            {
                response.code = JsonResponse.OK;
                response.value = inventario;
            }
            return Json(response, JsonRequestBehavior.AllowGet);
        }

        public JsonResult DetailsById(int codigoProducto)
        {
            JsonResponse response = new JsonResponse();
            if (codigoProducto==null)
            {
                response.code = JsonResponse.ERROR;
                response.value = null;

                return Json(response, JsonRequestBehavior.AllowGet);
            }
            StockService ss = new StockService();

            Inventario inventario = ss.Details(codigoProducto);

            if (inventario == null)
            {
                response.code = JsonResponse.ERROR;
                response.value = null;
            }
            else
            {
                response.code = JsonResponse.OK;
                response.value = inventario;
            }
            return Json(response, JsonRequestBehavior.AllowGet);
        }
        public JsonResult Details(string nombre)
        {
            JsonResponse response = new JsonResponse();
            if (string.IsNullOrEmpty(nombre))
            {
                response.code = JsonResponse.ERROR;
                response.value = null;

                return Json(response, JsonRequestBehavior.AllowGet);
            }
            StockService ss = new StockService();

            Inventario inventario = ss.Details(nombre);

            if (inventario == null)
            {
                response.code = JsonResponse.ERROR;
                response.value = null;
            }
            else
            {
                response.code = JsonResponse.OK;
                response.value = inventario;
            }
            return Json(response, JsonRequestBehavior.AllowGet);
        }

        public JsonResult get(string nombre)
        {
            StockService ss = new StockService();

            JsonResponse response = new JsonResponse();
            if (string.IsNullOrEmpty(nombre))
            {
                response.code = JsonResponse.ERROR;
                response.value = 0;

                return Json(response, JsonRequestBehavior.AllowGet);
            }

            int code = ss.Get(nombre);

            if (code == 0)
            {
                response.code = JsonResponse.ERROR;
            }
            else
            {
                response.code = JsonResponse.OK;
            }

            response.value = code;

            return Json(response, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Add(string nombre,string descripcion,string tipo, string stock)
        {
            JsonResponse response = new JsonResponse();

            if (string.IsNullOrEmpty(nombre)|| string.IsNullOrEmpty(descripcion) || string.IsNullOrEmpty(tipo) || string.IsNullOrEmpty(stock))
            {
                response.code = JsonResponse.ERROR;
                response.value = 0;

                return Json(response, JsonRequestBehavior.AllowGet);
            }

            StockService ss = new StockService();

            int code = ss.Add(nombre,descripcion,tipo,stock);

       

            response.value = code;

            return Json(response, JsonRequestBehavior.AllowGet);
        }
    }
}
