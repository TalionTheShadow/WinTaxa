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
            StartPrisBox = new TextBox();
            Afstand = new Label();
            AfstandBox = new TextBox();
            Destination = new Label();
            DestinationBox = new TextBox();
            NatTid = new CheckBox();
            StorVogn = new CheckBox();
            DagTid = new CheckBox();
            AntalPassagereNumeric = new NumericUpDown();
            AntalPassagere = new Label();
            ForventetPris = new Label();
            BeregnPris = new Button();
            AabenGoogleMaps = new Button();
            label1 = new Label();
            VarighedBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)AntalPassagereNumeric).BeginInit();
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
            // StartPrisBox
            // 
            StartPrisBox.Location = new Point(86, 18);
            StartPrisBox.Name = "StartPrisBox";
            StartPrisBox.Size = new Size(100, 23);
            StartPrisBox.TabIndex = 1;
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
            // AfstandBox
            // 
            AfstandBox.Location = new Point(86, 56);
            AfstandBox.Name = "AfstandBox";
            AfstandBox.Size = new Size(100, 23);
            AfstandBox.TabIndex = 3;
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
            // DestinationBox
            // 
            DestinationBox.Location = new Point(86, 94);
            DestinationBox.Name = "DestinationBox";
            DestinationBox.Size = new Size(100, 23);
            DestinationBox.TabIndex = 5;
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
            // AntalPassagereNumeric
            // 
            AntalPassagereNumeric.Location = new Point(109, 301);
            AntalPassagereNumeric.Name = "AntalPassagereNumeric";
            AntalPassagereNumeric.Size = new Size(120, 23);
            AntalPassagereNumeric.TabIndex = 10;
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
            BeregnPris.Location = new Point(152, 344);
            BeregnPris.Name = "BeregnPris";
            BeregnPris.Size = new Size(77, 23);
            BeregnPris.TabIndex = 13;
            BeregnPris.Tag = "BeregnPris";
            BeregnPris.Text = "Beregn Pris";
            BeregnPris.UseVisualStyleBackColor = true;
            BeregnPris.Click += BeregnPris_Click;
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
            // VarighedBox
            // 
            VarighedBox.Location = new Point(304, 21);
            VarighedBox.Name = "VarighedBox";
            VarighedBox.Size = new Size(100, 23);
            VarighedBox.TabIndex = 16;
            VarighedBox.TextChanged += textBox4_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(VarighedBox);
            Controls.Add(label1);
            Controls.Add(AabenGoogleMaps);
            Controls.Add(BeregnPris);
            Controls.Add(ForventetPris);
            Controls.Add(AntalPassagere);
            Controls.Add(AntalPassagereNumeric);
            Controls.Add(DagTid);
            Controls.Add(StorVogn);
            Controls.Add(NatTid);
            Controls.Add(DestinationBox);
            Controls.Add(Destination);
            Controls.Add(AfstandBox);
            Controls.Add(Afstand);
            Controls.Add(StartPrisBox);
            Controls.Add(StartPris);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)AntalPassagereNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label StartPris;
        private TextBox StartPrisBox;
        private Label Afstand;
        private TextBox AfstandBox;
        private Label Destination;
        private TextBox DestinationBox;
        private CheckBox NatTid;
        private CheckBox StorVogn;
        private CheckBox DagTid;
        private NumericUpDown AntalPassagereNumeric;
        private Label AntalPassagere;
        private Label ForventetPris;
        private Button BeregnPris;
        private Button AabenGoogleMaps;
        private Label label1;
        private TextBox VarighedBox;
    }
}