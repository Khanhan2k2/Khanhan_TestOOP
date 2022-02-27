using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Test_OOP
{
    public class AirConAC : AirCon
    {
        private int Antismell=0;
        private int Antimicro=0;

        public override void InPut()
        {
            do
            {
                Console.Write("\t\t\tNhập mã(3-10 kí tự gồm số hoặc chữ VD:AAC001): ");
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
                    Console.WriteLine("\t\t\tNhập 1 hoặc 2");
                }
            } while (inverter < 1 || inverter > 2);
            while (Antismell <= 0 || Antismell > 2)
            {
                Console.Write("\t\t\tCông nghệ khử mùi(1- Có, 2- Không):");
                try
                {
                    Antismell = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("\t\t\tChỉ nhập 1 hoặc 2");
                }
            }
            while (Antimicro <= 0 || Antimicro > 2)
            {
                Console.Write("\t\t\tCông nghệ kháng khuẩn(1- Có, 2- Không):");
                try
                {
                    Antimicro = int.Parse(Console.ReadLine());
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
                ACcost = 2500;
                if (Antismell == 1) ACcost += 500;
                if (Antimicro == 1) ACcost += 500;
            }
            else
            {
                ACcost = 2000;
                if (Antismell == 1) ACcost += 500;
                if (Antimicro == 1) ACcost += 500;
            }
            return ACcost;
        }
        public override void OutPut()
        {
            if (inverter == 1)
            {
                if (Antismell == 1 && Antimicro == 1)
                {
                    Console.WriteLine("\t\tMáy lạnh: \n\t\t\tMã sản phẩm: " + IDP + "\n\t\t\t Máy lạnh 2 chiều" + "\n\t\t\tCó công nghệ inverter, khử khuẩn, khử mùi" + "\n\t\t\tTên: " + NameP + "\n\t\t\tGiá: " + ACcost.ToString() + "\n\t\tSố lượng " + Amout.ToString());
                }
                else if (Antimicro == 1 && Antismell == 2)
                {
                    Console.WriteLine("\t\tMáy lạnh: \n\t\t\tMã sản phẩm: " + IDP + "\n\t\t\t Máy lạnh 2 chiều" + "\n\t\t\tCó công nghệ inverter, kháng khuẩn" + "\n\t\t\tTên: " + NameP + "\n\t\t\tGiá: " + ACcost.ToString() + "\n\t\tSố lượng " + Amout.ToString());
                }
                else if (Antimicro == 2 && Antismell == 1)
                {
                    Console.WriteLine("\t\ttMáy lạnh: \n\t\t\tMã sản phẩm: " + IDP + "\n\t\t\t Máy lạnh 2 chiều" + "\n\t\t\tCó công nghệ inverter, khử mùi" + "\n\t\t\tTên: " + NameP + "\n\t\t\tGiá: " + ACcost.ToString() + "\n\t\tSố lượng " + Amout.ToString());
                }
                else
                {
                    Console.WriteLine("\t\ttMáy lạnh: \n\t\t\tMã sản phẩm: " + IDP + "\n\t\t\t Máy lạnh 2 chiều" + "\n\t\t\tCó công nghệ inverter" + "\n\t\t\tTên: " + NameP + "\n\t\t\tGiá: " + ACcost.ToString() + "\n\t\tSố lượng " + Amout.ToString());
                }
            }
            else
            {
                if (Antismell == 1 && Antimicro == 1)
                {
                    Console.WriteLine("\t\tMáy lạnh: \n\t\t\tMã sản phẩm: " + IDP + "\n\t\t\t Máy lạnh 2 chiều" + "\n\t\t\tCó kháng khuẩn, khử mùi" + "\n\t\t\tTên: " + NameP + "\n\t\t\tGiá: " + ACcost.ToString() + "\n\t\tSố lượng " + Amout.ToString());
                }
                else if (Antimicro == 1 && Antismell == 2)
                {
                    Console.WriteLine("\t\tMáy lạnh: \n\t\t\tMã sản phẩm: " + IDP + "\n\t\t\t Máy lạnh 2 chiều" + "\n\t\t\tCó kháng khuẩn" + "\n\t\t\tTên: " + NameP + "\n\t\t\tGiá: " + ACcost.ToString() + "\n\t\tSố lượng " + Amout.ToString());
                }
                else if (Antimicro == 2 && Antismell == 1)
                {
                    Console.WriteLine("\t\tMáy lạnh: \n\t\t\tMã sản phẩm: " + IDP + "\n\t\t\t Máy lạnh 2 chiều" + "\n\t\t\tCó khử mùi" + "\n\t\t\tTên: " + NameP + "\n\t\t\tGiá: " + ACcost.ToString() + "\n\t\tSố lượng " + Amout.ToString());
                }
                else
                {
                    Console.WriteLine("\t\tMáy lạnh: \n\t\t\tMã sản phẩm: " + IDP + "\n\t\t\t Máy lạnh 2 chiều" + "\n\t\t\tKhông công nghệ inverter" + "\n\t\t\tTên: " + NameP + "\n\t\t\tGiá: " + ACcost.ToString() + "\n\t\tSố lượng " + Amout.ToString());
                }
            }
        }
        public override void OutToText()
        {
            StreamWriter sw = File.AppendText(Environment.CurrentDirectory + @"\danh_sach_hoa_don.txt");
            sw.WriteLine("\t\tMáy lạnh 2 chiều");
            sw.WriteLine("\t\t\tNhập mã: " + IDP);
            sw.WriteLine("\t\t\tTên sản phẩm: " + NameP);
            string temp = "";
            if(inverter==1)
            {
                temp += "Có công nghệ inverter";
            }    
            if(Antimicro==1)
            {
                temp += ", kháng khuẩn";
            }    
            if(Antismell==1)
            {
                temp += ", khử mùi.";
            }    
            if(temp!="")
            {
                sw.WriteLine("\t\t\t" + temp);
            }
            sw.WriteLine("\t\t\tĐơn giá: " + ACcost);
            sw.WriteLine("\t\tSố lượng bán ra: " + Amout);
            sw.Close();
        }
    }
}
