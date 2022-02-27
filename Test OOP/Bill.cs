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
        private string _idb="";
        private string _date="";
        private Customer _quest=new Customer();
        private List<Detai_lbill> _ldBill=new List<Detai_lbill>();
        private int _nodb=0;
        private double _total=0;
        public void InPut()
        {
            do
            {
                Console.Write("Mã hóa đơn(3-10 kí tự gồm số hoặc chữ,VD:HD003): ");
                _idb = Console.ReadLine();
            } while (!IsID(_idb));
            
            do
            {
                Console.Write("Ngày lập hóa đơn(dd/mm/yyyy): ");
                _date = Console.ReadLine();
            }
            while (!Is_date(_date)) ;
            
            Console.WriteLine("Thông tin khách hàng: ");
            _quest.Input();
            Console.WriteLine("Nhập danh sách các chi tiết hóa đơn: ");
            do
            {
                
               
                Console.Write("\tSố lượng chi tiết trong danh sách các chi tiết hóa đơn: ");
                try
                {
                    _nodb = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("\tvui lòng nhập số nguyên dương");
                    continue;
                }
            } while (_nodb<=0);
            for (int i = 0; i < _nodb; i++)
            {
                Detai_lbill temp = new Detai_lbill();
                Console.WriteLine("\tNhập chi tiết hóa đơn thứ " + (i + 1));
                temp.InPut();
                temp.Price();
                _ldBill.Add(temp);
                _total += temp._DBcost;
            }
        }
        public void OutPut()
        {
            Console.WriteLine("Hóa đơn: " + _idb + " " + _date+" "+_total);
            _quest.Output();
            for(int i=0;i<_ldBill.Count;i++)
            {
                _ldBill[i].Output();
            }    
            
        }
        protected bool Is_date(string temp_date)
        {
            if (temp_date == "") return false;
            DateTime from_dateValue;
            var formats = new[] { "dd/MM/yyyy", "yyyy-MM-dd","d/M/yyyy","dd/M/yyyy","d/MM/yyyy" };
            if (DateTime.TryParseExact(temp_date, formats, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out from_dateValue))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        protected bool IsID(string ID)
        {
            if (ID.Length < 3 || ID.Length > 10)
            {
                Console.WriteLine("\t\t\tMã thường gồm 3-10 kí tự gồm chữ hoặc số");
                return false;
            }
            else
            {
                if (ID.Contains(" "))
                {
                    Console.WriteLine("\t\t\tMã thường gồm 3-10 kí tự gồm chữ hoặc số");
                    return false;
                }
                if (System.Text.RegularExpressions.Regex.Match(ID, @"[a-zA-Z_0-9]").Success) return true;
                else
                {
                    Console.WriteLine("\t\t\tMã thường gồm 3-10 kí tự gồm chữ hoặc số");
                    return false;
                }
            }
        }
        public void OutToText()
        {
            StreamWriter sw = File.AppendText(Environment.CurrentDirectory + @"\danh_sach_hoa_don.txt");
            sw.WriteLine("\t\t\tMã hóa đơn: " + _idb);
            sw.WriteLine("\t\t\tNgày lập hóa đơn: " + _date);
            sw.WriteLine("Thông tin khách hàng: ");
            sw.Close();
            _quest.OutToText();
            sw = File.AppendText(Environment.CurrentDirectory + @"\danh_sach_hoa_don.txt");
            sw.WriteLine("Danh sách các chi tiết hóa đơn");
            sw.Close();
            for (int i = 0; i < _nodb; i++)
            {
                _ldBill[i].OutToText();
            }
        }

    }
}
