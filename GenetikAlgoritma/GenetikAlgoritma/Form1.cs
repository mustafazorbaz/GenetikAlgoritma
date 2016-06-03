using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenetikAlgoritma
{
    public partial class Form1 : Form
    {

        public int d_itesayonSayisi; //Kaç adım devam edecek
        public int d_populasyonOrani; //Kromozom Sayısı 
        public int d_caprazlamaOrani = 5;  // % diliminde
        public int d_mutasyonOrani;  // % diliminde
        public double d_mutasyonKatsayisi;
        public bool islemYaz;
        public bool islemVeGrafikPanel = false,kilit=false;

        //Gen Bilgisi
        public int d_genAdeti;  //Kromozomumuzda iki tane gen tutacagız x ve y genleri
        Populasyon populasyon = new Populasyon(); //Ana Popülasyon

        Kromozom ebeveyn1 = new Kromozom();
        Kromozom ebeveyn2 = new Kromozom();
        Kromozom cocuk1 = new Kromozom();
        Kromozom cocuk2 = new Kromozom();
        Kromozom iyiEbeveyn = new Kromozom(); 
        Kromozom yeniBirey = new Kromozom();
        public Random rand;
        public Random random;
        public Fonksiyon fonksiyon;
        public string fonksiyonAdi="";
        public Mutasyon mutasyonYap;
        public string mutasyonAdi = "";
        public BireySec birey;
        public string bireySecimAdi = "";

        //-----GRAFİK Çizimi İçin Veriler----
        List<double> ilkPopUygunluklari = new List<double>(); //ilk populasyonun uyguluk değerlerini tuttar grafik için
        List<double> sonPopUygunluklari = new List<double>(); //son populasyonun uyguluk değerlerini tuttar grafik için
        List<double> enIyiUygunluklar = new List<double>(); //İterasyondaki en iyi  değerlerin yugunlukarını tuttar grafik için 
        //---
    
        public Form1()
        {
            InitializeComponent();
            rand = new Random();
            random = new Random();
        }
        public void fonkPopulasyonOlustur()
        {

            
            for (int i = 0; i < d_populasyonOrani; i++)
            {
                Kromozom kromozom = new Kromozom();
                for (int j = 0; j < d_genAdeti; j++)
                {
                    Gen gen = new Gen();
                    gen.genDeger = gen.genOlustur(this, fonksiyonAdi);
                    kromozom.listGenler.Add(gen);
                    //Thread.Sleep(20);
                }
                populasyon.listKromozomlar.Add(kromozom);

            }
            fonkUygunlukDegeriniHesapla(populasyon);
            for (int j = 0; j < populasyon.listKromozomlar.Count; j++)
            {
                listBoxPopulasyon.Items.Add("Krm = " + j + genleriYaz(populasyon.listKromozomlar[j]) + "----> UYGUNLUK  =" + populasyon.listKromozomlar[j].getUygunluk());
                ilkPopUygunluklari.Add(populasyon.listKromozomlar[j].getUygunluk());
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            fonksiyonAdi = comboBoxFonksiyon.Text;
            mutasyonAdi = comboBoxMutosyon.Text;
            bireySecimAdi = comboBoxBireySec.Text;
            d_genAdeti = Convert.ToInt32(textBoxGenAdeti.Text);
            d_itesayonSayisi = Convert.ToInt32(textBoxIterasyonSayisi.Text);
            d_populasyonOrani = Convert.ToInt32(textBoxPopulasyonSayisi.Text);
            d_mutasyonKatsayisi = double.Parse(textBoxMutasyonKatsayi.Text);
            islemYaz = checkBoxIslemleriGor.Checked;
            if (fonksiyonAdi != "" && mutasyonAdi != "" && bireySecimAdi!="")
            {
                fitnessFonkisyonu(fonksiyonAdi);
                fonkPopulasyonOlustur();
                mutasyonBelirle(mutasyonAdi);
                bireySecimi(bireySecimAdi);
                
                for (int i = 0; i < d_itesayonSayisi; i++)
                {
                    if (islemYaz == true)
                    {
                        listBoxIslemler.Items.Add("----------------------" + i + "---------------------------------");
                        listBoxSecilenler.Items.Add("-----------------------------" + i + "--------------------------");
                    }


                    fonkUygunlukDegeriniHesapla(populasyon);
                    fonkBireySec();
                    fonkCarprazlama();
                    fonkMutasyon();
                    yeniBireyleriBelirle();

                    Ekle ekle = new Ekle(this,populasyon);
                    ekle.yeniBireyiEkle(iyiEbeveyn,yeniBirey);

                    if (islemYaz == true)
                    yazdir(listBoxSecilenler, populasyon);

                    PopulasyonAktar populasyonDegistir = new PopulasyonAktar(populasyon);
                    populasyonDegistir.aktar();
                    populasyon = populasyonDegistir.getPopulasyon();


                    if (iyiEbeveyn.getUygunluk() == fonksiyon.getGlobalMin())
                    {
                        MessageBox.Show("Sonuc 0 Bulundu Kromozom " + genleriYaz(iyiEbeveyn));
                        break;
                    }
                    if (yeniBirey.getUygunluk() == fonksiyon.getGlobalMin())
                    {
                        MessageBox.Show("Sonuc 0 Bulundu Kromozom " + genleriYaz(yeniBirey));
                        break;
                    }

                    double enIyiUygunluk =100000000.0000; 
                    for (int y = 0; y < populasyon.listKromozomlar.Count; y++)
                        if (enIyiUygunluk > populasyon.listKromozomlar[y].getUygunluk())
                            enIyiUygunluk = populasyon.listKromozomlar[y].getUygunluk();
                    enIyiUygunluklar.Add(enIyiUygunluk);
                    degerleriTemizle();
             
                }
                //Son iterasyondaki populasyonu yazdık.
                yazdir(listBoxSonPopulasyon, populasyon);
                for (int j = 0; j < populasyon.listKromozomlar.Count; j++)//Grafik İçin Degerleri Aldık 
                    sonPopUygunluklari.Add(populasyon.listKromozomlar[j].getUygunluk());
            }
            else
                MessageBox.Show("LÜTFEN FONKSİYONU SEÇİNİZ !!!");
           
        }
        public void fonkUygunlukDegeriniHesapla(Populasyon pop)
        {
            for (int i = 0; i < pop.listKromozomlar.Count; i++)
            {
                
                pop.listKromozomlar[i].setUygunluk(fonksiyon.hesapla(pop.listKromozomlar[i].listGenler));//Populasyondaki o kromozomun uygunluk degerini setledik.
                
            }
        }
        public void fonkBireySec()
        {
            if (islemYaz == true)
            listBoxIslemler.Items.Add("-----------BİREY SEÇ------------");            
           
          for (int  i = 0; i < 2; i++)
		  {

               Kromozom ebeveyn = new Kromozom();
              int rastgele = rand.Next(0,4) ;
              rastgeleKarisikSecim(rastgele);

              if (bireySecimAdi != "Karisik") //Hangi Bireyin Secildigini görebilmek için adlarını yazdırdık.
                  if (islemYaz == true)
                      listBoxIslemler.Items.Add("Birey Seç :-->" + bireySecimAdi);
               
                 ebeveyn=birey.sec(this,populasyon);
               
                if (i == 0 )
                {
                    kromozomAktar(ebeveyn1, ebeveyn);
                    if (islemYaz == true)
                    listBoxIslemler.Items.Add("Krm ebeveyn1 =" + genleriYaz(ebeveyn1) + "UYGUNLUK  =" + ebeveyn1.getUygunluk());
                }
                if (i == 1)
                {
                  
                    kromozomAktar(ebeveyn2, ebeveyn);
                    if (islemYaz == true)
                    listBoxIslemler.Items.Add("Krm ebeveyn2 =" + genleriYaz(ebeveyn2) + "UYGUNLUK  =" + ebeveyn2.getUygunluk());              
                }               
                  
           }
         

        }
        public void  rastgeleKarisikSecim(int rastgele)
        {

            if (rastgele == 0 && bireySecimAdi == "Karisik")//RULET TEKERLEĞİ
            {
                if (islemYaz == true)
                listBoxIslemler.Items.Add("Birey Seç :--> RULET TEK.");
                birey = new Rulet();
            }
            if (rastgele == 1 && bireySecimAdi == "Karisik")//RASTGELE
            {
                if (islemYaz == true)
                listBoxIslemler.Items.Add("Birey Seç :--> RASTGELE");
                birey = new Rastgele();
            }
            if (rastgele == 2 && bireySecimAdi == "Karisik")//TURNUVA
            {
                if (islemYaz == true)
                listBoxIslemler.Items.Add("Birey Seç :--> TURNUVA");
                birey = new Turnuva();
            }
            if (rastgele == 3 && bireySecimAdi == "Karisik")//DETERMİNİSTİK
            {
                if (islemYaz == true)
                listBoxIslemler.Items.Add("Birey Seç :--> DETERMİNİSTİK");
                birey = new Deterministik();
            }
        }
        
        public void fonkCarprazlama()
        {

            if (islemYaz == true)
            listBoxIslemler.Items.Add("-----------ÇAPRAZLAMA------------");
                     
                      //Rastgele seçilen 1. kromozom için çarprazmala yap sınıfındaki fonkCarprazlamaKrm1 fonk gönderdik çaprazladık ve çaprazlanan populasyona ekledik
                    if (islemYaz == true)
                    {
                        listBoxIslemler.Items.Add("Krm EBEVEYN 1 =" + genleriYaz(ebeveyn1) + "UYGUNLUK  =" + ebeveyn1.getUygunluk());
                        listBoxIslemler.Items.Add("Krm EBEVEYN 2 " + genleriYaz(ebeveyn2) + "UYGUNLUK  =" + ebeveyn2.getUygunluk());
                    }
            
                      int indis = rand.Next(0,d_genAdeti);
                      Caprazlama carprazla1 = new Caprazlama(indis,this);
                       kromozomAktar(cocuk1,carprazla1.fonkCarprazlamaKrm(ebeveyn1,ebeveyn2));
                       kromozomAktar(cocuk2, carprazla1.fonkCarprazlamaKrm(ebeveyn2, ebeveyn1));

                      cocuk1.setUygunluk(fonksiyon.hesapla(cocuk1.listGenler));
                      cocuk2.setUygunluk(fonksiyon.hesapla(cocuk2.listGenler));

                      if (islemYaz == true)
                      {
                          listBoxIslemler.Items.Add("Krm cocuk1 =" + genleriYaz(cocuk1) + "UYGUNLUK  =" + cocuk1.getUygunluk());
                          listBoxIslemler.Items.Add("Krm cocuk2 =" + genleriYaz(cocuk2) + "UYGUNLUK  =" + cocuk2.getUygunluk());
                      }
                   
        }
       public void fonkMutasyon()
        {
            if (islemYaz == true)
                listBoxIslemler.Items.Add("-----------MUTASYON------------");

            //Çoçuk 2 için motasyon durumu ve işlemi
            int rand1 = random.Next(0,2);//Mutasyon var veya yok
            if (rand1 == 1)
            {
                randomMutosyon();  //Random ise 1.çoçuk random mutasyona ugrar
                mutasyonYap.setMutasyonKatsayi(d_mutasyonKatsayisi);
                cocuk1 = mutasyonYap.mutasyon(cocuk1, this);
                cocuk1.setUygunluk(fonksiyon.hesapla(cocuk1.listGenler));
                if (islemYaz == true)
                    listBoxIslemler.Items.Add("Krm Mutasyonlu cocuk1 =" + genleriYaz(cocuk1) + "UYGUNLUK  =" + cocuk1.getUygunluk());
            }
           //Çoçuk 2 için motasyon durumu ve işlemi
            int rand2 = random.Next(0,2);
            if (rand2 == 1)
            {
                randomMutosyon();  //Random ise 2.Çoçuk mutasyona ugrar.
                mutasyonYap.setMutasyonKatsayi(d_mutasyonKatsayisi);
                cocuk2 = mutasyonYap.mutasyon(cocuk2, this);
                cocuk2.setUygunluk(fonksiyon.hesapla(cocuk2.listGenler));
                if (islemYaz == true)
                    listBoxIslemler.Items.Add("Krm Mutasyonlu cocuk2 =" + genleriYaz(cocuk2) + "UYGUNLUK  =" + cocuk2.getUygunluk());
            }

        }
        public void randomMutosyon()
        {
                 int rasgele = rand.Next(0, 2);
                if (rasgele == 0 && mutasyonAdi == "Karisik")
                {
                    mutasyonYap = new Toplama();
                    if (islemYaz == true)
                        listBoxIslemler.Items.Add("Mutasyon Yap :-->TOPLAMA");
                }
                if (rasgele == 1 && mutasyonAdi == "Karisik")
                {
                    mutasyonYap = new Cikarma();
                    if (islemYaz == true)
                        listBoxIslemler.Items.Add("Mutasyon Yap :-->ÇIKARMA");
                }             
                if (mutasyonAdi != "Karisik")
                {
                    if (islemYaz == true)
                        listBoxIslemler.Items.Add("Mutasyon Yap :-->" + mutasyonAdi);
                } 
        }
        
        public void yeniBireyleriBelirle()// Uygunlugu en düşük olanı şeçer
        {
            //NOT:Bu Fonksiyona göre 1 iterasyonda sadece 1 birey değişir ebeynlerin kötüsü çıkar en iyi çoçuk girer.
            if (ebeveyn1.getUygunluk() < ebeveyn2.getUygunluk())
                iyiEbeveyn = ebeveyn1;
            else
                iyiEbeveyn = ebeveyn2;
            if (cocuk1.getUygunluk() < cocuk2.getUygunluk())
                yeniBirey = cocuk1;
            else
                yeniBirey = cocuk2;
        }
        public void yazdir(ListBox listbox,Populasyon popu)
        {
            for (int i = 0; i < popu.listKromozomlar.Count; i++)
                listbox.Items.Add("Krm " + i + "=" + genleriYaz(popu.listKromozomlar[i]) + "UYGUNLUK =" + popu.listKromozomlar[i].getUygunluk());
          
        }
      public void degerleriTemizle(){
          iyiEbeveyn.listGenler.Clear();
          yeniBirey.listGenler.Clear();
          ebeveyn1.listGenler.Clear();
          ebeveyn2.listGenler.Clear();
          cocuk1.listGenler.Clear();
          cocuk2.listGenler.Clear();
      }
       public string genleriYaz(Kromozom kromozom)
       {
            string genler = "";
            for (int i = 0; i < kromozom.listGenler.Count; i++)          
                genler +="Gen :"+(i+1)+"-->"+kromozom.listGenler[i].genDeger;
            
            return genler;
       }
       public void kromozomAktar(Kromozom krm1,Kromozom krm2)
       {

           krm1.listGenler.Clear();
                for (int j = 0; j < d_genAdeti; j++)
                {
                    Gen gen = new Gen();
                    gen.genDeger =krm2.listGenler[j].genDeger;
                    krm1.listGenler.Add(gen);
                }

       
           krm1.setUygunluk(krm2.getUygunluk());
       }

      
       
       public void fitnessFonkisyonu(string benchmarkProblem)
       {
           if (benchmarkProblem == "Zakharov")
               fonksiyon = new Zakharov();
           if (benchmarkProblem == "Beale")
               fonksiyon = new Beale();
           if (benchmarkProblem == "Easom")
               fonksiyon = new Easom();
           if (benchmarkProblem == "Michalewicz2")
               fonksiyon = new Michalewicz2();
           if (benchmarkProblem == "Michalewicz5")
               fonksiyon = new Michalewicz5();
           if (benchmarkProblem == "Michalewicz10")
               fonksiyon = new Michalewicz10();
       }
       public void mutasyonBelirle(string mutasyonAdi)
       {
           if (mutasyonAdi == "Toplama")
               mutasyonYap = new Toplama();           
           if (mutasyonAdi == "Cikarma")
               mutasyonYap = new Cikarma();
          
         
       }
       public void bireySecimi(string bireySecimAdi)
       {
           if (bireySecimAdi == "Rulet")
               birey = new Rulet();
           if (bireySecimAdi == "Turnuva")
               birey = new Turnuva();
           if (bireySecimAdi == "Rastgele")
               birey = new Rastgele();
           if (bireySecimAdi == "Deterministik")
               birey = new Deterministik();

       }

       private void button2_Click(object sender, EventArgs e)
       {
           if (islemVeGrafikPanel == false)
           {
               islemVeGrafikPanel = true;
               groupBoxIslemAdimlari.Visible = false;
               if (kilit == false)
               {
                   GrafikCizdirme grafik = new GrafikCizdirme();
                   grafik.cizGrafik1(ilkPopUygunluklari, chart1, "ilk populasyon", Color.Red);
                   grafik.cizGrafik1(sonPopUygunluklari, chart1, "son populasyon", Color.Green);
                   grafik.cizGrafik1(enIyiUygunluklar, chart2, "populasyon degisimi", Color.Blue);
                   kilit = true;
               }
           }
           else
           {
               islemVeGrafikPanel = false;
               groupBoxIslemAdimlari.Visible = true;
           }
       }


             
    }
}
