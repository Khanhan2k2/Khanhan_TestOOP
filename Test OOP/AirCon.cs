using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Test_OOP
{
    public class AirCon:Product
    {
        protected int TypeAC=0;
        protected double ACcost=0;
        protected int inverter=0;
        public int _TypeAC
        {
            get { return TypeAC; }
            set { TypeAC = value; }
        }
        public override void InPut()
        {
            
            while (0 >= _TypeAC || _TypeAC > 2)
            {
                Console.Write("\t\t\tChọn loại máy lạnh (1- máy lạnh một chiều, 2- máy lạnh hai chiều):");
                try
                {
                    _TypeAC = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("\t\t\t nhập 1 hoặc 2");
                }
            }
            
        }

        public override void OutPut()
        { }
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
            if (name.Length < 3) return false;
            else
            {

                if (name.IndexOf(" ") == 0) return false;
                if (System.Text.RegularExpressions.Regex.Match(name, @"[a-zA-Z_0-9\s]").Success) return true;
                else return false;
            }
        }
        public override void OutToText()
        {
            StreamWriter sw = File.AppendText(Environment.CurrentDirectory + @"\danh_sach_hoa_don.txt");
            sw.WriteLine("\t\t\tChọn loại máy lạnh (1- máy lạnh một chiều, 2- máy lạnh hai chiều):" + _TypeAC);
            sw.Close();
        }
    }

    
    
}
