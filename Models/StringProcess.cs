using System.Text.RegularExpressions;

namespace NguyenHuongGiang_BTH.Models.Process
{
    public class StringProcess
    
    {
            //RemoveRemainingWhiteSpace: Xoá bỏ ký tự trắng còn thừa trong chuỗi.
        public string RemoveRemainingWhiteSpace (string strInput)
        {
            string result = "";
            // viết code xử lí yêu cầu bài toán
            strInput = strInput.Trim();
            int index = strInput.IndexOf(" ");
            while(strInput.IndexOf("  ")>0)
            {
               strInput=strInput.Replace("  "," ");

            }
            result = strInput;
            return result;
        }

       // UppertoLower: chuyển chuỗi sang in thường.

        public string UpperToLower (string strInput)
        {
            string strResult = "";
            //viết code xử lí theo yêu cầu của bài toán
            strInput = strInput.ToLower();
            strResult = strInput;
            // trả về giá trị
            return strResult;
        }

        
//LowerToUpper: chuyển chuỗi sang in hoa.
        public string LowerToUpper (string strInput)
        {
            string strResult = "";
            //viết code xử lí theo yêu cầu của bài toán
            strInput = strInput.ToUpper();
            strResult = strInput;
            // trả về giá trị
            
            return strResult;
        }

// CapitalizeOneFirstCharacter (string strInput): Viết hoa ký tự đầu tiên của chuỗi.
        public string CapitalizeOneFirstCharacter(string strInput)
        {
            string strResult = "";
            //giả sử có chuỗi " tin học kinh tế"

            //kq sau khi xử lí " Tin học kinh tế"
            // lấy ra ký tự đầu tiên của chuỗi 
            //lấy ra ký tự đàu tiên của chuỗi
            string strResult1 = strInput.Substring(0, 1);
            string strResult2 = strInput.Substring(1);

            strResult1 = strResult1.ToUpper();
            
            strResult = strResult1 + strResult2;
            return strResult;
        }

//CapitalizeFirstCharacter(string strInput): viết hoa kí tự đầu tiên của từng chữ
        public string CapitalizeFirstCharacter(string strInput)
        {
            string hoten = "";
            //=> giá trị trả về : " Nguyen Huong Giang"
            string strResult ="";
            // tách  các phần tử trong chuỗi  đưa vào 1 mảng 
            string[] chuoi = strInput.Split(" ");

            // sử dụng vòng lặp để xử lí giá trị trong mảng string
            strInput = strInput.ToLower();
        char[] array =strInput.ToCharArray();  
        if (array.Length >= 1)
            {
                if (char.IsLower(array[0]))
             {
            array[0] = char.ToUpper(array[0]);
             }
            }  
  
        for (int i = 1; i < array.Length; i++)
         {
        if (array[i - 1] == ' ')
        {
            if (char.IsLower(array[i]))
            {
                array[i] = char.ToUpper(array[i]);
            }
        }
        }
         return new string(array);
            return strResult;
        } 

        // RemoveVietnameseAccents (string strInput): Bỏ dấu tiếng việt
        public string RemoveVietnameseAccents(string strInput)
        {
            string Result = strInput.ToLower();
            Result = Regex.Replace(Result, "à|á|ạ|ả|ã|â|ầ|ấ|ậ|ẩ|ẫ|ă|ằ|ắ|ặ|ẳ|ẵ|/g", "a");
            Result = Regex.Replace(Result, "è|é|ẹ|ẻ|ẽ|ê|ề|ế|ệ|ể|ễ|/g", "e");
            Result = Regex.Replace(Result, "ì|í|ị|ỉ|ĩ|/g", "i");
            Result = Regex.Replace(Result, "ò|ó|ọ|ỏ|õ|ô|ồ|ố|ộ|ổ|ỗ|ơ|ờ|ớ|ợ|ở|ỡ|/g", "o");
            Result = Regex.Replace(Result, "ù|ú|ụ|ủ|ũ|ư|ừ|ứ|ự|ử|ữ|/g", "u");
            Result = Regex.Replace(Result, "ỳ|ý|ỵ|ỷ|ỹ|/g", "y");
            Result = Regex.Replace(Result, "đ", "d");
            return Result;
        }

    }
}