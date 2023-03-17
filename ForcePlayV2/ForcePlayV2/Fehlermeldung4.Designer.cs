namespace ForcePlayV2
{
    partial class Fehlermeldung4
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
            ok_button = new Button();
            fehlerbeschreibung_textBox = new TextBox();
            ueberschrift_label = new Label();
            SuspendLayout();
            // 
            // ok_button
            // 
            ok_button.Cursor = Cursors.Hand;
            ok_button.Font = new Font("Agency FB", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ok_button.ForeColor = Color.Black;
            ok_button.Location = new Point(342, 247);
            ok_button.MaximumSize = new Size(170, 50);
            ok_button.MinimumSize = new Size(170, 50);
            ok_button.Name = "ok_button";
            ok_button.Size = new Size(170, 50);
            ok_button.TabIndex = 10;
            ok_button.Text = "OK";
            ok_button.UseVisualStyleBackColor = true;
            ok_button.Click += Ok_button_Click;
            // 
            // fehlerbeschreibung_textBox
            // 
            fehlerbeschreibung_textBox.BackColor = Color.White;
            fehlerbeschreibung_textBox.BorderStyle = BorderStyle.None;
            fehlerbeschreibung_textBox.Font = new Font("Agency FB", 15F, FontStyle.Regular, GraphicsUnit.Point);
            fehlerbeschreibung_textBox.ForeColor = Color.Black;
            fehlerbeschreibung_textBox.Location = new Point(0, 85);
            fehlerbeschreibung_textBox.MaximumSize = new Size(530, 150);
            fehlerbeschreibung_textBox.MinimumSize = new Size(530, 150);
            fehlerbeschreibung_textBox.Multiline = true;
            fehlerbeschreibung_textBox.Name = "fehlerbeschreibung_textBox";
            fehlerbeschreibung_textBox.ReadOnly = true;
            fehlerbeschreibung_textBox.Size = new Size(530, 150);
            fehlerbeschreibung_textBox.TabIndex = 11;
            fehlerbeschreibung_textBox.Text = "Bitte fügen Sie erst ein Spiel hinzu, um es über den ForcePlay Game Launcher bearbeiten zu können.\r\n\r\nKlicken Sie auf \"OK\", um den ForcePlay Game Launcher weiter bedienen zu können.";
            // 
            // ueberschrift_label
            // 
            ueberschrift_label.BackColor = Color.Silver;
            ueberschrift_label.Font = new Font("Agency FB", 28.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            ueberschrift_label.ForeColor = Color.Black;
            ueberschrift_label.Location = new Point(0, 0);
            ueberschrift_label.MaximumSize = new Size(530, 85);
            ueberschrift_label.MinimumSize = new Size(530, 85);
            ueberschrift_label.Name = "ueberschrift_label";
            ueberschrift_label.Size = new Size(530, 85);
            ueberschrift_label.TabIndex = 9;
            ueberschrift_label.Text = "ACHTUNG";
            ueberschrift_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Fehlermeldung4
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.Silver;
            ClientSize = new Size(524, 309);
            ControlBox = false;
            Controls.Add(ok_button);
            Controls.Add(fehlerbeschreibung_textBox);
            Controls.Add(ueberschrift_label);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximumSize = new Size(530, 315);
            MinimumSize = new Size(530, 315);
            Name = "Fehlermeldung4";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ok_button;
        private TextBox fehlerbeschreibung_textBox;
        private Label ueberschrift_label;
    }
}