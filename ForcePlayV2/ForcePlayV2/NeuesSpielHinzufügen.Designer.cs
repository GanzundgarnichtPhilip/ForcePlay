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
            installationsdatum = new TextBox();
            zuletztGespielt = new TextBox();
            installationspfad = new TextBox();
            kategorie = new TextBox();
            publisher = new TextBox();
            usk = new ComboBox();
            exitButton = new Button();
            SuspendLayout();
            // 
            // SpielHinzufügenButton
            // 
            SpielHinzufügenButton.BackColor = Color.LightGoldenrodYellow;
            SpielHinzufügenButton.Location = new Point(15, 371);
            SpielHinzufügenButton.Margin = new Padding(4);
            SpielHinzufügenButton.Name = "SpielHinzufügenButton";
            SpielHinzufügenButton.Size = new Size(136, 121);
            SpielHinzufügenButton.TabIndex = 0;
            SpielHinzufügenButton.Text = "Submit";
            SpielHinzufügenButton.UseVisualStyleBackColor = false;
            SpielHinzufügenButton.Click += SpielHinzufügenButton_Click;
            // 
            // titel
            // 
            titel.Location = new Point(49, 15);
            titel.Margin = new Padding(4);
            titel.Name = "titel";
            titel.PlaceholderText = "Titel";
            titel.Size = new Size(228, 27);
            titel.TabIndex = 1;
            titel.TextAlign = HorizontalAlignment.Center;
            titel.TextChanged += textBox1_TextChanged;
            // 
            // installationsdatum
            // 
            installationsdatum.Location = new Point(49, 65);
            installationsdatum.Margin = new Padding(4);
            installationsdatum.Name = "installationsdatum";
            installationsdatum.PlaceholderText = "Installationsdatum";
            installationsdatum.Size = new Size(228, 27);
            installationsdatum.TabIndex = 2;
            installationsdatum.TextAlign = HorizontalAlignment.Center;
            // 
            // zuletztGespielt
            // 
            zuletztGespielt.Location = new Point(49, 118);
            zuletztGespielt.Margin = new Padding(4);
            zuletztGespielt.Name = "zuletztGespielt";
            zuletztGespielt.PlaceholderText = "Zuletzt gespielt";
            zuletztGespielt.Size = new Size(228, 27);
            zuletztGespielt.TabIndex = 3;
            zuletztGespielt.TextAlign = HorizontalAlignment.Center;
            // 
            // installationspfad
            // 
            installationspfad.Location = new Point(49, 171);
            installationspfad.Margin = new Padding(4);
            installationspfad.Name = "installationspfad";
            installationspfad.PlaceholderText = "Installationspfad";
            installationspfad.Size = new Size(228, 27);
            installationspfad.TabIndex = 4;
            installationspfad.TextAlign = HorizontalAlignment.Center;
            // 
            // kategorie
            // 
            kategorie.Location = new Point(49, 219);
            kategorie.Margin = new Padding(4);
            kategorie.Name = "kategorie";
            kategorie.PlaceholderText = "Kategorie";
            kategorie.Size = new Size(228, 27);
            kategorie.TabIndex = 5;
            kategorie.TextAlign = HorizontalAlignment.Center;
            // 
            // publisher
            // 
            publisher.Location = new Point(49, 266);
            publisher.Margin = new Padding(4);
            publisher.Name = "publisher";
            publisher.PlaceholderText = "Publisher";
            publisher.Size = new Size(228, 27);
            publisher.TabIndex = 6;
            publisher.TextAlign = HorizontalAlignment.Center;
            // 
            // usk
            // 
            usk.DropDownStyle = ComboBoxStyle.DropDownList;
            usk.FormattingEnabled = true;
            usk.Items.AddRange(new object[] { "0", "6", "12", "16", "18" });
            usk.Location = new Point(49, 318);
            usk.Margin = new Padding(4);
            usk.Name = "usk";
            usk.Size = new Size(228, 28);
            usk.TabIndex = 7;
            usk.SelectedIndexChanged += usk_SelectedIndexChanged;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.MistyRose;
            exitButton.Location = new Point(159, 371);
            exitButton.Margin = new Padding(4);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(136, 121);
            exitButton.TabIndex = 8;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += Button1_Click;
            // 
            // NeuesSpielHinzufuegen
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            BackColor = Color.Silver;
            ClientSize = new Size(424, 508);
            ControlBox = false;
            Controls.Add(exitButton);
            Controls.Add(usk);
            Controls.Add(publisher);
            Controls.Add(kategorie);
            Controls.Add(installationspfad);
            Controls.Add(zuletztGespielt);
            Controls.Add(installationsdatum);
            Controls.Add(titel);
            Controls.Add(SpielHinzufügenButton);
            Margin = new Padding(4);
            Name = "NeuesSpielHinzufuegen";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SpielHinzufügenButton;
        private TextBox titel;
        private TextBox installationsdatum;
        private TextBox zuletztGespielt;
        private TextBox installationspfad;
        private TextBox kategorie;
        private TextBox publisher;
        private ComboBox usk;
        private Button exitButton;
    }
}