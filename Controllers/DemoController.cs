using Microsoft.AspNetCore.Mvc;
using NguyenHuongGiang_BTH.Models;
using NguyenHuongGiang_BTH.Models.Process;

namespace NguyenHuongGiang_BTH.Controllers
{
    public class DemoController : Controller
    {
        GiaiPhuongTrinh gpt = new GiaiPhuongTrinh();
        public IActionResult Index()
        {
            return View();
        }

        //nhận được dữ liệu từ view gửi lên
        [HttpPost]
        public IActionResult Index (string heSoA, string heSoB)
        {
            double a = Convert.ToDouble(heSoA);
            double b = Double.Parse(heSoB);
            string thongBao = gpt.GiaiPhuongTrinhBacNhat(a,b);

            ViewBag.mess = thongBao;
            return View();

            //3. giải phương trình

            // gửi thông báo về view
        }
    [HttpPost]
    public IActionResult Create()
        {   
            string thongBao = gpt.GiaiPhuongTrinhBacHai(5.5, 6.3, 8.2);
            return View();
        }
    }
    
}
