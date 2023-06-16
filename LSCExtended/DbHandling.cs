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
    public class DbHandling
    {
        private String connectionString;

        
        private SqlDataReader reader;


        private String FDInsert;
        private String FDSelect;
        private String KWInsert;
        private String KWSelect;
        
        

        public DbHandling()
        {
            connectionString = @"Data Source=DGE09PC\SQLEXPRESS;Initial Catalog=LSCollection;Integrated Security=True;";
            FDInsert = "INSERT INTO FoundData VALUES(@collectedData, @category, @link); SELECT CAST(scope_identity() AS int);";
            KWInsert = "INSERT INTO Keyword VALUES(@keyword); SELECT CAST(scope_identity() AS int);";

            FDSelect = "SELECT * FROM FoundData;";
            KWSelect = "SELECT * FROM KeyWord;";


        }


        //================================================================================================
        //==================================  FoundData  =================================================
        //================================================================================================

        public void InsertFD()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand insCmd = new SqlCommand(FDInsert, con);
                insCmd.Parameters.AddWithValue("@collectedData", "idfk");
                insCmd.Parameters.AddWithValue("@category", "none");
                insCmd.Parameters.AddWithValue("@link", "www.google.at");

                con.Open();

                int idk = (int)insCmd.ExecuteNonQuery();

                con.Close();
            }
        }

        public List<FoundData> SelectFoundData()
        {
            List<FoundData> foundData = new();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand selCmd = new SqlCommand(KWSelect, con);

                con.Open();

                reader = selCmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        FoundData readFoundData = new();
                        readFoundData.ID = reader.GetInt32(0);
                        readFoundData.Data = reader.GetString(1);
                        readFoundData.Category = reader.GetString(2);
                        readFoundData.Link = reader.GetString(3);

                        foundData.Add(readFoundData);
                    }
                }

                reader.Close();

                return foundData;
            }
        }



        //================================================================================================
        //==================================  Keywords  ==================================================
        //================================================================================================
        public List<String> SelectKeywords()
        {
            List<string> KeyWords = new();
            string readKeyword = string.Empty;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand selCmd = new SqlCommand(KWSelect, con);
                
                con.Open();
                
                reader = selCmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        readKeyword = new(reader.GetString(1));
                        KeyWords.Add(readKeyword);
                    }
                }

                reader.Close();

                return KeyWords;
            }
        }

    }
}