namespace ForcePlayV2
{
    partial class NeuesSpielHinzufuegen
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
            SpielHinzufügenButton = new Button();
            titel = new TextBox();
            Installationsdatum = new TextBox();
            zuletztGespielt = new TextBox();
            installationspfad = new TextBox();
            kategorie = new TextBox();
            publisher = new TextBox();
            usk = new ComboBox();
            exitButton = new Button();
            prüfung = new Label();
            SuspendLayout();
            // 
            // SpielHinzufügenButton
            // 
            SpielHinzufügenButton.BackColor = Color.LightGoldenrodYellow;
            SpielHinzufügenButton.Location = new Point(12, 297);
            SpielHinzufügenButton.Name = "SpielHinzufügenButton";
            SpielHinzufügenButton.Size = new Size(109, 97);
            SpielHinzufügenButton.TabIndex = 0;
            SpielHinzufügenButton.Text = "Submit";
            SpielHinzufügenButton.UseVisualStyleBackColor = false;
            SpielHinzufügenButton.Click += SpielHinzufügenButton_Click;
            // 
            // titel
            // 
            titel.Location = new Point(39, 12);
            titel.Name = "titel";
            titel.PlaceholderText = "Titel";
            titel.Size = new Size(183, 23);
            titel.TabIndex = 1;
            titel.TextAlign = HorizontalAlignment.Center;
            titel.TextChanged += textBox1_TextChanged;
            // 
            // Installationsdatum
            // 
            Installationsdatum.Location = new Point(39, 52);
            Installationsdatum.Name = "Installationsdatum";
            Installationsdatum.PlaceholderText = "Installationsdatum";
            Installationsdatum.Size = new Size(183, 23);
            Installationsdatum.TabIndex = 2;
            Installationsdatum.TextAlign = HorizontalAlignment.Center;
            // 
            // zuletztGespielt
            // 
            zuletztGespielt.Location = new Point(39, 94);
            zuletztGespielt.Name = "zuletztGespielt";
            zuletztGespielt.PlaceholderText = "Zuletzt gespielt";
            zuletztGespielt.Size = new Size(183, 23);
            zuletztGespielt.TabIndex = 3;
            zuletztGespielt.TextAlign = HorizontalAlignment.Center;
            // 
            // installationspfad
            // 
            installationspfad.Location = new Point(39, 137);
            installationspfad.Name = "installationspfad";
            installationspfad.PlaceholderText = "Installationspfad";
            installationspfad.Size = new Size(183, 23);
            installationspfad.TabIndex = 4;
            installationspfad.TextAlign = HorizontalAlignment.Center;
            // 
            // kategorie
            // 
            kategorie.Location = new Point(39, 175);
            kategorie.Name = "kategorie";
            kategorie.PlaceholderText = "Kategorie";
            kategorie.Size = new Size(183, 23);
            kategorie.TabIndex = 5;
            kategorie.TextAlign = HorizontalAlignment.Center;
            // 
            // publisher
            // 
            publisher.Location = new Point(39, 213);
            publisher.Name = "publisher";
            publisher.PlaceholderText = "Publisher";
            publisher.Size = new Size(183, 23);
            publisher.TabIndex = 6;
            publisher.TextAlign = HorizontalAlignment.Center;
            // 
            // usk
            // 
            usk.FormattingEnabled = true;
            usk.Items.AddRange(new object[] { "0", "6", "12", "16", "18" });
            usk.Location = new Point(39, 254);
            usk.Name = "usk";
            usk.Size = new Size(183, 23);
            usk.TabIndex = 7;
            usk.SelectedIndexChanged += usk_SelectedIndexChanged;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.MistyRose;
            exitButton.Location = new Point(127, 297);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(109, 97);
            exitButton.TabIndex = 8;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += button1_Click;
            // 
            // prüfung
            // 
            prüfung.AutoSize = true;
            prüfung.Location = new Point(228, 140);
            prüfung.Name = "prüfung";
            prüfung.Size = new Size(38, 15);
            prüfung.TabIndex = 9;
            prüfung.Text = "label1";
            // 
            // NeuesSpielHinzufuegen
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            BackColor = Color.Silver;
            ClientSize = new Size(339, 406);
            ControlBox = false;
            Controls.Add(prüfung);
            Controls.Add(exitButton);
            Controls.Add(usk);
            Controls.Add(publisher);
            Controls.Add(kategorie);
            Controls.Add(installationspfad);
            Controls.Add(zuletztGespielt);
            Controls.Add(Installationsdatum);
            Controls.Add(titel);
            Controls.Add(SpielHinzufügenButton);
            Name = "NeuesSpielHinzufuegen";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SpielHinzufügenButton;
        private TextBox titel;
        private TextBox Installationsdatum;
        private TextBox zuletztGespielt;
        private TextBox installationspfad;
        private TextBox kategorie;
        private TextBox publisher;
        private ComboBox usk;
        private Button exitButton;
        private Label label2;
        private Label prüfung;
    }
}