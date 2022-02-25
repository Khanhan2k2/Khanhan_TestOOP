using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace Test_OOP
{

    public class Fan:Product
    {
        protected int TypeF;
        protected double Fcost;
        public Fan():base()
        {
            TypeF = 0;
            Fcost = 0;
        }
        public override void InPut()
        {
            StreamWriter sw = File.AppendText(@"D:\hk4\thực tập ASP\Test OOP\ListOfBill.txt");
            while (0>=TypeF||TypeF>3)
            {
                Console.Write("\t\t\tChọn loại máy quạt (1- máy quạt đứng, 2- máy quạt hơi nước, 3- máy quạt sạc điện):");
                try
                {
                    TypeF = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("\t\t\tChỉ nhập 1,2 hoặc 3");
                }
            }
            sw.WriteLine("\t\t\tChọn loại máy quạt (1- máy quạt đứng, 2- máy quạt hơi nước, 3- máy quạt sạc điện):" + TypeF);
        }
        public override void OutPut()
        { }
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
    public class StandFan : Fan
    {
        
        public StandFan() : base()
        {
            Fcost = 500;
            TypeF = 1;
        }
        public override void InPut()
        {
            StreamWriter sw = File.AppendText(@"D:\hk4\thực tập ASP\Test OOP\ListOfBill.txt");
            do
            {
                Console.Write("\t\t\tNhập mã(3-10 kí tự gồm số hoặc chữ): ");
                IDP = Console.ReadLine();
            } while (IDP == "" || !IsID(IDP)||IDP.Contains(" "));
            sw.WriteLine("\t\t\tNhập mã: " + IDP);
            do
            {
                Console.Write("\t\t\tTên sản phẩm: ");
                NameP = Console.ReadLine();
            } while (NameP == "" || !IsName(NameP));
            sw.WriteLine("\t\t\tTên sản phẩm: " + NameP);
            do
            {
                Console.Write("\t\t\tNơi sản xuất: ");
                Where = Console.ReadLine();
            } while (Where == "" || !IsName(Where) );
            sw.WriteLine("\t\t\tNơi sản xuất: " + Where);
            do
            {
                Console.Write("\t\tSố lượng bán ra: ");
                try
                {
                    Amout = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("\t\tNhập số nguyên dương");
                }
            } while (Amout <= 0);
            sw.WriteLine("\t\tSố lượng bán ra: " + Amout);
            sw.Close();
        }
        public override double Price()
        {
            Fcost = 500;
            return Fcost;
        }
        public override void OutPut()
        {
            Console.Write("Máy quạt: " + IDP + ", " + "quạt đứng" + ",tên: " + NameP + ",giá: " + Fcost.ToString() + ",số lượng " + Amout.ToString());
        }
    }
    public class WaterFan : Fan
    {
        private double Liter;
       
        public WaterFan():base()
        {
            Liter = 0;
        }
        public override void InPut()
        {
            StreamWriter sw = File.AppendText(@"D:\hk4\thực tập ASP\Test OOP\ListOfBill.txt");
            do
            {
                Console.Write("\t\t\tNhập mã(3-10 kí tự gồm số hoặc chữ): ");
                IDP = Console.ReadLine();
            } while (IDP == "" || !IsID(IDP) || IDP.Contains(" "));
            sw.WriteLine("\t\t\tNhập mã: " + IDP);
            do
            {
                Console.Write("\t\t\tTên sản phẩm: ");
                NameP = Console.ReadLine();
            } while (NameP == "" || !IsName(NameP));
            sw.WriteLine("\t\t\tTên sản phẩm: " + NameP);
            do
            {
                Console.Write("\t\t\tNơi sản xuất: ");
                Where = Console.ReadLine();
            } while (Where == "" || !IsName(Where) );
            sw.WriteLine("\t\t\tNơi sản xuất: " + Where);
            do
            {
                Console.Write("\t\t\tDung tích nước: ");
                try
                {
                    Liter = double.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("\t\t\tNhập số nguyên dương");
                }
            } while (Liter <= 0);
            sw.WriteLine("\t\t\tDung tích nước: " + Liter);
            do
            {
                Console.Write("\t\tSố lượng bán ra: ");
                try
                {
                    Amout = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("\t\tNhập số nguyên dương");
                }
            } while (Amout <= 0);
            sw.WriteLine("\t\tSố lượng bán ra: " + Amout);
            sw.Close();
        }
        public override double Price()
        {
            Fcost = 400*Liter;
            return Fcost;
        }
        public override void OutPut()
        {
            Console.Write("Máy quạt: " + IDP + " " + "quạt hơi nước" + ",tên: " + NameP + ",giá: " + Fcost.ToString() + ",dung tích: "+ Liter.ToString()+" lit" +",số lượng " + Amout.ToString());
        }
    }
    public class ElecFan : Fan
    {
        private double Pin;
        
        public ElecFan() : base()
        {
            Pin = 0;
        }
        public override void InPut()
        {
            StreamWriter sw = File.AppendText(@"D:\hk4\thực tập ASP\Test OOP\ListOfBill.txt");
            do
            {
                Console.Write("\t\t\tNhập mã(3-10 kí tự gồm số hoặc chữ): ");
                IDP = Console.ReadLine();
            } while (IDP == "" || !IsID(IDP) || IDP.Contains(" "));
            sw.WriteLine("\t\t\tNhập mã: " + IDP);
            do
            {
                Console.Write("\t\t\tTên sản phẩm: ");
                NameP = Console.ReadLine();
            } while (NameP == "" || !IsName(NameP) );
            sw.WriteLine("\t\t\tTên sản phẩm: " + NameP);
            do
            {
                Console.Write("\t\t\tNơi sản xuất: ");
                Where = Console.ReadLine();
            } while (Where == "" || !IsName(Where));
            sw.WriteLine("\t\t\tNơi sản xuất: " + Where);
            do
            {
                Console.Write("\t\t\tDung lượng pin: ");
                try
                {
                    Pin = double.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("\t\t\tNhập số nguyên dương");
                }
            } while (Pin <= 0);
            sw.WriteLine("\t\t\tDung lượng pin: " + Pin);
            do
            {
                Console.Write("\t\tSố lượng bán ra: ");
                try
                {
                    Amout = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("\t\tNhập số nguyên dương");
                }
            } while (Amout <= 0);
            sw.WriteLine("\t\tSố lượng bán ra: " + Amout);
            sw.Close();
        }
    
        public override double Price()
        {
            Fcost = 500*Pin;
            return Fcost;
        }
        public override void OutPut()
        {
            Console.WriteLine("Máy quạt: " + IDP + " " + "quạt sạc điện" + ",tên: " + NameP + ",giá: " + Fcost.ToString() + ",dung lượng pin " + Pin.ToString() + " mA" + ",số lượng: " + Amout.ToString());
        }
    }
}
