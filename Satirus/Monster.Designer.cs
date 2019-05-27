namespace Satirus
{
    partial class Monster
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
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.hp = new System.Windows.Forms.ProgressBar();
            this.lblyadda = new System.Windows.Forms.Label();
            this.power = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.defense = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.speed = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.spestat = new System.Windows.Forms.NumericUpDown();
            this.defstat = new System.Windows.Forms.NumericUpDown();
            this.pwrstat = new System.Windows.Forms.NumericUpDown();
            this.maxhp = new System.Windows.Forms.Label();
            this.level = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spestat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defstat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pwrstat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "/";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(270, 25);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(104, 20);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // hp
            // 
            this.hp.BackColor = System.Drawing.Color.Red;
            this.hp.Location = new System.Drawing.Point(270, 11);
            this.hp.Name = "hp";
            this.hp.Size = new System.Drawing.Size(240, 13);
            this.hp.TabIndex = 5;
            // 
            // lblyadda
            // 
            this.lblyadda.AutoSize = true;
            this.lblyadda.Location = new System.Drawing.Point(293, 60);
            this.lblyadda.Name = "lblyadda";
            this.lblyadda.Size = new System.Drawing.Size(36, 13);
            this.lblyadda.TabIndex = 9;
            this.lblyadda.Text = "PWR:";
            // 
            // power
            // 
            this.power.AutoSize = true;
            this.power.Location = new System.Drawing.Point(335, 60);
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(13, 13);
            this.power.TabIndex = 10;
            this.power.Text = "0";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(372, 60);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(31, 13);
            this.lbl.TabIndex = 11;
            this.lbl.Text = "DEF:";
            // 
            // defense
            // 
            this.defense.AutoSize = true;
            this.defense.Location = new System.Drawing.Point(410, 60);
            this.defense.Name = "defense";
            this.defense.Size = new System.Drawing.Size(13, 13);
            this.defense.TabIndex = 12;
            this.defense.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(448, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "SPE:";
            // 
            // speed
            // 
            this.speed.AutoSize = true;
            this.speed.Location = new System.Drawing.Point(485, 60);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(13, 13);
            this.speed.TabIndex = 14;
            this.speed.Text = "0";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(17, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 26);
            this.textBox1.TabIndex = 15;
            // 
            // spestat
            // 
            this.spestat.Location = new System.Drawing.Point(209, 55);
            this.spestat.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.spestat.Name = "spestat";
            this.spestat.Size = new System.Drawing.Size(46, 20);
            this.spestat.TabIndex = 18;
            this.spestat.ValueChanged += new System.EventHandler(this.spestat_ValueChanged);
            // 
            // defstat
            // 
            this.defstat.Location = new System.Drawing.Point(157, 55);
            this.defstat.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.defstat.Name = "defstat";
            this.defstat.Size = new System.Drawing.Size(46, 20);
            this.defstat.TabIndex = 17;
            this.defstat.ValueChanged += new System.EventHandler(this.defstat_ValueChanged);
            // 
            // pwrstat
            // 
            this.pwrstat.Location = new System.Drawing.Point(105, 55);
            this.pwrstat.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.pwrstat.Name = "pwrstat";
            this.pwrstat.Size = new System.Drawing.Size(46, 20);
            this.pwrstat.TabIndex = 16;
            this.pwrstat.ValueChanged += new System.EventHandler(this.pwrstat_ValueChanged);
            // 
            // maxhp
            // 
            this.maxhp.AutoSize = true;
            this.maxhp.Location = new System.Drawing.Point(398, 27);
            this.maxhp.Name = "maxhp";
            this.maxhp.Size = new System.Drawing.Size(13, 13);
            this.maxhp.TabIndex = 19;
            this.maxhp.Text = "0";
            // 
            // level
            // 
            this.level.Location = new System.Drawing.Point(218, 17);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(46, 20);
            this.level.TabIndex = 20;
            this.level.ValueChanged += new System.EventHandler(this.level_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "LVL:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.CausesValidation = false;
            this.label4.Location = new System.Drawing.Point(14, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "(str, res, spe)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.CausesValidation = false;
            this.label6.Location = new System.Drawing.Point(14, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Stat modifiers";
            // 
            // Monster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.level);
            this.Controls.Add(this.maxhp);
            this.Controls.Add(this.spestat);
            this.Controls.Add(this.defstat);
            this.Controls.Add(this.pwrstat);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.speed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.defense);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.power);
            this.Controls.Add(this.lblyadda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.hp);
            this.Name = "Monster";
            this.Size = new System.Drawing.Size(535, 86);
            this.Load += new System.EventHandler(this.Monster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spestat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defstat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pwrstat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.NumericUpDown numericUpDown1;
        public System.Windows.Forms.ProgressBar hp;
        public System.Windows.Forms.Label lblyadda;
        public System.Windows.Forms.Label power;
        public System.Windows.Forms.Label lbl;
        public System.Windows.Forms.Label defense;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label speed;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.NumericUpDown spestat;
        public System.Windows.Forms.NumericUpDown defstat;
        public System.Windows.Forms.NumericUpDown pwrstat;
        public System.Windows.Forms.Label maxhp;
        public System.Windows.Forms.NumericUpDown level;
        public System.Windows.Forms.Label label1;
    }
}
