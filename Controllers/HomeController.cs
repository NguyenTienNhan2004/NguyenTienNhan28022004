using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using PagedList;
using System.Web.UI;
using System.Collections.ObjectModel;
using WebBanLinhKien.Models;

namespace WebBanLinhKien.Controllers
{
    
        public class HomeController : Controller
        {
            // GET: Home
            public ActionResult TrangChu()
            {
                StoreComputerEntities db = new StoreComputerEntities();
                List<HangHoa> hangHoas = db.HangHoas.ToList();
                return View(hangHoas);
            }
            public ActionResult GioiThieu()
            {
                return View();
            }
            public ActionResult Laptop()
            {
                return RedirectToAction("DanhSachLaptop", "Laptop");
            }

            public ActionResult LinhKien()
            {
                return RedirectToAction("DanhSachLinhKien", "LinhKien");
            }
            public ActionResult TinTuc()
            {
                return View();
            }
            public ActionResult ThongTinLienHe()
            {
                return View();
            }
            public ActionResult DangNhap()
            {
                return View();
            }
        }
}