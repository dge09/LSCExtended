using System.Data.SQLite;
using LSCExtended.DataBase;
using LSCExtended.DataHandling;

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



            List<FoundData> fd = 

            dgv_data



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

                /* single insert works list insert not tested yet !!!!!!!!!!!!!!!!!!!
                fd.Data = i + "idkURL";
                fd.Link = i + "idkPageURL";
                fd.Category = i + "idkCategory";

                DBFileHandling.InsertIntoDB(myCon, fd);
                */
            }
        }

        private void Mbtn_addKeyWrd_Click(object sender, EventArgs e)
        {
            F_Keys keyForm = new(myCon);
            keyForm.ShowDialog();
        }

        private void btndoshit_Click(object sender, EventArgs e)
        {
            DbHandling dbh = new();

            //dbh.InsertFD();
            List<string> idk = dbh.SelectKeywords();
        }
    }
}



// DONE -> Lastenheft 
// Code und Ablauf Dokumentation
// Review (1/2 Seite)