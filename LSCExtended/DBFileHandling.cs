using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LSCExtended
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

            if (!(Directory.Exists(path)))
            {
                Directory.CreateDirectory(path);
            }

            file = path + "/FoundDataDB.sqlite";

            if (!(File.Exists(path)))
            {
                SQLiteConnection.CreateFile(file);
            }

            return file;
        }

        public static string GetConnectionString(string path)
        {
            string connectionString = "Data Source=" + path + ";Version=3;";

            return connectionString;
        }

        public static SQLiteConnection GetSQLiteConnection(string connectionString, SQLiteConnection myCon)
        {
            myCon = new SQLiteConnection(connectionString);
            myCon.Open();

            return myCon;
        }


        public static void CreateTable(SQLiteConnection myCon)
        {
            string sql = "CREATE TABLE FoundData(FoundDataID INTEGER PRIMARY KEY, ImageUrl NVARCHAR(1000), WebPageUrl NVARCHAR(1000), Category NVARCHAR(50));";

            if (myCon.State != System.Data.ConnectionState.Open)
            {
                throw new Exception("SQLite Creation Error");
            }

            SQLiteCommand cmd = new SQLiteCommand(sql, myCon);

            cmd.ExecuteNonQuery();
        }




        public static void InsertIntoDB(SQLiteConnection myCon, FoundData fd)
        {   
            if (myCon.State != System.Data.ConnectionState.Open)
            {
                throw new Exception("SQLite Connection Error");
            }

            SQLiteCommand sql = new("INSERT INTO FoundData (ImageUrl, WebPageUrl, Category) VALUES ('" + fd.Data + "', '" + fd.Link + "', '" + fd.Category + "');", myCon);

            sql.ExecuteNonQuery();
        }

        public static void InsertIntoDB(SQLiteConnection myCon, List<FoundData> fdList)
        {
            if (myCon.State != System.Data.ConnectionState.Open)
            {
                throw new Exception("SQLite Connection Error");
            }

            foreach (FoundData fd in fdList)
            {
                SQLiteCommand sql = new("INSERT INTO FoundData (ImageUrl, WebPageUrl, Category) VALUES ('" + fd.Data + "', '" + fd.Link + "', '" + fd.Category + "');", myCon);
                
                sql.ExecuteNonQuery();
            }
        }
    }
}
