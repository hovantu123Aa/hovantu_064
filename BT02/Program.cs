using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT02
{
    class Chunhat
    {
        private double Dai;
        private double Rong;
        public Chunhat() { }
        public Chunhat(double dai,double rong)
        {
            this.Dai = dai;
            this.Rong = rong;
        }
        public double dai
        {
            set { this.dai = value; }
            get { return dai; }
        }
        public double rong
        {
            set { this.rong = value; }
            get { return rong; }
        }
        public   double tinhdientich()
        {
            return dai * rong;
        }
        public double tinhchuvi()
        {
            return (dai + rong) * 2;
        }
        public void xuat()
        {
            Console.WriteLine("dai:");
            Console.WriteLine("rong:");
            Console.WriteLine("dien tich{0}  chu vi{1}", tinhdientich(), tinhchuvi());
            
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Chunhat CN = new Chunhat();
            CN.xuat();


        }
    }
}
