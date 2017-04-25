using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;


namespace YurtOtomasyonu.classlar
{
    class Yonetim
    {
        public void ogrenciEkle(string ad, string soyad,string tc,string kangrubu, string tel,string tarih,string adres,string mail,string ogretim,string odaId)
        {
            OracleCommand cmd = new OracleCommand(@"INSERT INTO Ogrenci(OgrenciAd,OgrenciSoyad,OgrenciTC,OgrenciKanGrubu,OgrenciTel,OgrenciKayitTarihi,OgrenciAdres,OgrenciMail,OgrenciOgretim,OdaID) 
                                                VALUES (:ad,:soyad,:tc,:kangrubu,:tel,:tarih,:adres,:mail,:ogretim,:odaId)",baglan);

            cmd.Parameters.Add(":ad",ad);
            cmd.Parameters.Add(":soyad",soyad);
            cmd.Parameters.Add(":tc",tc);
            cmd.Parameters.Add(":kangrubu",kangrubu);
            cmd.Parameters.Add(":tel",tel);
            cmd.Parameters.Add(":tarih",tarih);
            cmd.Parameters.Add(":adres",adres);
            cmd.Parameters.Add(":mail",mail);
            cmd.Parameters.Add(":ogretim",ogretim);
            cmd.Parameters.Add(":odaId",odaId);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ogrenci Başarıyla Eklenmiştir");
            }
            catch (Exception)
            {
                MessageBox.Show("Ogrenci Ekleme Hatası");
                throw;
            }
            

        }

        public void ogrenciSil(string ogrenciID) 
        {
            OracleCommand cmd = new OracleCommand(@"DELETE * from Ogrenci Where OgrenciID="+ogrenciID,baglan);
            try
            {
                MessageBox.Show("Öğrenci Başarıyla Silinmiştir");
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Öğrenci Silme Hatası");
                throw;
            }
        }

        public void ogrenciGuncelle(string ad, string soyad, string tc, string kangrubu, string tel, string tarih, string adres, string mail, string ogretim, string odaId) 
        {
       
            OracleCommand cmd = new OracleCommand(@"UPDATE Ogrenci SET OgrenciAd=:ad,OgrenciSoyad=:soyad,OgrenciTC=:tc,OgrenciKanGrubu=:kangrubu,OgrenciTel=:tel,OgrenciKayitTarihi=:tarih,OgrenciAdres=:adres,OgrenciMail=:mail,OgrenciOgretim=:ogretim,OdaID=:odaId",baglan);
            cmd.Parameters.Add(":ad",ad);
            cmd.Parameters.Add(":soyad",soyad);
            cmd.Parameters.Add(":tc",tc);
            cmd.Parameters.Add(":kangrubu",kangrubu);
            cmd.Parameters.Add(":tel",tel);
            cmd.Parameters.Add(":tarih",tarih);
            cmd.Parameters.Add(":adres",adres);
            cmd.Parameters.Add(":mail",mail);
            cmd.Parameters.Add(":ogretim",ogretim);
            cmd.Parameters.Add(":odaId",odaId);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Öğrenci Başarıyla Güncellendi");
            }
            catch (Exception)
            {
                MessageBox.Show("Öğrenci Güncelleme Hatası");
                throw;
            }  
        }
        //------------------------------------------------------------------------------------------------------
        public void odaEkle(string odaId, string odanumarasi,string odakati, string odablok, string odatipiId)
        {
            OracleCommand cmd = new OracleCommand(@"INSERT INTO Oda VALUES(:odaId,:odanumarasi,:odakati,:odablok,:odatipiId)", baglan);

            cmd.Parameters.Add(":odaId", odaId);
            cmd.Parameters.Add(":odanumarasi", odanumarasi);
            cmd.Parameters.Add(":odakati", odakati);
            cmd.Parameters.Add(":odablok", odablok);
            cmd.Parameters.Add(":odatipiId", odatipiId);
            try
            {
                MessageBox.Show("Oda Başarıyla Eklenmiştir");
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Oda Ekleme Hatası");
                throw;
            }
        }
        //------------------------------------------------------------------------------------------------------------
        public void odaTipiEkle(string ODATIPIID, string YATAKNO, string ODATIPI, string ODADURUMU, string YURTID)
        {
            OracleCommand cmd = new OracleCommand(@"INSERT INTO Oda VALUES(:ODATIPIID,:YATAKNO,:ODATIPI,:ODADURUMU,:YURTID)", baglan);

            cmd.Parameters.Add(":ODATIPIID", ODATIPIID);
            cmd.Parameters.Add(":YATAKNO", YATAKNO);
            cmd.Parameters.Add(":ODATIPI", ODATIPI);
            cmd.Parameters.Add(":ODADURUMU", ODADURUMU);
            cmd.Parameters.Add(":YURTID", YURTID);
            try
            {
                MessageBox.Show("Oda Tipi Başarıyla Eklenmiştir");
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Oda Tipi Ekleme Hatası");
                throw;
            }
        }

