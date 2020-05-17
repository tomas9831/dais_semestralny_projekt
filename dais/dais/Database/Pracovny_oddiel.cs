using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dais.Database
{
    public class Pracovny_oddiel
    {
        public int id_oddielu { get; set; }
        public string nazov_oddielu { get; set; }
        public int id_veduci { get; set; }
    }
}
