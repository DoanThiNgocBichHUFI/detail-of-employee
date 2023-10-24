using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bai4.Models;

namespace bai4.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            var nv = new NhanVien();
            ViewData["nv"] = nv;
            return View();
        }
	}
}