        public void odaTipiGuncelle(string ODATIPI_ID, string YATAK_NO, string ODA_TIPI, string ODA_DURUMU, string YURT_ID)
        {

            OracleCommand cmd = new OracleCommand(@"UPDATE Ogrenci SET ODATIPIID=:ODATIPI_ID,YATAKNO=:YATAK_NO,ODATIPI=:ODA_TIPI,ODADURUMU=:ODA_DURUMU,YURTID=:YURT_ID", baglan);
            cmd.Parameters.Add(":ODATIPI_ID", ODATIPI_ID);
            cmd.Parameters.Add(":YATAK_NO", YATAK_NO);
            cmd.Parameters.Add(":ODA_TIPI", ODA_TIPI);
            cmd.Parameters.Add(":ODA_DURUMU", ODA_DURUMU);
            cmd.Parameters.Add(":YURT_ID", YURT_ID);
        
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Oda Tipi Başarıyla Güncellendi");
            }
            catch (Exception)
            {
                MessageBox.Show("Oda Tipi Güncelleme Hatası");
                throw;
            }
        }

        //-------------------------------------------------------------------------------------------------------------

        public void yurtEkle(string yurt_ID, string yurt_Ad, string yurt_Adres)
        {
            OracleCommand cmd = new OracleCommand(@"INSERT INTO Oda VALUES(:yurt_ID,:yurt_Ad,:yurt_Adres)", baglan);

            cmd.Parameters.Add(":yurt_ID", yurt_ID);
            cmd.Parameters.Add(":yurt_Ad", yurt_Ad);
            cmd.Parameters.Add(":yurt_Adres", yurt_Adres);
            try
            {
                MessageBox.Show("Yurt Başarıyla Eklenmiştir");
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Yurt Ekleme Hatası");
                throw;
            }
        }

        public void yurtGuncelle(string yurt_ID, string yurt_Ad, string yurt_Adres)
        {

            OracleCommand cmd = new OracleCommand(@"UPDATE Ogrenci SET YURTID=:yurt_ID,YURTAD=:yurt_Ad,YURTADRES=:yurt_Adres", baglan);
            cmd.Parameters.Add(":yurt_ID", yurt_ID);
            cmd.Parameters.Add(":yurt_Ad", yurt_Ad);
            cmd.Parameters.Add(":yurt_Adres", yurt_Adres);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Yurt Başarıyla Güncellendi");
            }
            catch (Exception)
            {
                MessageBox.Show("Yurt Güncelleme Hatası");
                throw;
            }
        }

        
        
        public void YurtSil(string yurt_ID)
        {
            OracleCommand cmd = new OracleCommand(@"DELETE * from Yurt Where YurtID=" + yurt_ID, baglan);
            try
            {
                MessageBox.Show("Yurt Başarıyla Silinmiştir");
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Yurt Silme Hatası");
                throw;
            }
        }
        //-------------------------------------------------------------------------------------------------------------
        public void personelEkle(string ad,string soyad,string kidem,string tel,string adres,string maas,string yurId) 
        {
            OracleCommand cmd = new OracleCommand(@"INSERT INTO Personel (PersonelAd,PersonelSoyad,PersonelKidem,PersonelTel,PersonelAdres,PersonelMaas,YurtID)
                                                    VALUES(:ad,:soyad,:kidem,:tel,:adres,:maas,:yurtId)",baglan);

            cmd.Parameters.Add(":ad",ad);
            cmd.Parameters.Add(":soyad",soyad);
            cmd.Parameters.Add(":kidem",kidem);
            cmd.Parameters.Add(":tel",tel);
            cmd.Parameters.Add(":adres",adres);
            cmd.Parameters.Add(":maas",maas);
            cmd.Parameters.Add(":yurtId",yurId);
            try
            {
                MessageBox.Show("Personel Başarıyla Eklenmiştir");
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Personel Ekleme Hatası");
                throw;
            }
        }

        public void personelSilme(string ad,string soyad) 
        {
            OracleCommand cmd = new OracleCommand(@"DELETE * from Personel Where ",baglan);
            try
            {
                MessageBox.Show("Personel Başarıyla Silinmiştir");
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Personel Silme Hatası");
                throw;
            }
        }
        
        public void personelGuncelleme()
        {

        }

        public void odemeEkle(String odemeNo, String taksitSayisi, String odeme, String kalan, String toplam, String tarih, String ogrenciId, String personelId) 
        {
            OracleCommand cmd = new OracleCommand(@"INSERT INTO Odeme(OdemeNo,TaksitSayisi,Odeme,Kalan,Toplam,Tarih,OgrenciID,PersonelID) 
                                                              VALUES(:odemeNo,:taksitSayisi,:odeme,:kalan,:toplam,:tarih,:ogrenciId,:personelId)",baglan);
            cmd.Parameters.Add(":odemeNo", Convert.ToInt16(odemeNo));
            cmd.Parameters.Add(":taksitSayisi", Convert.ToInt16(taksitSayisi));
            cmd.Parameters.Add(":odeme", Convert.ToInt16(odeme));
            cmd.Parameters.Add(":kalan", Convert.ToInt16(kalan));
            cmd.Parameters.Add(":toplam", Convert.ToInt16(toplam));
            cmd.Parameters.Add("tarih", tarih);
            cmd.Parameters.Add(":ogrenciId", ogrenciId);
            cmd.Parameters.Add(":personelId", personelId);
        
        }
        public void odemeSil() 
        { 
        }
       
      public void odemeGuncelle(String odemeNo, String taksitSayisi,String odeme,String kalan,String toplam,String tarih,String ogrenciId,String personelId) 
        {
            int kalan_int = Convert.ToInt16(kalan) - Convert.ToInt16(odeme);
            OracleCommand cmd = new OracleCommand(@"UPDATE Odeme SET OdemeNo=:odemeNo,TaksitSayisi=:taksitSayisi,Odeme=:odeme,Kalan=:kalan,
                                                                    Toplam=:toplam,Tarih=:tarih,OgrenciID=:ogrenciId,PersonelID=:personelId",baglan);
            
            //parametreler string alındıgı icin veritabanına atmadan önce ceviri yaptim
            cmd.Parameters.Add(":odemeNo",Convert.ToInt16(odemeNo));
            cmd.Parameters.Add(":taksitSayisi", Convert.ToInt16(taksitSayisi));
            cmd.Parameters.Add(":odeme", Convert.ToInt16(odeme));
            cmd.Parameters.Add(":kalan",kalan_int);
            cmd.Parameters.Add(":toplam", Convert.ToInt16(toplam));
            cmd.Parameters.Add("tarih",tarih);
            cmd.Parameters.Add(":ogrenciId",ogrenciId);
            cmd.Parameters.Add(":personelId", personelId);
        }
        //----------------------------------------------------------------------------------------
      public void ogrenciDisiplinEkle(string ogrenciDisiplin_ID, string ogrenciDisiplin_Durum, string ogrenci_ID)
      {
          OracleCommand cmd = new OracleCommand(@"INSERT INTO Oda VALUES(:ogrenciDisiplin_ID,:ogrenciDisiplin_Durum,:ogrenci_ID)", baglan);

          cmd.Parameters.Add(":ogrenciDisiplin_ID", ogrenciDisiplin_ID);
          cmd.Parameters.Add(":ogrenciDisiplin_Durum", ogrenciDisiplin_Durum);
          cmd.Parameters.Add(":ogrenci_ID", ogrenci_ID);
          try
          {
              MessageBox.Show("Disiplin Başarıyla Eklenmiştir");
              cmd.ExecuteNonQuery();
          }
          catch (Exception)
          {
              MessageBox.Show("Disiplin Ekleme Hatası");
              throw;
          }
      }
        //---------------------------------------------------------------
      public void ogrenciGirisCikisEkle(string ogrenciGirisCikis_ID, string o_giris, string o_tarih, string o_izin, string ogrenci_Id)
      {
          OracleCommand cmd = new OracleCommand(@"INSERT INTO Oda VALUES(:ogrenciGirisCikis_ID,:o_giris,:o_tarih,:o_izin,:ogrenci_Id)", baglan);

          cmd.Parameters.Add(":ogrenciGirisCikis_ID", ogrenciGirisCikis_ID);
          cmd.Parameters.Add(":o_giris", o_giris);
          cmd.Parameters.Add(":o_tarih", o_tarih);
          cmd.Parameters.Add(":o_izin", o_izin);
          cmd.Parameters.Add(":ogrenci_Id", ogrenci_Id);
          try
          {
              MessageBox.Show("Giriş Çıkış Başarıyla Eklenmiştir");
              cmd.ExecuteNonQuery();
          }
          catch (Exception)
          {
              MessageBox.Show("Giriş Çıkış Ekleme Hatası");
              throw;
          }
      }
        
    }
}
