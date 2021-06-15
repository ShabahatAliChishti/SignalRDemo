using SignalRDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SignalRDemo.Controllers
{
    public class AddController : Controller
    {
        //
        // GET: /Add/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(tblEmployee model)
        {
            SignalRDBEntities entity = new SignalRDBEntities();
            model.AddedOn = DateTime.Now;
            entity.tblEmployees.Add(model);
            entity.SaveChanges();
            return View();
        }

    }
}
