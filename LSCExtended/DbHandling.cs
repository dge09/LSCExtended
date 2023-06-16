using LSCExtended.Models;
using SixLabors.ImageSharp.ColorSpaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSCExtended
{
    public static class DbHandling
    {
        private static String connectionString;

        
        private static SqlDataReader reader;


        private static String FDInsert;
        private static String FDSelect;
        private static String KWInsert;
        private static String KWSelect;
        private static String FDDelete;
        private static String KWDelete;


        private static String SelectSpecific;
        
        

        static DbHandling()
        {
            connectionString = @"Data Source=DGE09PC\SQLEXPRESS;Initial Catalog=LSCollection;Integrated Security=True;";
            FDInsert = "INSERT INTO FoundData VALUES(@collectedData, @category, @link); SELECT CAST(scope_identity() AS int);";
            KWInsert = "INSERT INTO Keyword VALUES(@keyword); SELECT CAST(scope_identity() AS int);";

            FDSelect = "SELECT FDID, FData, Category, Link FROM FoundData;";
            KWSelect = "SELECT * FROM KeyWord;";

            FDDelete = "DELETE FROM FoundData WHERE FDID = @fdID";
            KWDelete = "DELETE FROM KeyWord WHERE KeyID = @keyID";

            SelectSpecific = "SELECT * FROM FoundData Where Category = @category;";
        }


        //================================================================================================
        //==================================  FoundData  =================================================
        //================================================================================================

        public static void InsertFD(string collectedData, List<string> categoryLs, string link)
        {
            string category = String.Empty;

            foreach (var item in categoryLs)
            {
                category += item + ',';
            }

            category = category.TrimEnd(',');

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand insCmd = new SqlCommand(FDInsert, con);
                insCmd.Parameters.AddWithValue("@collectedData", collectedData);
                insCmd.Parameters.AddWithValue("@category", category);
                insCmd.Parameters.AddWithValue("@link", link);

                con.Open();

                int idk = (int)insCmd.ExecuteNonQuery();

                con.Close();
            }
        }


        public static List<FoundData> SelectFoundData()
        {
            List<FoundData> foundData = new();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand selCmd = new SqlCommand(FDSelect, con);

                con.Open();

                reader = selCmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        FoundData readFoundData = new FoundData
                        {
                            FDID = reader.GetInt32(0),
                            FData = reader.GetString(1),
                            Category = reader.GetString(2),
                            Link = reader.GetString(3)
                        };

                        foundData.Add(readFoundData);
                    }
                }

                reader.Close();

                return foundData;
            }
        }

        public static void DeleteFoundData(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand insCmd = new SqlCommand(FDDelete, con);

                con.Open();

                insCmd.Parameters.AddWithValue("@fdID", id);
                int idk = (int)insCmd.ExecuteNonQuery();

                con.Close();
            }
        }


        //================================================================================================
        //==================================  Keywords  ==================================================
        //================================================================================================
        public static void InsertKeyword(string unsplitKeys)
        {
            if (!String.IsNullOrEmpty(unsplitKeys))
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand insCmd = new SqlCommand(KWInsert, con);

                    string[] Keywords = unsplitKeys.Split(',');
                
                    con.Open();

                    foreach (string item in Keywords)
                    {
                        insCmd.Parameters.Clear();

                        insCmd.Parameters.AddWithValue("@keyword", item);
                        int idk = (int)insCmd.ExecuteNonQuery();
                    }

                    con.Close();
                }
            }
        }

        public static List<Keyword> SelectKeywords()
        {
            List<Keyword> kw = new();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand selCmd = new SqlCommand(KWSelect, con);

                con.Open();

                reader = selCmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Keyword readKeyWord = new Keyword
                        {
                            ID = reader.GetInt32(0),
                            KeyWord = reader.GetString(1)
                        };

                        kw.Add(readKeyWord);
                    }
                }

                reader.Close();

                return kw;
            }
        }

        public static void DeleteKeyword(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand insCmd = new SqlCommand(KWDelete, con);

                con.Open();

                insCmd.Parameters.AddWithValue("@keyID", id);
                int idk = (int)insCmd.ExecuteNonQuery();

                con.Close();
            }
        }





        //================================================================================================
        //==================================  INF Exercice  ==============================================
        //================================================================================================
        public static List<FoundData> SelectFoundDataSpecific(string category)
        {
            List<FoundData> foundData = new();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand selCmd = new SqlCommand(SelectSpecific, con);

                selCmd.Parameters.AddWithValue("@category", category);

                con.Open();

                reader = selCmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        FoundData readFoundData = new FoundData
                        {
                            FDID = reader.GetInt32(0),
                            FData = reader.GetString(1),
                            Category = reader.GetString(2),
                            Link = reader.GetString(3)
                        };

                        foundData.Add(readFoundData);
                    }
                }

                reader.Close();

                return foundData;
            }
        }

    }
}