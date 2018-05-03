namespace Workers
{
    partial class Form1
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
            this.NameText = new System.Windows.Forms.TextBox();
            this.SecondNameText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CheckDirector = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CheckManager = new System.Windows.Forms.CheckBox();
            this.CheckWorkers = new System.Windows.Forms.CheckBox();
            this.HoursInWorkNumeric = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.yearsInCorpo = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numericOfPeople = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HoursInWorkNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearsInCorpo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericOfPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(26, 54);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(100, 20);
            this.NameText.TabIndex = 0;
            this.NameText.Text = "Janusz";
            this.NameText.TextChanged += new System.EventHandler(this.Name_TextChanged);
            // 
            // SecondNameText
            // 
            this.SecondNameText.Location = new System.Drawing.Point(175, 54);
            this.SecondNameText.Name = "SecondNameText";
            this.SecondNameText.Size = new System.Drawing.Size(100, 20);
            this.SecondNameText.TabIndex = 1;
            this.SecondNameText.Text = "Tracz";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Imie";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(201, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Nazwisko";
            // 
            // CheckDirector
            // 
            this.CheckDirector.AutoSize = true;
            this.CheckDirector.Location = new System.Drawing.Point(116, 115);
            this.CheckDirector.Name = "CheckDirector";
            this.CheckDirector.Size = new System.Drawing.Size(66, 17);
            this.CheckDirector.TabIndex = 4;
            this.CheckDirector.Text = "Dyrektor";
            this.CheckDirector.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(120, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Stanowisko";
            // 
            // CheckManager
            // 
            this.CheckManager.AutoSize = true;
            this.CheckManager.Location = new System.Drawing.Point(116, 138);
            this.CheckManager.Name = "CheckManager";
            this.CheckManager.Size = new System.Drawing.Size(72, 17);
            this.CheckManager.TabIndex = 6;
            this.CheckManager.Text = "Kierownik";
            this.CheckManager.UseVisualStyleBackColor = true;
            // 
            // CheckWorkers
            // 
            this.CheckWorkers.AutoSize = true;
            this.CheckWorkers.Location = new System.Drawing.Point(116, 161);
            this.CheckWorkers.Name = "CheckWorkers";
            this.CheckWorkers.Size = new System.Drawing.Size(76, 17);
            this.CheckWorkers.TabIndex = 7;
            this.CheckWorkers.Text = "Pracownik";
            this.CheckWorkers.UseVisualStyleBackColor = true;
            // 
            // HoursInWorkNumeric
            // 
            this.HoursInWorkNumeric.Location = new System.Drawing.Point(92, 210);
            this.HoursInWorkNumeric.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.HoursInWorkNumeric.Name = "HoursInWorkNumeric";
            this.HoursInWorkNumeric.Size = new System.Drawing.Size(120, 20);
            this.HoursInWorkNumeric.TabIndex = 8;
            this.HoursInWorkNumeric.Value = new decimal(new int[] {
            199,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(92, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Przepracowane godziny";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(95, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 51);
            this.button2.TabIndex = 10;
            this.button2.Text = "Generuj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // yearsInCorpo
            // 
            this.yearsInCorpo.Location = new System.Drawing.Point(95, 254);
            this.yearsInCorpo.Name = "yearsInCorpo";
            this.yearsInCorpo.Size = new System.Drawing.Size(120, 20);
            this.yearsInCorpo.TabIndex = 11;
            this.yearsInCorpo.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(92, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Staż w korporacji ";
            // 
            // numericOfPeople
            // 
            this.numericOfPeople.Location = new System.Drawing.Point(194, 135);
            this.numericOfPeople.Name = "numericOfPeople";
            this.numericOfPeople.Size = new System.Drawing.Size(120, 20);
            this.numericOfPeople.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(252, 294);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(186, 37);
            this.button3.TabIndex = 14;
            this.button3.Text = "Dodaj dyrektora";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(453, 360);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.numericOfPeople);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.yearsInCorpo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.HoursInWorkNumeric);
            this.Controls.Add(this.CheckWorkers);
            this.Controls.Add(this.CheckManager);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CheckDirector);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SecondNameText);
            this.Controls.Add(this.NameText);
            this.Name = "Form1";
            this.Text = "Pracownicy";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.HoursInWorkNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearsInCorpo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericOfPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown hoursInMonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown yearsInCorporation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.TextBox SecondNameText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox CheckDirector;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox CheckManager;
        private System.Windows.Forms.CheckBox CheckWorkers;
        private System.Windows.Forms.NumericUpDown HoursInWorkNumeric;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown yearsInCorpo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericOfPeople;
        private System.Windows.Forms.Button button3;
    }
}

