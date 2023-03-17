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
            spieleListBox = new ListBox();
            titel_label = new Label();
            genres_label = new Label();
            zuletztGesp_label = new Label();
            instPfad_label = new Label();
            instDatum_label = new Label();
            usk_label = new Label();
            publisher = new TextBox();
            genres = new TextBox();
            usk = new TextBox();
            instDatum = new TextBox();
            instPfad = new TextBox();
            titel = new TextBox();
            del_button = new Button();
            sfChanges_button = new Button();
            startGame_button = new Button();
            zuletztGesp = new TextBox();
            fehlerMeldung_label = new Label();
            SuspendLayout();
            // 
            // publisher_label
            // 
            publisher_label.AutoSize = true;
            publisher_label.Font = new Font("Agency FB", 15F, FontStyle.Italic, GraphicsUnit.Point);
            publisher_label.ImeMode = ImeMode.NoControl;
            publisher_label.Location = new Point(359, 89);
            publisher_label.Margin = new Padding(2, 0, 2, 0);
            publisher_label.Name = "publisher_label";
            publisher_label.Size = new Size(84, 29);
            publisher_label.TabIndex = 12;
            publisher_label.Text = "Publisher";
            // 
            // spieleListBox
            // 
            spieleListBox.BackColor = Color.White;
            spieleListBox.Font = new Font("Agency FB", 15F, FontStyle.Regular, GraphicsUnit.Point);
            spieleListBox.ForeColor = Color.Black;
            spieleListBox.FormattingEnabled = true;
            spieleListBox.ItemHeight = 29;
            spieleListBox.Location = new Point(20, 20);
            spieleListBox.Margin = new Padding(2);
            spieleListBox.Name = "spieleListBox";
            spieleListBox.Size = new Size(280, 700);
            spieleListBox.Sorted = true;
            spieleListBox.TabIndex = 9;
            spieleListBox.SelectedIndexChanged += SpieleListBox_SelectedIndexChanged;
            // 
            // titel_label
            // 
            titel_label.AutoSize = true;
            titel_label.Font = new Font("Agency FB", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            titel_label.Location = new Point(359, 20);
            titel_label.Margin = new Padding(2, 0, 2, 0);
            titel_label.Name = "titel_label";
            titel_label.Size = new Size(132, 41);
            titel_label.TabIndex = 13;
            titel_label.Text = "Game Titel";
            // 
            // genres_label
            // 
            genres_label.AutoSize = true;
            genres_label.Font = new Font("Agency FB", 15F, FontStyle.Italic, GraphicsUnit.Point);
            genres_label.Location = new Point(359, 152);
            genres_label.Margin = new Padding(2, 0, 2, 0);
            genres_label.Name = "genres_label";
            genres_label.Size = new Size(58, 29);
            genres_label.TabIndex = 14;
            genres_label.Text = "Genre";
            // 
            // zuletztGesp_label
            // 
            zuletztGesp_label.AutoSize = true;
            zuletztGesp_label.Font = new Font("Agency FB", 15F, FontStyle.Italic, GraphicsUnit.Point);
            zuletztGesp_label.Location = new Point(359, 214);
            zuletztGesp_label.Margin = new Padding(2, 0, 2, 0);
            zuletztGesp_label.Name = "zuletztGesp_label";
            zuletztGesp_label.Size = new Size(123, 29);
            zuletztGesp_label.TabIndex = 15;
            zuletztGesp_label.Text = "Zuletzt gespielt";
            // 
            // instPfad_label
            // 
            instPfad_label.AutoSize = true;
            instPfad_label.Font = new Font("Agency FB", 15F, FontStyle.Italic, GraphicsUnit.Point);
            instPfad_label.Location = new Point(359, 402);
            instPfad_label.Margin = new Padding(2, 0, 2, 0);
            instPfad_label.Name = "instPfad_label";
            instPfad_label.Size = new Size(133, 29);
            instPfad_label.TabIndex = 16;
            instPfad_label.Text = "Installationspfad";
            // 
            // instDatum_label
            // 
            instDatum_label.AutoSize = true;
            instDatum_label.Font = new Font("Agency FB", 15F, FontStyle.Italic, GraphicsUnit.Point);
            instDatum_label.Location = new Point(359, 339);
            instDatum_label.Margin = new Padding(2, 0, 2, 0);
            instDatum_label.Name = "instDatum_label";
            instDatum_label.Size = new Size(148, 29);
            instDatum_label.TabIndex = 17;
            instDatum_label.Text = "Installationsdatum";
            // 
            // usk_label
            // 
            usk_label.AutoSize = true;
            usk_label.Font = new Font("Agency FB", 15F, FontStyle.Italic, GraphicsUnit.Point);
            usk_label.Location = new Point(359, 277);
            usk_label.Margin = new Padding(2, 0, 2, 0);
            usk_label.Name = "usk_label";
            usk_label.Size = new Size(124, 29);
            usk_label.TabIndex = 19;
            usk_label.Text = "USK-Einstufung";
            // 
            // publisher
            // 
            publisher.Font = new Font("Agency FB", 15F, FontStyle.Regular, GraphicsUnit.Point);
            publisher.Location = new Point(532, 93);
            publisher.Margin = new Padding(2);
            publisher.Name = "publisher";
            publisher.Size = new Size(870, 37);
            publisher.TabIndex = 20;
            // 
            // genres
            // 
            genres.Font = new Font("Agency FB", 15F, FontStyle.Regular, GraphicsUnit.Point);
            genres.Location = new Point(532, 156);
            genres.Margin = new Padding(2);
            genres.Name = "genres";
            genres.Size = new Size(870, 37);
            genres.TabIndex = 21;
            // 
            // usk
            // 
            usk.Font = new Font("Agency FB", 15F, FontStyle.Regular, GraphicsUnit.Point);
            usk.Location = new Point(532, 281);
            usk.Margin = new Padding(2);
            usk.Name = "usk";
            usk.Size = new Size(870, 37);
            usk.TabIndex = 23;
            // 
            // instDatum
            // 
            instDatum.Font = new Font("Agency FB", 15F, FontStyle.Regular, GraphicsUnit.Point);
            instDatum.Location = new Point(532, 343);
            instDatum.Margin = new Padding(2);
            instDatum.Name = "instDatum";
            instDatum.Size = new Size(870, 37);
            instDatum.TabIndex = 24;
            // 
            // instPfad
            // 
            instPfad.Font = new Font("Agency FB", 15F, FontStyle.Regular, GraphicsUnit.Point);
            instPfad.Location = new Point(532, 406);
            instPfad.Margin = new Padding(2);
            instPfad.Name = "instPfad";
            instPfad.Size = new Size(870, 37);
            instPfad.TabIndex = 25;
            // 
            // titel
            // 
            titel.Font = new Font("Agency FB", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            titel.Location = new Point(532, 20);
            titel.Margin = new Padding(2);
            titel.Name = "titel";
            titel.Size = new Size(870, 47);
            titel.TabIndex = 26;
            // 
            // del_button
            // 
            del_button.BackColor = Color.MistyRose;
            del_button.Font = new Font("Agency FB", 15F, FontStyle.Regular, GraphicsUnit.Point);
            del_button.Location = new Point(1132, 468);
            del_button.Margin = new Padding(2);
            del_button.Name = "del_button";
            del_button.Size = new Size(270, 100);
            del_button.TabIndex = 27;
            del_button.Text = "Löschen";
            del_button.UseVisualStyleBackColor = false;
            del_button.Click += Del_button_Click;
            // 
            // sfChanges_button
            // 
            sfChanges_button.BackColor = Color.SpringGreen;
            sfChanges_button.Font = new Font("Agency FB", 15F, FontStyle.Regular, GraphicsUnit.Point);
            sfChanges_button.Location = new Point(833, 468);
            sfChanges_button.Margin = new Padding(2);
            sfChanges_button.Name = "sfChanges_button";
            sfChanges_button.Size = new Size(270, 100);
            sfChanges_button.TabIndex = 28;
            sfChanges_button.Text = "Änderungen speichern";
            sfChanges_button.UseVisualStyleBackColor = false;
            sfChanges_button.Click += SfChanges_button_Click;
            // 
            // startGame_button
            // 
            startGame_button.BackColor = Color.LightGoldenrodYellow;
            startGame_button.Font = new Font("Agency FB", 15F, FontStyle.Regular, GraphicsUnit.Point);
            startGame_button.Location = new Point(532, 468);
            startGame_button.Margin = new Padding(2);
            startGame_button.Name = "startGame_button";
            startGame_button.Size = new Size(270, 100);
            startGame_button.TabIndex = 29;
            startGame_button.Text = "Starten";
            startGame_button.UseVisualStyleBackColor = false;
            startGame_button.Click += StartGame_button_Click;
            // 
            // zuletztGesp
            // 
            zuletztGesp.Font = new Font("Agency FB", 15F, FontStyle.Regular, GraphicsUnit.Point);
            zuletztGesp.Location = new Point(532, 219);
            zuletztGesp.Margin = new Padding(2);
            zuletztGesp.Name = "zuletztGesp";
            zuletztGesp.Size = new Size(870, 37);
            zuletztGesp.TabIndex = 22;
            // 
            // fehlerMeldung_label
            // 
            fehlerMeldung_label.AutoSize = true;
            fehlerMeldung_label.Font = new Font("Agency FB", 15F, FontStyle.Regular, GraphicsUnit.Point);
            fehlerMeldung_label.Location = new Point(956, 229);
            fehlerMeldung_label.Margin = new Padding(2, 0, 2, 0);
            fehlerMeldung_label.Name = "fehlerMeldung_label";
            fehlerMeldung_label.Size = new Size(0, 29);
            fehlerMeldung_label.TabIndex = 0;
            // 
            // MeineSpiele
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            BackColor = Color.Silver;
            ClientSize = new Size(1432, 782);
            ControlBox = false;
            Controls.Add(startGame_button);
            Controls.Add(fehlerMeldung_label);
            Controls.Add(sfChanges_button);
            Controls.Add(del_button);
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
            Controls.Add(spieleListBox);
            Margin = new Padding(2);
            Name = "MeineSpiele";
            WindowState = FormWindowState.Maximized;
            Activated += MeineSpiele_Activated;
            Load += MeineSpiele_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label publisher_label;
        public ListBox spieleListBox;
        private Label titel_label;
        private Label genres_label;
        private Label zuletztGesp_label;
        private Label instPfad_label;
        private Label instDatum_label;
        private Label usk_label;
        private TextBox publisher;
        private TextBox genres;
        private TextBox usk;
        private TextBox instDatum;
        private TextBox instPfad;
        private TextBox titel;
        private Button del_button;
        private Button sfChanges_button;
        private Button startGame_button;
        private TextBox zuletztGesp;
        private Label fehlerMeldung_label;
    }
}