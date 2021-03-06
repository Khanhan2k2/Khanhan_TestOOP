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
        private Product _mainProduct=new Product();
        private int _amout=0;
        private double _detailBillCost=0;
        private  int _test = 0;
        public double DetailBillCost
        {
            get { return _detailBillCost; }
            set { _detailBillCost = value; }
        }
        public void InPut()
        {
            
            _mainProduct.InPut();
            if(_mainProduct.TypeProduct==1)
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
                    _amout = t.Amout;
                }
                else if(_test == 2)
                {
                    WaterFan t = new WaterFan();
                    t.InPut();
                    _mainProduct = t;
                    _amout = t.Amout;
                }  
                else
                {
                    ElecFan t = new ElecFan();
                    t.InPut();
                    _mainProduct = t;
                    _amout = t.Amout;
                }
                
            }
            else
            {
                AirCon temp = new AirCon();
                temp.InPut();
                if(temp.TypeAirConditioner==1)
                {
                    OneWayAirConditioners t = new OneWayAirConditioners();
                    t.InPut();
                    _mainProduct = t;
                    _amout = t.Amout;
                }    
                else
                {
                    TwoWayConditioners t = new TwoWayConditioners();
                    t.InPut();
                    _mainProduct = t;
                    _amout = t.Amout;
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
            DetailBillCost = _mainProduct.Price();
            DetailBillCost *= _amout;
            return DetailBillCost;
        }
        public void OutToText()
        {
            StreamWriter sw = File.AppendText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\danh_sach_hoa_don.txt");
            sw.Close();
            _mainProduct.OutToText();

        }
    }
}
