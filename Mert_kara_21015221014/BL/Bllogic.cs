using Mert_kara_21015221014.DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mert_kara_21015221014.BL
{
    public static class Bllogic
    {
        public static bool musteriekle(Musteri m)
        {
            try
            {
                int res = DataLayer.musteriekle(m);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu"+ex.Message);
                return false;
            }
        }
        internal static DataSet musterigetir(string filtre) 
        {
            try
            {
              DataSet ds= DataLayer.musterigetir(filtre);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu" + ex.Message);
                return null;
            }
        }
        internal static bool musteriguncelle(Musteri m)
        {
            try
            {
                int res = DataLayer.musteriguncelle(m);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu" + ex.Message);
                return false;
            }

        }
        internal static bool musterisil(string Tc) 
        {
            try
            {
                int res = DataLayer.musterisil(Tc);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu" + ex.Message);
                return false;
            }
        }
        //-----------------------------------------------------------
        public static bool teknik_ekle(teknik t)
        {
            try
            {
                int res = DataLayer.teknik_ekle(t);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu" + ex.Message);
                return false;
            }
        }
        internal static DataSet teknik_getir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.teknik_getir(filtre);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu" + ex.Message);
                return null;
            }
        }

        internal static bool teknik_guncelle(teknik t)
        {
            try
            {
                int res = DataLayer.teknik_guncelle(t);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu" + ex.Message);
                return false;
            }
        }

        internal static bool teknik_sil(Guid tid)
        {
            try
            {
                int res = DataLayer.teknik_sil(tid);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu" + ex.Message);
                return false;
            }
        }
        //----------------------------------------------------------

        internal static bool parca_ekle(y_parca p)
        {
            try
            {
                int res = DataLayer.parca_ekle(p);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu" + ex.Message);
                return false;
            }
        }

        internal static DataSet parca_getir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.parca_getir(filtre);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu" + ex.Message);
                return null;
            }
        }

        internal static bool parca_guncelle(y_parca p)
        {
            try
            {
                int res = DataLayer.parca_guncelle(p);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu" + ex.Message);
                return false;
            }
        }

        internal static bool parca_sil(Guid pid)
        {
            try
            {
                int res = DataLayer.parca_sil(pid);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu" + ex.Message);
                return false;
            }
        }
        //-------------------------------------------------------------------
        internal static bool urun_ekle(urun u)
        {
            try
            {
                int res = DataLayer.urun_ekle(u);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu" + ex.Message);
                return false;
            }
        }

        internal static DataSet urun_getir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.urun_getir(filtre);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu" + ex.Message);
                return null;
            }
        }

        internal static bool urun_guncelle(urun u)
        {
            try
            {
                int res = DataLayer.urun_guncelle(u);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu" + ex.Message);
                return false;
            }
        }

        internal static bool urun_sil(string seri)
        {
            try
            {
                int res = DataLayer.urun_sil(seri);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu" + ex.Message);
                return false;
            }
        }
        //-------------------------------------------------------------------
        internal static bool onarim_ekle(onarim o)
        {
            try
            {
                int res = DataLayer.onarim_ekle(o);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu" + ex.Message);
                return false;
            }
        }

        internal static DataSet onarim_getir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.onarim_getir(filtre);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu" + ex.Message);
                return null;
            }
        }

        internal static bool onarim_guncelle(onarim o)
        {
            try
            {
                int res = DataLayer.onar_guncelle(o);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu" + ex.Message);
                return false;
            }
        }

        internal static bool onarim_sil(string oid)
        {
            try
            {
                int res = DataLayer.onar_sil(oid);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu" + ex.Message);
                return false;
            }
        }
        //--------------------------------------------------------
    }
}
