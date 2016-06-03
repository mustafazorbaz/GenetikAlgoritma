using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenetikAlgoritma
{
    public class Populasyon 
    {
        public List<Kromozom> listKromozomlar;
        public Populasyon()
        {
            listKromozomlar = new List<Kromozom>();
        }
        public List<Kromozom> getListPopulasyon()
        {
            return listKromozomlar;
        }
      

      
    }
}  
