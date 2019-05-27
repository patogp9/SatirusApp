namespace Satirus
{
    partial class fighter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hp = new System.Windows.Forms.ProgressBar();
            this.currhp = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.strstat = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.intstat = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.resstat = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.agistat = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.chastat = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.lucstat = new System.Windows.Forms.NumericUpDown();
            this.namechar = new System.Windows.Forms.ComboBox();
            this.level = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tothp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.currhp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strstat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intstat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resstat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agistat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chastat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lucstat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level)).BeginInit();
            this.SuspendLayout();
            // 
            // hp
            // 
            this.hp.Location = new System.Drawing.Point(270, 11);
            this.hp.Name = "hp";
            this.hp.Size = new System.Drawing.Size(240, 13);
            this.hp.TabIndex = 1;
            // 
            // currhp
            // 
            this.currhp.Location = new System.Drawing.Point(270, 25);
            this.currhp.Name = "currhp";
            this.currhp.Size = new System.Drawing.Size(104, 20);
            this.currhp.TabIndex = 2;
            this.currhp.ValueChanged += new System.EventHandler(this.currhp_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "/";
            // 
            // strstat
            // 
            this.strstat.Location = new System.Drawing.Point(48, 57);
            this.strstat.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.strstat.Name = "strstat";
            this.strstat.Size = new System.Drawing.Size(46, 20);
            this.strstat.TabIndex = 5;
            this.strstat.ValueChanged += new System.EventHandler(this.strstat_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "STR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "INT";
            // 
            // intstat
            // 
            this.intstat.Location = new System.Drawing.Point(129, 57);
            this.intstat.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.intstat.Name = "intstat";
            this.intstat.Size = new System.Drawing.Size(46, 20);
            this.intstat.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "RES";
            // 
            // resstat
            // 
            this.resstat.Location = new System.Drawing.Point(214, 57);
            this.resstat.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.resstat.Name = "resstat";
            this.resstat.Size = new System.Drawing.Size(46, 20);
            this.resstat.TabIndex = 9;
            this.resstat.ValueChanged += new System.EventHandler(this.resstat_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(267, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "AGI";
            // 
            // agistat
            // 
            this.agistat.Location = new System.Drawing.Point(295, 57);
            this.agistat.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.agistat.Name = "agistat";
            this.agistat.Size = new System.Drawing.Size(46, 20);
            this.agistat.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(348, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "CHA";
            // 
            // chastat
            // 
            this.chastat.Location = new System.Drawing.Point(380, 57);
            this.chastat.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.chastat.Name = "chastat";
            this.chastat.Size = new System.Drawing.Size(46, 20);
            this.chastat.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(433, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "LUC";
            // 
            // lucstat
            // 
            this.lucstat.Location = new System.Drawing.Point(464, 57);
            this.lucstat.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.lucstat.Name = "lucstat";
            this.lucstat.Size = new System.Drawing.Size(46, 20);
            this.lucstat.TabIndex = 15;
            // 
            // namechar
            // 
            this.namechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namechar.FormattingEnabled = true;
            this.namechar.Location = new System.Drawing.Point(17, 12);
            this.namechar.Name = "namechar";
            this.namechar.Size = new System.Drawing.Size(192, 28);
            this.namechar.TabIndex = 17;
            this.namechar.Text = "Character";
            this.namechar.SelectedIndexChanged += new System.EventHandler(this.namechar_changed);
            this.namechar.Click += new System.EventHandler(this.namechar_Click);
            // 
            // level
            // 
            this.level.Location = new System.Drawing.Point(218, 25);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(42, 20);
            this.level.TabIndex = 19;
            this.level.ValueChanged += new System.EventHandler(this.level_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Lvl";
            // 
            // tothp
            // 
            this.tothp.AutoSize = true;
            this.tothp.Location = new System.Drawing.Point(398, 27);
            this.tothp.Name = "tothp";
            this.tothp.Size = new System.Drawing.Size(13, 13);
            this.tothp.TabIndex = 21;
            this.tothp.Text = "0";
            // 
            // fighter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.Controls.Add(this.tothp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.level);
            this.Controls.Add(this.namechar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lucstat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chastat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.agistat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.resstat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.intstat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.strstat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.currhp);
            this.Controls.Add(this.hp);
            this.Name = "fighter";
            this.Size = new System.Drawing.Size(521, 86);
            this.Load += new System.EventHandler(this.fighter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.currhp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strstat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intstat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resstat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agistat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chastat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lucstat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tothp;
        public System.Windows.Forms.ProgressBar hp;
        public System.Windows.Forms.NumericUpDown currhp;
        public System.Windows.Forms.NumericUpDown strstat;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.NumericUpDown intstat;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.NumericUpDown resstat;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.NumericUpDown agistat;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.NumericUpDown chastat;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.NumericUpDown lucstat;
        public System.Windows.Forms.ComboBox namechar;
        public System.Windows.Forms.NumericUpDown level;
    }
}
