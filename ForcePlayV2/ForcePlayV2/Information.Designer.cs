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
            ok_button.Location = new Point(342, 368);
            ok_button.MaximumSize = new Size(170, 50);
            ok_button.MinimumSize = new Size(170, 50);
            ok_button.Name = "ok_button";
            ok_button.Size = new Size(170, 50);
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
            informationBeschreibung_textBox.Location = new Point(0, 85);
            informationBeschreibung_textBox.MaximumSize = new Size(530, 280);
            informationBeschreibung_textBox.MinimumSize = new Size(530, 180);
            informationBeschreibung_textBox.Multiline = true;
            informationBeschreibung_textBox.Name = "informationBeschreibung_textBox";
            informationBeschreibung_textBox.ReadOnly = true;
            informationBeschreibung_textBox.Size = new Size(530, 265);
            informationBeschreibung_textBox.TabIndex = 5;
            informationBeschreibung_textBox.Text = resources.GetString("informationBeschreibung_textBox.Text");
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
            ueberschrift_label.TabIndex = 3;
            ueberschrift_label.Text = "INFORMATION";
            ueberschrift_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Informationsanzeige
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.Silver;
            ClientSize = new Size(524, 430);
            ControlBox = false;
            Controls.Add(ok_button);
            Controls.Add(informationBeschreibung_textBox);
            Controls.Add(ueberschrift_label);
            FormBorderStyle = FormBorderStyle.Fixed3D;
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