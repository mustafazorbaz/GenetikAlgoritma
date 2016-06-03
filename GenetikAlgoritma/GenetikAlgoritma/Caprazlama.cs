using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenetikAlgoritma
{
    public class Caprazlama
    {
        
        int indis;
        Form1 form;
        public Caprazlama(int deger,Form1 form)
        {
            this.form = form;
            this.indis = deger;
        }
     


        public Kromozom fonkCarprazlamaKrm(Kromozom krm1, Kromozom krm2)
        {
          
            Kromozom kromozom = new Kromozom();
            kromozom.listGenler.Add(krm1.listGenler[indis]);
            for (int i = 0; i < krm1.listGenler.Count; i++)
            {
                if (i == indis)
                    continue;
                  kromozom.listGenler.Add(krm2.listGenler[i]);
                if (kromozom.listGenler.Count == krm2.listGenler.Count)
                    break;
              
               
            }
            return kromozom;
          
        }        
      
    }
}
