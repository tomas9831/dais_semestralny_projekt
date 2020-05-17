using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dais.Database.dao
{
    public class UkolyTable
    {
        public static String TABLE_NAME = "Ukoly";

        public static String SQL_INSERT = "INSERT INTO " + TABLE_NAME + " VALUES (@id_zodpovedneho_oddielu,@nazov,@popis)";

        public static String SQL_SELECT = "SELECT * FROM " + TABLE_NAME;

        public static String SQL_DELETE_ID = "DELETE FROM " + TABLE_NAME + " WHERE id_ukolu=@id_ukolu";
        //dropdown menu z funkcie 5.1
        public static String SQL_SELECT_DROPDOWN = "SELECT u.id_ukolu, u.nazov, u.popis FROM ukoly AS u " +
                                                   "INNER JOIN pracovny_oddiel AS po " +
                                                   "ON u.id_zodpovedneho_oddielu = po.id_oddielu " +
                                                   "INNER JOIN personal as p " +
                                                   "ON p.id_oddielu = po.id_oddielu WHERE p.pid = @p_pid";

        public static String SQL_DETAIL = "SELECT * FROM " + TABLE_NAME + " WHERE id_ukolu=@id_ukolu";
        public static String SQL_UPDATE = "UPDATE " + TABLE_NAME + " SET id_zodpovedneho_oddielu = @id_zodpovedneho_oddielu," +
                                          "nazov = @nazov, popis = @popis  WHERE id_ukolu=@id_ukolu";

        public static int Insert(Ukoly ukoly, Database pDb)
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
            PrepareCommand(command, ukoly);
            int ret = db.ExecuteNonQuery(command);

            if (pDb == null)
            {
                db.Close();
            }

            return ret;

        }
        public static int Update(Ukoly ukoly, Database pDb)
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
            PrepareCommand(command, ukoly);
            int ret = db.ExecuteNonQuery(command);

            if (pDb == null)
            {
                db.Close();
            }

            return ret;
        }
        public static int Delete(Ukoly ukoly, Database pDb)
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
            PrepareCommand(command, ukoly);
            int ret = db.ExecuteNonQuery(command);

            if (pDb == null)
            {
                db.Close();
            }

            return ret;
        }
        public static Collection<Ukoly> Select(String SELECT, Database pDb = null)
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

            Collection<Ukoly> ukoly = Read(reader);
            reader.Close();

            if (pDb == null)
            {
                db.Close();
            }

            return ukoly;
        }
        public static Collection<Ukoly> SelectDetail(Ukoly u, Database pDb = null)
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
            PrepareCommand(command, u);
            SqlDataReader reader = db.Select(command);

            Collection<Ukoly> ukoly = Read(reader);
            reader.Close();

            if (pDb == null)
            {
                db.Close();
            }

            return ukoly;
        }
        public static Collection<Ukoly> SelectByPid(String pid, Database pDb = null)
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

            SqlCommand command = db.CreateCommand(SQL_SELECT_DROPDOWN);
            command.Parameters.AddWithValue("@p_pid", pid);
            SqlDataReader reader = db.Select(command);

            Collection<Ukoly> ukoly = Read(reader);
            reader.Close();

            if (pDb == null)
            {
                db.Close();
            }

            return ukoly;
        }
        private static void PrepareCommand(SqlCommand command, Ukoly ukoly)
        {
            command.Parameters.AddWithValue("@id_ukolu", ukoly.id_ukolu);
            command.Parameters.AddWithValue("@id_zodpovedneho_oddielu", ukoly.id_zodpovedneho_oddielu);
            command.Parameters.AddWithValue("@nazov", ukoly.nazov);
            command.Parameters.AddWithValue("@popis", ukoly.popis);

        }

        private static Collection<Ukoly> Read(SqlDataReader reader)
        {
            Collection<Ukoly> ukoly = new Collection<Ukoly>();

            while (reader.Read())
            {
                int i = -1;
                Ukoly ukol = new Ukoly();
                ukol.id_ukolu = reader.GetInt32(++i);
                ukol.id_zodpovedneho_oddielu = reader.GetInt32(++i);
                ukol.nazov = reader.GetString(++i);
                ukol.popis = reader.GetString(++i);

                ukoly.Add(ukol);
            }
            return ukoly;
        }
    }
}
