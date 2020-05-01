using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        NWDataContext nDC = new NWDataContext();
        public ActionResult Index()
        {
            // lấy dữ liệu từ NW context đổ ra
            var sp = from p in nDC.Products select p; // lấy ds sp trong Product
            return View(sp); // truyền vào

        }
        public ActionResult Details(int id)
        {
            // lấy dữ liệu từ NW context đổ ra
            var sp= nDC.Products.Where(p=>p.ProductID == id); // lấy mã sp, tên sp, đơn giá LinQ
            return View(sp); // đổ vào view

        }
    }
}