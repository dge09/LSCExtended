using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LSCExtended.DataBase;

namespace LSCExtended
{
    public partial class F_Keys : Form
    {
        public SQLiteConnection myCon;

        public F_Keys(SQLiteConnection myCon)
        {
            InitializeComponent();

            this.myCon = myCon;

            UpdateDGVKeys();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            string[] aKeys = Tb_Keys.Text.Split(',');
            List<string> keys = aKeys.ToList<string>();

            DBFileHandling.InsertIntoDBKeywords(myCon, keys);

            this.Close();
        }

        private void UpdateDGVKeys()
        {
            DGV_Keys.Columns.Clear();

            List<string> keys = DBFileHandling.GetKeys(myCon);

            foreach (var key in keys)
            {
                DGV_Keys.Rows.Add(key);
            }
        }
    }
}
