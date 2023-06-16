using System.Data.SQLite;
using LSCExtended.DataBase;
using LSCExtended.DataHandling;
using LSCExtended.Models;
using SixLabors.Fonts;

namespace LSCExtended
{
    public partial class Form1 : Form
    {
        public string basePath;
        public string BaseFilePath;
        public string ConnectionString;
        public SQLiteConnection myCon;

        public Form1()
        {
            InitializeComponent();

            lb_liveLog.Visible = false;
            dgv_data.Visible = true;

            List<FoundData> fd = DbHandling.SelectFoundData();

            dgv_data.Columns.Add("ID", "ID");
            dgv_data.Columns.Add("FData", "FData");
            dgv_data.Columns.Add("Category", "Category");
            dgv_data.Columns.Add("Link", "Link");

            foreach (FoundData item in fd)
            {
                dgv_data.Rows.Add(item.ID, item.FData, item.Category, item.Link);
            }



            // no longer needed
            //basePath = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache);

            //BaseFilePath = DBFileHandling.CheckSQLiteFile();
            //BaseFilePath = DBFileHandling.SetupSQLite(BaseFilePath);
            //ConnectionString = DBFileHandling.GetConnectionString(BaseFilePath);

            //myCon = DBFileHandling.GetSQLiteConnection(ConnectionString, myCon);

            //DBFileHandling.CreateFoundDataTable(myCon);
            //DBFileHandling.CreateKeywordTable(myCon);
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            dgv_data.Visible = false;
            lb_liveLog.Visible = true;
            string url;
            string imgUrl;
            string httpCode;
            string imgPath;
            string collectedData;
            FoundData fd = new();

            for (int i = 0; i < int.Parse(tb_repeats.Text); i++)
            {
                url = WebHandling.GenerateUrl(6);
                httpCode = WebHandling.GetHttpString(url);
                imgUrl = WebHandling.GetImgUrl(httpCode);

                if (WebHandling.CheckWebsiteExistance(imgUrl))
                {
                    imgPath = WebHandling.DownloadImg(imgUrl, basePath);
                    collectedData = OCRHandling.GetTextFromImg(imgPath);

                }
            }
        }

        private void Mbtn_addKeyWrd_Click(object sender, EventArgs e)
        {
            F_Keys keyForm = new(myCon);
            keyForm.ShowDialog();
        }


        // just for testin DELETE AT THE END
        private void btndoshit_Click(object sender, EventArgs e)
        {
            
            
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Keys keyForm = new(myCon);
            keyForm.ShowDialog();
        }
    }
}



// DONE -> Lastenheft 
// Code und Ablauf Dokumentation
// Review (1/2 Seite)