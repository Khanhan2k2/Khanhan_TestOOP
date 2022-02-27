using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Test_OOP
{
    public class WaterFan : Fan
    {
        private double _liter;

        public WaterFan() : base()
        {
            _liter = 0;
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
                Console.Write("\t\t\tDung tích nước: ");
                try
                {
                    _liter = double.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("\t\t\tNhập số nguyên dương");
                }
            } while (_liter <= 0);
            
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
            Fcost = 400 * _liter;
            return Fcost;
        }
        public override void OutPut()
        {
            Console.Write("Máy quạt: " + IDP + " " + "quạt hơi nước" + ",tên: " + NameP + ",giá: " + Fcost.ToString() + ",dung tích: " + _liter.ToString() + " lit" + ",số lượng " + Amout.ToString());
        }
        public override void OutToText()
        {
            StreamWriter sw = File.AppendText(Environment.CurrentDirectory + @"\danh_sach_hoa_don.txt");
            sw.WriteLine("\t\tChọn loại thiết bị điện (1-máy quạt , 2- máy lạnh): 1");
            sw.WriteLine("\t\t\tChọn loại máy quạt (1- máy quạt đứng, 2- máy quạt hơi nước, 3- máy quạt sạc điện): 2");
            sw.WriteLine("\t\t\tNhập mã: " + IDP);
            sw.WriteLine("\t\t\tTên sản phẩm: " + NameP);
            sw.WriteLine("\t\t\tNơi sản xuất: " + Where);
            sw.WriteLine("\t\t\tDung tích nước: " + _liter);
            sw.WriteLine("\t\tSố lượng bán ra: " + Amout);
            sw.Close();
        }
    }
}
