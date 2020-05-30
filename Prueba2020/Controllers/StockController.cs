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
        public JsonResult GetAll()
        {
            StockService ss = new StockService();

            List<Inventario> inventario = ss.GetAll();

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

        public JsonResult Get(int codigoProducto)
        {
            StockService ss = new StockService();

            Inventario inventario = ss.Get(codigoProducto);

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
        // GET: Stock/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Stock/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Stock/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Stock/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Stock/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Stock/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Stock/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
