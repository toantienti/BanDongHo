using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BanDongHo.Areas.Admin.Controllers
{
    public class BanhangController : Controller
    {
        // GET: Admin/Banhang
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Donhang()
        {
            return View();
        }
        public ActionResult Danhgia_Nhanxet()
        {
            return View();
        }
    }
}