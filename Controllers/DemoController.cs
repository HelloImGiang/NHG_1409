using System.Net.NetworkInformation;
using Microsoft.AspNetCore.Mvc;
using NguyenHuongGiang_BTH.Models;
using NguyenHuongGiang_BTH.Models.Process;

namespace NguyenHuongGiang_BTH.Controllers
{
    public class DemoController : Controller
    {
        //khai bao class theo huong doi tuong
        GiaiPhuongTrinh gpt = new GiaiPhuongTrinh();

        StringProcess strPro = new StringProcess();
        public IActionResult Index()
        {
            return View();
        }

        //nhận được dữ liệu từ view gửi lên
        [HttpPost]
        public IActionResult Index (string heSoA, string heSoB)
        {
            //ep kieu du lieu cua tham so
            double a = Convert.ToDouble(heSoA);
            double b = Convert.ToDouble(heSoB);
            string thongBao = gpt.GiaiPhuongTrinhBacNhat(a,b);

            ViewBag.mess = thongBao;
            return View();

            //3. giải phương trình

            // gửi thông báo về view
        }
        public IActionResult Create ()
      {
            return View();
      }
        
    [HttpPost]
    public IActionResult Create(string a, string b, string c)
        {   
            double f = Convert.ToDouble(a);
            double d = Convert.ToDouble(b);
            double e = Convert.ToDouble(c);
            string thongBao = gpt.GiaiPhuongTrinhBacHai( f,d,e );
            
            ViewBag.thongBao=thongBao;
            return View();
        }

    //RemoveRemainingWhiteSpace: Xoá bỏ ký tự trắng còn thừa trong chuỗi.
    public IActionResult RemoveSpace()
        {
            return View();
        }
    
    [HttpPost]
    public IActionResult RemoveSpace(string strInput)
        {
             ViewBag.thongbao= strPro.RemoveRemainingWhiteSpace(strInput);
            return View();
        }
        // UppertoLower: chuyển chuỗi sang in thường.
        public IActionResult Lower()
        {
            return View(); 
        }
       [HttpPost]
        public IActionResult Lower(string strInput )
        { 
            ViewBag.thongbao=strPro.UpperToLower(strInput);
            return View();
        }

//LowerToUpper: chuyển chuỗi sang in hoa.
        public IActionResult Upper()
        {
            return View(); 
        }
       [HttpPost]
        public IActionResult Upper(string strInput )
        { 
            ViewBag.thongbao= strPro.LowerToUpper(strInput);
            return View();
        }

    // CapitalizeOneFirstCharacter (string strInput): Viết hoa ký tự đầu tiên của chuỗi.
    public IActionResult OneFirstChar()
        {
            return View(); 
        }
       [HttpPost]
        public IActionResult OneFirstChar(string strInput )
        { 
            ViewBag.thongbao= strPro.CapitalizeOneFirstCharacter(strInput);
            return View();
        }
        
//CapitalizeFirstCharacter(strInput): viết in hoa từng câu
        public IActionResult FirstChar()
        {
            return View(); 
        }
       [HttpPost]
        public IActionResult FirstChar(string strInput )
        { 
            ViewBag.thongbao= strPro.CapitalizeFirstCharacter(strInput);
            return View();
        }
//        // RemoveVietnameseAccents (string strInput): Bỏ dấu tiếng việt

        public IActionResult RemoveVietese()
        {
            return View(); 
        }
       [HttpPost]
        public IActionResult RemoveVietese(string strInput)
        { 
            ViewBag.thongbao= strPro.RemoveVietnameseAccents(strInput);
            return View();
        }
    
    }   
}

