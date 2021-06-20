using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _04_D01.Controllers
{
    public class HomeController : Controller
    {
        DB01Entities entity = new DB01Entities();
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult GetMenu()
        {
            var menu = entity.LoaiSPs.ToList();
            return PartialView("PartialMenu", menu);
        }

        public ActionResult TrangChu()
        {
            return View();
        }

        public ActionResult SPTheoLoai(int maLoai, int? index)
        {
            var pageSize = 10 / 2;
            index = index ?? 1;
            var dssp = entity.SanPhams.Where(s => s.MaLoai == maLoai).ToList();
            return View(dssp);
        }

        public ActionResult ChiTietSP(int id)
        {
            var rs = entity.SanPhams.FirstOrDefault(s => s.MaSP == id);
            ViewBag.thuongHieu = entity.LoaiSPs.FirstOrDefault(l => l.MaLoai == rs.MaLoai).Ten;
            ViewBag.SPTuongTu = entity.SanPhams.Where(x => x.MaLoai == rs.MaLoai && x.MaSP != rs.MaSP);
            return View(entity.SanPhams.FirstOrDefault(s => s.MaSP == id));
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}