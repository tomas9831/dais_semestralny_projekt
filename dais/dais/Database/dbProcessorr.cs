using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using dais.Database.dao;

namespace dais.Database
{
    public class dbProcessorr
    {
        private static dao.Database db;
        public static int CreateZamestnanec(string ppid, string pmeno, string ppriezvisko, int poddiel, string ppraceschopnost)
        {
            db = new dao.Database();
            db.Connect();
            Personal p = new Personal()
            {
                pid = ppid,
                meno = pmeno,
                priezvisko = ppriezvisko,
                id_oddielu = poddiel,
                praceschopnost = ppraceschopnost,
            };
            int v = PersonalTable.Insert(p, db);
            db.Close();
            return v;
        }
        public static Collection<Personal> GetAllResults()
        {
            db = new dao.Database();
            db.Connect();
            Collection < Personal > coll = PersonalTable.Select(db);
            db.Close();
            return coll;
        }
        public static Collection<Pracovny_oddiel> GetAllOddieli()
        {
            db = new dao.Database();
            db.Connect();
            Collection<Pracovny_oddiel> coll = Pracovny_oddielTable.Select(Pracovny_oddielTable.SQL_SELECT, db);
            db.Close();
            return coll;
        }

        public static int RemoveEmployee(Personal p)
        {
            db = new dao.Database();
            db.Connect();
            int res = PersonalTable.Delete(p,db);
            db.Close();
            return res;
        }
        public static int EditEmployee(Personal p)
        {
            db = new dao.Database();
            db.Connect();
            int res = PersonalTable.Update(p, db);
            db.Close();
            return res;
        }
        public static Collection<Pracovne_smeny> getSmenyPreZamestnanca(String pid)
        {
            db = new dao.Database();
            db.Connect();
            Collection<Pracovne_smeny> coll = Pracovne_smenyTable.SelectSmenyPreZamestnanca(pid, db);
            db.Close();
            return coll;
        }
        public static Collection<Personal> getZamestnanciNaLet(int id )
        {
            db = new dao.Database();
            db.Connect();
            Collection<Personal> coll = PersonalTable.SelectLetySoZamestnancami(id, db);
            db.Close();
            return coll;
        }
        public static Collection<Planovane_lety> getLety()
        {
            db = new dao.Database();
            db.Connect();
            Collection<Planovane_lety> coll = Planovane_letyTable.Select(Planovane_letyTable.SQL_SELECT, db);
            db.Close();
            return coll;
        }
    }
}
