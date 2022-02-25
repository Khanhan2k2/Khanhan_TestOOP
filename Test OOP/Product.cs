using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Test_OOP
{
    public class Product
    {
        protected string IDP;
        protected string NameP;
        protected string Where;
        protected double Cost;
        protected int TypeP;
        protected int Amout;
        public int _TypeP
            {
            get { return TypeP; }
            set { TypeP = value; }
        }
        public int _Amout
        {
            get { return Amout; }
            set { Amout = value; }
        }
        public Product()
        {
            IDP = "";
            NameP = "";
            Where = "";
            Cost = 0;
            TypeP = 0;
            Amout = 0;
        }
        public virtual  void InPut()
        {
            StreamWriter sw = File.AppendText(@"D:\hk4\thực tập ASP\Test OOP\ListOfBill.txt");
            while (TypeP<=0 || TypeP>2)
            {
                Console.Write("\t\tChọn loại thiết bị điện (1-máy quạt , 2- máy lạnh):");
                try
                {
                    TypeP = Int32.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Nhập 1 hoặc 2");
                }
            }
            sw.WriteLine("\t\tChọn loại thiết bị điện (1-máy quạt , 2- máy lạnh):" + TypeP);
            sw.Close();
        }
        public virtual void OutPut()
        {

        }
        public virtual double Price()
        {
            return 0;
        }
       

    }
}
