using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Test_OOP
{
   
    class BillManagement
    {
        private int AOB;
        private List<Bill> LB = new List<Bill>();
        public void Init()
        {
            File.WriteAllText(@"D:\hk4\thực tập ASP\Test OOP\ListOfBill.txt", "");
            StreamWriter sw = File.AppendText(@"D:\hk4\thực tập ASP\Test OOP\ListOfBill.txt");

            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            do
            {
                Console.Write("Số lượng hóa đơn muốn nhập: ");
                try
                {
                    AOB = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Vui lòng nhập số nguyên dương");
                }
            } while (AOB <= 0);
            sw.WriteLine("Số lượng hóa đơn muốn nhập: " + AOB);
            
            sw.Close();
            for (int i = 0; i < AOB; i++)
            {
                Console.WriteLine("Nhập thông tin hóa đơn " + (i + 1) + ": ");
                sw = File.AppendText(@"D:\hk4\thực tập ASP\Test OOP\ListOfBill.txt");
                sw.WriteLine("Nhập thông tin hóa đơn " + (i + 1) + ": ");

                Bill temp = new Bill();
                sw.Close();
                temp.InPut();
                LB.Add(temp);
            }
            Console.WriteLine("Danh sách các chi tiết hóa đơn: ");
            ConsoleKeyInfo signalt;
            Console.Clear();
            int index = 0;
            LB[index].OutPut();
            Console.WriteLine("");
            do
            {
                Console.Write((index + 1) + "/" + LB.Count);
                Console.Write(" Nhấn <- -> để di chuyển qua lại; Esc để dừng");
                signalt = Console.ReadKey();
                if (signalt.Key == ConsoleKey.LeftArrow)
                {
                    Console.Clear();
                    if (index > 0)
                    {
                        index--;
                        LB[index].OutPut();
                        Console.WriteLine("");
                    }
                    else if (index == 0)
                    {
                        LB[index].OutPut();
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("Không thể di chuyển về trước nữa");
                        continue;
                    }

                }
                else if (signalt.Key == ConsoleKey.RightArrow)
                {
                    Console.Clear();
                    if (index < LB.Count - 1)
                    {
                        index++;
                        LB[index].OutPut();
                        Console.WriteLine("");
                    }
                    else if (index == LB.Count - 1)
                    {
                        LB[index].OutPut();
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("Không thể di chuyển về sau nữa");
                        continue;
                    }
                }
            } while (signalt.Key != ConsoleKey.Escape);

            /*   for (int i = 0; i < AOB; i++)
               {
                   LB[i].OutPut();
                   Console.WriteLine("");
               }*/
        }
        public void Input()
        {
            File.WriteAllText(@"D:\hk4\thực tập ASP\Test OOP\ListOfBill.txt", "");
            StreamWriter sw = File.AppendText(@"D:\hk4\thực tập ASP\Test OOP\ListOfBill.txt");

            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            do
            {
                Console.Write("Số lượng hóa đơn muốn nhập: ");
                try
                {
                    AOB = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Vui lòng nhập số nguyên dương");
                }
            } while (AOB <= 0);
            sw.WriteLine("Số lượng hóa đơn muốn nhập: " + AOB);
            sw.Close();
            for (int i = 0; i < AOB; i++)
            {
                Console.WriteLine("Nhập thông tin hóa đơn " + (i + 1) + ": ");
                sw = File.AppendText(@"D:\hk4\thực tập ASP\Test OOP\ListOfBill.txt");
                sw.WriteLine("Nhập thông tin hóa đơn " + (i + 1) + ": ");

                Bill temp = new Bill();
                sw.Close();
                temp.InPut();
                LB.Add(temp);
            }
        }
        public void OutPut()
        {
            Console.WriteLine("Danh sách các chi tiết hóa đơn: ");
            ConsoleKeyInfo signalt;
            Console.Clear();
            int index = 0;
            LB[index].OutPut();
            Console.WriteLine("");
            do
            {
                Console.Write((index + 1) + "/" + LB.Count);
                Console.WriteLine(" Nhấn <- -> để di chuyển qua lại; Esc để dừng");
                signalt = Console.ReadKey();
                if (signalt.Key == ConsoleKey.LeftArrow)
                {
                    Console.Clear();
                    if (index > 0)
                    {
                        index--;
                        LB[index].OutPut();
                        Console.WriteLine("");
                    }
                    else if (index == 0)
                    {
                        LB[index].OutPut();
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("Không thể di chuyển về trước nữa");
                        continue;
                    }

                }
                else if (signalt.Key == ConsoleKey.RightArrow)
                {
                    Console.Clear();
                    if (index < LB.Count - 1)
                    {
                        index++;
                        LB[index].OutPut();
                        Console.WriteLine("");
                    }
                    else if (index == LB.Count - 1)
                    {
                        LB[index].OutPut();
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("Không thể di chuyển về sau nữa");
                        continue;
                    }
                }
            } while (signalt.Key != ConsoleKey.Escape);
        }
    }
}
