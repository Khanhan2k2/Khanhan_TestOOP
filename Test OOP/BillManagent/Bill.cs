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
        private string _idBill="";
        private string _date="";
        private Customer _quest=new Customer();
        private List<DetailBill> _listDetailBill=new List<DetailBill>();
        private int _NumberOfDetailBill=0;
        private double _total=0;
        public void InPut()
        {
            do
            {
                Console.Write("Mã hóa đơn(3-10 kí tự gồm số hoặc chữ,VD:HD003): ");
                _idBill = Console.ReadLine();
            } while (!IsID(_idBill));
            
            do
            {
                Console.Write("Ngày lập hóa đơn(dd/mm/yyyy): ");
                _date = Console.ReadLine();
            }
            while (!IsDate(_date)) ;
            
            Console.WriteLine("Thông tin khách hàng: ");
            _quest.Input();
            Console.WriteLine("Nhập danh sách các chi tiết hóa đơn: ");
            do
            {
                
               
                Console.Write("\tSố lượng chi tiết trong danh sách các chi tiết hóa đơn: ");
                try
                {
                    _NumberOfDetailBill = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("\tvui lòng nhập số nguyên dương");
                    continue;
                }
            } while (_NumberOfDetailBill <= 0);
            for (int i = 0; i < _NumberOfDetailBill; i++)
            {
                DetailBill temp = new DetailBill();
                Console.WriteLine("\tNhập chi tiết hóa đơn thứ " + (i + 1));
                temp.InPut();
                temp.Price();
                _listDetailBill.Add(temp);
                _total += temp.DetailBillCost;
            }
        }
        public void OutPut()
        {
            Console.WriteLine("Hóa đơn:\n\t\t\tMã hóa đơn: " + _idBill + "\n\t\t\tNgày nhập hóa đơn: " + _date+"\n\t\t\tGiá: "+_total);
            _quest.Output();
            for(int i=0;i< _listDetailBill.Count;i++)
            {
                _listDetailBill[i].Output();
            }    
            
        }
        protected bool IsDate(string temp_date)
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
            StreamWriter sw = File.AppendText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\danh_sach_hoa_don.txt");
            sw.WriteLine("\t\t\tMã hóa đơn: " + _idBill);
            sw.WriteLine("\t\t\tNgày lập hóa đơn: " + _date);
            sw.WriteLine("\t\t\tTổng giá: " + _total);
            sw.WriteLine("Thông tin khách hàng: ");
            sw.Close();
            _quest.OutToText();
            sw = File.AppendText(Environment.CurrentDirectory + @"\danh_sach_hoa_don.txt");
            sw.WriteLine("Danh sách các chi tiết hóa đơn");
            sw.Close();
            for (int i = 0; i < _NumberOfDetailBill; i++)
            {
                _listDetailBill[i].OutToText();
            }
        }

    }
}
