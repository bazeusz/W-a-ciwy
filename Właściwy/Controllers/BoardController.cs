using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Właściwy.Controllers
{
    public class BoardController : Controller
    {
        // GET: Board
        public ActionResult Board()
        {
            return View();
        }
    }
}