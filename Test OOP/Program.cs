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
            Console.WriteLine("Chương trình quản lí hóa đơn của cửa hàng điện máy");
            do
            {
                Console.WriteLine("Nhập \n1. Để nhập Hóa đơn \n2. Để xem hóa đơn \n3. Lưu hóa đơn vào file .txt \n0. Để dừng chương trình");
                try
                {
                    opt = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Chỉ nhập 1,2,3 hoặc 0");
                }
                switch (opt)
                {
                    case 1:
                        Option[0] = true;
                        B.InPut();
                        Console.Clear();
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
                            int temp = 0;
                            Console.WriteLine("Chưa nhập bất kì hóa đơn nào");
                            do
                            {
                                Console.WriteLine("Nhập 1 để nhập hóa đơn, 2 để dừng việc xuất file hóa đơn: ");
                                try
                                {
                                    temp = int.Parse(Console.ReadLine());
                                }
                                catch
                                {
                                    Console.WriteLine("Chỉ nhập 1 hoặc 2");
                                }
                            } while (temp <= 0 || temp > 2);
                            if(temp==1)
                            {
                                B.InPut();
                                Option[0] = true;
                                Console.Clear();
                                B.OutPut();
                            }    
                            else
                            {
                                break;
                            }    
                            break;
                        }
                    case 3:
                        if (!Option[0])
                        {
                            int temp = 0;
                            Console.WriteLine("Chưa nhập bất kì hóa đơn nào");
                            do
                            {
                                Console.WriteLine("Nhập 1 để nhập hóa đơn, 2 để dừng việc xem hóa đơn: ");
                                try
                                {
                                    temp = int.Parse(Console.ReadLine());
                                }
                                catch
                                {
                                    Console.WriteLine("Chỉ nhập 1 hoặc 2");
                                }
                            } while (temp <= 0 || temp > 2);
                            if(temp==1)
                            {
                                B.InPut();
                                B.OutToText();
                                Console.Clear();
                                Console.WriteLine("Đã lưu thành công, vui lòng kiểm tra file danh_sach_hoa_don.txt tại DeskTop");
                                Option[2] = true;
                                Option[0] = true;

                            }    
                            else
                            {
                                break;
                            }    
                            break;
                        }
                        else
                        {
                            B.OutToText();
                            Console.WriteLine("Đã lưu thành công, vui lòng kiểm tra file danh_sach_hoa_don.txt tại Desktop");
                            Option[2] = true;
                            break;
                        }
                    case 0:
                        continue;
                        //break;
                    default:
                        break;

                }
                Console.WriteLine(" Nhập phím bất kì để quay lại menu");
                Console.ReadLine();
                Console.Clear();
                opt = -1;
            } while (opt != 0);
            //Console.ReadLine();
        }
        
    }
}
