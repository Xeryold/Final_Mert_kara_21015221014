using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Security.Cryptography;

namespace Mert_kara_21015221014.DL
{
    public static class DataLayer
    {
       static MySqlConnection connection = new MySqlConnection(
            new MySqlConnectionStringBuilder() 
            {
                Server= "localhost",
                Database= "21015221014",
                UserID="root",
                Password="110812mk",
            }.ConnectionString
            );

        //---------------------------------------------------------------
        public static int musteriekle(Musteri m) 
        {
            try 
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();
                MySqlCommand komut = new MySqlCommand("musteri_ekle", connection);
                komut.CommandType=System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Tc",m.Tc);
                komut.Parameters.AddWithValue("@Ad", m.Ad);
                komut.Parameters.AddWithValue("@Soyad", m.Soyad);
                komut.Parameters.AddWithValue("@Adres", m.Adres);
                komut.Parameters.AddWithValue("@Tel", m.Tel);
               int res = komut.ExecuteNonQuery();
                return res;
            } 
            catch (Exception Ex) 
            {
                throw Ex;
            }
            finally 
            {
                if (connection.State != System.Data.ConnectionState.Closed) ;
                connection.Close();
            }


        }
        internal static DataSet musterigetir(string filtre) 
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();
                MySqlCommand komut;
                if (string.IsNullOrEmpty(filtre))
                {
                    komut = new MySqlCommand("musteri_hepsi", connection);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;

                }
                else 
                {
                    komut = new MySqlCommand("musteri_getir", connection);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@filtre", filtre);
                }
                DataSet dataSet=new DataSet();
               MySqlDataAdapter adp=new MySqlDataAdapter(komut);
                adp.Fill(dataSet);
                return dataSet;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                    connection.Close();
            }
        }
        internal static int musteriguncelle(Musteri m) 
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();
                MySqlCommand komut = new MySqlCommand("UPDATE musteri SET Ad = @Ad, Soyad = @Soyad, Adres = @Adres, Tel = @Tel WHERE Tc = @Tc", connection);
                komut.Parameters.AddWithValue("@Tc", m.Tc);
                komut.Parameters.AddWithValue("@Ad", m.Ad);
                komut.Parameters.AddWithValue("@Soyad", m.Soyad);
                komut.Parameters.AddWithValue("@Adres", m.Adres);
                komut.Parameters.AddWithValue("@Tel", m.Tel);
                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                    connection.Close();
            }
        }
        internal static int musterisil(string Tc) 
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();
                MySqlCommand komut = new MySqlCommand("DELETE FROM musteri WHERE Tc = @Tc", connection);
                komut.Parameters.AddWithValue("@Tc", Tc);
                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                    connection.Close();
            } 
        }
        //---------------------------------------------------------------
        public static int teknik_ekle(teknik t)
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();
                MySqlCommand komut = new MySqlCommand("teknik_ekle", connection);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@tid", t.tid);
                komut.Parameters.AddWithValue("@Ad", t.ad);
                komut.Parameters.AddWithValue("@Soyad", t.soyad);
                komut.Parameters.AddWithValue("@Ilgi", t.ilgi);
                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed) ;
                connection.Close();
            }


        }
        internal static DataSet teknik_getir(string filtre)
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();
                MySqlCommand komut;
                if (string.IsNullOrEmpty(filtre))
                {
                    komut = new MySqlCommand("teknik_hepsi", connection);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;

                }
                else
                {
                    komut = new MySqlCommand("teknik_getir", connection);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@filtre", filtre);
                }
                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);
                return dataSet;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                    connection.Close();
            }
        }

        internal static int teknik_guncelle(teknik t)
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();
                MySqlCommand komut = new MySqlCommand("UPDATE teknik SET ad = @ad, soyad = @soyad, ilgi = @ilgi WHERE tid = @tid", connection);
                komut.Parameters.AddWithValue("@tid", t.tid);
                komut.Parameters.AddWithValue("@ad", t.ad);
                komut.Parameters.AddWithValue("@soyad", t.soyad);
                komut.Parameters.AddWithValue("@ilgi", t.ilgi);
                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                    connection.Close();
            }
        }

        internal static int teknik_sil(Guid tid)
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();
                MySqlCommand komut = new MySqlCommand("DELETE FROM teknik WHERE tid = @tid", connection);
                komut.Parameters.AddWithValue("@tid", tid);
                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                    connection.Close();
            }
        }
        //---------------------------------------------------------------------

        internal static int parca_ekle(y_parca p)
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();
                MySqlCommand komut = new MySqlCommand("parca_ekle", connection);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@pid", p.pid);
                komut.Parameters.AddWithValue("@pad", p.pad);
                komut.Parameters.AddWithValue("@pmarka", p.pmarka);
                komut.Parameters.AddWithValue("@pmodel", p.pmodel);
                komut.Parameters.AddWithValue("@fiyat", p.fiyat);
                komut.Parameters.AddWithValue("@stok", p.stok);
                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed) ;
                connection.Close();
            }
        }

        internal static DataSet parca_getir(string filtre)
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();
                MySqlCommand komut;
                if (string.IsNullOrEmpty(filtre))
                {
                    komut = new MySqlCommand("parca_hepsi", connection);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;

                }
                else
                {
                    komut = new MySqlCommand("parca_getir", connection);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@filtre", filtre);
                }
                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);
                return dataSet;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                    connection.Close();
            }
        }

        internal static int parca_guncelle(y_parca p)
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();
                MySqlCommand komut = new MySqlCommand("UPDATE y_parca SET pad = @pad, pmarka = @pmarka, pmodel = @pmodel,fiyat=@fiyat,stok=@stok WHERE pid = @pid", connection);
                komut.Parameters.AddWithValue("@pid", p.pid);
                komut.Parameters.AddWithValue("@pad", p.pad);
                komut.Parameters.AddWithValue("@pmarka", p.pmarka);
                komut.Parameters.AddWithValue("@pmodel", p.pmodel);
                komut.Parameters.AddWithValue("@fiyat", p.fiyat);
                komut.Parameters.AddWithValue("@stok", p.stok);
                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                    connection.Close();
            }
        }

        internal static int parca_sil(Guid pid)
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();
                MySqlCommand komut = new MySqlCommand("DELETE FROM y_parca WHERE pid = @pid", connection);
                komut.Parameters.AddWithValue("@pid", pid);
                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                    connection.Close();
            }
        }
        //--------------------------------------------------------------------------

        internal static int urun_ekle(urun u)
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();
                MySqlCommand komut = new MySqlCommand("urun_ekle", connection);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@seri", u.seri);
                komut.Parameters.AddWithValue("@tc", u.Musteriid);
                komut.Parameters.AddWithValue("@marka", u.marka);
                komut.Parameters.AddWithValue("@model", u.model);
                komut.Parameters.AddWithValue("@sorun", u.sorun);
                komut.Parameters.AddWithValue("@garanti", u.garanti);
                komut.Parameters.AddWithValue("@gtarih", u.gtarih);
                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed) ;
                connection.Close();
            }
        }
        internal static DataSet urun_getir(string filtre)
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();
                MySqlCommand komut;
                if (string.IsNullOrEmpty(filtre))
                {
                    komut = new MySqlCommand("urun_hepsi", connection);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;

                }
                else
                {
                    komut = new MySqlCommand("urun_getir", connection);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@filtre", filtre);
                }
                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);
                return dataSet;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                    connection.Close();
            }
        }

        internal static int urun_guncelle(urun u)
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();
                MySqlCommand komut = new MySqlCommand("UPDATE urun SET tc = @tc, marka = @marka, model = @model,sorun=@sorun,garanti=@garanti,gtarih=@gtarih WHERE seri = @seri", connection);
                komut.Parameters.AddWithValue("@seri", u.seri);
                komut.Parameters.AddWithValue("@tc", u.Musteriid);
                komut.Parameters.AddWithValue("@marka", u.marka);
                komut.Parameters.AddWithValue("@model", u.model);
                komut.Parameters.AddWithValue("@sorun", u.sorun);
                komut.Parameters.AddWithValue("@garanti", u.garanti);
                komut.Parameters.AddWithValue("@gtarih", u.gtarih);
                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                    connection.Close();
            }
        }

        internal static int urun_sil(string seri)
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();
                MySqlCommand komut = new MySqlCommand("DELETE FROM urun WHERE seri = @seri", connection);
                komut.Parameters.AddWithValue("@seri", seri);
                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                    connection.Close();
            }
        }
        //------------------------------------------------------------------------------

        internal static int onarim_ekle(onarim o)
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();
                MySqlCommand komut = new MySqlCommand("onarim_ekle", connection);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@oid", o.oid);
                komut.Parameters.AddWithValue("@tc", o.tc);
                komut.Parameters.AddWithValue("@seri", o.seri);
                komut.Parameters.AddWithValue("@tid", o.tid);
                komut.Parameters.AddWithValue("@pid", o.pid);
                komut.Parameters.AddWithValue("@durum", o.durum);
                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed) ;
                connection.Close();
            }
        }

        internal static DataSet onarim_getir(string filtre)
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();
                MySqlCommand komut;
                if (string.IsNullOrEmpty(filtre))
                {
                    komut = new MySqlCommand("onarim_hepsi", connection);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;

                }
                else
                {
                    komut = new MySqlCommand("onarim_getir", connection);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@filtre", filtre);
                }
                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);
                return dataSet;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                    connection.Close();
            }
        }

        internal static int onar_guncelle(onarim o)
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();
                MySqlCommand komut = new MySqlCommand("UPDATE onarim SET tc = @tc, seri = @seri, tid = @tid,pid=@pid,durum=@durum WHERE oid = @oid", connection);
                komut.Parameters.AddWithValue("@oid", o.oid);
                komut.Parameters.AddWithValue("@tc", o.tc);
                komut.Parameters.AddWithValue("@seri", o.seri);
                komut.Parameters.AddWithValue("@tid", o.tid);
                komut.Parameters.AddWithValue("@pid", o.pid);
                komut.Parameters.AddWithValue("@durum", o.durum);
                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                    connection.Close();
            }
        }

        internal static int onar_sil(string oid)
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();
                MySqlCommand komut = new MySqlCommand("DELETE FROM onarim WHERE oid = @oid", connection);
                komut.Parameters.AddWithValue("@oid", oid);
                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                    connection.Close();
            }
        }
    }
        //-------------------------------------------------------------------
}
