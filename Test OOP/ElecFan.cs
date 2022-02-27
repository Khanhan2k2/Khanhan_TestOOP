﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Test_OOP
{
    public class ElecFan : Fan
    {
        private double _pin=0;


        public override void InPut()
        {
            StreamWriter sw = File.AppendText(Environment.CurrentDirectory + @"\danh_sach_hoa_don.txt");
            do
            {
                Console.Write("\t\t\tNhập mã(3-10 kí tự gồm số hoặc chữ VD:EF001): ");
                IDP = Console.ReadLine();
            } while (!IsID(IDP));
            do
            {
                Console.Write("\t\t\tTên sản phẩm: ");
                NameP = Console.ReadLine();
            } while (!IsName(NameP));
            do
            {
                Console.Write("\t\t\tNơi sản xuất: ");
                Where = Console.ReadLine();
            } while (!IsName(Where));
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
            Console.WriteLine("\t\tMáy quạt: \n\t\t\tMã sản phẩm: " + IDP + "\n\t\t\t" + "Quạt sạc điện" + "\n\t\t\tTên: " + NameP + "\n\t\t\tGiá: " + Fcost.ToString() + "\n\t\t\tDung lượng _pin " + _pin.ToString() + " mA" + "\n\t\tSố lượng: " + Amout.ToString());
        }
        public override void OutToText()
        {
            StreamWriter sw = File.AppendText(Environment.CurrentDirectory + @"\danh_sach_hoa_don.txt");
            sw.WriteLine("\t\tQuạt sạc điện");
            sw.WriteLine("\t\t\tNhập mã: " + IDP);
            sw.WriteLine("\t\t\tTên sản phẩm: " + NameP);
            sw.WriteLine("\t\t\tNơi sản xuất: " + Where);
            sw.WriteLine("\t\t\tDung lượng _pin: " + _pin);
            sw.WriteLine("\t\t\tĐơn giá: " + Fcost);
            sw.WriteLine("\t\tSố lượng bán ra: " + Amout);
            sw.Close();
        }
    }
}