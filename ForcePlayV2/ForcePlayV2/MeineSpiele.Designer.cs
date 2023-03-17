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
            this.publisher_label = new System.Windows.Forms.Label();
            this.spieleListBox = new System.Windows.Forms.ListBox();
            this.titel_label = new System.Windows.Forms.Label();
            this.genres_label = new System.Windows.Forms.Label();
            this.zuletztGesp_label = new System.Windows.Forms.Label();
            this.instPfad_label = new System.Windows.Forms.Label();
            this.instDatum_label = new System.Windows.Forms.Label();
            this.usk_label = new System.Windows.Forms.Label();
            this.publisher = new System.Windows.Forms.TextBox();
            this.genres = new System.Windows.Forms.TextBox();
            this.zuletztGesp = new System.Windows.Forms.TextBox();
            this.usk = new System.Windows.Forms.TextBox();
            this.instDatum = new System.Windows.Forms.TextBox();
            this.instPfad = new System.Windows.Forms.TextBox();
            this.titel = new System.Windows.Forms.TextBox();
            this.del_button = new System.Windows.Forms.Button();
            this.sfChanges_button = new System.Windows.Forms.Button();
            this.fehlerMeldung_label = new System.Windows.Forms.Label();
            this.startGame_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // publisher_label
            // 
            this.publisher_label.AutoSize = true;
            this.publisher_label.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.publisher_label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.publisher_label.Location = new System.Drawing.Point(328, 94);
            this.publisher_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.publisher_label.Name = "publisher_label";
            this.publisher_label.Size = new System.Drawing.Size(100, 36);
            this.publisher_label.TabIndex = 12;
            this.publisher_label.Text = "Publisher";
            // 
            // spieleListBox
            // 
            this.spieleListBox.BackColor = System.Drawing.Color.White;
            this.spieleListBox.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.spieleListBox.ForeColor = System.Drawing.Color.Black;
            this.spieleListBox.FormattingEnabled = true;
            this.spieleListBox.ItemHeight = 36;
            this.spieleListBox.Location = new System.Drawing.Point(12, 12);
            this.spieleListBox.Margin = new System.Windows.Forms.Padding(2);
            this.spieleListBox.Name = "spieleListBox";
            this.spieleListBox.Size = new System.Drawing.Size(296, 832);
            this.spieleListBox.Sorted = true;
            this.spieleListBox.TabIndex = 9;
            this.spieleListBox.SelectedIndexChanged += new System.EventHandler(this.spieleListBox_SelectedIndexChanged);
            // 
            // titel_label
            // 
            this.titel_label.AutoSize = true;
            this.titel_label.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titel_label.Location = new System.Drawing.Point(328, 12);
            this.titel_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titel_label.Name = "titel_label";
            this.titel_label.Size = new System.Drawing.Size(154, 49);
            this.titel_label.TabIndex = 13;
            this.titel_label.Text = "Game Titel";
            // 
            // genres_label
            // 
            this.genres_label.AutoSize = true;
            this.genres_label.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.genres_label.Location = new System.Drawing.Point(328, 169);
            this.genres_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.genres_label.Name = "genres_label";
            this.genres_label.Size = new System.Drawing.Size(79, 36);
            this.genres_label.TabIndex = 14;
            this.genres_label.Text = "Genres";
            // 
            // zuletztGesp_label
            // 
            this.zuletztGesp_label.AutoSize = true;
            this.zuletztGesp_label.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.zuletztGesp_label.Location = new System.Drawing.Point(328, 244);
            this.zuletztGesp_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.zuletztGesp_label.Name = "zuletztGesp_label";
            this.zuletztGesp_label.Size = new System.Drawing.Size(152, 36);
            this.zuletztGesp_label.TabIndex = 15;
            this.zuletztGesp_label.Text = "Zuletzt gespielt";
            // 
            // instPfad_label
            // 
            this.instPfad_label.AutoSize = true;
            this.instPfad_label.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.instPfad_label.Location = new System.Drawing.Point(328, 469);
            this.instPfad_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.instPfad_label.Name = "instPfad_label";
            this.instPfad_label.Size = new System.Drawing.Size(164, 36);
            this.instPfad_label.TabIndex = 16;
            this.instPfad_label.Text = "Installationspfad";
            // 
            // instDatum_label
            // 
            this.instDatum_label.AutoSize = true;
            this.instDatum_label.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.instDatum_label.Location = new System.Drawing.Point(328, 394);
            this.instDatum_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.instDatum_label.Name = "instDatum_label";
            this.instDatum_label.Size = new System.Drawing.Size(182, 36);
            this.instDatum_label.TabIndex = 17;
            this.instDatum_label.Text = "Installationsdatum";
            // 
            // usk_label
            // 
            this.usk_label.AutoSize = true;
            this.usk_label.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usk_label.Location = new System.Drawing.Point(328, 319);
            this.usk_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usk_label.Name = "usk_label";
            this.usk_label.Size = new System.Drawing.Size(150, 36);
            this.usk_label.TabIndex = 19;
            this.usk_label.Text = "USK-Einstufung";
            // 
            // publisher
            // 
            this.publisher.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.publisher.Location = new System.Drawing.Point(535, 98);
            this.publisher.Margin = new System.Windows.Forms.Padding(2);
            this.publisher.Name = "publisher";
            this.publisher.Size = new System.Drawing.Size(492, 47);
            this.publisher.TabIndex = 20;
            // 
            // genres
            // 
            this.genres.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.genres.Location = new System.Drawing.Point(535, 174);
            this.genres.Margin = new System.Windows.Forms.Padding(2);
            this.genres.Name = "genres";
            this.genres.Size = new System.Drawing.Size(492, 47);
            this.genres.TabIndex = 21;
            // 
            // zuletztGesp
            // 
            this.zuletztGesp.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.zuletztGesp.Location = new System.Drawing.Point(535, 250);
            this.zuletztGesp.Margin = new System.Windows.Forms.Padding(2);
            this.zuletztGesp.Name = "zuletztGesp";
            this.zuletztGesp.Size = new System.Drawing.Size(492, 47);
            this.zuletztGesp.TabIndex = 22;
            // 
            // usk
            // 
            this.usk.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usk.Location = new System.Drawing.Point(535, 324);
            this.usk.Margin = new System.Windows.Forms.Padding(2);
            this.usk.Name = "usk";
            this.usk.Size = new System.Drawing.Size(492, 47);
            this.usk.TabIndex = 23;
            // 
            // instDatum
            // 
            this.instDatum.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.instDatum.Location = new System.Drawing.Point(535, 398);
            this.instDatum.Margin = new System.Windows.Forms.Padding(2);
            this.instDatum.Name = "instDatum";
            this.instDatum.Size = new System.Drawing.Size(492, 47);
            this.instDatum.TabIndex = 24;
            // 
            // instPfad
            // 
            this.instPfad.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.instPfad.Location = new System.Drawing.Point(535, 474);
            this.instPfad.Margin = new System.Windows.Forms.Padding(2);
            this.instPfad.Name = "instPfad";
            this.instPfad.Size = new System.Drawing.Size(492, 47);
            this.instPfad.TabIndex = 25;
            // 
            // titel
            // 
            this.titel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titel.Location = new System.Drawing.Point(535, 0);
            this.titel.Margin = new System.Windows.Forms.Padding(2);
            this.titel.Name = "titel";
            this.titel.Size = new System.Drawing.Size(492, 61);
            this.titel.TabIndex = 26;
            // 
            // del_button
            // 
            this.del_button.BackColor = System.Drawing.Color.MistyRose;
            this.del_button.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.del_button.Location = new System.Drawing.Point(903, 548);
            this.del_button.Name = "del_button";
            this.del_button.Size = new System.Drawing.Size(124, 106);
            this.del_button.TabIndex = 27;
            this.del_button.Text = "Delete";
            this.del_button.UseVisualStyleBackColor = false;
            this.del_button.Click += new System.EventHandler(this.del_button_Click);
            // 
            // sfChanges_button
            // 
            this.sfChanges_button.BackColor = System.Drawing.Color.SpringGreen;
            this.sfChanges_button.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sfChanges_button.Location = new System.Drawing.Point(719, 548);
            this.sfChanges_button.Name = "sfChanges_button";
            this.sfChanges_button.Size = new System.Drawing.Size(124, 106);
            this.sfChanges_button.TabIndex = 28;
            this.sfChanges_button.Text = "Safe Changes";
            this.sfChanges_button.UseVisualStyleBackColor = false;
            this.sfChanges_button.Click += new System.EventHandler(this.sfChanges_button_Click);
            // 
            // fehlerMeldung_label
            // 
            this.fehlerMeldung_label.AutoSize = true;
            this.fehlerMeldung_label.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fehlerMeldung_label.Location = new System.Drawing.Point(1044, 261);
            this.fehlerMeldung_label.Name = "fehlerMeldung_label";
            this.fehlerMeldung_label.Size = new System.Drawing.Size(0, 36);
            this.fehlerMeldung_label.TabIndex = 0;
            // 
            // startGame_button
            // 
            this.startGame_button.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.startGame_button.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startGame_button.Location = new System.Drawing.Point(535, 548);
            this.startGame_button.Name = "startGame_button";
            this.startGame_button.Size = new System.Drawing.Size(124, 106);
            this.startGame_button.TabIndex = 29;
            this.startGame_button.Text = "Start";
            this.startGame_button.UseVisualStyleBackColor = false;
            // 
            // MeineSpiele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1685, 898);
            this.ControlBox = false;
            this.Controls.Add(this.startGame_button);
            this.Controls.Add(this.fehlerMeldung_label);
            this.Controls.Add(this.sfChanges_button);
            this.Controls.Add(this.del_button);
            this.Controls.Add(this.titel);
            this.Controls.Add(this.instPfad);
            this.Controls.Add(this.instDatum);
            this.Controls.Add(this.usk);
            this.Controls.Add(this.zuletztGesp);
            this.Controls.Add(this.genres);
            this.Controls.Add(this.publisher);
            this.Controls.Add(this.usk_label);
            this.Controls.Add(this.instDatum_label);
            this.Controls.Add(this.instPfad_label);
            this.Controls.Add(this.zuletztGesp_label);
            this.Controls.Add(this.genres_label);
            this.Controls.Add(this.titel_label);
            this.Controls.Add(this.publisher_label);
            this.Controls.Add(this.spieleListBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MeineSpiele";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.MeineSpiele_Activated);
            this.Load += new System.EventHandler(this.MeineSpiele_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private TextBox zuletztGesp;
        private TextBox usk;
        private TextBox instDatum;
        private TextBox instPfad;
        private TextBox titel;
        private Button del_button;
        private Button sfChanges_button;
        private Label fehlerMeldung_label;
        private Button startGame_button;
    }
}