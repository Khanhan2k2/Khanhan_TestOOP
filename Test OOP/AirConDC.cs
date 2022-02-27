using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Test_OOP
{
    public class AirConDC : AirCon
    {
        public AirConDC() : base()
        {
        }
        public override void InPut()
        {
            do
            {
                Console.Write("\t\t\tNhập mã(3-10 kí tự gồm số hoặc chữ): ");
                IDP = Console.ReadLine();
            } while (IDP == "" || !IsID(IDP) || IDP.Contains(" "));
            do
            {
                Console.Write("\t\t\tTên sản phẩm: ");
                NameP = Console.ReadLine();
            } while (NameP == "" || !IsName(NameP));
            do
            {
                Console.Write("\t\t\tNơi sản xuất: ");
                Where = Console.ReadLine();
            } while (Where == "" || !IsName(Where));
            do
            {
                Console.Write("\t\t\tCông nghệ inverter(1- Có, 2- Không): ");
                try
                {
                    inverter = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.Write("\t\t\tNhập 1 hoặc 2");
                    Console.WriteLine();
                }
            } while (inverter < 1 || inverter > 2);
            do
            {
                Console.Write("\t\tSố lượng bán ra: ");
                try
                {
                    Amout = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Nhập số nguyên dương");
                }
            } while (Amout <= 0);
        }

        public override double Price()
        {
            if (inverter == 1)
            {
                ACcost = 1000;
            }
            else
            {
                ACcost = 1500;
            }
            return ACcost;
        }
        public override void OutPut()
        {
            if (inverter == 1)
            {
                Console.WriteLine("Máy lạnh: " + IDP + " 1 chiều có công nghệ inverter, tên: " + NameP + ", giá: " + ACcost.ToString() + ", số lượng " + Amout.ToString());
            }
            else
            {
                Console.WriteLine("Máy lạnh: " + IDP + " 1 chiều không công nghệ inverter, tên: " + NameP + ", giá: " + ACcost.ToString() + ", số lượng " + Amout.ToString());
            }
        }
        public override void OutToText()
        {
            StreamWriter sw = File.AppendText(Environment.CurrentDirectory + @"\danh_sach_hoa_don.txt");
            sw.WriteLine("\t\tChọn loại thiết bị điện (1-máy quạt , 2- máy lạnh): 2");
            sw.WriteLine("\t\t\tChọn loại máy lạnh (1- máy lạnh một chiều, 2- máy lạnh hai chiều): 1");
            sw.WriteLine("\t\t\tNhập mã: " + IDP);
            sw.WriteLine("\t\t\tTên sản phẩm: " + NameP);
            sw.WriteLine("\t\t\tNơi sản xuất: " + Where);
            sw.WriteLine("\t\t\tCông nghệ inverter(1- Có, 2- Không): " + inverter);
            sw.WriteLine("\t\tSố lượng bán ra: " + Amout);
            sw.Close();
        }
    }
}
