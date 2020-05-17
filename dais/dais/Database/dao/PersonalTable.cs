using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dais.Database.dao
{
    public class PersonalTable
    {
        public static String TABLE_NAME = "personal";
        public static String SQL_INSERT = "INSERT INTO " + TABLE_NAME + " VALUES (@pid,@meno," + "@priezvisko,@id_oddielu,@praceschopnost)";
        public static String SQL_SELECT = "SELECT * FROM " + TABLE_NAME;
        public static String SQL_DELETE_ID = "DELETE FROM " + TABLE_NAME + " WHERE pid=@pid";

        public static String  SQL_SELECT_ZAMESTNANCI =
            "SELECT p.pid, p.meno, p.priezvisko, p.id_oddielu, p.praceschopnost FROM planovane_lety as pl " +
            "INNER JOIN  pracovne_smeny as pz on pz.id_letu = pl.id_letu " +
            "INNER JOIN personal as p on p.pid = pz.pid " +
            "WHERE pl.id_letu = @id_letu ";
        public static String SQL_UPDATE = "UPDATE " + TABLE_NAME + " SET pid = @pid, meno = @meno," 
                                          + "priezvisko = @priezvisko,id_oddielu = @id_oddielu, " +
                                          "praceschopnost = @praceschopnost WHERE pid=@pid";
        public static String SQL_DETAIL = "SELECT * FROM " + TABLE_NAME + " WHERE pid=@pid";

        public static String SQL_SMENY_PRE_ZAMESTNANCA = "select * from pracovne_smeny as ps " +
                                                         "inner join personal as p on p.pid = ps.pid " +
                                                         "where p.pid = @pid";


        public static int Insert(Personal personal, Database pDb)
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
            PrepareCommand(command, personal);
            int ret = db.ExecuteNonQuery(command);

            if (pDb == null)
            {
                db.Close();
            }

            return ret;

        }
        public static int Update(Personal p, Database pDb)
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
            PrepareCommand(command, p);
            int ret = db.ExecuteNonQuery(command);

            if (pDb == null)
            {
                db.Close();
            }

            return ret;
        }
        public static int Delete(Personal p, Database pDb)
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
            PrepareCommand(command, p);
            int ret = db.ExecuteNonQuery(command);

            if (pDb == null)
            {
                db.Close();
            }

            return ret;
        }
        public static Collection<Personal> Select(Database pDb = null)
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

            Collection<Personal> personal = Read(reader);
            reader.Close();

            if (pDb == null)
            {
                db.Close();
            }

            return personal;
        }
        public static Collection<Personal> SelectDetail(Personal p, Database pDb = null)
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
            PrepareCommand(command, p);
            SqlDataReader reader = db.Select(command);

            Collection<Personal> personal = Read(reader);
            reader.Close();

            if (pDb == null)
            {
                db.Close();
            }

            return personal;
        }
        public static Collection<Personal> SelectSmenyPreZamestnaca(Personal p, Database pDb = null)
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

            SqlCommand command = db.CreateCommand(SQL_SMENY_PRE_ZAMESTNANCA);
            PrepareCommand(command, p);
            SqlDataReader reader = db.Select(command);

            Collection<Personal> personal = Read(reader);
            reader.Close();

            if (pDb == null)
            {
                db.Close();
            }

            return personal;
        }
        public static Collection<Personal> SelectLetySoZamestnancami(int id_letu, Database pDb = null)
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

            SqlCommand command = db.CreateCommand(SQL_SELECT_ZAMESTNANCI);
            command.Parameters.AddWithValue("@id_letu", id_letu);
            SqlDataReader reader = db.Select(command);

            Collection<Personal> personal = Read(reader);
            reader.Close();

            if (pDb == null)
            {
                db.Close();
            }

            return personal;
        }


        private static void PrepareCommand(SqlCommand command, Personal personal)
        {
            command.Parameters.AddWithValue("@pid", personal.pid);
            command.Parameters.AddWithValue("@meno", personal.meno);
            command.Parameters.AddWithValue("@priezvisko", personal.priezvisko);
            command.Parameters.AddWithValue("@id_oddielu", personal.id_oddielu);
            command.Parameters.AddWithValue("@praceschopnost", personal.praceschopnost);

        }

        private static Collection<Personal> Read(SqlDataReader reader)
        {
            Collection<Personal> personalCollection = new Collection<Personal>();

            while (reader.Read())
            {
                int i = -1;
                Personal zamestnanec = new Personal();
                zamestnanec.pid = reader.GetString(++i);
                zamestnanec.meno = reader.GetString(++i);
                zamestnanec.priezvisko = reader.GetString(++i);
                zamestnanec.id_oddielu = reader.GetInt32(++i);
                zamestnanec.praceschopnost = reader.GetString(++i);

                personalCollection.Add(zamestnanec);
            }
            return personalCollection;
        }
    }
}

