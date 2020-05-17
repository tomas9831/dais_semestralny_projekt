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
    public class ZiadostiTable
    {
        public static String TABLE_NAME = "ziadosti";

        public static String SQL_INSERT = "INSERT INTO " + TABLE_NAME + " VALUES (@id_zamestnanec,@id_veduci,@id_ukolu," +
                                          "@id_letu,@akceptovane,@info,@pozadovany_datum,@pozadovana_smena)";

        public static String SQL_SELECT = "SELECT * FROM " + TABLE_NAME;
        public static String SQL_DELETE_ID = "DELETE FROM " + TABLE_NAME + " WHERE id_ziadost=@id_ziadost";
        public static String SQL_UPDATE_SCHVALENA = "UPDATE ziadosti SET akceptovane = 1 WHERE id_ziadost  = v_id_ziadost_schvalena";
        public static String SQL_UPDATE_NESCHVALENA = "UPDATE ziadosti SET akceptovane = 0 WHERE id_ziadost  = v_id_ziadost_neschvalena";

        public static String SQL_SELECT_ZIADOSTI_VEDUCI =
            "SELECT  id_ziadost, id_zamestnanec, z.id_veduci, id_ukolu, id_letu, akceptovane, info, " +
            "pozadovany_datum, pozadovana_smena FROM ZIADOSTI AS z " +
            "INNER JOIN personal as p ON p.pid = z.id_zamestnanec " +
            "INNER JOIN pracovny_oddiel AS po ON po.id_oddielu = p.id_oddielu " +
            "WHERE po.id_veduci = @p_id_veduci";


        public static int Insert(Ziadosti ziadosti, Database pDb)
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
            PrepareCommand(command, ziadosti);
            int ret = db.ExecuteNonQuery(command);

            if (pDb == null)
            {
                db.Close();
            }

            return ret;

        }
        public static int UpdateSchvalena(Ziadosti ziadosti,int v_id_ziadost_schvalena, Database pDb)
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

            SqlCommand command = db.CreateCommand(SQL_UPDATE_SCHVALENA);
            command.Parameters.AddWithValue("v_id_ziadost_schvalena", v_id_ziadost_schvalena);
            PrepareCommand(command, ziadosti);
            int ret = db.ExecuteNonQuery(command);

            if (pDb == null)
            {
                db.Close();
            }

            return ret;

        }
        public static int UpdateNeschvalena(Ziadosti ziadosti, int v_id_ziadost_neschvalena, Database pDb)
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

            SqlCommand command = db.CreateCommand(SQL_UPDATE_SCHVALENA);
            command.Parameters.AddWithValue("v_id_ziadost_neschvalena", v_id_ziadost_neschvalena);
            PrepareCommand(command, ziadosti);
            int ret = db.ExecuteNonQuery(command);

            if (pDb == null)
            {
                db.Close();
            }

            return ret;

        }
        public static Collection<Ziadosti> Select(Database pDb = null)
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

            Collection<Ziadosti> ziadosti = Read(reader);
            reader.Close();

            if (pDb == null)
            {
                db.Close();
            }

            return ziadosti;
        }
        public static Collection<Ziadosti> SelectVeduci(int id_veduci, Database pDb = null)
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

            SqlCommand command = db.CreateCommand(SQL_SELECT_ZIADOSTI_VEDUCI);
            command.Parameters.AddWithValue("@p_id_veduci", id_veduci);
            SqlDataReader reader = db.Select(command);

            Collection<Ziadosti> ziadosti = Read(reader);
            reader.Close();

            if (pDb == null)
            {
                db.Close();
            }

            return ziadosti;
        }
        private static void PrepareCommand(SqlCommand command, Ziadosti ziadosti)
        {
            command.Parameters.AddWithValue("@id_ziadost", ziadosti.id_ziadost);
            command.Parameters.AddWithValue("@id_zamestnanec", ziadosti.id_zamestnanec);
            command.Parameters.AddWithValue("@id_veduci", ziadosti.id_veduci);
            command.Parameters.AddWithValue("@id_ukolu", ziadosti.id_ukolu);
            command.Parameters.AddWithValue("@id_letu", ziadosti.id_letu);
            command.Parameters.AddWithValue("@akceptovane", ziadosti.akceptovane == null ? DBNull.Value : (object)ziadosti.akceptovane);
            command.Parameters.AddWithValue("@info", ziadosti.info);
            command.Parameters.AddWithValue("@pozadovany_datum", ziadosti.pozadovany_datum);
            command.Parameters.AddWithValue("@pozadovana_smena", ziadosti.pozadovana_smena);


        }

        private static Collection<Ziadosti> Read(SqlDataReader reader)
        {
            Collection<Ziadosti> ziadosti = new Collection<Ziadosti>();

            while (reader.Read())
            {
                int i = -1;
                Ziadosti ziadost = new Ziadosti();
                ziadost.id_ziadost = reader.GetInt32(++i);
                ziadost.id_zamestnanec = reader.GetString(++i);
                ziadost.id_veduci = reader.GetInt32(++i);
                ziadost.id_ukolu = reader.GetInt32(++i);
                ziadost.id_letu = reader.GetInt32(++i);
                if (!reader.IsDBNull(++i))
                {
                    ziadost.akceptovane = reader.GetInt32(i);
                }
                else
                {
                    ziadost.akceptovane = 0;
                }

                    
                ziadost.info = reader.GetString(++i);
                ziadost.pozadovany_datum = reader.GetDateTime(++i);
                ziadost.pozadovana_smena = reader.GetInt32(++i);

                ziadosti.Add(ziadost);
            }
            return ziadosti;
        }
        public static bool ZiadostOSmenu(String p_pid, int p_id_letu, DateTime p_pozadovany_datum, int p_pozadovana_smena, string p_info, int v_id_ukolu, Database pDb)
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
            SqlCommand command = db.CreateCommand("ZiadostOSmenu");

            // 2. set the command object so it knows to execute a stored procedure
            command.CommandType = CommandType.StoredProcedure;

            // pid arg
            SqlParameter iPid = new SqlParameter();
            iPid.ParameterName = "@p_pid";
            iPid.DbType = DbType.String;
            iPid.Value = p_pid;
            iPid.Direction = ParameterDirection.Input;
            command.Parameters.Add(iPid);
            // idletu arg
            SqlParameter iIdLetu = new SqlParameter();
            iIdLetu.ParameterName = "@p_id_letu";
            iIdLetu.DbType = DbType.Int32;
            iIdLetu.Value = p_id_letu;
            iIdLetu.Direction = ParameterDirection.Input;
            command.Parameters.Add(iIdLetu);
            // pozadovanydatum arg
            SqlParameter iDatum = new SqlParameter();
            iDatum.ParameterName = "@p_pozadovany_datum";
            iDatum.DbType = DbType.DateTime;
            iDatum.Value = p_pozadovany_datum;
            iDatum.Direction = ParameterDirection.Input;
            command.Parameters.Add(iDatum);
            // smena arg
            SqlParameter iSmena = new SqlParameter();
            iSmena.ParameterName = "@p_pozadovana_smena";
            iSmena.DbType = DbType.Int32;
            iSmena.Value = p_pozadovana_smena;
            iSmena.Direction = ParameterDirection.Input;
            command.Parameters.Add(iSmena);
            // info arg
            SqlParameter iInfo = new SqlParameter();
            iInfo.ParameterName = "@p_info";
            iInfo.DbType = DbType.String;
            iInfo.Value = p_info;
            iInfo.Direction = ParameterDirection.Input;
            command.Parameters.Add(iInfo);
            // dropdown id ukolu arg
            SqlParameter iUkol = new SqlParameter();
            iUkol.ParameterName = "@v_id_ukolu";
            iUkol.DbType = DbType.Int32;
            iUkol.Value = v_id_ukolu;
            iUkol.Direction = ParameterDirection.Input;
            command.Parameters.Add(iUkol);

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
