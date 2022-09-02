using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;

namespace SFDev2022.Mvc.Controllers
{
    [ControllerToolboxItem(Name ="HelloWorld", Title ="Hello World", SectionName ="SFDev2022")]
    public class HelloWorldController : Controller
    {
        public string Message { get; set; }
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }
    }
}