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
using LSCExtended.Models;

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
            DbHandling.InsertKeyword(Tb_Keys.Text);

            UpdateDGVKeys();
        }

        private void Kd_del(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (DGV_Keys.SelectedRows.Count > 0)
                {
                    DataGridViewRow selRow = DGV_Keys.SelectedRows[0];
                    int idToDelete = (int)selRow.Cells[0].Value;

                    DbHandling.DeleteKeyword(idToDelete);

                    UpdateDGVKeys();
                }
            }
        }

        private void Btn_del_Click(object sender, EventArgs e)
        {
            if (DGV_Keys.SelectedRows.Count > 0)
            {
                DataGridViewRow selRow = DGV_Keys.SelectedRows[0];
                int idToDelete = (int)selRow.Cells[0].Value;

                DbHandling.DeleteKeyword(idToDelete);

                UpdateDGVKeys();
            }
        }

        private void UpdateDGVKeys()
        {
            DGV_Keys.Columns.Clear();

            List<Keyword> kw = DbHandling.SelectKeywords();

            DGV_Keys.Columns.Add("ID", "ID");


            DataGridViewColumn columnKeyword = new DataGridViewTextBoxColumn();
            columnKeyword.HeaderText = "Keyword";
            columnKeyword.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGV_Keys.Columns.Add(columnKeyword);

            foreach (Keyword item in kw)
            {
                DGV_Keys.Rows.Add(item.ID, item.KeyWord);
            }
        }

    }
}
