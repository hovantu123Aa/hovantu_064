using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT01
{
    class NhanVien
    {
        private string Hoten;
        private int Songaycong;
        private int Songaylamthem;
        private string Xeploai;
        private string Bophan;
        public NhanVien() { }
        public NhanVien(string Hoten, int Songaycong,int Songaylamthem,string Xeploai,string BoPhan)
        {
            this.Hoten = Hoten;
            this.Songaycong = Songaycong;
            this.Songaylamthem = Songaylamthem;
            this.Xeploai = Xeploai;
            this.Bophan = Bophan;
        }
        public string hoten
        {
            set { this.hoten = value; }
            get { return hoten; }
        }
        public int songaycong
        {
            set { this.songaycong = value; }
            get { return songaycong; }
        }
        public int songaylamthem
        {
            set { this.songaylamthem = value; }
            get { return songaylamthem; }
        }
        public string xeploai
        {
            get { return xeploai; }
            set if (xeploai == "A")
                else ()
            { this.xeploai = value; }

            }
        public string bophan
        {
            get { return bophan; }
            set
                if (bophan == "truc tiep") ;
            else (songaycong == 0.30)
                    if (bophan == "gian tiep") ;
            else (songaycong == 0.20)
            {
                this.bophan = value;
            }

            }
        public int Congthucluong()
        {
            return (songaycong + songaylamthem * 0.30 %) * 100000;

        }
        public void Inthongtin()
        {
            Console.WriteLine("nhap ho ten:");
            Console.WriteLine("nhap bo phan:");
            Console.WriteLine("thu nhap:{0}", Congthucluong());
        }

    }
    class Program
    {
        
        static void Main(string[] args)
        {
            NhanVien NV = new NhanVien();
            Console.WriteLine("nhap ho ten:");
            NV.hoten = Console.ReadLine();
            Console.WriteLine("nhap bo phan:");
            NV.bophan = Console.ReadLine();
            Console.Write("hoten{0} ,bo phan{1}, luong{2}", NV.hoten, NV.bophan, NV.Congthucluong());
            NhanVien nv = new NhanVien();
            nv.Inthongtin();

        }
    }
}
