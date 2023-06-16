using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SQLite;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using LSCExtended.Models;

namespace LSCExtended.DataBase
{
    public static class DBFileHandling
    {
        public static string CheckSQLiteFile()
        {
            string file = Assembly.GetExecutingAssembly().CodeBase;

            string pattern = @"^.*(C:/.+)/bin.*";

            Match match = Regex.Match(file, pattern);
            return match.Groups[1].Value;
        }

        public static string SetupSQLite(string path)
        {
            path += "/DataBase";
            string file = path;

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            file = path + "/FoundDataDB.sqlite";

            if (!File.Exists(path))
            {
                SQLiteConnection.CreateFile(file);
            }

            return file;
        }

        public static string GetConnectionString(string path)
        {
            string connectionString = "Data Source=" + path + ";Version=3;";
            connectionString = @"Server=DGE09PC\SQLEXPRESS;Database=master;User Id=myUsername;Password=myPassword;";

            return connectionString;
        }

        public static SQLiteConnection GetSQLiteConnection(string connectionString, SQLiteConnection myCon)
        {
            myCon = new SQLiteConnection(connectionString);
            myCon.Open();

            return myCon;
        }


        public static void CreateFoundDataTable(SQLiteConnection myCon)
        {
            string sql = "CREATE TABLE FoundData(FoundDataID INTEGER PRIMARY KEY, ImageUrl NVARCHAR(1000), WebPageUrl NVARCHAR(1000), Category NVARCHAR(50));";

            if (myCon.State != System.Data.ConnectionState.Open)
            {
                throw new Exception("SQLite Creation Error");
            }

            SQLiteCommand cmd = new SQLiteCommand(sql, myCon);

            cmd.ExecuteNonQuery();


        }

        public static void CreateKeywordTable(SQLiteConnection myCon)
        {
            string sql = "CREATE TABLE Keywords(Keyword NVARCHAR(1000) PRIMARY KEY);";

            if (myCon.State != System.Data.ConnectionState.Open)
            {
                throw new Exception("SQLite Creation Error");
            }

            SQLiteCommand cmd = new SQLiteCommand(sql, myCon);

            cmd.ExecuteNonQuery();
        }





        public static void InsertIntoDBFoundData(SQLiteConnection myCon, FoundData fd)
        {
            if (myCon.State != System.Data.ConnectionState.Open)
            {
                throw new Exception("SQLite Connection Error");
            }

            SQLiteCommand sql = new("INSERT INTO FoundData (ImageUrl, WebPageUrl, Category) VALUES ('" + fd.FData + "', '" + fd.Link + "', '" + fd.Category + "');", myCon);

            sql.ExecuteNonQuery();

            sql = new("COMMIT;");
            sql.ExecuteNonQuery();
        }

        public static void InsertIntoDBFoundData(SQLiteConnection myCon, List<FoundData> fdList)
        {
            if (myCon.State != System.Data.ConnectionState.Open)
            {
                throw new Exception("SQLite Connection Error");
            }

            SQLiteCommand sql;

            foreach (FoundData fd in fdList)
            {
                sql = new("INSERT INTO FoundData (ImageUrl, WebPageUrl, Category) VALUES ('" + fd.FData + "', '" + fd.Link + "', '" + fd.Category + "');", myCon);

                sql.ExecuteNonQuery();
            }

            sql = new("COMMIT;");
            sql.ExecuteNonQuery();
        }

        public static void InsertIntoDBKeywords(SQLiteConnection myCon, List<string> keyList)
        {
            if (myCon.State != System.Data.ConnectionState.Open)
            {
                throw new Exception("SQLite Connection Error");
            }

            SQLiteCommand sql;

            using (DbTransaction dbTrans = myCon.BeginTransaction())
            {
                using (DbCommand cmd = myCon.CreateCommand())
                {
                    foreach (string key in keyList)
                    {
                        sql = new("INSERT INTO Keywords (Keyword) VALUES ('" + key + "');", myCon);

                        sql.ExecuteNonQuery();
                    }

                }

                dbTrans.Commit();
            }

        }

        public static List<string> GetKeys(SQLiteConnection myCon)
        {
            if (myCon.State != System.Data.ConnectionState.Open)
            {
                throw new Exception("SQLite Connection Error");
            }

            List<string> keys = new List<string>();

            SQLiteDataReader reader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = myCon.CreateCommand();

            sqlite_cmd.CommandText = "SELECT Keyword FROM Keywords";

            reader = sqlite_cmd.ExecuteReader();


            /*
            Int64 count = 0;

            using (SQLiteCommand command = new SQLiteCommand("SELECT COUNT(*) FROM Keywords", myCon))
            {
                count = (Int64)command.ExecuteScalar();
            }



            for (int i = 0; i < count; i++)
            {
                keys.Add(reader.GetString(i));        // !!!!!!!!!!!!!!!!!!! Error index out of range

                i++;
            }
            */

            return keys;
        }
    }
}
