using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dais.Database
{
    public class Ukoly
    {
        public int id_ukolu { get; set; }
        public int id_zodpovedneho_oddielu { get; set; }
        public string nazov { get; set; }
        public string popis { get; set; }
        
    }
}
