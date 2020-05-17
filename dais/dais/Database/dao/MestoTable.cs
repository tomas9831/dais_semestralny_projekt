using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dais.Database.dao
{
    public class MestoTable
    {
        public static String TABLE_NAME = "mesto";

        public static String SQL_INSERT = "INSERT INTO " + TABLE_NAME +" VALUES (@mesto,@stat,@eu)";

        public static String SQL_SELECT = "SELECT * FROM " + TABLE_NAME;

        public static String SQL_DELETE_ID = "DELETE FROM " + TABLE_NAME + " WHERE mesto=@mesto";

        public static int Insert(Mesto mesto, Database pDb)
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
            PrepareCommand(command, mesto);
            int ret = db.ExecuteNonQuery(command);

            if (pDb == null)
            {
                db.Close();
            }

            return ret;

        }
        public static Collection<Mesto> Select(Database pDb = null)
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

            Collection<Mesto> mesta = Read(reader);
            reader.Close();

            if (pDb == null)
            {
                db.Close();
            }

            return mesta;
        }
        private static void PrepareCommand(SqlCommand command, Mesto mesta)
        {
            command.Parameters.AddWithValue("@mesto", mesta.mesto);
            command.Parameters.AddWithValue("@stat", mesta.stat);
            command.Parameters.AddWithValue("@eu", mesta.eu);

        }

        private static Collection<Mesto> Read(SqlDataReader reader)
        {
            Collection<Mesto> mesta = new Collection<Mesto>();

            while (reader.Read())
            {
                int i = -1;
                Mesto mesto = new Mesto();
                mesto.mesto = reader.GetString(++i);
                mesto.stat = reader.GetString(++i);
                mesto.eu = reader.GetString(++i);

                mesta.Add(mesto);
            }
            return mesta;
        }
    }
}

