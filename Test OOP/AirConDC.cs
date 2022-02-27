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

        public override void InPut()
        {
            do
            {
                Console.Write("\t\t\tNhập mã(3-10 kí tự gồm số hoặc chữ VD:ADC001): ");
                IDP = Console.ReadLine();
            } while (!IsID(IDP));
            do
            {
                Console.Write("\t\t\tTên sản phẩm: ");
                NameP = Console.ReadLine();
            } while ( !IsName(NameP));
            do
            {
                Console.Write("\t\t\tNơi sản xuất: ");
                Where = Console.ReadLine();
            } while (!IsName(Where));
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
                Console.WriteLine("\t\tMáy lạnh: \n\t\t\tMã sản phẩm: " + IDP + "\n\t\t\t Máy lạnh 1 chiều"+"\n\t\t\tCó công nghệ inverter"+"\n\t\t\tTên: " + NameP + "\n\t\t\tGiá: " + ACcost.ToString() + "\n\t\tSố lượng " + Amout.ToString());
            }
            else
            {
                Console.WriteLine("\t\tMáy lạnh: \n\t\t\tMã sản phẩm: " + IDP + "\n\t\t\t Máy lạnh 1 chiều" + "\n\t\t\tKhông công nghệ inverter" + "\n\t\t\tTên: " + NameP + "\n\t\t\tGiá: " + ACcost.ToString() + "\n\t\tSố lượng " + Amout.ToString());
            }
        }
        public override void OutToText()
        {
            StreamWriter sw = File.AppendText(Environment.CurrentDirectory + @"\danh_sach_hoa_don.txt");
            sw.WriteLine("\t\tMáy lạnh một chiều");
            sw.WriteLine("\t\t\tNhập mã: " + IDP);
            sw.WriteLine("\t\t\tTên sản phẩm: " + NameP);
            sw.WriteLine("\t\t\tNơi sản xuất: " + Where);
            if(inverter==1)
            {
                sw.WriteLine("\t\t\tCó công nghệ inverter" + inverter);
            }
            sw.WriteLine("\t\t\tĐơn giá: " + ACcost);
            sw.WriteLine("\t\tSố lượng bán ra: " + Amout);
            sw.Close();
        }
    }
}
