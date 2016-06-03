using GenetikAlgoritma;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenetikAlgoritma
{
    public abstract class Fonksiyon
    {

        int degiskenSayisi;
        double altSinir, ustSinir, globalMin;

        public Fonksiyon(int degiskenSayisi, double altSinir, double ustSinir, double globalMin)
        {
            setDegiskenSayisi(degiskenSayisi);
            setAltSinir(altSinir);
            setUstSinir(ustSinir);
            setGlobalMin(globalMin);
        }

        void setDegiskenSayisi(int degiskenSayisi)
        {
            this.degiskenSayisi = degiskenSayisi;
        }

        void setAltSinir(double altSinir)
        {
            this.altSinir = altSinir;
        }

        void setUstSinir(double ustSinir)
        {
            this.ustSinir = ustSinir;
        }

        void setGlobalMin(double globalMin)
        {
            this.globalMin = globalMin;
        }

        public int getDegiskenSayisi()
        {
            return degiskenSayisi;
        }

        public double getAltSinir()
        {
            return altSinir;
        }

        public double getUstSinir()
        {
            return ustSinir;
        }

        public double getGlobalMin()
        {
            return globalMin;
        }

        public static Fonksiyon fonksiyonYarat(string benchmarkProblem)
        {
            switch (benchmarkProblem)
            {
                case "Zakharov": return new Zakharov();
                case "Beale": return new Beale();
                case "Easom": return new Easom();
                case "Michalewicz 2": return new Michalewicz2();
                case "Michalewicz 5": return new Michalewicz5();
                case "Michalewicz 10": return new Michalewicz10();
                default: return null;
            }
        }

        public abstract double hesapla(List<Gen> genler);
    }
    class Zakharov : Fonksiyon
    {
        public Zakharov()
            : base(10, -5, 10, 0)
        {

        }

       override public double hesapla(List<Gen> genler)
        {
            double y1 = 0, y2 = 0, y3 = 0;
            for (int i = 0; i < getDegiskenSayisi(); i++)
            {
                y1 = y1 + Math.Pow(genler[i].genDeger, 2);
                y2 = y2 + 0.5 * (i + 1) * genler[i].genDeger;
                y3 = y3 + 0.5 * (i + 1) * genler[i].genDeger;
            }
            return y1 + Math.Pow(y2, 2) + Math.Pow(y3, 4);
           
        }
    }
    public class Beale : Fonksiyon
    {
        public Beale() : base(2, -4.5, 4.5, 0)
        {

        }
        override public double hesapla(List<Gen> genler)
        {
            double y = Math.Pow((1.5 - genler[0].genDeger + genler[0].genDeger * genler[1].genDeger), 2) + Math.Pow((2.25 - genler[0].genDeger + genler[0].genDeger * Math.Pow(genler[1].genDeger, 2)), 2)
                + Math.Pow((2.625 - genler[0].genDeger + genler[0].genDeger * Math.Pow(genler[1].genDeger, 3)), 2);
            return y;
        }
    }

    public class Easom : Fonksiyon
    {
        public Easom() : base(2, -100, 100, -1)
        {

        }

        override public double hesapla(List<Gen> genler)
        {
            double y = -Math.Cos(genler[0].genDeger) * Math.Cos(genler[1].genDeger) * Math.Exp(-Math.Pow((genler[0].genDeger - Math.PI), 2) - Math.Pow((genler[1].genDeger - Math.PI), 2));
            return y;
        }
    }

    class Michalewicz2 : Fonksiyon
    {  
        public Michalewicz2() : base(2, 0, Math.PI, -1.8013)
        {

        }
        override public double hesapla(List<Gen> genler)
        {
            double y = 0;
            for (int i = 0; i < genler.Count; i++)
                y = y + (Math.Sin(genler[i].genDeger) * Math.Pow(Math.Sin((i + 1) * Math.Pow(genler[i].genDeger, 2) / Math.PI), 20));
            y = y * -1;
            return y;
        }
    }
    class Michalewicz5 : Fonksiyon
    {

        public Michalewicz5()  : base(5, 0, Math.PI, -4.687658)
        {

        }


        override public double hesapla(List<Gen> genler)
        {
            double y = 0;
            for (int i = 0; i < genler.Count; i++)
                y = y + (Math.Sin(genler[i].genDeger) * Math.Pow(Math.Sin((i + 1) * Math.Pow(genler[i].genDeger, 2) / Math.PI), 20));
            y = y * -1;
            return y;
        }
    }

    class Michalewicz10 : Fonksiyon
    {
        public Michalewicz10() : base(10, 0, Math.PI, -9.660151715641349)
        {

        }
        override public double hesapla(List<Gen> genler)
        {
            double y = 0;
            for (int i = 0; i < genler.Count; i++)
                y = y + (Math.Sin(genler[i].genDeger) * Math.Pow(Math.Sin((i + 1) * Math.Pow(genler[i].genDeger, 2) / Math.PI), 20));
            y = y * -1;
            return y;
        }
    }
}
