using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dais.Database.dao
{
    public class Pracovne_smenyTable
    {
        public static String TABLE_NAME = "pracovne_smeny";
        public static String SQL_INSERT = "INSERT INTO " + TABLE_NAME + " VALUES (@id_typ_ukolu,@id_letu," +
                                          "@pid,@datum,@smena)";
        public static String SQL_SELECT = "SELECT * FROM " + TABLE_NAME;
        public static String SQL_DELETE_ID = "DELETE FROM " + TABLE_NAME + " WHERE id_smeny=@id_smeny";

        public static String SQL_SELECT_SMENY_PRE_ZAMESTNANCA =
            "SELECT id_smeny, id_typ_ukolu, id_letu, p.pid, datum, smena " +
            "FROM pracovne_smeny as PS INNER JOIN personal as P " +
            "on ps.pid = p.pid where p.pid = @pid";

        public static String SQL_UPDATE = "UPDATE " + TABLE_NAME + " SET id_typ_ukolu = @id_typ_ukolu,id_letu = @id_letu," +
                                          "pid = @pid,datum = @datum,smena = @smena WHERE id_smeny=@id_smeny";

        public static int Insert(Pracovne_smeny smeny, Database pDb)
        {
            Database db;
            if (pDb == null)
            {
                db = new Database();
                db.Connect();
            }
            else
            {
                db = pDb;
            }

            SqlCommand command = db.CreateCommand(SQL_INSERT);
            PrepareCommand(command, smeny);
            int ret = db.ExecuteNonQuery(command);

            if (pDb == null)
            {
                db.Close();
            }

            return ret;

        }
        public static Collection<Pracovne_smeny> Select(Database pDb = null)
        {
            Database db;
            if (pDb == null)
            {
                db = new Database();
                db.Connect();
            }
            else
            {
                db = (Database)pDb;
            }

            SqlCommand command = db.CreateCommand(SQL_SELECT);
            SqlDataReader reader = db.Select(command);

            Collection<Pracovne_smeny> smeny = Read(reader);
            reader.Close();

            if (pDb == null)
            {
                db.Close();
            }

            return smeny;
        }
        public static Collection<Pracovne_smeny> SelectSmenyPreZamestnanca(String pid, Database pDb = null)
        {
            Database db;
            if (pDb == null)
            {
                db = new Database();
                db.Connect();
            }
            else
            {
                db = (Database)pDb;
            }

            SqlCommand command = db.CreateCommand(SQL_SELECT_SMENY_PRE_ZAMESTNANCA);
            command.Parameters.AddWithValue("@pid", pid);
            SqlDataReader reader = db.Select(command);

            Collection<Pracovne_smeny> smeny = Read(reader);
            reader.Close();

            if (pDb == null)
            {
                db.Close();
            }

            return smeny;
        }
        private static void PrepareCommand(SqlCommand command, Pracovne_smeny smeny)
        {
            command.Parameters.AddWithValue("@id_smeny", smeny.id_smeny);
            command.Parameters.AddWithValue("@id_typ_ukolu", smeny.id_typ_ukolu);
            command.Parameters.AddWithValue("@id_letu", smeny.id_letu);
            command.Parameters.AddWithValue("@pid", smeny.pid);
            command.Parameters.AddWithValue("@datum", smeny.datum);
            command.Parameters.AddWithValue("@smena", smeny.smena);

        }

        private static Collection<Pracovne_smeny> Read(SqlDataReader reader)
        {
            Collection<Pracovne_smeny> smeny = new Collection<Pracovne_smeny>();

            while (reader.Read())
            {
                int i = -1;
                Pracovne_smeny smena = new Pracovne_smeny();
                smena.id_smeny = reader.GetInt32(++i);
                smena.id_typ_ukolu = reader.GetInt32(++i);
                smena.id_letu = reader.GetInt32(++i);
                smena.pid = reader.GetString(++i);
                smena.datum = reader.GetDateTime(++i);
                smena.smena = reader.GetInt32(++i);

                smeny.Add(smena);
            }
            return smeny;
        }
        public static bool AkceptovanieSmien( Database pDb)
        {
            Database db;
            if (pDb == null)
            {
                db = new Database();
                db.Connect();
            }
            else
            {
                db = (Database)pDb;
            }

            // 1.  create a command object identifying the stored procedure
            SqlCommand command = db.CreateCommand("AkceptovanieSmien");

            // 2. set the command object so it knows to execute a stored procedure
            command.CommandType = CommandType.StoredProcedure;

            // 4. execute procedure
            int ret = db.ExecuteNonQuery(command);

            if (pDb == null)
            {
                db.Close();
            }
            return true;
        }
    }
}
