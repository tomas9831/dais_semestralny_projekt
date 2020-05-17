using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dais.Database
{
    public class Ziadosti
    {
        public int id_ziadost { get; set; }
        public String id_zamestnanec { get; set; }
        public int id_veduci { get; set; }
        public int id_ukolu { get; set; }
        public int id_letu { get; set; }
        public int akceptovane { get; set; }
        public string info { get; set; }
        public DateTime pozadovany_datum { get; set; }
        public int pozadovana_smena { get; set; }
    }
}
