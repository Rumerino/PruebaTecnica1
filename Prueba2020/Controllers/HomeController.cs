using Prueba2020.Service.Interface;
using Prueba2020.Service.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prueba2020.Controllers
{
    public class HomeController : Controller
    {
        /*private readonly IStock _iStock;
        public HomeController(IStock _istock)
        {
            _iStock = _istock;
        }*/
        public ActionResult Index()
        {
            //_iStock.prueba1(2,2);

            StockService ss = new StockService();
            var prueba = ss.GetAll();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}