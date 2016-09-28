namespace E_Deklaracja.Controls
{
    partial class SendControl
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
            this.btnSend = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbTestowy = new System.Windows.Forms.RadioButton();
            this.rbOficjalny = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKodStatusu = new System.Windows.Forms.Label();
            this.txtStatusWysylki = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboCertificates = new System.Windows.Forms.ComboBox();
            this.btnPobierzUpo = new System.Windows.Forms.Button();
            this.btnDrukujUpo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumerReferencyjny = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rtxtDane = new System.Windows.Forms.RichTextBox();
            this.cbBezPodpisu = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(111, 110);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(202, 23);
            this.btnSend.TabIndex = 12;
            this.btnSend.Text = "Wyśllij e-Deklarację...";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbTestowy);
            this.panel1.Controls.Add(this.rbOficjalny);
            this.panel1.Location = new System.Drawing.Point(113, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 17);
            this.panel1.TabIndex = 11;
            // 
            // rbTestowy
            // 
            this.rbTestowy.AutoSize = true;
            this.rbTestowy.Checked = true;
            this.rbTestowy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbTestowy.Location = new System.Drawing.Point(91, 0);
            this.rbTestowy.Name = "rbTestowy";
            this.rbTestowy.Size = new System.Drawing.Size(65, 17);
            this.rbTestowy.TabIndex = 1;
            this.rbTestowy.TabStop = true;
            this.rbTestowy.Text = "Testowy";
            this.rbTestowy.UseVisualStyleBackColor = true;
            // 
            // rbOficjalny
            // 
            this.rbOficjalny.AutoSize = true;
            this.rbOficjalny.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbOficjalny.Location = new System.Drawing.Point(0, 0);
            this.rbOficjalny.Name = "rbOficjalny";
            this.rbOficjalny.Size = new System.Drawing.Size(65, 17);
            this.rbOficjalny.TabIndex = 0;
            this.rbOficjalny.Text = "Oficjalny";
            this.rbOficjalny.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Typ komunikacji:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Plik e-deklaracji:";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(111, 3);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(591, 20);
            this.txtFilePath.TabIndex = 8;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(599, 29);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(103, 23);
            this.btnOpenFile.TabIndex = 7;
            this.btnOpenFile.Text = "Wczytaj plik...";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Status wysyłki:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Kod statusu wysyłki:";
            // 
            // txtKodStatusu
            // 
            this.txtKodStatusu.AutoSize = true;
            this.txtKodStatusu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtKodStatusu.Location = new System.Drawing.Point(113, 339);
            this.txtKodStatusu.Name = "txtKodStatusu";
            this.txtKodStatusu.Size = new System.Drawing.Size(28, 13);
            this.txtKodStatusu.TabIndex = 15;
            this.txtKodStatusu.Text = "brak";
            // 
            // txtStatusWysylki
            // 
            this.txtStatusWysylki.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtStatusWysylki.Location = new System.Drawing.Point(113, 364);
            this.txtStatusWysylki.Name = "txtStatusWysylki";
            this.txtStatusWysylki.Size = new System.Drawing.Size(589, 114);
            this.txtStatusWysylki.TabIndex = 16;
            this.txtStatusWysylki.Text = "brak";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Certyfikat:";
            // 
            // comboCertificates
            // 
            this.comboCertificates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCertificates.FormattingEnabled = true;
            this.comboCertificates.Location = new System.Drawing.Point(111, 83);
            this.comboCertificates.Name = "comboCertificates";
            this.comboCertificates.Size = new System.Drawing.Size(591, 21);
            this.comboCertificates.TabIndex = 18;
            // 
            // btnPobierzUpo
            // 
            this.btnPobierzUpo.Location = new System.Drawing.Point(319, 308);
            this.btnPobierzUpo.Name = "btnPobierzUpo";
            this.btnPobierzUpo.Size = new System.Drawing.Size(158, 23);
            this.btnPobierzUpo.TabIndex = 19;
            this.btnPobierzUpo.Text = "Sprawdź status...";
            this.btnPobierzUpo.UseVisualStyleBackColor = true;
            // 
            // btnDrukujUpo
            // 
            this.btnDrukujUpo.Location = new System.Drawing.Point(483, 308);
            this.btnDrukujUpo.Name = "btnDrukujUpo";
            this.btnDrukujUpo.Size = new System.Drawing.Size(158, 23);
            this.btnDrukujUpo.TabIndex = 20;
            this.btnDrukujUpo.Text = "Zapisz UPO do pdf";
            this.btnDrukujUpo.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Location = new System.Drawing.Point(502, 513);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 17);
            this.panel2.TabIndex = 22;
            this.panel2.Visible = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton1.Location = new System.Drawing.Point(91, 0);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(82, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "bez podpisu";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton2.Location = new System.Drawing.Point(0, 0);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(78, 17);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.Text = "z podpisem";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(392, 515);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Plik:";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Numer referencyjny:";
            // 
            // txtNumerReferencyjny
            // 
            this.txtNumerReferencyjny.Location = new System.Drawing.Point(111, 310);
            this.txtNumerReferencyjny.Name = "txtNumerReferencyjny";
            this.txtNumerReferencyjny.Size = new System.Drawing.Size(202, 20);
            this.txtNumerReferencyjny.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Wysłane dane:";
            // 
            // rtxtDane
            // 
            this.rtxtDane.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtDane.Location = new System.Drawing.Point(111, 141);
            this.rtxtDane.Name = "rtxtDane";
            this.rtxtDane.Size = new System.Drawing.Size(591, 161);
            this.rtxtDane.TabIndex = 26;
            this.rtxtDane.Text = "";
            // 
            // cbBezPodpisu
            // 
            this.cbBezPodpisu.AutoSize = true;
            this.cbBezPodpisu.Location = new System.Drawing.Point(319, 54);
            this.cbBezPodpisu.Name = "cbBezPodpisu";
            this.cbBezPodpisu.Size = new System.Drawing.Size(113, 17);
            this.cbBezPodpisu.TabIndex = 27;
            this.cbBezPodpisu.Text = "Wyślij bez podpisu";
            this.cbBezPodpisu.UseVisualStyleBackColor = true;
            // 
            // SendControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbBezPodpisu);
            this.Controls.Add(this.rtxtDane);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNumerReferencyjny);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDrukujUpo);
            this.Controls.Add(this.btnPobierzUpo);
            this.Controls.Add(this.comboCertificates);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtStatusWysylki);
            this.Controls.Add(this.txtKodStatusu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnOpenFile);
            this.Name = "SendControl";
            this.Size = new System.Drawing.Size(705, 533);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbTestowy;
        private System.Windows.Forms.RadioButton rbOficjalny;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtKodStatusu;
        private System.Windows.Forms.Label txtStatusWysylki;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboCertificates;
        private System.Windows.Forms.Button btnPobierzUpo;
        private System.Windows.Forms.Button btnDrukujUpo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumerReferencyjny;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rtxtDane;
        private System.Windows.Forms.CheckBox cbBezPodpisu;
    }
}
