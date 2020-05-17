using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dais.Database.dao
{
    public class VeduciTable
    {
        public static String TABLE_NAME = "veduci";

        public static String SQL_INSERT = "INSERT INTO Veduci VALUES (@meno, @priezvisko)";

        public static String SQL_SELECT = "SELECT * FROM veduci";

        public static String SQL_DELETE_ID = "DELETE FROM veduci WHERE id_veduci=@id_veduci";

        public static String SQL_UPDATE = "UPDATE " + TABLE_NAME + " SET meno = @meno, priezvisko = @priezvisko " +
                                          "WHERE id_veduci=@id_veduci";

        public static int Insert(Veduci veduci, Database pDb)
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
            PrepareCommand(command, veduci);
            int ret = db.ExecuteNonQuery(command);

            if (pDb == null)
            {
                db.Close();
            }

            return ret;
        }
        public static int Update(Veduci v, Database pDb)
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
            PrepareCommand(command, v);
            int ret = db.ExecuteNonQuery(command);

            if (pDb == null)
            {
                db.Close();
            }

            return ret;
        }
        public static int Delete(Veduci v, Database pDb)
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
            PrepareCommand(command, v);
            int ret = db.ExecuteNonQuery(command);

            if (pDb == null)
            {
                db.Close();
            }

            return ret;
        }
        public static Collection<Veduci> Select(Database pDb = null)
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

            Collection<Veduci> veduciCollection = Read(reader);
            reader.Close();

            if (pDb == null)
            {
                db.Close();
            }

            return veduciCollection;
        }
        private static void PrepareCommand(SqlCommand command, Veduci veduci)
        {
            command.Parameters.AddWithValue("@id_veduci", veduci.id_veduci);
            command.Parameters.AddWithValue("@meno", veduci.meno);
            command.Parameters.AddWithValue("@priezvisko", veduci.priezvisko);

        }

        private static Collection<Veduci> Read(SqlDataReader reader)
        {
            Collection<Veduci> veduciCollection = new Collection<Veduci>();

            while (reader.Read())
            {
                int i = -1;
                Veduci veduci = new Veduci();
                veduci.id_veduci = reader.GetInt32(++i);
                veduci.meno = reader.GetString(++i);
                veduci.priezvisko = reader.GetString(++i);

                veduciCollection.Add(veduci);
            }
            return veduciCollection;
        }
    }
}
