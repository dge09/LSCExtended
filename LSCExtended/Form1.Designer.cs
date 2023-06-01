namespace LSCExtended
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bg_controlls = new System.Windows.Forms.GroupBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.tb_repeats = new System.Windows.Forms.TextBox();
            this.l_repeats = new System.Windows.Forms.Label();
            this.gb_data = new System.Windows.Forms.GroupBox();
            this.dgv_data = new System.Windows.Forms.DataGridView();
            this.l_data = new System.Windows.Forms.Label();
            this.lb_liveLog = new System.Windows.Forms.ListBox();
            this.bg_controlls.SuspendLayout();
            this.gb_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).BeginInit();
            this.SuspendLayout();
            // 
            // bg_controlls
            // 
            this.bg_controlls.Controls.Add(this.btn_start);
            this.bg_controlls.Controls.Add(this.tb_repeats);
            this.bg_controlls.Controls.Add(this.l_repeats);
            this.bg_controlls.Location = new System.Drawing.Point(12, 12);
            this.bg_controlls.Name = "bg_controlls";
            this.bg_controlls.Size = new System.Drawing.Size(559, 71);
            this.bg_controlls.TabIndex = 4;
            this.bg_controlls.TabStop = false;
            this.bg_controlls.Text = "Controlls";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(459, 23);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(94, 29);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // tb_repeats
            // 
            this.tb_repeats.Location = new System.Drawing.Point(148, 20);
            this.tb_repeats.Name = "tb_repeats";
            this.tb_repeats.Size = new System.Drawing.Size(106, 27);
            this.tb_repeats.TabIndex = 1;
            // 
            // l_repeats
            // 
            this.l_repeats.AutoSize = true;
            this.l_repeats.Location = new System.Drawing.Point(6, 23);
            this.l_repeats.Name = "l_repeats";
            this.l_repeats.Size = new System.Drawing.Size(136, 20);
            this.l_repeats.TabIndex = 0;
            this.l_repeats.Text = "How many repeats:";
            // 
            // gb_data
            // 
            this.gb_data.Controls.Add(this.lb_liveLog);
            this.gb_data.Controls.Add(this.dgv_data);
            this.gb_data.Controls.Add(this.l_data);
            this.gb_data.Location = new System.Drawing.Point(12, 89);
            this.gb_data.Name = "gb_data";
            this.gb_data.Size = new System.Drawing.Size(559, 318);
            this.gb_data.TabIndex = 5;
            this.gb_data.TabStop = false;
            this.gb_data.Text = "Data View";
            // 
            // dgv_data
            // 
            this.dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_data.Location = new System.Drawing.Point(6, 46);
            this.dgv_data.Name = "dgv_data";
            this.dgv_data.RowHeadersWidth = 51;
            this.dgv_data.RowTemplate.Height = 29;
            this.dgv_data.Size = new System.Drawing.Size(547, 266);
            this.dgv_data.TabIndex = 1;
            // 
            // l_data
            // 
            this.l_data.AutoSize = true;
            this.l_data.Location = new System.Drawing.Point(6, 23);
            this.l_data.Name = "l_data";
            this.l_data.Size = new System.Drawing.Size(100, 20);
            this.l_data.TabIndex = 0;
            this.l_data.Text = "Previous Data";
            // 
            // lb_liveLog
            // 
            this.lb_liveLog.FormattingEnabled = true;
            this.lb_liveLog.ItemHeight = 20;
            this.lb_liveLog.Location = new System.Drawing.Point(6, 46);
            this.lb_liveLog.Name = "lb_liveLog";
            this.lb_liveLog.Size = new System.Drawing.Size(547, 264);
            this.lb_liveLog.TabIndex = 2;
            this.lb_liveLog.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 416);
            this.Controls.Add(this.gb_data);
            this.Controls.Add(this.bg_controlls);
            this.Name = "Form1";
            this.Text = "LSCExtended";
            this.bg_controlls.ResumeLayout(false);
            this.bg_controlls.PerformLayout();
            this.gb_data.ResumeLayout(false);
            this.gb_data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox bg_controlls;
        private Button btn_start;
        private TextBox tb_repeats;
        private Label l_repeats;
        private GroupBox gb_data;
        private DataGridView dgv_data;
        private Label l_data;
        private ListBox lb_liveLog;
    }
}