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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NeuesSpielHinzufuegen));
            SpielHinzufügenButton = new Button();
            titel = new TextBox();
            zuletztGespielt = new TextBox();
            kategorie = new TextBox();
            publisher = new TextBox();
            usk = new ComboBox();
            exitButton = new Button();
            kategorie2_label = new Label();
            publisher2_label = new Label();
            usk2_label = new Label();
            installationspfad2_label = new Label();
            zuletztGespielt2_label = new Label();
            titel2_label = new Label();
            installationsdatum2_label = new Label();
            installationspfad = new TextBox();
            explorer_Button = new Button();
            installationsdatum = new DateTimePicker();
            SuspendLayout();
            // 
            // SpielHinzufügenButton
            // 
            SpielHinzufügenButton.BackColor = Color.FromArgb(255, 255, 192);
            SpielHinzufügenButton.Cursor = Cursors.Hand;
            SpielHinzufügenButton.Font = new Font("Agency FB", 15F, FontStyle.Regular, GraphicsUnit.Point);
            SpielHinzufügenButton.Location = new Point(173, 339);
            SpielHinzufügenButton.Name = "SpielHinzufügenButton";
            SpielHinzufügenButton.Size = new Size(216, 80);
            SpielHinzufügenButton.TabIndex = 0;
            SpielHinzufügenButton.Text = "Hinzufügen";
            SpielHinzufügenButton.UseVisualStyleBackColor = false;
            SpielHinzufügenButton.Click += SpielHinzufügenButton_Click;
            // 
            // titel
            // 
            titel.Font = new Font("Agency FB", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            titel.Location = new Point(173, 16);
            titel.Name = "titel";
            titel.Size = new Size(697, 39);
            titel.TabIndex = 1;
            titel.TextChanged += textBox1_TextChanged;
            // 
            // zuletztGespielt
            // 
            zuletztGespielt.Font = new Font("Agency FB", 15F, FontStyle.Regular, GraphicsUnit.Point);
            zuletztGespielt.Location = new Point(173, 156);
            zuletztGespielt.Name = "zuletztGespielt";
            zuletztGespielt.Size = new Size(697, 31);
            zuletztGespielt.TabIndex = 3;
            // 
            // kategorie
            // 
            kategorie.Font = new Font("Agency FB", 15F, FontStyle.Regular, GraphicsUnit.Point);
            kategorie.Location = new Point(173, 112);
            kategorie.Name = "kategorie";
            kategorie.Size = new Size(697, 31);
            kategorie.TabIndex = 5;
            // 
            // publisher
            // 
            publisher.Font = new Font("Agency FB", 15F, FontStyle.Regular, GraphicsUnit.Point);
            publisher.Location = new Point(173, 68);
            publisher.Name = "publisher";
            publisher.Size = new Size(697, 31);
            publisher.TabIndex = 6;
            // 
            // usk
            // 
            usk.Cursor = Cursors.Hand;
            usk.DropDownStyle = ComboBoxStyle.DropDownList;
            usk.Font = new Font("Agency FB", 15F, FontStyle.Regular, GraphicsUnit.Point);
            usk.FormattingEnabled = true;
            usk.Items.AddRange(new object[] { "0", "6", "12", "16", "18" });
            usk.Location = new Point(173, 200);
            usk.Name = "usk";
            usk.Size = new Size(697, 32);
            usk.TabIndex = 7;
            usk.SelectedIndexChanged += usk_SelectedIndexChanged;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.FromArgb(255, 192, 255);
            exitButton.Cursor = Cursors.Hand;
            exitButton.Font = new Font("Agency FB", 15F, FontStyle.Regular, GraphicsUnit.Point);
            exitButton.Location = new Point(653, 339);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(216, 80);
            exitButton.TabIndex = 8;
            exitButton.Text = "Eingabe Löschen";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += Button1_Click;
            // 
            // kategorie2_label
            // 
            kategorie2_label.AutoSize = true;
            kategorie2_label.Font = new Font("Agency FB", 15F, FontStyle.Italic, GraphicsUnit.Point);
            kategorie2_label.Location = new Point(20, 112);
            kategorie2_label.Margin = new Padding(2, 0, 2, 0);
            kategorie2_label.Name = "kategorie2_label";
            kategorie2_label.Size = new Size(45, 24);
            kategorie2_label.TabIndex = 26;
            kategorie2_label.Text = "Genre";
            // 
            // publisher2_label
            // 
            publisher2_label.AutoSize = true;
            publisher2_label.Font = new Font("Agency FB", 15F, FontStyle.Italic, GraphicsUnit.Point);
            publisher2_label.Location = new Point(20, 68);
            publisher2_label.Margin = new Padding(2, 0, 2, 0);
            publisher2_label.Name = "publisher2_label";
            publisher2_label.Size = new Size(65, 24);
            publisher2_label.TabIndex = 25;
            publisher2_label.Text = "Publisher";
            // 
            // usk2_label
            // 
            usk2_label.AutoSize = true;
            usk2_label.Font = new Font("Agency FB", 15F, FontStyle.Italic, GraphicsUnit.Point);
            usk2_label.Location = new Point(20, 200);
            usk2_label.Margin = new Padding(2, 0, 2, 0);
            usk2_label.Name = "usk2_label";
            usk2_label.Size = new Size(98, 24);
            usk2_label.TabIndex = 24;
            usk2_label.Text = "USK-Einstufung";
            // 
            // installationspfad2_label
            // 
            installationspfad2_label.AutoSize = true;
            installationspfad2_label.Font = new Font("Agency FB", 15F, FontStyle.Italic, GraphicsUnit.Point);
            installationspfad2_label.Location = new Point(20, 295);
            installationspfad2_label.Margin = new Padding(2, 0, 2, 0);
            installationspfad2_label.Name = "installationspfad2_label";
            installationspfad2_label.Size = new Size(103, 24);
            installationspfad2_label.TabIndex = 23;
            installationspfad2_label.Text = "Installationspfad";
            // 
            // zuletztGespielt2_label
            // 
            zuletztGespielt2_label.AutoSize = true;
            zuletztGespielt2_label.Font = new Font("Agency FB", 15F, FontStyle.Italic, GraphicsUnit.Point);
            zuletztGespielt2_label.Location = new Point(20, 156);
            zuletztGespielt2_label.Margin = new Padding(2, 0, 2, 0);
            zuletztGespielt2_label.Name = "zuletztGespielt2_label";
            zuletztGespielt2_label.Size = new Size(96, 24);
            zuletztGespielt2_label.TabIndex = 22;
            zuletztGespielt2_label.Text = "Zuletzt gespielt";
            // 
            // titel2_label
            // 
            titel2_label.AutoSize = true;
            titel2_label.Font = new Font("Agency FB", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            titel2_label.Location = new Point(20, 16);
            titel2_label.Margin = new Padding(2, 0, 2, 0);
            titel2_label.Name = "titel2_label";
            titel2_label.Size = new Size(103, 34);
            titel2_label.TabIndex = 21;
            titel2_label.Text = "Game Titel";
            // 
            // installationsdatum2_label
            // 
            installationsdatum2_label.AutoSize = true;
            installationsdatum2_label.Font = new Font("Agency FB", 15F, FontStyle.Italic, GraphicsUnit.Point);
            installationsdatum2_label.ImeMode = ImeMode.NoControl;
            installationsdatum2_label.Location = new Point(20, 244);
            installationsdatum2_label.Margin = new Padding(2, 0, 2, 0);
            installationsdatum2_label.Name = "installationsdatum2_label";
            installationsdatum2_label.Size = new Size(115, 24);
            installationsdatum2_label.TabIndex = 20;
            installationsdatum2_label.Text = "Installationsdatum";
            // 
            // installationspfad
            // 
            installationspfad.Font = new Font("Agency FB", 15F, FontStyle.Regular, GraphicsUnit.Point);
            installationspfad.Location = new Point(173, 288);
            installationspfad.Name = "installationspfad";
            installationspfad.Size = new Size(665, 31);
            installationspfad.TabIndex = 4;
            // 
            // explorer_Button
            // 
            explorer_Button.Cursor = Cursors.Hand;
            explorer_Button.Image = (Image)resources.GetObject("explorer_Button.Image");
            explorer_Button.Location = new Point(838, 287);
            explorer_Button.Margin = new Padding(2, 2, 2, 2);
            explorer_Button.Name = "explorer_Button";
            explorer_Button.Size = new Size(30, 30);
            explorer_Button.TabIndex = 27;
            explorer_Button.UseVisualStyleBackColor = true;
            explorer_Button.Click += Explorer_Button_Click;
            // 
            // installationsdatum
            // 
            installationsdatum.Cursor = Cursors.Hand;
            installationsdatum.Font = new Font("Agency FB", 15F, FontStyle.Regular, GraphicsUnit.Point);
            installationsdatum.Format = DateTimePickerFormat.Short;
            installationsdatum.ImeMode = ImeMode.NoControl;
            installationsdatum.Location = new Point(173, 244);
            installationsdatum.Margin = new Padding(2, 2, 2, 2);
            installationsdatum.Name = "installationsdatum";
            installationsdatum.RightToLeft = RightToLeft.No;
            installationsdatum.Size = new Size(697, 31);
            installationsdatum.TabIndex = 28;
            // 
            // NeuesSpielHinzufuegen
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            BackColor = Color.Silver;
            ClientSize = new Size(918, 489);
            ControlBox = false;
            Controls.Add(installationsdatum);
            Controls.Add(explorer_Button);
            Controls.Add(kategorie2_label);
            Controls.Add(publisher2_label);
            Controls.Add(usk2_label);
            Controls.Add(installationspfad2_label);
            Controls.Add(zuletztGespielt2_label);
            Controls.Add(titel2_label);
            Controls.Add(installationsdatum2_label);
            Controls.Add(exitButton);
            Controls.Add(usk);
            Controls.Add(publisher);
            Controls.Add(kategorie);
            Controls.Add(installationspfad);
            Controls.Add(zuletztGespielt);
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
        private TextBox zuletztGespielt;
        private TextBox kategorie;
        private TextBox publisher;
        private ComboBox usk;
        private Button exitButton;
        private Label kategorie2_label;
        private Label publisher2_label;
        private Label usk2_label;
        private Label installationspfad2_label;
        private Label zuletztGespielt2_label;
        private Label titel2_label;
        private Label installationsdatum2_label;
        private TextBox installationspfad;
        private Button explorer_Button;
        private DateTimePicker installationsdatum;
    }
}