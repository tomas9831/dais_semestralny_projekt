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
    public class Planovane_letyTable
    {
        public static String TABLE_NAME = "planovane_lety";
        public static String SQL_INSERT = "INSERT INTO " + TABLE_NAME + " VALUES (@povod,@destinacia," + "@odlet,@stav)";
        public static String SQL_SELECT = "SELECT * FROM " + TABLE_NAME;
        public static String SQL_DELETE_ID = "DELETE FROM " + TABLE_NAME + " WHERE id_letu=@id_letu";

        public static String SQL_SELECT_LETY_COUNT = "SELECT pl.id_letu, povod, destinacia, odlet, stav, COUNT(pz.pid) AS pocet_pracovnikov " +
                                                     "FROM planovane_lety as pl" +
                                                     " INNER JOIN pracovne_smeny as pz on pz.id_letu = pl.id_letu " +
                                                     "GROUP BY pz.pid, pl.id_letu, pl.povod, pl.destinacia, pl.odlet, pl.stav " +
                                                     "ORDER BY pocet_pracovnikov DESC ";

        public static String SQL_DETAIL = "SELECT * FROM " + TABLE_NAME + " WHERE id_letu=@id_letu";

        public static String SQL_UPDATE = "UPDATE " + TABLE_NAME + " SET povod = @povod, destinacia = @destinacia,"
                                          + "odlet = @odlet, stav = @stav  WHERE id_letu=@id_letu";

        public static int Insert(Planovane_lety lety, Database pDb)
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
            PrepareCommand(command, lety);
            int ret = db.ExecuteNonQuery(command);

            if (pDb == null)
            {
                db.Close();
            }

            return ret;

        }
        public static int Update(Planovane_lety lety, Database pDb)
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

            SqlCommand command = db.CreateCommand(SQL_UPDATE);
            PrepareCommand(command, lety);
            int ret = db.ExecuteNonQuery(command);

            if (pDb == null)
            {
                db.Close();
            }

            return ret;
        }
        public static int Delete(Planovane_lety lety, Database pDb)
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

            SqlCommand command = db.CreateCommand(SQL_DELETE_ID);
            PrepareCommand(command, lety);
            int ret = db.ExecuteNonQuery(command);

            if (pDb == null)
            {
                db.Close();
            }

            return ret;
        }

        public static Collection<Planovane_lety> Select(String SELECT, Database pDb = null)
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

            SqlCommand command = db.CreateCommand(SELECT);
            SqlDataReader reader = db.Select(command);
            Collection<Planovane_lety> lety = Read(reader);

            reader.Close();

            if (pDb == null)
            {
                db.Close();
            }

            return lety;
        }
        public static Collection<Planovane_lety> SelectDetail(Planovane_lety let, Database pDb = null)
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

            SqlCommand command = db.CreateCommand(SQL_DETAIL);
            PrepareCommand(command, let);
            SqlDataReader reader = db.Select(command);
            Collection<Planovane_lety> lety = Read(reader);

            reader.Close();

            if (pDb == null)
            {
                db.Close();
            }

            return lety;
        }
        public static Collection<Planovane_lety> SelectLetyCount(Database pDb = null)
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

            SqlCommand command = db.CreateCommand(SQL_SELECT_LETY_COUNT);
            SqlDataReader reader = db.Select(command);

            Collection<Planovane_lety> lety = ReadCountZamestnanci(reader);
            reader.Close();

            if (pDb == null)
            {
                db.Close();
            }

            return lety;
        }
        private static void PrepareCommand(SqlCommand command, Planovane_lety lety)
        {
            command.Parameters.AddWithValue("@id_letu", lety.id_letu);
            command.Parameters.AddWithValue("@povod", lety.povod);
            command.Parameters.AddWithValue("@destinacia", lety.destinacia);
            command.Parameters.AddWithValue("@odlet", lety.odlet);
            command.Parameters.AddWithValue("@stav", lety.stav);

        }

        private static Collection<Planovane_lety> Read(SqlDataReader reader)
        {
            Collection<Planovane_lety> lety = new Collection<Planovane_lety>();

            while (reader.Read())
            {
                int i = -1;
                Planovane_lety let = new Planovane_lety();
                let.id_letu = reader.GetInt32(++i);
                let.povod = reader.GetString(++i);
                let.destinacia = reader.GetString(++i);
                let.odlet = reader.GetDateTime(++i);
                let.stav = reader.GetString(++i);

                lety.Add(let);
            }
            return lety;
        }

        private static Collection<Planovane_lety> ReadCountZamestnanci(SqlDataReader reader)
        {
            Collection<Planovane_lety> lety = new Collection<Planovane_lety>();

            while (reader.Read())
            {
                int i = -1;
                Planovane_lety let = new Planovane_lety();
                let.id_letu = reader.GetInt32(++i);
                let.povod = reader.GetString(++i);
                let.destinacia = reader.GetString(++i);
                let.odlet = reader.GetDateTime(++i);
                let.stav = reader.GetString(++i);
                let.count = reader.GetInt32(++i);

                lety.Add(let);
            }
            return lety;
        }

        public static bool AktualizujZrus(String p_stat, String p_dovod, Database pDb)
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
            SqlCommand command = db.CreateCommand("AktualizujZrus");

            // 2. set the command object so it knows to execute a stored procedure
            command.CommandType = CommandType.StoredProcedure;

            // Stat arg
            SqlParameter iStat = new SqlParameter();
            iStat.ParameterName = "@p_stat";
            iStat.DbType = DbType.String;
            iStat.Value = p_stat;
            iStat.Direction = ParameterDirection.Input;
            command.Parameters.Add(iStat);
            // Dovod arg
            SqlParameter iDovod = new SqlParameter();
            iDovod.ParameterName = "@p_dovod";
            iDovod.DbType = DbType.String;
            iDovod.Value = p_dovod;
            iDovod.Direction = ParameterDirection.Input;
            command.Parameters.Add(iDovod);

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

