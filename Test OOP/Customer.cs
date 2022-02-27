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
        private string _idc;
        private string _nameC;
        private string _address;
        private string _phone;
        public Customer()
        {
            _idc = "";
            _nameC = "";
            _address = "";
            _phone = "";
        }
        public void Input()
        {
            
            Console.WriteLine("\tNhập thông tin khách hàng: ");
            do
            {
                Console.Write("\tMã khách hàng(3-10 kí tự gồm số hoặc chữ): ");
                _idc = Console.ReadLine();
            } while (!IsID(_idc));
            do
            {
                Console.Write("\tTên khách hàng: ");
                _nameC = Console.ReadLine();
            } while (!IsName(_nameC));
            do
            {
                Console.Write("\tĐịa chỉ: ");
                _address = Console.ReadLine();
            } while (!IsName(_address));
            do
            {
                Console.Write("\tSố điện thoại: ");
                _phone = Console.ReadLine();
            } while (!IsNumber_phone(_phone));


            
        }
        public void Output()
        {
            Console.WriteLine("Thông tin khách hàng: " + _idc + " " + _nameC + " " + _address + " " + _phone);
        }
        protected bool IsNumber_phone(string number)
        {
            if (number.Length<5||number.Length>14)
            {
                return false;
            }
            else
            {
                if (System.Text.RegularExpressions.Regex.Match(number, @"^[0-9]{10}").Success) return true;
                else return false;
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
        protected bool IsName(string name)
        {
            if (name.Length < 0) return false;
            else
            {

                if (name.IndexOf(" ") == 0) return false;
                if (System.Text.RegularExpressions.Regex.Match(name, @"[a-zA-Z_0-9\s]").Success) return true;
                else return false;
            }
        }
        public void OutToText()
        {
            StreamWriter sw = File.AppendText(Environment.CurrentDirectory + @"\danh_sach_hoa_don.txt");
            sw.WriteLine("\tNhập thông tin khách hàng: ");
            sw.WriteLine("\tMã khách hàng: " + _idc);
            sw.WriteLine("\tTên khách hàng: " + _nameC);
            sw.WriteLine("\tĐịa chỉ: " + _address);
            sw.WriteLine("\tSố điện thoại: " + _phone);
            sw.Close();
        }
    }
}
