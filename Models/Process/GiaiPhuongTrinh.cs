namespace NguyenHuongGiang_BTH.Models.Process
{
    public class GiaiPhuongTrinh
    {
        // xay dưng phuong thuc giai pt bac nhat
        public string GiaiPhuongTrinhBacNhat (double heSoA, double heSoB)
        {
            string message ="";
            double x;
            if(heSoA==0){
                if(heSoB==0){
                    message = "phuong trinh vo so nghiem";
                }
                else {
                message = "phuong trinh vo nghiem";
                }   
            } else {
                x =-heSoB/heSoA;
                message = "phuong trinh co nghiem x =" +x ;
            }
               return message;            
        }
        //phuong thuc giai phuong trinh bac 2
        public string GiaiPhuongTrinhBacHai(double a, double b, double c)
        {
            //giai phuong trinh bac 2 
            string message = "";
            if(a==0){
                message = GiaiPhuongTrinhBacNhat(b,c);
            }
            else {
                //giai phuong trinh bac 2 khi a!=0
            }
            return message;
        }
    }   
}