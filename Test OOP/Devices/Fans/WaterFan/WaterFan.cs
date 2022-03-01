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
        private double _liter=0;


        public override void InPut()
        {
            do
            {
                Console.Write("\t\t\tNhập mã(3-10 kí tự gồm số hoặc chữ VD:WF001): ");
                idProduct = Console.ReadLine();
            } while (!IsID(idProduct));
            do
            {
                Console.Write("\t\t\tTên sản phẩm: ");
                nameProduct = Console.ReadLine();
            } while (!IsName(nameProduct));
            do
            {
                Console.Write("\t\t\tNơi sản xuất: ");
                where = Console.ReadLine();
            } while (!IsName(where));
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
            fanCost = 400 * _liter;
            return fanCost;
        }
        public override void OutPut()
        {
            Console.WriteLine("\t\tMáy quạt: \n\t\t\tMã sản phẩm: " + idProduct + "\n\t\t\t" + "Quạt hơi nước" + "\n\t\t\tTên: " + nameProduct + "\n\t\t\tGiá: " + fanCost.ToString() + "\n\t\t\tDung tích nước " + _liter.ToString() + " lít" + "\n\t\tSố lượng: " + Amout.ToString());
        }
        public override void OutToText()
        {
            StreamWriter sw = File.AppendText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\danh_sach_hoa_don.txt");
            sw.WriteLine("\t\tQuạt hơi nước");
            sw.WriteLine("\t\t\tNhập mã: " + idProduct);
            sw.WriteLine("\t\t\tTên sản phẩm: " + nameProduct);
            sw.WriteLine("\t\t\tNơi sản xuất: " + where);
            sw.WriteLine("\t\t\tDung tích nước: " + _liter);
            sw.WriteLine("\t\t\tĐơn giá: " + fanCost);
            sw.WriteLine("\t\tSố lượng bán ra: " + Amout);
            sw.Close();
        }
    }
}
