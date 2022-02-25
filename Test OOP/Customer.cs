using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Test_OOP
{
    public class Customer
    {
        private string IDC;
        private string NameC;
        private string Address;
        private string Phone;
        public Customer()
        {
            IDC = "";
            NameC = "";
            Address = "";
            Phone = "";
        }
        public void Input()
        {
            StreamWriter sw = File.AppendText(@"D:\hk4\thực tập ASP\Test OOP\ListOfBill.txt");
            Console.WriteLine("\tNhập thông tin khách hàng: ");
            do
            {
                Console.Write("\tMã khách hàng(3-10 kí tự gồm số hoặc chữ): ");
                IDC = Console.ReadLine();
            } while (IDC == "" || !IsID(IDC));
            do
            {
                Console.Write("\tTên khách hàng: ");
                NameC = Console.ReadLine();
            } while (NameC == "" || !IsName(NameC));
            do
            {
                Console.Write("\tĐịa chỉ: ");
                Address = Console.ReadLine();
            } while (NameC == ""||!IsName(Address));
            do
            {
                Console.Write("\tSố điện thoại: ");
                Phone = Console.ReadLine();
            } while (Phone == "" || !IsNumberPhone(Phone));


            sw.WriteLine("\tNhập thông tin khách hàng: ");
            sw.WriteLine("\tMã khách hàng: " + IDC);
            sw.WriteLine("\tTên khách hàng: " + NameC);
            sw.WriteLine("\tĐịa chỉ: " + Address);
            sw.WriteLine("\tSố điện thoại: " + Phone);
            sw.Close();
        }
        public void Output()
        {
            Console.WriteLine("Thông tin khách hàng: " + IDC + " " + NameC + " " + Address + " " + Phone);
        }
        public static bool IsNumberPhone(string number)
        {
            if (number.Length != 10)
            {
                return false;
            }
            else
            {
                if (System.Text.RegularExpressions.Regex.Match(number, @"^[0-9]{10}").Success) return true;
                else return false;
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
        public static bool IsName(string name)
        {
            if (name.Length < 3) return false;
            else
            {

                if (name.IndexOf(" ") == 0) return false;
                if (System.Text.RegularExpressions.Regex.Match(name, @"[a-zA-Z_0-9\s]").Success) return true;
                else return false;
            }
        }
    }
}
