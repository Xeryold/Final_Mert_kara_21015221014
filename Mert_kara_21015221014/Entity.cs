using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mert_kara_21015221014
{
    public  class Musteri 
    {
        public string Tc { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Adres { get; set; }
        public string Tel { get; set; }
        public override string ToString()
        {
            return $"{Ad} {Soyad}";
        }
    }
    public class teknik
    {
        public Guid tid { get; set; }
        public string ad{ get; set; }
        public string soyad { get; set; }
        public string ilgi { get; set; }
        public override string ToString()
        {
            return $"{ad} {soyad}";
        }
    }
    public class y_parca 
    {
        public Guid pid { get; set; }
        public string pad { get; set; }
        public string pmarka { get; set; }
        public string pmodel { get; set; }
        public double fiyat { get; set; }
        public int stok { get; set; }
        public override string ToString()
        {
            return $"{pid}";
        }
    }
    public class urun 
    {
        public string seri { get; set; }
        public string Musteriid { get; set; }
        public string marka { get; set; }
        public string model { get; set; }
        public string sorun { get; set; }
        public string garanti { get; set; }
        public DateTime gtarih { get; set; }
        public override string ToString()
        {
            return $"{seri}";
        }
    }
    public class onarim 
    {
        public Guid oid { get; set; }
        public string tc{ get; set; }
        public string seri { get; set; }
        public Guid tid { get; set; }
        public Guid pid { get; set; }
        public string durum { get; set; }
    }
}
