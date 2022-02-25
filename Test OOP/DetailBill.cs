using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Test_OOP
{
    public class DetailBill
    {
        private Product MainProduct;
        private int Amout;
        private double DBcost;
        public double _DBcost
        {
            get { return DBcost; }
            set { DBcost = value; }
        }
        public DetailBill()
        {
            MainProduct = new Product();
            Amout = 0;
            DBcost = 0;
        }
        public void InPut()
        {
            
            MainProduct.InPut();
            if(MainProduct._TypeP==1)
            {
                int test = 0;
                while(test<=0||test>3)
                {
                    Console.Write("\t\tChọn loại máy quạt (1- máy quạt đứng, 2- máy quạt hơi nước, 3- máy quạt sạc điện):");
                    try
                    {
                        test = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("\t\tNhập 1,2 hoặc 3");
                    }
                }    
                if(test==1)
                {
                    StandFan t = new StandFan();
                    t.InPut();
                    MainProduct = t;
                    Amout = t._Amout;
                }
                else if(test==2)
                {
                    WaterFan t = new WaterFan();
                    t.InPut();
                    MainProduct = t;
                    Amout = t._Amout;
                }  
                else
                {
                    ElecFan t = new ElecFan();
                    t.InPut();
                    MainProduct = t;
                    Amout = t._Amout;
                }
                StreamWriter sw = File.AppendText(@"D:\hk4\thực tập ASP\Test OOP\ListOfBill.txt");
                sw.WriteLine("\t\tChọn loại máy quạt (1- máy quạt đứng, 2- máy quạt hơi nước, 3- máy quạt sạc điện):" + test);
                sw.Close();
            }
            else
            {
                AirCon temp = new AirCon();
                temp.InPut();
                if(temp._TypeAC==1)
                {
                    AirConDC t = new AirConDC();
                    t.InPut();
                    MainProduct = t;
                    Amout = t._Amout;
                }    
                else
                {
                    AirConAC t = new AirConAC();
                    t.InPut();
                    MainProduct = t;
                    Amout = t._Amout;
                }    

            }    
        }
        public void Output()
        {
            MainProduct.OutPut();
            Console.WriteLine();
        }   
        public double Price()
        {
            DBcost = MainProduct.Price();
            DBcost *= Amout;
            return DBcost;
        }
    }
}
