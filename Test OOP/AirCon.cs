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
        protected int TypeAC;
        protected double ACcost;
        protected int inverter;
        public int _TypeAC
        {
            get { return TypeAC; }
            set { TypeAC = value; }
        }
        public AirCon():base()
        {
            TypeAC = 0;
            ACcost = 0;
            inverter = 0;
        }
        public override void InPut()
        {
            StreamWriter sw = File.AppendText(@"D:\hk4\thực tập ASP\Test OOP\ListOfBill.txt");
            while (0 >= TypeAC || TypeAC > 2)
            {
                Console.Write("\t\t\tChọn loại máy lạnh (1- máy lạnh một chiều, 2- máy lạnh hai chiều):");
                try
                {
                    TypeAC = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("\t\t\t nhập 1 hoặc 2");
                }
            }
            sw.WriteLine("\t\t\tChọn loại máy lạnh (1- máy lạnh một chiều, 2- máy lạnh hai chiều):" + TypeAC);
            sw.Close();
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

    public class AirConDC:AirCon
    {
        public AirConDC():base()
        {
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
            } while (Where == "" || !IsName(Where));
            sw.WriteLine("\t\t\tNơi sản xuất: " + Where);
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
            sw.WriteLine("\t\t\tCông nghệ inverter(1- Có, 2- Không): " + inverter);
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
            sw.WriteLine("\t\tSố lượng bán ra: " + Amout);
            sw.Close();
        }

        public override double Price()
        {
            if(inverter==1)
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
            if(inverter==1)
            {
                Console.WriteLine("Máy lạnh: " + IDP + " 1 chiều có công nghệ inverter, tên: " + NameP + ", giá: " + ACcost.ToString() + ", số lượng " + Amout.ToString());
            }    
            else
            {
                Console.WriteLine("Máy lạnh: " + IDP + " 1 chiều không công nghệ inverter, tên: " + NameP + ", giá: " + ACcost.ToString() + ", số lượng " + Amout.ToString());
            }    
        }
    }
    public class AirConAC : AirCon
    {
        private int Antismell;
        private int Antimicro;
        public AirConAC() : base()
        {
            Antimicro = 0;
            Antismell = 0;
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
            sw.WriteLine("\t\t\tCông nghệ inverter(1- Có, 2- Không): " + inverter);
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
                sw.WriteLine("\t\t\tCông nghệ khử mùi(1- Có, 2- Không):" + Antismell);
            }
            while (Antimicro <= 0 || Antimicro > 2)
            {
                Console.Write("\t\t\tCông nghệ khử mùi(1- Có, 2- Không):");
                try
                {
                    Antimicro = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("\t\t\tChỉ nhập 1 hoặc 2");
                }
                sw.WriteLine("\t\t\tCông nghệ khử mùi(1- Có, 2- Không):" + Antimicro);
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
            sw.WriteLine("\t\tSố lượng bán ra: " + Amout);
            sw.Close();
        }

        public override double Price()
        {
            if (inverter==1)
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
            if (inverter==1)
            {
                if(Antismell==1 && Antimicro==1)
                {
                    Console.WriteLine("Máy lạnh: " + IDP + " 2 chiều có công nghệ inverter, kháng khuẩn và khử mùi, tên: " + NameP + ", giá: " + ACcost.ToString() + ", số lượng " + Amout.ToString());
                } 
                else if(Antimicro==1 && Antismell==2)
                {
                    Console.WriteLine("Máy lạnh: " + IDP + " 2 chiều có công nghệ inverter, kháng khuẩn, tên: " + NameP + ", giá: " + ACcost.ToString() + ", số lượng " + Amout.ToString());
                }
                else if (Antimicro == 2 && Antismell == 1)
                {
                    Console.WriteLine("Máy lạnh: " + IDP + " 2 chiều có công nghệ inverter, khử mùi, tên: " + NameP + ", giá: " + ACcost.ToString() + ", số lượng " + Amout.ToString());
                }
                else
                {
                    Console.WriteLine("Máy lạnh: " + IDP + " 2 chiều có công nghệ inverter, tên: " + NameP + ", giá: " + ACcost.ToString() + ", số lượng " + Amout.ToString());
                }    
            }
            else
            {
                if (Antismell == 1 && Antimicro == 1)
                {
                    Console.WriteLine("Máy lạnh: " + IDP + " 2 chiều không công nghệ inverter, có kháng khuẩn và khử mùi, tên: " + NameP + ", giá: " + ACcost.ToString() + ", số lượng " + Amout.ToString());
                }
                else if (Antimicro == 1 && Antismell == 2)
                {
                    Console.WriteLine("Máy lạnh: " + IDP + " 2 chiều không công nghệ inverter, có kháng khuẩn, tên: " + NameP + ", giá: " + ACcost.ToString() + ", số lượng " + Amout.ToString());
                }
                else if (Antimicro == 2 && Antismell == 1)
                {
                    Console.WriteLine("Máy lạnh: " + IDP + " 2 chiều không công nghệ inverter, có khử mùi, tên: " + NameP + ", giá: " + ACcost.ToString() + ", số lượng " + Amout.ToString());
                }
                else
                {
                    Console.WriteLine("Máy lạnh: " + IDP + " 2 chiều không công nghệ inverter, tên: " + NameP + ", giá: " + ACcost.ToString() + ", số lượng " + Amout.ToString());
                }
            }
        }
    }
}
