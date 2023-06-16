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
            this.btndoshit = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.tb_repeats = new System.Windows.Forms.TextBox();
            this.l_repeats = new System.Windows.Forms.Label();
            this.gb_data = new System.Windows.Forms.GroupBox();
            this.lb_liveLog = new System.Windows.Forms.ListBox();
            this.dgv_data = new System.Windows.Forms.DataGridView();
            this.l_data = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Mbtn_addKeyWrd = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Mbtn_showLateFnd = new System.Windows.Forms.ToolStripMenuItem();
            this.bg_controlls.SuspendLayout();
            this.gb_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bg_controlls
            // 
            this.bg_controlls.Controls.Add(this.btndoshit);
            this.bg_controlls.Controls.Add(this.btn_start);
            this.bg_controlls.Controls.Add(this.tb_repeats);
            this.bg_controlls.Controls.Add(this.l_repeats);
            this.bg_controlls.Location = new System.Drawing.Point(12, 33);
            this.bg_controlls.Name = "bg_controlls";
            this.bg_controlls.Size = new System.Drawing.Size(559, 71);
            this.bg_controlls.TabIndex = 4;
            this.bg_controlls.TabStop = false;
            this.bg_controlls.Text = "Controlls";
            // 
            // btndoshit
            // 
            this.btndoshit.Location = new System.Drawing.Point(296, 20);
            this.btndoshit.Name = "btndoshit";
            this.btndoshit.Size = new System.Drawing.Size(94, 29);
            this.btndoshit.TabIndex = 3;
            this.btndoshit.Text = "do smthng";
            this.btndoshit.UseVisualStyleBackColor = true;
            this.btndoshit.Click += new System.EventHandler(this.btndoshit_Click);
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
            this.gb_data.Location = new System.Drawing.Point(12, 110);
            this.gb_data.Name = "gb_data";
            this.gb_data.Size = new System.Drawing.Size(559, 318);
            this.gb_data.TabIndex = 5;
            this.gb_data.TabStop = false;
            this.gb_data.Text = "Data View";
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
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.historyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mbtn_addKeyWrd});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.settingsToolStripMenuItem.Text = "Edit Keys";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // Mbtn_addKeyWrd
            // 
            this.Mbtn_addKeyWrd.Name = "Mbtn_addKeyWrd";
            this.Mbtn_addKeyWrd.Size = new System.Drawing.Size(224, 26);
            this.Mbtn_addKeyWrd.Text = "Add Keywords";
            this.Mbtn_addKeyWrd.Click += new System.EventHandler(this.Mbtn_addKeyWrd_Click);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.historyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mbtn_showLateFnd});
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.historyToolStripMenuItem.Text = "History";
            // 
            // Mbtn_showLateFnd
            // 
            this.Mbtn_showLateFnd.Name = "Mbtn_showLateFnd";
            this.Mbtn_showLateFnd.Size = new System.Drawing.Size(225, 26);
            this.Mbtn_showLateFnd.Text = "Show latest findings";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 441);
            this.Controls.Add(this.gb_data);
            this.Controls.Add(this.bg_controlls);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "LSCExtended";
            this.bg_controlls.ResumeLayout(false);
            this.bg_controlls.PerformLayout();
            this.gb_data.ResumeLayout(false);
            this.gb_data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox bg_controlls;
        private Button btn_start;
        private TextBox tb_repeats;
        private Label l_repeats;
        private GroupBox gb_data;
        private DataGridView dgv_data;
        private Label l_data;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem Mbtn_addKeyWrd;
        private ToolStripMenuItem historyToolStripMenuItem;
        private ToolStripMenuItem Mbtn_showLateFnd;
        private Button btndoshit;
        private ListBox lb_liveLog;
    }
}