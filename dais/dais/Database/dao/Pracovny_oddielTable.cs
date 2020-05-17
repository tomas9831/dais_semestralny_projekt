using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dais.Database.dao
{
    public class Pracovny_oddielTable
    {
        public static String TABLE_NAME = "Pracovny_oddiel";

        public static String SQL_INSERT = "INSERT INTO " + TABLE_NAME + " VALUES (@nazov_oddielu,@id_veduci)";

        public static String SQL_SELECT = "SELECT * FROM " + TABLE_NAME;

        public static String SQL_DELETE_ID = "DELETE FROM " + TABLE_NAME + " WHERE id_oddielu=@id_oddielu";

        public static String SQL_DETAIL = "SELECT * FROM " + TABLE_NAME + " WHERE id_oddielu=@id_oddielu";

        public static String SQL_UPDATE = "UPDATE " + TABLE_NAME + " SET nazov_oddielu = @nazov_oddielu," +
                                          "id_veduci =@id_veduci WHERE id_oddielu=@id_oddielu";

        public static int Insert(Pracovny_oddiel oddiel, Database pDb)
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
            PrepareCommand(command, oddiel);
            int ret = db.ExecuteNonQuery(command);

            if (pDb == null)
            {
                db.Close();
            }

            return ret;

        }
        public static int Update(Pracovny_oddiel oddiel, Database pDb)
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
            PrepareCommand(command, oddiel);
            int ret = db.ExecuteNonQuery(command);

            if (pDb == null)
            {
                db.Close();
            }

            return ret;
        }
        public static int Delete(Pracovny_oddiel oddiel, Database pDb)
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
            PrepareCommand(command, oddiel);
            int ret = db.ExecuteNonQuery(command);

            if (pDb == null)
            {
                db.Close();
            }

            return ret;
        }
        public static Collection<Pracovny_oddiel> Select(String SELECT, Database pDb = null)
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

            Collection<Pracovny_oddiel> oddiely = Read(reader);
            reader.Close();

            if (pDb == null)
            {
                db.Close();
            }

            return oddiely;
        }
        public static Collection<Pracovny_oddiel> SelectDetail(Pracovny_oddiel po, Database pDb = null)
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
            PrepareCommand(command, po);
            SqlDataReader reader = db.Select(command);

            Collection<Pracovny_oddiel> oddiely = Read(reader);
            reader.Close();

            if (pDb == null)
            {
                db.Close();
            }

            return oddiely;
        }
        private static void PrepareCommand(SqlCommand command, Pracovny_oddiel oddiely)
        {
            command.Parameters.AddWithValue("@id_oddielu", oddiely.id_oddielu);
            command.Parameters.AddWithValue("@nazov_oddielu", oddiely.nazov_oddielu);
            command.Parameters.AddWithValue("@id_veduci", oddiely.id_veduci);

        }

        private static Collection<Pracovny_oddiel> Read(SqlDataReader reader)
        {
            Collection<Pracovny_oddiel> oddiely = new Collection<Pracovny_oddiel>();

            while (reader.Read())
            {
                int i = -1;
                Pracovny_oddiel oddiel = new Pracovny_oddiel();
                oddiel.id_oddielu = reader.GetInt32(++i);
                oddiel.nazov_oddielu = reader.GetString(++i);
                oddiel.id_veduci = reader.GetInt32(++i);

                oddiely.Add(oddiel);
            }
            return oddiely;
        }
    }
}
