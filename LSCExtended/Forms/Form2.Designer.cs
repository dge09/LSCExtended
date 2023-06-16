namespace LSCExtended
{
    partial class F_Keys
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tb_Keys = new System.Windows.Forms.TextBox();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.DGV_Keys = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Keys)).BeginInit();
            this.SuspendLayout();
            // 
            // Tb_Keys
            // 
            this.Tb_Keys.Location = new System.Drawing.Point(12, 12);
            this.Tb_Keys.Name = "Tb_Keys";
            this.Tb_Keys.Size = new System.Drawing.Size(493, 27);
            this.Tb_Keys.TabIndex = 0;
            // 
            // Btn_Add
            // 
            this.Btn_Add.Location = new System.Drawing.Point(511, 12);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(94, 29);
            this.Btn_Add.TabIndex = 1;
            this.Btn_Add.Text = "Add";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // DGV_Keys
            // 
            this.DGV_Keys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Keys.Location = new System.Drawing.Point(12, 45);
            this.DGV_Keys.Name = "DGV_Keys";
            this.DGV_Keys.RowHeadersWidth = 51;
            this.DGV_Keys.RowTemplate.Height = 29;
            this.DGV_Keys.Size = new System.Drawing.Size(493, 221);
            this.DGV_Keys.TabIndex = 2;
            // 
            // F_Keys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 278);
            this.Controls.Add(this.DGV_Keys);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.Tb_Keys);
            this.Name = "F_Keys";
            this.Text = "Keys";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Keys)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Tb_Keys;
        private Button Btn_Add;
        private DataGridView DGV_Keys;
    }
}