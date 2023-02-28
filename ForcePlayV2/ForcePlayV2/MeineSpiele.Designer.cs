﻿namespace ForcePlayV2
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
            this.spiele = new System.Windows.Forms.ListBox();
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
            this.SuspendLayout();
            // 
            // publisher_label
            // 
            this.publisher_label.AutoSize = true;
            this.publisher_label.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.publisher_label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.publisher_label.Location = new System.Drawing.Point(328, 94);
            this.publisher_label.Name = "publisher_label";
            this.publisher_label.Size = new System.Drawing.Size(100, 36);
            this.publisher_label.TabIndex = 12;
            this.publisher_label.Text = "Publisher";
            // 
            // spiele
            // 
            this.spiele.BackColor = System.Drawing.Color.White;
            this.spiele.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.spiele.ForeColor = System.Drawing.Color.Black;
            this.spiele.FormattingEnabled = true;
            this.spiele.ItemHeight = 36;
            this.spiele.Location = new System.Drawing.Point(12, 12);
            this.spiele.Name = "spiele";
            this.spiele.Size = new System.Drawing.Size(296, 868);
            this.spiele.TabIndex = 9;
            // 
            // titel_label
            // 
            this.titel_label.AutoSize = true;
            this.titel_label.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titel_label.Location = new System.Drawing.Point(328, 12);
            this.titel_label.Name = "titel_label";
            this.titel_label.Size = new System.Drawing.Size(154, 49);
            this.titel_label.TabIndex = 13;
            this.titel_label.Text = "Game Titel";
            this.titel_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // genres_label
            // 
            this.genres_label.AutoSize = true;
            this.genres_label.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.genres_label.Location = new System.Drawing.Point(328, 169);
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
            this.usk_label.Name = "usk_label";
            this.usk_label.Size = new System.Drawing.Size(150, 36);
            this.usk_label.TabIndex = 19;
            this.usk_label.Text = "USK-Einstufung";
            this.usk_label.Click += new System.EventHandler(this.usk_Click);
            // 
            // publisher
            // 
            this.publisher.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.publisher.Location = new System.Drawing.Point(535, 99);
            this.publisher.Name = "publisher";
            this.publisher.Size = new System.Drawing.Size(492, 47);
            this.publisher.TabIndex = 20;
            // 
            // genres
            // 
            this.genres.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.genres.Location = new System.Drawing.Point(535, 174);
            this.genres.Name = "genres";
            this.genres.Size = new System.Drawing.Size(492, 47);
            this.genres.TabIndex = 21;
            // 
            // zuletztGesp
            // 
            this.zuletztGesp.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.zuletztGesp.Location = new System.Drawing.Point(535, 249);
            this.zuletztGesp.Name = "zuletztGesp";
            this.zuletztGesp.Size = new System.Drawing.Size(492, 47);
            this.zuletztGesp.TabIndex = 22;
            // 
            // usk
            // 
            this.usk.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usk.Location = new System.Drawing.Point(535, 324);
            this.usk.Name = "usk";
            this.usk.Size = new System.Drawing.Size(492, 47);
            this.usk.TabIndex = 23;
            // 
            // instDatum
            // 
            this.instDatum.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.instDatum.Location = new System.Drawing.Point(535, 399);
            this.instDatum.Name = "instDatum";
            this.instDatum.Size = new System.Drawing.Size(492, 47);
            this.instDatum.TabIndex = 24;
            // 
            // instPfad
            // 
            this.instPfad.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.instPfad.Location = new System.Drawing.Point(535, 474);
            this.instPfad.Name = "instPfad";
            this.instPfad.Size = new System.Drawing.Size(492, 47);
            this.instPfad.TabIndex = 25;
            // 
            // titel
            // 
            this.titel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titel.Location = new System.Drawing.Point(535, 0);
            this.titel.Name = "titel";
            this.titel.Size = new System.Drawing.Size(492, 61);
            this.titel.TabIndex = 26;
            // 
            // MeineSpiele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1685, 898);
            this.ControlBox = false;
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
            this.Controls.Add(this.spiele);
            this.Name = "MeineSpiele";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

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