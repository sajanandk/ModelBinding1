using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ModelBinding1.CustomFilters
{[Authorize]
    public class EmployeeFilter:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Log("OnActionExecuting", filterContext.RouteData);
        }
        private void Log(string method,RouteData routeData)
        {
            var ControllerName = routeData.Values["controller"];
            var actionName = routeData.Values["action"];
            var message = string.Format("{0}={1}->{2}", method, ControllerName, actionName);
            Console.WriteLine(message);
        }
    } 
}