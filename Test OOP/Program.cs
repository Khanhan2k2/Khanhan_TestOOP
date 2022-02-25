using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Test_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            BillManagement B = new BillManagement();
            bool[] Option = new bool[3];
            int opt = 0;
            do
            {
                Console.WriteLine("Nhập \n1. Để nhập Hóa đơn \n2. Để xem hóa đơn \n3.Lưu hóa đơn vào file .txt \n0. Để dừng chương trình");
                opt = int.Parse(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        Option[0] = true;
                        B.Input();
                        break;
                    case 2:
                        if (Option[0])
                        {
                            Option[1] = true;
                            Console.Clear();
                            B.OutPut();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Vui lòng nhập hóa đơn để xem");
                            B.Input();
                            Option[0] = true;
                            Console.Clear();
                            B.OutPut();
                            break;
                        }
                    case 3:
                        if (Option[0]||Option[1])
                        {
                            Console.WriteLine("Đã lưu thành công, vui lòng kiểm tra file ListOfBill.txt");
                            Option[2] = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Vui lòng nhập hóa đơn để lưu");
                            B.Input();
                            Console.WriteLine("Đã lưu thành công, vui lòng kiểm tra file ListOfBill.txt");
                            Option[2] = true;
                            Option[0] = true;
                            break;
                        }
                    case 0:
                        continue;
                        //break;
                    default:
                        break;

                }
                Console.WriteLine("Nhập phím bất kì để quay lại menu");
                Console.ReadLine();
            } while (opt != 0);
            //Console.ReadLine();
        }
        
    }
}
