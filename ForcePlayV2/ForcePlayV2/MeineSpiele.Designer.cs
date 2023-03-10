namespace ForcePlayV2
{
    partial class MeineSpiele
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
            publisher_label = new Label();
            spiele = new ListBox();
            titel_label = new Label();
            genres_label = new Label();
            zuletztGesp_label = new Label();
            instPfad_label = new Label();
            instDatum_label = new Label();
            usk_label = new Label();
            publisher = new TextBox();
            genres = new TextBox();
            zuletztGesp = new TextBox();
            usk = new TextBox();
            instDatum = new TextBox();
            instPfad = new TextBox();
            titel = new TextBox();
            SuspendLayout();
            // 
            // publisher_label
            // 
            publisher_label.AutoSize = true;
            publisher_label.Font = new Font("Agency FB", 15F, FontStyle.Regular, GraphicsUnit.Point);
            publisher_label.ImeMode = ImeMode.NoControl;
            publisher_label.Location = new Point(273, 78);
            publisher_label.Margin = new Padding(2, 0, 2, 0);
            publisher_label.Name = "publisher_label";
            publisher_label.Size = new Size(84, 29);
            publisher_label.TabIndex = 12;
            publisher_label.Text = "Publisher";
            // 
            // spiele
            // 
            spiele.BackColor = Color.White;
            spiele.Font = new Font("Agency FB", 15F, FontStyle.Regular, GraphicsUnit.Point);
            spiele.ForeColor = Color.Black;
            spiele.FormattingEnabled = true;
            spiele.ItemHeight = 29;
            spiele.Location = new Point(10, 10);
            spiele.Margin = new Padding(2);
            spiele.Name = "spiele";
            spiele.Size = new Size(247, 700);
            spiele.TabIndex = 9;
            // 
            // titel_label
            // 
            titel_label.AutoSize = true;
            titel_label.Font = new Font("Agency FB", 20F, FontStyle.Regular, GraphicsUnit.Point);
            titel_label.Location = new Point(273, 10);
            titel_label.Margin = new Padding(2, 0, 2, 0);
            titel_label.Name = "titel_label";
            titel_label.Size = new Size(123, 42);
            titel_label.TabIndex = 13;
            titel_label.Text = "Game Titel";
            titel_label.Click += label1_Click;
            // 
            // genres_label
            // 
            genres_label.AutoSize = true;
            genres_label.Font = new Font("Agency FB", 15F, FontStyle.Regular, GraphicsUnit.Point);
            genres_label.Location = new Point(273, 141);
            genres_label.Margin = new Padding(2, 0, 2, 0);
            genres_label.Name = "genres_label";
            genres_label.Size = new Size(67, 29);
            genres_label.TabIndex = 14;
            genres_label.Text = "Genres";
            // 
            // zuletztGesp_label
            // 
            zuletztGesp_label.AutoSize = true;
            zuletztGesp_label.Font = new Font("Agency FB", 15F, FontStyle.Regular, GraphicsUnit.Point);
            zuletztGesp_label.Location = new Point(273, 203);
            zuletztGesp_label.Margin = new Padding(2, 0, 2, 0);
            zuletztGesp_label.Name = "zuletztGesp_label";
            zuletztGesp_label.Size = new Size(123, 29);
            zuletztGesp_label.TabIndex = 15;
            zuletztGesp_label.Text = "Zuletzt gespielt";
            // 
            // instPfad_label
            // 
            instPfad_label.AutoSize = true;
            instPfad_label.Font = new Font("Agency FB", 15F, FontStyle.Regular, GraphicsUnit.Point);
            instPfad_label.Location = new Point(273, 391);
            instPfad_label.Margin = new Padding(2, 0, 2, 0);
            instPfad_label.Name = "instPfad_label";
            instPfad_label.Size = new Size(133, 29);
            instPfad_label.TabIndex = 16;
            instPfad_label.Text = "Installationspfad";
            // 
            // instDatum_label
            // 
            instDatum_label.AutoSize = true;
            instDatum_label.Font = new Font("Agency FB", 15F, FontStyle.Regular, GraphicsUnit.Point);
            instDatum_label.Location = new Point(273, 328);
            instDatum_label.Margin = new Padding(2, 0, 2, 0);
            instDatum_label.Name = "instDatum_label";
            instDatum_label.Size = new Size(148, 29);
            instDatum_label.TabIndex = 17;
            instDatum_label.Text = "Installationsdatum";
            // 
            // usk_label
            // 
            usk_label.AutoSize = true;
            usk_label.Font = new Font("Agency FB", 15F, FontStyle.Regular, GraphicsUnit.Point);
            usk_label.Location = new Point(273, 266);
            usk_label.Margin = new Padding(2, 0, 2, 0);
            usk_label.Name = "usk_label";
            usk_label.Size = new Size(124, 29);
            usk_label.TabIndex = 19;
            usk_label.Text = "USK-Einstufung";
            usk_label.Click += usk_Click;
            // 
            // publisher
            // 
            publisher.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            publisher.Location = new Point(446, 82);
            publisher.Margin = new Padding(2);
            publisher.Name = "publisher";
            publisher.Size = new Size(411, 41);
            publisher.TabIndex = 20;
            // 
            // genres
            // 
            genres.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            genres.Location = new Point(446, 145);
            genres.Margin = new Padding(2);
            genres.Name = "genres";
            genres.Size = new Size(411, 41);
            genres.TabIndex = 21;
            // 
            // zuletztGesp
            // 
            zuletztGesp.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            zuletztGesp.Location = new Point(446, 208);
            zuletztGesp.Margin = new Padding(2);
            zuletztGesp.Name = "zuletztGesp";
            zuletztGesp.Size = new Size(411, 41);
            zuletztGesp.TabIndex = 22;
            // 
            // usk
            // 
            usk.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            usk.Location = new Point(446, 270);
            usk.Margin = new Padding(2);
            usk.Name = "usk";
            usk.Size = new Size(411, 41);
            usk.TabIndex = 23;
            // 
            // instDatum
            // 
            instDatum.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            instDatum.Location = new Point(446, 332);
            instDatum.Margin = new Padding(2);
            instDatum.Name = "instDatum";
            instDatum.Size = new Size(411, 41);
            instDatum.TabIndex = 24;
            // 
            // instPfad
            // 
            instPfad.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            instPfad.Location = new Point(446, 395);
            instPfad.Margin = new Padding(2);
            instPfad.Name = "instPfad";
            instPfad.Size = new Size(411, 41);
            instPfad.TabIndex = 25;
            // 
            // titel
            // 
            titel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            titel.Location = new Point(446, 0);
            titel.Margin = new Padding(2);
            titel.Name = "titel";
            titel.Size = new Size(411, 52);
            titel.TabIndex = 26;
            // 
            // MeineSpiele
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            BackColor = Color.Silver;
            ClientSize = new Size(1404, 748);
            ControlBox = false;
            Controls.Add(titel);
            Controls.Add(instPfad);
            Controls.Add(instDatum);
            Controls.Add(usk);
            Controls.Add(zuletztGesp);
            Controls.Add(genres);
            Controls.Add(publisher);
            Controls.Add(usk_label);
            Controls.Add(instDatum_label);
            Controls.Add(instPfad_label);
            Controls.Add(zuletztGesp_label);
            Controls.Add(genres_label);
            Controls.Add(titel_label);
            Controls.Add(publisher_label);
            Controls.Add(spiele);
            Margin = new Padding(2);
            Name = "MeineSpiele";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label publisher_label;
        public ListBox spiele;
        private Label titel_label;
        private Label genres_label;
        private Label zuletztGesp_label;
        private Label instPfad_label;
        private Label instDatum_label;
        private Label usk_label;
        private TextBox publisher;
        private TextBox genres;
        private TextBox zuletztGesp;
        private TextBox usk;
        private TextBox instDatum;
        private TextBox instPfad;
        private TextBox titel;
    }
}