using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Test_OOP
{
   public class Bill
    {
        private string IDB;
        private string Date;
        private Customer Quest;
        private List<DetailBill> LDBill;
        private int NODB;
        private double Total;
        public Bill()
        {
            IDB = "";
            Date = "";
            Quest = new Customer();
            LDBill = new List<DetailBill>();
            NODB = 0;
            Total = 0;
        }
        public void InPut()
        {
            StreamWriter sw = File.AppendText(@"D:\hk4\thực tập ASP\Test OOP\ListOfBill.txt");
            do
            {
                Console.Write("Mã hóa đơn(3-10 kí tự gồm số hoặc chữ): ");
                IDB = Console.ReadLine();
            } while (!IsID(IDB));
            sw.WriteLine("Mã hóa đơn: " + IDB);
            do
            {
                Console.Write("Ngày lập hóa đơn: ");
                Date = Console.ReadLine();
            }
            while (Date == "" || !IsDate(Date)) ;
            sw.WriteLine("Ngày lập hóa đơn: " + Date);
            Console.WriteLine("Thông tin khách hàng: ");
            sw.WriteLine("Thông tin khách hàng: ");
            sw.Close();
            Quest.Input();
            Console.WriteLine("Nhập danh sách các chi tiết hóa đơn: ");
            do
            {
                
               
                Console.Write("\t Số lượng chi tiết trong dah sách các chi tiết hóa đơn: ");
                try
                {
                    NODB = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("\tvui lòng nhập số nguyên dương");
                    continue;
                }
            } while (NODB<=0);
            sw = File.AppendText(@"D:\hk4\thực tập ASP\Test OOP\ListOfBill.txt");
            sw.WriteLine("Nhập danh sách các chi tiết hóa đơn: ");
            sw.WriteLine("\t Số lượng chi tiết trong dah sách các chi tiết hóa đơn: " + NODB);
            sw.Close();
            for (int i=0;i<NODB;i++)
            {
                sw = File.AppendText(@"D:\hk4\thực tập ASP\Test OOP\ListOfBill.txt");
                DetailBill temp = new DetailBill();
                Console.WriteLine("\tNhập chi tiết hóa đơn thứ " + (i + 1));
                sw.WriteLine("\tNhập chi tiết hóa đơn thứ " + (i + 1));
                sw.Close();
                temp.InPut();
                temp.Price();
                LDBill.Add(temp);
                Total += temp._DBcost;
            }    
        }
        public void OutPut()
        {
            Console.WriteLine("Hóa đơn: " + IDB + " " + Date+" "+Total);
            Quest.Output();
            for(int i=0;i<LDBill.Count;i++)
            {
                LDBill[i].Output();
            }    
            
        }
        public static bool IsDate(string tempDate)
        {
            DateTime fromDateValue;
            var formats = new[] { "dd/MM/yyyy", "yyyy-MM-dd" };
            if (DateTime.TryParseExact(tempDate, formats, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out fromDateValue))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsID(string ID)
        {
            if (ID.Length < 3 || ID.Length > 10) return false;
            else
            {
                if (ID.Contains(" ")) return false;
                if (System.Text.RegularExpressions.Regex.Match(ID, @"[a-zA-Z_0-9]").Success) return true;
                else return false;
            }    
        }
       
    }
}
