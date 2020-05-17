using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dais.Database
{
    public class Pracovne_smeny
    {
        public int id_smeny { get; set; }
        public int id_typ_ukolu { get; set; }
        public int id_letu { get; set; }
        public String pid { get; set; }
        public DateTime datum { get; set; }
        public int smena { get; set; }
    }
}
