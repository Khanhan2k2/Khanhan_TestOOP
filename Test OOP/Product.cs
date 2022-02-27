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
        protected string IDP="";
        protected string NameP="";
        protected string Where="";
        protected double Cost=0;
        protected int TypeP=0;
        protected int Amout=0;
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
        public virtual  void InPut()
        {
            
            while (_TypeP<=0 || _TypeP>2)
            {
                Console.Write("\t\tChọn loại thiết bị điện (1-máy quạt , 2- máy lạnh):");
                try
                {
                    _TypeP = Int32.Parse(Console.ReadLine());
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
