using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeatherApp.Models;

namespace WeatherApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        // GET: WeatherJs
        public ActionResult WeatherJs()
        {
            return View();
        }
        // GET: Json GetWeather
        public JsonResult GetWeather()
        {
            Weather weath = new Weather();
            return Json(weath.getWeatherForcast(),JsonRequestBehavior.AllowGet); //problem??
        }
        public ActionResult WeatherOrNot()
        {
            return View();
        }
    }
}