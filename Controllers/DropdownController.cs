using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication53.Models;

namespace WebApplication53.Controllers
{
    public class DropdownController : Controller
    {
        cascading objdb = new cascading();
        // GET: Dropdown
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetCountry()
        {
            var countries = objdb.GetCountries();
            return Json(countries, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetState(int id)
        {
            var states = objdb.GetState(id);
            return Json(states, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetCity(int id)
        {
            var cities = objdb.GetCity(id);
            return Json(cities, JsonRequestBehavior.AllowGet);
        }
    }
}