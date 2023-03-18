namespace ForcePlayV2
{
    partial class Informationsanzeige
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Informationsanzeige));
            ok_button = new Button();
            informationBeschreibung_textBox = new TextBox();
            ueberschrift_label = new Label();
            SuspendLayout();
            // 
            // ok_button
            // 
            ok_button.Cursor = Cursors.Hand;
            ok_button.Font = new Font("Agency FB", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ok_button.ForeColor = Color.Black;
            ok_button.Location = new Point(272, 304);
            ok_button.Margin = new Padding(2, 2, 2, 2);
            ok_button.MaximumSize = new Size(136, 40);
            ok_button.MinimumSize = new Size(136, 40);
            ok_button.Name = "ok_button";
            ok_button.Size = new Size(136, 40);
            ok_button.TabIndex = 4;
            ok_button.Text = "OK";
            ok_button.UseVisualStyleBackColor = true;
            ok_button.Click += Ok_button_Click;
            // 
            // informationBeschreibung_textBox
            // 
            informationBeschreibung_textBox.BackColor = Color.White;
            informationBeschreibung_textBox.BorderStyle = BorderStyle.None;
            informationBeschreibung_textBox.Font = new Font("Agency FB", 15F, FontStyle.Regular, GraphicsUnit.Point);
            informationBeschreibung_textBox.ForeColor = Color.Black;
            informationBeschreibung_textBox.Location = new Point(0, 68);
            informationBeschreibung_textBox.Margin = new Padding(2, 2, 2, 2);
            informationBeschreibung_textBox.MaximumSize = new Size(424, 224);
            informationBeschreibung_textBox.MinimumSize = new Size(424, 144);
            informationBeschreibung_textBox.Multiline = true;
            informationBeschreibung_textBox.Name = "informationBeschreibung_textBox";
            informationBeschreibung_textBox.ReadOnly = true;
            informationBeschreibung_textBox.Size = new Size(424, 224);
            informationBeschreibung_textBox.TabIndex = 5;
            informationBeschreibung_textBox.Text = resources.GetString("informationBeschreibung_textBox.Text");
            // 
            // ueberschrift_label
            // 
            ueberschrift_label.BackColor = Color.Silver;
            ueberschrift_label.Font = new Font("Agency FB", 28.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            ueberschrift_label.ForeColor = Color.Black;
            ueberschrift_label.Location = new Point(0, 0);
            ueberschrift_label.Margin = new Padding(2, 0, 2, 0);
            ueberschrift_label.MaximumSize = new Size(424, 68);
            ueberschrift_label.MinimumSize = new Size(424, 68);
            ueberschrift_label.Name = "ueberschrift_label";
            ueberschrift_label.Size = new Size(424, 68);
            ueberschrift_label.TabIndex = 3;
            ueberschrift_label.Text = "INFORMATION";
            ueberschrift_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Informationsanzeige
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.Silver;
            ClientSize = new Size(419, 355);
            ControlBox = false;
            Controls.Add(ok_button);
            Controls.Add(informationBeschreibung_textBox);
            Controls.Add(ueberschrift_label);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(2, 2, 2, 2);
            Name = "Informationsanzeige";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ok_button;
        private TextBox informationBeschreibung_textBox;
        private Label ueberschrift_label;
    }
}