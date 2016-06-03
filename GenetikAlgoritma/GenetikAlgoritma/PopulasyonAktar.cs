using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenetikAlgoritma
{
    public class PopulasyonAktar
    {
        public Populasyon yeniPopulasyon = new Populasyon();
        public Populasyon eskiPopulasyon = new Populasyon();
        public PopulasyonAktar(Populasyon populasyon)
        {
            this.eskiPopulasyon = populasyon;
        }
        public void aktar()
        {
            for (int i = 0; i < eskiPopulasyon.listKromozomlar.Count; i++)
            {
                Kromozom kromozom = new Kromozom();
                for (int j = 0; j < eskiPopulasyon.listKromozomlar[i].listGenler.Count; j++)//Gen sayısı kadar
                {
                    Gen gen = new Gen();
                    gen.genDeger = eskiPopulasyon.listKromozomlar[i].listGenler[j].genDeger;
                    kromozom.listGenler.Add(gen);
                   
                }
                kromozom.setUygunluk(eskiPopulasyon.listKromozomlar[i].getUygunluk());
                yeniPopulasyon.listKromozomlar.Add(kromozom);
            }
        }
        public Populasyon getPopulasyon()
        {
            return yeniPopulasyon;
        }
        public void setAktar()
        {
            yeniPopulasyon = eskiPopulasyon;
        }
    }
}
