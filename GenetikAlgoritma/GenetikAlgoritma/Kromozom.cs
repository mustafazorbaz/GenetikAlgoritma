using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenetikAlgoritma
{
    public class Kromozom
    {
        public List<Gen> listGenler; //Kromozomumuzdur.
        double uygunluk;
        public Kromozom()
        {
            listGenler = new List<Gen>();
        }
        public void setUygunluk(double deger)
        {
            this.uygunluk=deger;
        }
        public double getUygunluk()
        {
            return uygunluk;
        }

        public void genEkle(Gen gen)
        {
            listGenler.Add(gen);
        }
        public List<Gen> kromozomListeGet()
        {
            return listGenler;
        }
        public Kromozom getKromozom()
        {
           
            return this;
        }
      
    }
}
