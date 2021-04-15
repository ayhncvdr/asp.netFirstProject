using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp.netFirstProject.Controllers
{
    public class CetController : Controller
    {
        // get/ Cet/Hello
        public IActionResult Hello()
        {
            return Content("Hello Cet");
        }
    }
}
