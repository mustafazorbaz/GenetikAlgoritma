using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenetikAlgoritma
{
    public abstract class BireySec
    {


         public  Random random = new Random();

         public static BireySec bireySecimiYap(string mutasyonAdi)
        {
            switch (mutasyonAdi)
            {
                case "Rulet": return new Rulet();
                case "Rastgele": return new Rastgele();
                case "Turnuva": return new Turnuva();
                case "Deterministik": return new Deterministik();
                default: return null;
            }
        }
         public abstract Kromozom sec(Form1 form, Populasyon populasyon);
        //public abstract void setIndis(int indis);       
    }
        public class Rulet : BireySec
        {
            override public  Kromozom sec(Form1 form, Populasyon populasyon)
            {
                       List<double> diziYuzde = new List<double>();

                    double toplamSonuc = 0;
                    if (form.islemYaz == true)
                    form.listBoxIslemler.Items.Add("----RULET----");

                    for (int j = 0; j < populasyon.listKromozomlar.Count; j++)
                    {

                        double deger = populasyon.listKromozomlar[j].getUygunluk();
                        double sonuc = Math.Round((1 / deger), 5);

                        toplamSonuc += sonuc;
                        diziYuzde.Add(sonuc);
                    }

                    double rastgele = getRandomSayi(0, toplamSonuc);
                    if (form.islemYaz == true)
                    form.listBoxIslemler.Items.Add("rastgele" + rastgele);
                    int k;
                    double toplam = 0;
                    for (k = 0; k < populasyon.listKromozomlar.Count; k++)
                    {
                        toplam += diziYuzde[k];
                        if (form.islemYaz == true)
                        form.listBoxIslemler.Items.Add("toplam" + toplam);
                        if (toplam > rastgele)
                        {
                            if (form.islemYaz == true)
                            form.listBoxIslemler.Items.Add("TOPLAM %=" + toplam);
                            break;
                        }
                    }
                    if (form.islemYaz == true)
                    form.listBoxIslemler.Items.Add("Döndürülen k. inids =" + k);
                    if (k >= populasyon.listKromozomlar.Count)
                    {
                             k--;
                             if (form.islemYaz == true)
                             form.listBoxIslemler.Items.Add("Döndürülen k-----------  inids =" + k);
                    }

                    Kromozom secilenKromozom = new Kromozom();
                    form.kromozomAktar(secilenKromozom, populasyon.listKromozomlar[k]);
                    populasyon.listKromozomlar.RemoveAt(k);
                    return secilenKromozom;
            }
             public double getRandomSayi(double min, double max)
          {
              
            return random.NextDouble() * (max - min) + min;
           }
        }
        public class Rastgele : BireySec
        {
            override public  Kromozom sec(Form1 form, Populasyon populasyon)
            {
                int rastgele = random.Next(0, populasyon.listKromozomlar.Count);
                Kromozom secilenKromozom = new Kromozom();
                form.kromozomAktar(secilenKromozom, populasyon.listKromozomlar[rastgele]);
            populasyon.listKromozomlar.RemoveAt(rastgele);
            return secilenKromozom;
            }
        }
        public class Turnuva : BireySec
        {     //Turnuva yöntemi=Rastgele seçilen iki bireyden uygunluk derecesi yüksek olan bir sonraki popülasyona aktarılır.
              //Seçilen iki kromozomdan uygunulugu büyük olanı return ile geriye gönderir.
      
            override public  Kromozom sec(Form1 form, Populasyon populasyon)
            {
                int rastgele1 = form.rand.Next(0, populasyon.listKromozomlar.Count);
                 int rastgele2 = form.rand.Next(0, populasyon.listKromozomlar.Count);
                double uygunluk1 = populasyon.listKromozomlar[rastgele1].getUygunluk();
                double uygunluk2 = populasyon.listKromozomlar[rastgele2].getUygunluk();

                if (form.islemYaz == true)
                form.listBoxIslemler.Items.Add("fonkSecimTurnuva() -->uygunluk1=" + uygunluk1 + "     uygunluk2=" + uygunluk2);
                Kromozom secilenKromozom = new Kromozom();
                if (uygunluk1 < uygunluk2)
                {
                    form.kromozomAktar(secilenKromozom, populasyon.listKromozomlar[rastgele1]);
                    populasyon.listKromozomlar.RemoveAt(rastgele1);
                    return secilenKromozom;

                }
                else
                {
                  
                    form.kromozomAktar(secilenKromozom, populasyon.listKromozomlar[rastgele2]);
                    populasyon.listKromozomlar.RemoveAt(rastgele2);
                    return secilenKromozom;

                }
            }
        }
        public class Deterministik : BireySec
        {
            /*Belirli sayıdaki en iyi olan bireyler ile yeni popülasyon oluşturulur.
             *Burada ise Sirali popülasyon ile bir saralama yapar ve bunun sonucunda rastgele  10 da birlik bir seçim sonucu yeni popülasyona akatarır.
             */           
            override public  Kromozom sec(Form1 form, Populasyon populasyon)
            {
                Populasyon populasyonSirali = new Populasyon();
                for (int i = 0; i < populasyon.listKromozomlar.Count; i++)
                    {

                        populasyonSirali.listKromozomlar.Add(populasyon.listKromozomlar[i]);
                    }
                    for (int a = 0; a < populasyon.listKromozomlar.Count; a++)
                    {
                        for (int b = 0; b < populasyon.listKromozomlar.Count; b++)
                        {

                            if (populasyonSirali.listKromozomlar[a].getUygunluk() < populasyonSirali.listKromozomlar[b].getUygunluk())
                            {
                                Kromozom krm = populasyonSirali.listKromozomlar[b];
                                populasyonSirali.listKromozomlar[b] = populasyonSirali.listKromozomlar[a];
                                populasyonSirali.listKromozomlar[a] = krm;

                            }
                        }
                    }
                       
                        
                        // int rastgeleIndis = random.Next(0, populasyon.listKromozomlar.Count / 2);
                        Kromozom secilenKromozom = new Kromozom();
                        form.kromozomAktar(secilenKromozom, populasyon.listKromozomlar[0]);
                        populasyon.listKromozomlar.RemoveAt(0);
                        return secilenKromozom;
                    }
           
        }

   


       
      
    
}
