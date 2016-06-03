using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GenetikAlgoritma;

namespace GenetikAlgoritma
{
    public abstract class Mutasyon
    {
                public Random rnd;
                public  double mutosyonKatsayisi;
               
                public Mutasyon()
                {            
                    rnd = new Random();                 
                   
                }
                public void setMutasyonKatsayi(double mutosyonKatsayisi)
                {
                     this.mutosyonKatsayisi = mutosyonKatsayisi;
                }
                
                public static Mutasyon mutasyonYap(string mutasyonAdi)
                {
                    switch (mutasyonAdi)
                    {
                        case "Toplama": return new Toplama();
                        case "Cikarma": return new Cikarma();                       
                        default: return null;
                    }
                }
                public abstract Kromozom mutasyon(Kromozom kromozom, Form1 form);
               

         }
        public class Toplama : Mutasyon
        {
            public Toplama() 
             {

             }
            override public Kromozom mutasyon(Kromozom kromozom, Form1 form)
            {
                Kromozom krm = new Kromozom();
                Gen gen = new Gen();
                int indis = rnd.Next(0, form.d_genAdeti); //Kromozomumuz 2 adet genden oluşacaktır onun için hangisi ile işlem yapacaksak onun indisini belirleriz.
                gen = (Gen)kromozom.listGenler[indis].Clone();
                krm = kromozom.getKromozom();
                gen.genDeger += mutosyonKatsayisi;
                if (gen.genDeger > form.fonksiyon.getUstSinir())
                    gen.genDeger = form.fonksiyon.getUstSinir() - rnd.NextDouble();
                if (gen.genDeger < form.fonksiyon.getAltSinir())
                    gen.genDeger = form.fonksiyon.getAltSinir() + rnd.NextDouble();
                krm.listGenler[indis].genDeger = gen.genDeger;
                             
                return krm;
            }
        }
        public class Cikarma : Mutasyon
        {
            public Cikarma() 
             {

             }
            override public Kromozom mutasyon(Kromozom kromozom, Form1 form)
            {
                Kromozom krm = new Kromozom();
                Gen gen = new Gen();
                int indis = rnd.Next(0, form.d_genAdeti); //Kromozomumuz 2 adet genden oluşacaktır onun için hangisi ile işlem yapacaksak onun indisini belirleriz.
                gen = (Gen)kromozom.listGenler[indis].Clone();
                krm = kromozom.getKromozom();
                gen.genDeger -= mutosyonKatsayisi;
                if (gen.genDeger > form.fonksiyon.getUstSinir())
                    gen.genDeger = form.fonksiyon.getUstSinir() - rnd.NextDouble();
                if (gen.genDeger < form.fonksiyon.getAltSinir())
                    gen.genDeger = form.fonksiyon.getAltSinir() + rnd.NextDouble();
                krm.listGenler[indis].genDeger = gen.genDeger;

                // MessageBox.Show("fonkMutasyonToplama" + krm.listGenler[indis].genDeger);
                return krm;
            }
        }
       
}
