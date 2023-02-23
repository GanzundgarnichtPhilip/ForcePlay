namespace ForcePlayV2
{
    partial class NeuesSpielHinzufügen
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
            this.SpielHinzufügenButton = new System.Windows.Forms.Button();
            this.titel = new System.Windows.Forms.TextBox();
            this.Installationsdatum = new System.Windows.Forms.TextBox();
            this.zuletztGespielt = new System.Windows.Forms.TextBox();
            this.installationspfad = new System.Windows.Forms.TextBox();
            this.kategorie = new System.Windows.Forms.TextBox();
            this.publisher = new System.Windows.Forms.TextBox();
            this.usk = new System.Windows.Forms.ComboBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SpielHinzufügenButton
            // 
            this.SpielHinzufügenButton.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.SpielHinzufügenButton.Location = new System.Drawing.Point(12, 297);
            this.SpielHinzufügenButton.Name = "SpielHinzufügenButton";
            this.SpielHinzufügenButton.Size = new System.Drawing.Size(109, 97);
            this.SpielHinzufügenButton.TabIndex = 0;
            this.SpielHinzufügenButton.Text = "Submit";
            this.SpielHinzufügenButton.UseVisualStyleBackColor = false;
            this.SpielHinzufügenButton.UseWaitCursor = true;
            // 
            // titel
            // 
            this.titel.Location = new System.Drawing.Point(39, 12);
            this.titel.Name = "titel";
            this.titel.PlaceholderText = "Titel";
            this.titel.Size = new System.Drawing.Size(183, 23);
            this.titel.TabIndex = 1;
            this.titel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.titel.UseWaitCursor = true;
            this.titel.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Installationsdatum
            // 
            this.Installationsdatum.Location = new System.Drawing.Point(39, 52);
            this.Installationsdatum.Name = "Installationsdatum";
            this.Installationsdatum.PlaceholderText = "Installationsdatum";
            this.Installationsdatum.Size = new System.Drawing.Size(183, 23);
            this.Installationsdatum.TabIndex = 2;
            this.Installationsdatum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Installationsdatum.UseWaitCursor = true;
            // 
            // zuletztGespielt
            // 
            this.zuletztGespielt.Location = new System.Drawing.Point(39, 94);
            this.zuletztGespielt.Name = "zuletztGespielt";
            this.zuletztGespielt.PlaceholderText = "Zuletzt gespielt";
            this.zuletztGespielt.Size = new System.Drawing.Size(183, 23);
            this.zuletztGespielt.TabIndex = 3;
            this.zuletztGespielt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.zuletztGespielt.UseWaitCursor = true;
            // 
            // installationspfad
            // 
            this.installationspfad.Location = new System.Drawing.Point(39, 137);
            this.installationspfad.Name = "installationspfad";
            this.installationspfad.PlaceholderText = "Installationspfad";
            this.installationspfad.Size = new System.Drawing.Size(183, 23);
            this.installationspfad.TabIndex = 4;
            this.installationspfad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.installationspfad.UseWaitCursor = true;
            // 
            // kategorie
            // 
            this.kategorie.Location = new System.Drawing.Point(39, 175);
            this.kategorie.Name = "kategorie";
            this.kategorie.PlaceholderText = "Kategorie";
            this.kategorie.Size = new System.Drawing.Size(183, 23);
            this.kategorie.TabIndex = 5;
            this.kategorie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.kategorie.UseWaitCursor = true;
            // 
            // publisher
            // 
            this.publisher.Location = new System.Drawing.Point(39, 213);
            this.publisher.Name = "publisher";
            this.publisher.PlaceholderText = "Publisher";
            this.publisher.Size = new System.Drawing.Size(183, 23);
            this.publisher.TabIndex = 6;
            this.publisher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.publisher.UseWaitCursor = true;
            // 
            // usk
            // 
            this.usk.FormattingEnabled = true;
            this.usk.Items.AddRange(new object[] {
            "0",
            "6",
            "12",
            "16",
            "18"});
            this.usk.Location = new System.Drawing.Point(39, 254);
            this.usk.Name = "usk";
            this.usk.Size = new System.Drawing.Size(183, 23);
            this.usk.TabIndex = 7;
            this.usk.UseWaitCursor = true;
            this.usk.SelectedIndexChanged += new System.EventHandler(this.usk_SelectedIndexChanged);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.MistyRose;
            this.exitButton.Location = new System.Drawing.Point(127, 297);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(109, 97);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.UseWaitCursor = true;
            this.exitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // NeuesSpielHinzufügen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(245, 406);
            this.ControlBox = false;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.usk);
            this.Controls.Add(this.publisher);
            this.Controls.Add(this.kategorie);
            this.Controls.Add(this.installationspfad);
            this.Controls.Add(this.zuletztGespielt);
            this.Controls.Add(this.Installationsdatum);
            this.Controls.Add(this.titel);
            this.Controls.Add(this.SpielHinzufügenButton);
            this.Name = "NeuesSpielHinzufügen";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}