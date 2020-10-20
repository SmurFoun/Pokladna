namespace Pokladna
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxObdobi = new System.Windows.Forms.GroupBox();
            this.comboBoxMesic = new System.Windows.Forms.ComboBox();
            this.comboBoxRok = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dateTimePickerDatum = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCisloDokladu = new System.Windows.Forms.TextBox();
            this.textBoxPopis = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownCastka = new System.Windows.Forms.NumericUpDown();
            this.textBoxPoznamka = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonUlozit = new System.Windows.Forms.Button();
            this.buttonUlozitJakoNovy = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBoxObdobi.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCastka)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBoxObdobi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(755, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 513);
            this.panel1.TabIndex = 0;
            // 
            // groupBoxObdobi
            // 
            this.groupBoxObdobi.Controls.Add(this.comboBoxMesic);
            this.groupBoxObdobi.Controls.Add(this.comboBoxRok);
            this.groupBoxObdobi.Controls.Add(this.label2);
            this.groupBoxObdobi.Controls.Add(this.label1);
            this.groupBoxObdobi.Location = new System.Drawing.Point(3, 3);
            this.groupBoxObdobi.Name = "groupBoxObdobi";
            this.groupBoxObdobi.Size = new System.Drawing.Size(303, 82);
            this.groupBoxObdobi.TabIndex = 0;
            this.groupBoxObdobi.TabStop = false;
            this.groupBoxObdobi.Text = "Účetní období";
            // 
            // comboBoxMesic
            // 
            this.comboBoxMesic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMesic.FormattingEnabled = true;
            this.comboBoxMesic.Items.AddRange(new object[] {
            "Leden",
            "Únor",
            "Březen",
            "Duben",
            "Květen",
            "Červen\t",
            "Červenec",
            "Srpen",
            "Září",
            "Říjen",
            "Listopad",
            "Prosinec"});
            this.comboBoxMesic.Location = new System.Drawing.Point(74, 52);
            this.comboBoxMesic.Name = "comboBoxMesic";
            this.comboBoxMesic.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMesic.TabIndex = 3;
            this.comboBoxMesic.SelectedIndexChanged += new System.EventHandler(this.comboBoxRok_SelectedIndexChanged);
            // 
            // comboBoxRok
            // 
            this.comboBoxRok.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRok.FormattingEnabled = true;
            this.comboBoxRok.Items.AddRange(new object[] {
            "2021",
            "2020",
            "2019"});
            this.comboBoxRok.Location = new System.Drawing.Point(74, 22);
            this.comboBoxRok.Name = "comboBoxRok";
            this.comboBoxRok.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRok.TabIndex = 2;
            this.comboBoxRok.SelectedIndexChanged += new System.EventHandler(this.comboBoxRok_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Měsíc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rok";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.HoverSelection = true;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(755, 513);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Datum";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Číslo dokladu";
            this.columnHeader2.Width = 93;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Popis";
            this.columnHeader3.Width = 192;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Příjmy";
            this.columnHeader4.Width = 69;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Výdaje";
            this.columnHeader5.Width = 75;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Zůstatek";
            this.columnHeader6.Width = 67;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Poznámka";
            this.columnHeader7.Width = 130;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonUlozitJakoNovy);
            this.groupBox1.Controls.Add(this.buttonUlozit);
            this.groupBox1.Controls.Add(this.textBoxPoznamka);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.numericUpDownCastka);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxPopis);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxCisloDokladu);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePickerDatum);
            this.groupBox1.Location = new System.Drawing.Point(3, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 213);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Položka";
            // 
            // dateTimePickerDatum
            // 
            this.dateTimePickerDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDatum.Location = new System.Drawing.Point(87, 32);
            this.dateTimePickerDatum.Name = "dateTimePickerDatum";
            this.dateTimePickerDatum.Size = new System.Drawing.Size(108, 20);
            this.dateTimePickerDatum.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Datum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Č. dokladu";
            // 
            // textBoxCisloDokladu
            // 
            this.textBoxCisloDokladu.Location = new System.Drawing.Point(88, 66);
            this.textBoxCisloDokladu.Name = "textBoxCisloDokladu";
            this.textBoxCisloDokladu.ReadOnly = true;
            this.textBoxCisloDokladu.Size = new System.Drawing.Size(142, 20);
            this.textBoxCisloDokladu.TabIndex = 8;
            this.textBoxCisloDokladu.TextChanged += new System.EventHandler(this.textBoxCisloDokladu_TextChanged);
            // 
            // textBoxPopis
            // 
            this.textBoxPopis.Location = new System.Drawing.Point(88, 92);
            this.textBoxPopis.Name = "textBoxPopis";
            this.textBoxPopis.Size = new System.Drawing.Size(207, 20);
            this.textBoxPopis.TabIndex = 10;
            this.textBoxPopis.TextChanged += new System.EventHandler(this.textBoxPopis_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Popis";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Částka";
            // 
            // numericUpDownCastka
            // 
            this.numericUpDownCastka.Location = new System.Drawing.Point(88, 121);
            this.numericUpDownCastka.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.numericUpDownCastka.Minimum = new decimal(new int[] {
            200000,
            0,
            0,
            -2147483648});
            this.numericUpDownCastka.Name = "numericUpDownCastka";
            this.numericUpDownCastka.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownCastka.TabIndex = 12;
            this.numericUpDownCastka.ValueChanged += new System.EventHandler(this.numericUpDownCastka_ValueChanged);
            // 
            // textBoxPoznamka
            // 
            this.textBoxPoznamka.Location = new System.Drawing.Point(88, 147);
            this.textBoxPoznamka.Name = "textBoxPoznamka";
            this.textBoxPoznamka.Size = new System.Drawing.Size(207, 20);
            this.textBoxPoznamka.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Poznámka";
            // 
            // buttonUlozit
            // 
            this.buttonUlozit.Enabled = false;
            this.buttonUlozit.Location = new System.Drawing.Point(214, 173);
            this.buttonUlozit.Name = "buttonUlozit";
            this.buttonUlozit.Size = new System.Drawing.Size(83, 34);
            this.buttonUlozit.TabIndex = 15;
            this.buttonUlozit.Text = "Uložit";
            this.buttonUlozit.UseVisualStyleBackColor = true;
            // 
            // buttonUlozitJakoNovy
            // 
            this.buttonUlozitJakoNovy.Enabled = false;
            this.buttonUlozitJakoNovy.Location = new System.Drawing.Point(100, 173);
            this.buttonUlozitJakoNovy.Name = "buttonUlozitJakoNovy";
            this.buttonUlozitJakoNovy.Size = new System.Drawing.Size(108, 34);
            this.buttonUlozitJakoNovy.TabIndex = 16;
            this.buttonUlozitJakoNovy.Text = "Uložit jako nový";
            this.buttonUlozitJakoNovy.UseVisualStyleBackColor = true;
            this.buttonUlozitJakoNovy.Click += new System.EventHandler(this.buttonUlozitJakoNovy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 513);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.groupBoxObdobi.ResumeLayout(false);
            this.groupBoxObdobi.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCastka)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.GroupBox groupBoxObdobi;
        private System.Windows.Forms.ComboBox comboBoxMesic;
        private System.Windows.Forms.ComboBox comboBoxRok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownCastka;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPopis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCisloDokladu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatum;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBoxPoznamka;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonUlozitJakoNovy;
        private System.Windows.Forms.Button buttonUlozit;
    }
}

