using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Test_OOP
{
    public class TwoWayConditioners : AirCon
    {
        private int _antiSmell=0;
        private int _antiMicro=0;

        public override void InPut()
        {
            do
            {
                Console.Write("\t\t\tNhập mã(3-10 kí tự gồm số hoặc chữ VD:AAC001): ");
                idProduct = Console.ReadLine();
            } while (idProduct == "" || !IsID(idProduct) || idProduct.Contains(" "));
            do
            {
                Console.Write("\t\t\tTên sản phẩm: ");
                nameProduct = Console.ReadLine();
            } while (nameProduct == "" || !IsName(nameProduct));
            do
            {
                Console.Write("\t\t\tNơi sản xuất: ");
                where = Console.ReadLine();
            } while (where == "" || !IsName(where));
            do
            {
                Console.Write("\t\t\tCông nghệ inverter(1- Có, 2- Không): ");
                try
                {
                    inverter = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("\t\t\tNhập 1 hoặc 2");
                }
            } while (inverter < 1 || inverter > 2);
            while (_antiSmell <= 0 || _antiSmell > 2)
            {
                Console.Write("\t\t\tCông nghệ khử mùi(1- Có, 2- Không):");
                try
                {
                    _antiSmell = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("\t\t\tChỉ nhập 1 hoặc 2");
                }
            }
            while (_antiMicro <= 0 || _antiMicro > 2)
            {
                Console.Write("\t\t\tCông nghệ kháng khuẩn(1- Có, 2- Không):");
                try
                {
                    _antiMicro = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("\t\t\tChỉ nhập 1 hoặc 2");
                }
            }
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

        }

        public override double Price()
        {
            if (inverter == 1)
            {
                airConditionerCost = 2500;
                if (_antiSmell == 1) airConditionerCost += 500;
                if (_antiMicro == 1) airConditionerCost += 500;
            }
            else
            {
                airConditionerCost = 2000;
                if (_antiSmell == 1) airConditionerCost += 500;
                if (_antiMicro == 1) airConditionerCost += 500;
            }
            return airConditionerCost;
        }
        public override void OutPut()
        {
            if (inverter == 1)
            {
                if (_antiSmell == 1 && _antiMicro == 1)
                {
                    Console.WriteLine("\t\tMáy lạnh: \n\t\t\tMã sản phẩm: " + idProduct + "\n\t\t\t Máy lạnh 2 chiều" + "\n\t\t\tCó công nghệ inverter, khử khuẩn, khử mùi" + "\n\t\t\tTên: " + nameProduct + "\n\t\t\tGiá: " + airConditionerCost.ToString() + "\n\t\tSố lượng " + Amout.ToString());
                }
                else if (_antiMicro == 1 && _antiSmell == 2)
                {
                    Console.WriteLine("\t\tMáy lạnh: \n\t\t\tMã sản phẩm: " + idProduct + "\n\t\t\t Máy lạnh 2 chiều" + "\n\t\t\tCó công nghệ inverter, kháng khuẩn" + "\n\t\t\tTên: " + nameProduct + "\n\t\t\tGiá: " + airConditionerCost.ToString() + "\n\t\tSố lượng " + Amout.ToString());
                }
                else if (_antiMicro == 2 && _antiSmell == 1)
                {
                    Console.WriteLine("\t\ttMáy lạnh: \n\t\t\tMã sản phẩm: " + idProduct + "\n\t\t\t Máy lạnh 2 chiều" + "\n\t\t\tCó công nghệ inverter, khử mùi" + "\n\t\t\tTên: " + nameProduct + "\n\t\t\tGiá: " + airConditionerCost.ToString() + "\n\t\tSố lượng " + Amout.ToString());
                }
                else
                {
                    Console.WriteLine("\t\ttMáy lạnh: \n\t\t\tMã sản phẩm: " + idProduct + "\n\t\t\t Máy lạnh 2 chiều" + "\n\t\t\tCó công nghệ inverter" + "\n\t\t\tTên: " + nameProduct + "\n\t\t\tGiá: " + airConditionerCost.ToString() + "\n\t\tSố lượng " + Amout.ToString());
                }
            }
            else
            {
                if (_antiSmell == 1 && _antiMicro == 1)
                {
                    Console.WriteLine("\t\tMáy lạnh: \n\t\t\tMã sản phẩm: " + idProduct + "\n\t\t\t Máy lạnh 2 chiều" + "\n\t\t\tCó kháng khuẩn, khử mùi" + "\n\t\t\tTên: " + nameProduct + "\n\t\t\tGiá: " + airConditionerCost.ToString() + "\n\t\tSố lượng " + Amout.ToString());
                }
                else if (_antiMicro == 1 && _antiSmell == 2)
                {
                    Console.WriteLine("\t\tMáy lạnh: \n\t\t\tMã sản phẩm: " + idProduct + "\n\t\t\t Máy lạnh 2 chiều" + "\n\t\t\tCó kháng khuẩn" + "\n\t\t\tTên: " + nameProduct + "\n\t\t\tGiá: " + airConditionerCost.ToString() + "\n\t\tSố lượng " + Amout.ToString());
                }
                else if (_antiMicro == 2 && _antiSmell == 1)
                {
                    Console.WriteLine("\t\tMáy lạnh: \n\t\t\tMã sản phẩm: " + idProduct + "\n\t\t\t Máy lạnh 2 chiều" + "\n\t\t\tCó khử mùi" + "\n\t\t\tTên: " + nameProduct + "\n\t\t\tGiá: " + airConditionerCost.ToString() + "\n\t\tSố lượng " + Amout.ToString());
                }
                else
                {
                    Console.WriteLine("\t\tMáy lạnh: \n\t\t\tMã sản phẩm: " + idProduct + "\n\t\t\t Máy lạnh 2 chiều" + "\n\t\t\tKhông công nghệ inverter" + "\n\t\t\tTên: " + nameProduct + "\n\t\t\tGiá: " + airConditionerCost.ToString() + "\n\t\tSố lượng " + Amout.ToString());
                }
            }
        }
        public override void OutToText()
        {
            StreamWriter sw = File.AppendText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\danh_sach_hoa_don.txt");
            sw.WriteLine("\t\tMáy lạnh 2 chiều");
            sw.WriteLine("\t\t\tNhập mã: " + idProduct);
            sw.WriteLine("\t\t\tTên sản phẩm: " + nameProduct);
            string temp = "";
            if(inverter==1)
            {
                temp += "Có công nghệ inverter";
            }    
            if(_antiMicro == 1)
            {
                temp += ", kháng khuẩn";
            }    
            if(_antiSmell == 1)
            {
                temp += ", khử mùi.";
            }    
            if(temp!="")
            {
                sw.WriteLine("\t\t\t" + temp);
            }
            sw.WriteLine("\t\t\tĐơn giá: " + airConditionerCost);
            sw.WriteLine("\t\tSố lượng bán ra: " + Amout);
            sw.Close();
        }
    }
}
