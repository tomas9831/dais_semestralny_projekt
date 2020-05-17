using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dais.Database
{
    public class Planovane_lety
    {
        public int id_letu { get; set; }
        public string povod { get; set; }
        public string destinacia { get; set; }
        public DateTime odlet { get; set; }
        public string stav { get; set; }
        //pomocna premenna
        public int count { get; set; }

    }
}
