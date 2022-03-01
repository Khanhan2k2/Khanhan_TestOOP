using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Test_OOP
{
    public class OneWayAirConditioners : AirCon
    {

        public override void InPut()
        {
            do
            {
                Console.Write("\t\t\tNhập mã(3-10 kí tự gồm số hoặc chữ VD:ADC001): ");
                idProduct = Console.ReadLine();
            } while (!IsID(idProduct));
            do
            {
                Console.Write("\t\t\tTên sản phẩm: ");
                nameProduct = Console.ReadLine();
            } while ( !IsName(nameProduct));
            do
            {
                Console.Write("\t\t\tNơi sản xuất: ");
                where = Console.ReadLine();
            } while (!IsName(where));
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
                airConditionerCost = 1000;
            }
            else
            {
                airConditionerCost = 1500;
            }
            return airConditionerCost;
        }
        public override void OutPut()
        {
            if (inverter == 1)
            {
                Console.WriteLine("\t\tMáy lạnh: \n\t\t\tMã sản phẩm: " + idProduct + "\n\t\t\t Máy lạnh 1 chiều"+"\n\t\t\tCó công nghệ inverter"+"\n\t\t\tTên: " + nameProduct + "\n\t\t\tGiá: " + airConditionerCost.ToString() + "\n\t\tSố lượng " + Amout.ToString());
            }
            else
            {
                Console.WriteLine("\t\tMáy lạnh: \n\t\t\tMã sản phẩm: " + idProduct + "\n\t\t\t Máy lạnh 1 chiều" + "\n\t\t\tKhông công nghệ inverter" + "\n\t\t\tTên: " + nameProduct + "\n\t\t\tGiá: " + airConditionerCost.ToString() + "\n\t\tSố lượng " + Amout.ToString());
            }
        }
        public override void OutToText()
        {
            StreamWriter sw = File.AppendText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\danh_sach_hoa_don.txt");
            sw.WriteLine("\t\tMáy lạnh một chiều");
            sw.WriteLine("\t\t\tNhập mã: " + idProduct);
            sw.WriteLine("\t\t\tTên sản phẩm: " + nameProduct);
            sw.WriteLine("\t\t\tNơi sản xuất: " + where);
            if(inverter==1)
            {
                sw.WriteLine("\t\t\tCó công nghệ inverter" + inverter);
            }
            sw.WriteLine("\t\t\tĐơn giá: " + airConditionerCost);
            sw.WriteLine("\t\tSố lượng bán ra: " + Amout);
            sw.Close();
        }
    }
}
