using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Test_OOP
{
    public class ElecFan : Fan
    {
        private double _pin;

        public ElecFan() : base()
        {
            _pin = 0;
        }
        public override void InPut()
        {
            StreamWriter sw = File.AppendText(Environment.CurrentDirectory + @"\danh_sach_hoa_don.txt");
            do
            {
                Console.Write("\t\t\tNhập mã: ");
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
                Console.Write("\t\t\tDung lượng _pin: ");
                try
                {
                    _pin = double.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("\t\t\tNhập số nguyên dương");
                }
            } while (_pin <= 0);

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
            Fcost = 500 * _pin;
            return Fcost;
        }
        public override void OutPut()
        {
            Console.WriteLine("Máy quạt: " + IDP + " " + "quạt sạc điện" + ",tên: " + NameP + ",giá: " + Fcost.ToString() + ",dung lượng _pin " + _pin.ToString() + " mA" + ",số lượng: " + Amout.ToString());
        }
        public override void OutToText()
        {
            StreamWriter sw = File.AppendText(Environment.CurrentDirectory + @"\danh_sach_hoa_don.txt");
            sw.WriteLine("\t\tChọn loại thiết bị điện (1-máy quạt , 2- máy lạnh): 1");
            sw.WriteLine("\t\t\tChọn loại máy quạt (1- máy quạt đứng, 2- máy quạt hơi nước, 3- máy quạt sạc điện): 3");
            sw.WriteLine("\t\t\tNhập mã: " + IDP);
            sw.WriteLine("\t\t\tTên sản phẩm: " + NameP);
            sw.WriteLine("\t\t\tNơi sản xuất: " + Where);
            sw.WriteLine("\t\t\tDung lượng _pin: " + _pin);
            sw.WriteLine("\t\tSố lượng bán ra: " + Amout);
            sw.Close();
        }
    }
}
