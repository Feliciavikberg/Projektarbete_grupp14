using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IIProjectClient.Controllers
{
    public class PassageinfoController : Controller
    {
        // GET: Passageinfo
        public ActionResult Index()
        {
            PassageServiceReference.PassageInfoServiceClient passageClient = new PassageServiceReference.PassageInfoServiceClient();
            passageClient.Test();
            return View();
        }
        
    }
}