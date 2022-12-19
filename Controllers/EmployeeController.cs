using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelBinding1.Controllers
{    public class EmployeeController : Controller
    {
        // GET: Employee
        //[Authorize]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(EmployeeController employee)
        {
            return View();

        }



    }
}