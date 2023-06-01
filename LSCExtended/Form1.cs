using System.Data.SQLite;

namespace LSCExtended
{
    public partial class Form1 : Form
    {
        public string BaseFilePath;
        public string ConnectionString;
        public SQLiteConnection myCon;

        public Form1()
        {
            InitializeComponent();


            BaseFilePath = DBFileHandling.CheckSQLiteFile();
            BaseFilePath = DBFileHandling.SetupSQLite(BaseFilePath);
            ConnectionString = DBFileHandling.GetConnectionString(BaseFilePath);

            myCon = DBFileHandling.GetSQLiteConnection(ConnectionString, myCon);

            DBFileHandling.CreateTable(myCon);
            }

        private void btn_start_Click(object sender, EventArgs e)
        {
            dgv_data.Visible = false;
            lb_liveLog.Visible = true;
            FoundData fd = new();

            for (int i = 0; i < int.Parse(tb_repeats.Text); i++)
            {
                
                
                
                
                /* single insert works list insert not tested yet !!!!!!!!!!!!!!!!!!!
                fd.Data = i + "idkURL";
                fd.Link = i + "idkPageURL";
                fd.Category = i + "idkCategory";

                DBFileHandling.InsertIntoDB(myCon, fd);
                */
            }
        }
    }
}