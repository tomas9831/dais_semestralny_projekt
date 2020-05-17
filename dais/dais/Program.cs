using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dais.Database;
using dais.Database.dao;

namespace dais
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.dao.Database db = new Database.dao.Database();
            db.Connect();
            //planovane_lety
            /*Planovane_lety let = new Planovane_lety();
            let.povod = "berlin";
            let.destinacia = "helsinki";
            let.odlet = DateTime.Today;
            let.stav = "nacas";
            //1.1
            Planovane_letyTable.Insert(let, db);
            //1.2
            let.id_letu = 8;
            let.povod = "bratislava";
            let.destinacia = "budapest";
            let.odlet = DateTime.Today;
            let.stav = "nacas";
            Planovane_letyTable.Update(let,db);
            //1.3
            //Planovane_letyTable.Delete(let, db);
            //1.4
            Collection<Planovane_lety> letyC = Planovane_letyTable.Select(Planovane_letyTable.SQL_SELECT, db);
            foreach (var v in letyC)
            {
                Console.Write(v.id_letu);
                Console.Write(',');
                Console.Write(v.povod + ',');
                Console.Write(v.destinacia + ',');
                Console.Write(v.stav + ',');
                Console.WriteLine();
            }
            //1.5
            Console.WriteLine("detail");
            letyC = Planovane_letyTable.SelectDetail(let, db);
            foreach (var v in letyC)
            {
                Console.Write(v.id_letu);
                Console.Write(',');
                Console.Write(v.povod + ',');
                Console.Write(v.destinacia + ',');
                Console.Write(v.stav + ',');
                Console.WriteLine();
            }
            
            //evidencia typov ukolov
            //2.1
            Ukoly u = new Ukoly();
            u.id_zodpovedneho_oddielu = 2;
            u.nazov = "test";
            u.popis = "testPopis";

            UkolyTable.Insert(u, db);
            //2.2
            u.id_ukolu = 3;
            u.nazov = "test2";
            UkolyTable.Update(u, db);
            //2.3
            //UkolyTable.Delete(u, db);
            //2.4
            Collection<Ukoly> ukolyC = UkolyTable.Select(UkolyTable.SQL_SELECT, db);
            foreach (var v in ukolyC)
            {
                Console.Write(v.nazov + ',');
                Console.Write(v.popis);
                Console.WriteLine();
            }
            //2.5
            ukolyC = UkolyTable.SelectDetail(u, db);
            foreach (var v in ukolyC)
            {
                Console.Write(v.nazov + ',');
                Console.Write(v.popis);
                Console.WriteLine();
            }

            //pracovny_oddiel
            Pracovny_oddiel po = new Pracovny_oddiel();
            po.id_veduci = 2;
            po.nazov_oddielu = "test";
            //3.1
            Pracovny_oddielTable.Insert(po, db);
            //3.2
            po.id_oddielu = 4;
            po.nazov_oddielu = "test2";
            Pracovny_oddielTable.Update(po, db);
            //3.3
            //Pracovny_oddielTable.Delete(po, db);
            //3.4
            Collection<Pracovny_oddiel> pCollection = Pracovny_oddielTable.Select(Pracovny_oddielTable.SQL_SELECT, db);
            Console.WriteLine("zoznam oddielov");
            foreach (var v in pCollection)
            {
                
                Console.Write(v.nazov_oddielu + ',');
                Console.Write(v.id_veduci);
                Console.WriteLine();

            }
            //3.5
            pCollection = Pracovny_oddielTable.SelectDetail(po, db);
            Console.WriteLine("detail oddielu");
            foreach (var v in pCollection)
            {

                Console.Write(v.nazov_oddielu + ',');
                Console.Write(v.id_veduci);
                Console.WriteLine();

            }
            //Personal
            Personal p = new Personal();
            p.pid = "tes002";
            p.meno = "peter";
            p.priezvisko = "test";
            p.id_oddielu = 2;
            p.praceschopnost = "aktivny";
            //4.1
            PersonalTable.Insert(p, db);
            //4.2
            p.meno = "maros";
            PersonalTable.Update(p, db);
            //4.3
            //PersonalTable.Delete(p, db);
            //4.4
            Collection<Personal> personal = PersonalTable.SelectLetySoZamestnancami(1, db);
            Console.WriteLine("zoznam zamestnancov ktorý pracujú na lete s id 1");
            foreach (var person in personal)
            {
                Console.Write(person.pid+',');
                Console.Write(person.meno + ',');
                Console.Write(person.priezvisko + ',');
                Console.WriteLine();
            }
            //4.5
            Collection<Planovane_lety> lety = Planovane_letyTable.SelectLetyCount(db);
            Console.WriteLine("lety s počtom zamestnancov");
            foreach (var v in lety)
            {
                Console.Write(v.id_letu);
                Console.Write(',');
                Console.Write(v.povod + ',');
                Console.Write(v.destinacia + ',');
                Console.Write(v.stav + ',');
                Console.Write(v.count);
                Console.WriteLine();
            }
            //4.8
            personal = PersonalTable.Select(db);
            foreach (var person in personal)
            {
                Console.Write(person.pid + ',');
                Console.Write(person.meno + ',');
                Console.Write(person.priezvisko + ',');
                Console.WriteLine();
            }
            //4.7
            personal = PersonalTable.SelectDetail(p,db);
            foreach (var person in personal)
            {
                Console.Write(person.pid + ',');
                Console.Write(person.meno + ',');
                Console.Write(person.priezvisko + ',');
                Console.WriteLine();
            }
            //4.6
            PersonalTable.SelectSmenyPreZamestnaca(p, db);
            foreach (var person in personal)
            {
                Console.Write(person.pid + ',');
                Console.Write(person.meno + ',');
                Console.Write(person.priezvisko + ',');
                Console.WriteLine();
            }


            //5.1
            // dropdown menu UkolyTable.SelectByPid()
            //ZiadostiTable.ZiadostOSmenu("pet113", 1, DateTime.Today, 1, "testInfo", 3, db);
            
            Collection<Ziadosti> ziadosti = ZiadostiTable.Select(db);
            Console.WriteLine("zoznam žiadostí");
            foreach (var v in ziadosti)
            {
                Console.Write(v.id_zamestnanec + ',');
                Console.Write(v.id_ukolu);
                Console.Write(',');
                Console.Write(v.id_veduci);
                Console.Write(',');
                Console.Write(v.info + ',');
                Console.Write(v.akceptovane);
                Console.WriteLine();
            }
            //5.2
            //Vedúcemu sa zobrazí zoznam žiadostí určených pre neho
            Collection<Ziadosti> ziadostiV = ZiadostiTable.SelectVeduci(1, db);
            Console.WriteLine("zoznam žiadostí pre Vedúceho");
            foreach (var v in ziadostiV)
            {
                Console.Write(v.id_zamestnanec + ',');
                Console.Write(v.id_ukolu);
                Console.Write(',');
                Console.Write(v.id_veduci);
                Console.Write(',');
                Console.Write(v.info + ',');
                Console.Write(v.akceptovane);
                Console.WriteLine();
            }
            // tlačítkom akceptuje/ neakceptuje žiadosti
            //ZiadostiTable.UpdateSchvalena(...parametre)
            //akceptuje všetky potvrdené smeny
            //Pracovne_smenyTable.AkceptovanieSmien(db);
            //5.3
            Pracovne_smeny s = new Pracovne_smeny();
            s.id_letu = 2;
            s.datum = DateTime.Today;
            s.id_smeny = 2;
            s.smena = 1;
            s.pid = "jan673";
            s.id_typ_ukolu = 2;
            Pracovne_smenyTable.Insert(s, db);

            //6.1
            //Planovane_letyTable.AktualizujZrus("nemecko", "dovod", db);
            //7.1
            Veduci ved = new Veduci();
            ved.meno = "marcel";
            ved.priezvisko = "mindek";
            VeduciTable.Insert(ved, db);
            //7.2
            ved.id_veduci = 6;
            ved.meno = "marcel2";
            VeduciTable.Update(ved, db);
            //7.3
            //VeduciTable.Delete(ved, db);
            //7.4
            Collection < Veduci > veducis = VeduciTable.Select(db);
            foreach (var vv in veducis)
            {
                Console.Write(vv.id_veduci);
                Console.Write(',');
                Console.Write(vv.meno);
                Console.Write(vv.priezvisko);
                Console.WriteLine();
            }*/

            Console.ReadKey();
        }
    }
}
