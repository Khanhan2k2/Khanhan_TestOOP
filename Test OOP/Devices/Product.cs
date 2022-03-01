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
        protected string idProduct="";
        protected string nameProduct="";
        protected string where="";
        protected double cost=0;
        protected int typeProduct=0;
        protected int amout=0;
        public int TypeProduct
            {
            get { return typeProduct; }
            set { typeProduct = value; }
        }
        public int Amout
        {
            get { return amout; }
            set { amout = value; }
        }
        public virtual  void InPut()
        {
            
            while (TypeProduct <= 0 || TypeProduct > 2)
            {
                Console.Write("\t\tChọn loại thiết bị điện (1-máy quạt , 2- máy lạnh):");
                try
                {
                    TypeProduct = Int32.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Nhập 1 hoặc 2");
                }
            }
            
        }
        public virtual void OutPut()
        {

        }
        public virtual double Price()
        {
            return 0;
        }
        public virtual void OutToText()
        {
            
        }

    }
}
