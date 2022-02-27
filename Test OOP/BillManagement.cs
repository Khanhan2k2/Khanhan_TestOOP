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
        private int _aob;
        private List<Bill> _lb = new List<Bill>();
        public void Init()
        {
            File.WriteAllText(Environment.CurrentDirectory + @"\danh_sach_hoa_don.txt","");
            StreamWriter sw = File.AppendText(Environment.CurrentDirectory + @"\danh_sach_hoa_don.txt");

            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            do
            {
                Console.Write("Số lượng hóa đơn muốn nhập: ");
                try
                {
                    _aob = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Vui lòng nhập số nguyên dương");
                }
            } while (_aob <= 0);
            sw.WriteLine("Số lượng hóa đơn muốn nhập: " + _aob);
            
            
            Console.WriteLine("Danh sách các chi tiết hóa đơn: ");
            ConsoleKeyInfo signalt;
            Console.Clear();
            int index = 0;
            _lb[index].OutPut();
            Console.WriteLine("");
            do
            {
                Console.Write((index + 1) + "/" + _lb.Count);
                Console.Write(" Nhấn <- -> để di chuyển qua lại; Esc để dừng");
                signalt = Console.ReadKey();
                if (signalt.Key == ConsoleKey.LeftArrow)
                {
                    Console.Clear();
                    if (index > 0)
                    {
                        index--;
                        _lb[index].OutPut();
                        Console.WriteLine("");
                    }
                    else if (index == 0)
                    {
                        _lb[index].OutPut();
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
                    if (index < _lb.Count - 1)
                    {
                        index++;
                        _lb[index].OutPut();
                        Console.WriteLine("");
                    }
                    else if (index == _lb.Count - 1)
                    {
                        _lb[index].OutPut();
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("Không thể di chuyển về sau nữa");
                        continue;
                    }
                }
            } while (signalt.Key != ConsoleKey.Escape);

            /*   for (int i = 0; i < _aob; i++)
               {
                   _lb[i].OutPut();
                   Console.WriteLine("");
               }*/
        }
        public void Input()
        {


            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            do
            {
                Console.Write("Số lượng hóa đơn muốn nhập: ");
                try
                {
                    _aob = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Vui lòng nhập số nguyên dương");
                }
            } while (_aob <= 0);

            for (int i = 0; i < _aob; i++)
            {
                Console.WriteLine("Nhập thông tin hóa đơn " + (i + 1) + ": ");
                Bill temp = new Bill();
                temp.InPut();
                _lb.Add(temp);
            }
        }
        public void OutPut()
        {
            Console.WriteLine("Danh sách các chi tiết hóa đơn: ");
            ConsoleKeyInfo signalt;
            Console.Clear();
            int index = 0;
            _lb[index].OutPut();
            Console.WriteLine("");
            do
            {
                Console.Write((index + 1) + "/" + _lb.Count);
                Console.WriteLine(" Nhấn <- -> để di chuyển qua lại để xem các hóa đơn đa nhập; Esc để dừng việc xem hóa đơn");
                signalt = Console.ReadKey(false);
                if (signalt.Key == ConsoleKey.LeftArrow)
                {
                    Console.Clear();
                    if (index > 0)
                    {
                        index--;
                        _lb[index].OutPut();
                        Console.WriteLine("");
                    }
                    else if (index == 0)
                    {
                        _lb[index].OutPut();
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
                    if (index < _lb.Count - 1)
                    {
                        index++;
                        _lb[index].OutPut();
                        Console.WriteLine("");
                    }
                    else if (index == _lb.Count - 1)
                    {
                        _lb[index].OutPut();
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
        public void OutToText()
        {
            File.WriteAllText(Environment.CurrentDirectory + @"\danh_sach_hoa_don.txt", "");
            
            for (int i = 0; i < _aob; i++)
            {
                StreamWriter sw = File.AppendText(Environment.CurrentDirectory + @"\danh_sach_hoa_don.txt");
                sw.WriteLine("Hóa đơn " + (i + 1) + ": ");
                sw.Close();
                _lb[i].OutToText();
            }
        }
    }
}
