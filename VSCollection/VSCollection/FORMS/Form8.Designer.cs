namespace VSCollection.FORMS
{
    partial class EventList
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
            this.dtgEventList = new System.Windows.Forms.DataGridView();
            this.btnIntrams = new System.Windows.Forms.Button();
            this.btnAcquintance = new System.Windows.Forms.Button();
            this.btnGODAY = new System.Windows.Forms.Button();
            this.btnCongress = new System.Windows.Forms.Button();
            this.btnSeminar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hOMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEventList)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgEventList
            // 
            this.dtgEventList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEventList.Location = new System.Drawing.Point(83, 31);
            this.dtgEventList.Name = "dtgEventList";
            this.dtgEventList.RowHeadersWidth = 51;
            this.dtgEventList.RowTemplate.Height = 24;
            this.dtgEventList.Size = new System.Drawing.Size(812, 473);
            this.dtgEventList.TabIndex = 0;
            // 
            // btnIntrams
            // 
            this.btnIntrams.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnIntrams.Location = new System.Drawing.Point(83, 526);
            this.btnIntrams.Name = "btnIntrams";
            this.btnIntrams.Size = new System.Drawing.Size(124, 37);
            this.btnIntrams.TabIndex = 1;
            this.btnIntrams.Text = "INTRAMURALS";
            this.btnIntrams.UseVisualStyleBackColor = false;
            this.btnIntrams.Click += new System.EventHandler(this.btnIntrams_Click);
            // 
            // btnAcquintance
            // 
            this.btnAcquintance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAcquintance.Location = new System.Drawing.Point(255, 526);
            this.btnAcquintance.Name = "btnAcquintance";
            this.btnAcquintance.Size = new System.Drawing.Size(124, 37);
            this.btnAcquintance.TabIndex = 1;
            this.btnAcquintance.Text = "ACQUINTANCE";
            this.btnAcquintance.UseVisualStyleBackColor = false;
            this.btnAcquintance.Click += new System.EventHandler(this.btnAcquintance_Click);
            // 
            // btnGODAY
            // 
            this.btnGODAY.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGODAY.Location = new System.Drawing.Point(428, 526);
            this.btnGODAY.Name = "btnGODAY";
            this.btnGODAY.Size = new System.Drawing.Size(124, 37);
            this.btnGODAY.TabIndex = 1;
            this.btnGODAY.Text = "GO DAY";
            this.btnGODAY.UseVisualStyleBackColor = false;
            this.btnGODAY.Click += new System.EventHandler(this.btnGODAY_Click);
            // 
            // btnCongress
            // 
            this.btnCongress.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCongress.Location = new System.Drawing.Point(602, 526);
            this.btnCongress.Name = "btnCongress";
            this.btnCongress.Size = new System.Drawing.Size(124, 37);
            this.btnCongress.TabIndex = 1;
            this.btnCongress.Text = "ICT CONGRESS";
            this.btnCongress.UseVisualStyleBackColor = false;
            this.btnCongress.Click += new System.EventHandler(this.btnCongress_Click);
            // 
            // btnSeminar
            // 
            this.btnSeminar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSeminar.Location = new System.Drawing.Point(771, 526);
            this.btnSeminar.Name = "btnSeminar";
            this.btnSeminar.Size = new System.Drawing.Size(124, 37);
            this.btnSeminar.TabIndex = 2;
            this.btnSeminar.Text = "SEMINAR";
            this.btnSeminar.UseVisualStyleBackColor = false;
            this.btnSeminar.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hOMEToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(978, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hOMEToolStripMenuItem
            // 
            this.hOMEToolStripMenuItem.Name = "hOMEToolStripMenuItem";
            this.hOMEToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.hOMEToolStripMenuItem.Text = "HOME";
            this.hOMEToolStripMenuItem.Click += new System.EventHandler(this.hOMEToolStripMenuItem_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // EventList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(978, 591);
            this.Controls.Add(this.btnSeminar);
            this.Controls.Add(this.btnCongress);
            this.Controls.Add(this.btnGODAY);
            this.Controls.Add(this.btnAcquintance);
            this.Controls.Add(this.btnIntrams);
            this.Controls.Add(this.dtgEventList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EventList";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEventList)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgEventList;
        private System.Windows.Forms.Button btnIntrams;
        private System.Windows.Forms.Button btnAcquintance;
        private System.Windows.Forms.Button btnGODAY;
        private System.Windows.Forms.Button btnCongress;
        private System.Windows.Forms.Button btnSeminar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hOMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
    }
}