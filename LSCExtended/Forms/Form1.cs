using System.Data.SQLite;
using LSC;
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

            basePath = FileHanlding.CheckRequiredBasePath();

            Updatedgv_data();

            List<string> keywords = DataFilter.GetStringListKeywords(DbHandling.SelectKeywords());

            foreach (string item in keywords)
            {
                Cb_keywords.Items.Add(item);
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            string url;
            string imgUrl;
            string httpCode;
            string imgPath;
            string collectedData;
            List<string> foundKeywords = new();
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

                    if (!String.IsNullOrEmpty(collectedData))
                    {
                        foundKeywords = DataFilter.SearchForKeywords(collectedData);
                    }

                    if (foundKeywords.Count > 0)
                    {
                        DbHandling.InsertFD(collectedData, foundKeywords, url);
                    }
                }
                l_data.Text = i + " runs done!";
            }

            l_data.Text = "Done!";

            Updatedgv_data();

        }

        private void Mbtn_addKeyWrd_Click(object sender, EventArgs e)
        {
            F_Keys keyForm = new(myCon);
            keyForm.ShowDialog();
        }

        private void Mi_editKeys_Click(object sender, EventArgs e)
        {
            F_Keys keyForm = new(myCon);
            keyForm.ShowDialog();
        }

        private void Kd_del(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (dgv_data.SelectedRows.Count > 0)
                {
                    DataGridViewRow selRow = dgv_data.SelectedRows[0];
                    int idToDelete = (int)selRow.Cells[0].Value;

                    DbHandling.DeleteFoundData(idToDelete);

                    Updatedgv_data();
                }
            }
        }

        private void Updatedgv_data()
        {
            dgv_data.Columns.Clear();

            List<FoundData> fd = DbHandling.SelectFoundData();

            DataGridViewTextBoxColumn columnID = new DataGridViewTextBoxColumn();
            columnID.Name = "ColumnID";
            columnID.HeaderText = "ID";
            dgv_data.Columns.Add(columnID);
            columnID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgv_data.Columns.Add("FData", "FData");
            dgv_data.Columns.Add("Category", "Category");

            DataGridViewColumn columnLink = new DataGridViewTextBoxColumn();
            columnLink.HeaderText = "Link";
            columnLink.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_data.Columns.Add(columnLink);

            foreach (FoundData item in fd)
            {
                dgv_data.Rows.Add(item.FDID, item.FData, item.Category, item.Link);
            }
        }

        private void Sic_filter(object sender, EventArgs e)
        {
            List<FoundData> fd = DbHandling.SelectFoundDataSpecific(Cb_keywords.Text);

            dgv_data.Rows.Clear();

            foreach (var item in fd)
            {
                dgv_data.Rows.Add(item.FDID, item.FData, item.Category, item.Link);
            }
        }

        private void Mi_History_Click(object sender, EventArgs e)
        {
            Cb_keywords.Text = "";
            Updatedgv_data();
        }
    }
}



// DONE -> Lastenheft 
// Code und Ablauf Dokumentation
// Review (1/2 Seite


// https://image.prntscr.com/image/7EveunrfR-i4V7BZw7TMqw.jpeg
// https://prnt.sc/taavls