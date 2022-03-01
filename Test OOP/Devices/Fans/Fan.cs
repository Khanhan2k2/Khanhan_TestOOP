using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace Test_OOP
{

    public class Fan:Product
    {
        protected int typeFan=0;
        protected double fanCost=0;

        public Fan():base()
        {
            typeFan = 0;
            fanCost = 0;
        }
        public override void InPut()
        {
            while (0>=typeFan||typeFan>3)
            {
                Console.Write("\t\t\tChọn loại máy quạt (1- máy quạt đứng, 2- máy quạt hơi nước, 3- máy quạt sạc điện):");
                try
                {
                    typeFan = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("\t\t\tChỉ nhập 1,2 hoặc 3");
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
            if (name.Length < 3)
            {
                Console.WriteLine("\t\t\t Cần phải nhập nhiều hơn 2 kí tự và chỉ nhận chữ hoặc số.");
                return false;
            }
            else
            {

                if (name.IndexOf(" ") == 0) return false;
                if (System.Text.RegularExpressions.Regex.Match(name, @"[a-zA-Z_0-9\s]").Success) return true;
                else return false;
            }
        }
        public override void OutToText()
        {

        }

    }
    
    
    
}
