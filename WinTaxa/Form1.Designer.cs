namespace WinTaxa
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
            StartPris = new Label();
            textBox1 = new TextBox();
            Afstand = new Label();
            textBox2 = new TextBox();
            Destination = new Label();
            textBox3 = new TextBox();
            NatTid = new CheckBox();
            StorVogn = new CheckBox();
            DagTid = new CheckBox();
            numericUpDown1 = new NumericUpDown();
            AntalPassagere = new Label();
            ForventetPris = new Label();
            BeregnPris = new Button();
            AabenGoogleMaps = new Button();
            label1 = new Label();
            textBox4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // StartPris
            // 
            StartPris.AutoSize = true;
            StartPris.Location = new Point(30, 21);
            StartPris.Name = "StartPris";
            StartPris.Size = new Size(50, 15);
            StartPris.TabIndex = 0;
            StartPris.Text = "StartPris";
            StartPris.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(86, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // Afstand
            // 
            Afstand.AutoSize = true;
            Afstand.Location = new Point(32, 59);
            Afstand.Name = "Afstand";
            Afstand.Size = new Size(48, 15);
            Afstand.TabIndex = 2;
            Afstand.Text = "Afstand";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(86, 56);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // Destination
            // 
            Destination.AutoSize = true;
            Destination.Location = new Point(13, 97);
            Destination.Name = "Destination";
            Destination.Size = new Size(67, 15);
            Destination.TabIndex = 4;
            Destination.Text = "Destination";
            Destination.Click += label1_Click_1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(86, 94);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 5;
            // 
            // NatTid
            // 
            NatTid.AutoSize = true;
            NatTid.Location = new Point(86, 203);
            NatTid.Name = "NatTid";
            NatTid.Size = new Size(67, 19);
            NatTid.TabIndex = 7;
            NatTid.Text = "Nat tid?";
            NatTid.UseVisualStyleBackColor = true;
            // 
            // StorVogn
            // 
            StorVogn.AutoSize = true;
            StorVogn.Location = new Point(86, 153);
            StorVogn.Name = "StorVogn";
            StorVogn.Size = new Size(188, 19);
            StorVogn.TabIndex = 8;
            StorVogn.Text = "Skal vi have en stor vogn med?";
            StorVogn.UseVisualStyleBackColor = true;
            // 
            // DagTid
            // 
            DagTid.AutoSize = true;
            DagTid.Location = new Point(86, 178);
            DagTid.Name = "DagTid";
            DagTid.Size = new Size(69, 19);
            DagTid.TabIndex = 9;
            DagTid.Text = "Dag tid?";
            DagTid.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(109, 301);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 10;
            // 
            // AntalPassagere
            // 
            AntalPassagere.AutoSize = true;
            AntalPassagere.Location = new Point(13, 301);
            AntalPassagere.Name = "AntalPassagere";
            AntalPassagere.Size = new Size(90, 15);
            AntalPassagere.TabIndex = 11;
            AntalPassagere.Text = "Antal passagere";
            // 
            // ForventetPris
            // 
            ForventetPris.AutoSize = true;
            ForventetPris.Location = new Point(13, 344);
            ForventetPris.Name = "ForventetPris";
            ForventetPris.Size = new Size(79, 15);
            ForventetPris.TabIndex = 12;
            ForventetPris.Text = "Forventet Pris";
            // 
            // BeregnPris
            // 
            BeregnPris.Location = new Point(109, 344);
            BeregnPris.Name = "BeregnPris";
            BeregnPris.Size = new Size(77, 23);
            BeregnPris.TabIndex = 13;
            BeregnPris.Tag = "BeregnPris";
            BeregnPris.Text = "Beregn Pris";
            BeregnPris.UseVisualStyleBackColor = true;
            // 
            // AabenGoogleMaps
            // 
            AabenGoogleMaps.Location = new Point(109, 388);
            AabenGoogleMaps.Name = "AabenGoogleMaps";
            AabenGoogleMaps.Size = new Size(149, 23);
            AabenGoogleMaps.TabIndex = 14;
            AabenGoogleMaps.Text = "Åben Google Maps";
            AabenGoogleMaps.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(236, 24);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 15;
            label1.Tag = "Varighed";
            label1.Text = "Varighed";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(304, 21);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 16;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox4);
            Controls.Add(label1);
            Controls.Add(AabenGoogleMaps);
            Controls.Add(BeregnPris);
            Controls.Add(ForventetPris);
            Controls.Add(AntalPassagere);
            Controls.Add(numericUpDown1);
            Controls.Add(DagTid);
            Controls.Add(StorVogn);
            Controls.Add(NatTid);
            Controls.Add(textBox3);
            Controls.Add(Destination);
            Controls.Add(textBox2);
            Controls.Add(Afstand);
            Controls.Add(textBox1);
            Controls.Add(StartPris);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label StartPris;
        private TextBox textBox1;
        private Label Afstand;
        private TextBox textBox2;
        private Label Destination;
        private TextBox textBox3;
        private CheckBox NatTid;
        private CheckBox StorVogn;
        private CheckBox DagTid;
        private NumericUpDown numericUpDown1;
        private Label AntalPassagere;
        private Label ForventetPris;
        private Button BeregnPris;
        private Button AabenGoogleMaps;
        private Label label1;
        private TextBox textBox4;
    }
}