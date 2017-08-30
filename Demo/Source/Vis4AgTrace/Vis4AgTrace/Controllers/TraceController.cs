using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vis4AgTrace.Models.Trace;

namespace Vis4AgTrace.Controllers
{
    public class TraceController : Controller
    {
        // /Trace
        [HttpGet]
        public virtual ActionResult Index()
        {
            return View(new TraceModel());
        }

        // /Trace
        [HttpPost]
        public virtual ActionResult Index(string ContainerID, string LoadID, string traceType)
        {
            Guid containerFromPage;
            Guid loadFromPage;
                       
            Guid.TryParse(ContainerID, out containerFromPage);
            Guid.TryParse(LoadID, out loadFromPage);
              
            return View(new TraceModel(containerFromPage, loadFromPage, traceType));
        }
    }
}