namespace Satirus
{
    partial class Master
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
            this.components = new System.ComponentModel.Container();
            this.charSheet = new System.Windows.Forms.Button();
            this.load = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.idt = new System.Windows.Forms.Label();
            this.battlesimulator = new System.Windows.Forms.Button();
            this.dicebutton = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // charSheet
            // 
            this.charSheet.Location = new System.Drawing.Point(12, 12);
            this.charSheet.Name = "charSheet";
            this.charSheet.Size = new System.Drawing.Size(360, 52);
            this.charSheet.TabIndex = 0;
            this.charSheet.Text = "Character Sheets";
            this.charSheet.UseVisualStyleBackColor = true;
            this.charSheet.Click += new System.EventHandler(this.button1_Click);
            // 
            // load
            // 
            this.load.Enabled = false;
            this.load.Location = new System.Drawing.Point(12, 70);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(204, 52);
            this.load.TabIndex = 1;
            this.load.Text = "Load";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(222, 87);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "Character";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // idt
            // 
            this.idt.AutoSize = true;
            this.idt.Location = new System.Drawing.Point(222, 71);
            this.idt.Name = "idt";
            this.idt.Size = new System.Drawing.Size(25, 13);
            this.idt.TabIndex = 4;
            this.idt.Text = "???";
            // 
            // battlesimulator
            // 
            this.battlesimulator.Location = new System.Drawing.Point(12, 128);
            this.battlesimulator.Name = "battlesimulator";
            this.battlesimulator.Size = new System.Drawing.Size(360, 52);
            this.battlesimulator.TabIndex = 5;
            this.battlesimulator.Text = "Battle Simulator";
            this.battlesimulator.UseVisualStyleBackColor = true;
            this.battlesimulator.Click += new System.EventHandler(this.battlesimulator_Click);
            // 
            // dicebutton
            // 
            this.dicebutton.Location = new System.Drawing.Point(12, 186);
            this.dicebutton.Name = "dicebutton";
            this.dicebutton.Size = new System.Drawing.Size(360, 52);
            this.dicebutton.TabIndex = 6;
            this.dicebutton.Text = "Dices";
            this.dicebutton.UseVisualStyleBackColor = true;
            this.dicebutton.Click += new System.EventHandler(this.dicebutton_Click);
            // 
            // Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(384, 256);
            this.Controls.Add(this.dicebutton);
            this.Controls.Add(this.battlesimulator);
            this.Controls.Add(this.idt);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.load);
            this.Controls.Add(this.charSheet);
            this.Name = "Master";
            this.Text = "Satirus";
            this.Load += new System.EventHandler(this.Master_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button charSheet;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label idt;
        private System.Windows.Forms.Button battlesimulator;
        private System.Windows.Forms.Button dicebutton;
    }
}