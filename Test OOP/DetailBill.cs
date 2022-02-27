using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Test_OOP
{
    public class Detai_lbill
    {
        private Product _mainProduct=new Product();
        private int _amout=0;
        private double _dbCost=0;
        private static int _test = 0;
        public double _DBcost
        {
            get { return _dbCost; }
            set { _dbCost = value; }
        }
        public void InPut()
        {
            
            _mainProduct.InPut();
            if(_mainProduct._TypeP==1)
            {
                while(_test <= 0|| _test > 3)
                {
                    Console.Write("\t\tChọn loại máy quạt (1- máy quạt đứng, 2- máy quạt hơi nước, 3- máy quạt sạc điện):");
                    try
                    {
                        _test = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("\t\tNhập 1,2 hoặc 3");
                    }
                }    
                if(_test== 1)
                {
                    StandFan t = new StandFan();
                    t.InPut();
                    _mainProduct = t;
                    _amout = t._Amout;
                }
                else if(_test == 2)
                {
                    WaterFan t = new WaterFan();
                    t.InPut();
                    _mainProduct = t;
                    _amout = t._Amout;
                }  
                else
                {
                    ElecFan t = new ElecFan();
                    t.InPut();
                    _mainProduct = t;
                    _amout = t._Amout;
                }
                
            }
            else
            {
                AirCon temp = new AirCon();
                temp.InPut();
                if(temp._TypeAC==1)
                {
                    AirConDC t = new AirConDC();
                    t.InPut();
                    _mainProduct = t;
                    _amout = t._Amout;
                }    
                else
                {
                    AirConAC t = new AirConAC();
                    t.InPut();
                    _mainProduct = t;
                    _amout = t._Amout;
                }    

            }    
        }
        public void Output()
        {
            _mainProduct.OutPut();
            Console.WriteLine();
        }   
        public double Price()
        {
            _DBcost = _mainProduct.Price();
            _DBcost *= _amout;
            return _DBcost;
        }
        public void OutToText()
        {
            StreamWriter sw = File.AppendText(Environment.CurrentDirectory + @"\danh_sach_hoa_don.txt");
            sw.Close();
            _mainProduct.OutToText();

        }
    }
}
