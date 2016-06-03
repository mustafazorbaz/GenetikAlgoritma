using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenetikAlgoritma
{
   public class Gen :ICloneable
    {

        public double genDeger;
     
       public Gen()
        {
            
        }

       public Gen(double p)
       {
           // TODO: Complete member initialization
           this.genDeger = p;
       }

       public double genOlustur(Form1 frm,string benchmarkProblem)
        {

            double deger = frm.rand.NextDouble() * (frm.fonksiyon.getUstSinir() * 2) - (frm.fonksiyon.getUstSinir()); 
                return deger;
          

           
        }
        public object Clone()
        {
            return new Gen(this.genDeger);
        } 






   
    }
}
