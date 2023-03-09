namespace ForcePlayV2
{
    partial class Menue
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menue));
            meineSpiele_button = new Button();
            neuesSpielHinzufügen_button = new Button();
            logo_label = new Label();
            exit_button = new Button();
            navigationBar_panel = new Panel();
            content_panel = new Panel();
            navigationBar_panel.SuspendLayout();
            SuspendLayout();
            // 
            // meineSpiele_button
            // 
            meineSpiele_button.AutoSize = true;
            meineSpiele_button.BackColor = Color.FromArgb(0, 0, 64);
            meineSpiele_button.Cursor = Cursors.Hand;
            meineSpiele_button.FlatAppearance.BorderColor = Color.White;
            meineSpiele_button.FlatStyle = FlatStyle.Flat;
            meineSpiele_button.Font = new Font("Agency FB", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            meineSpiele_button.ForeColor = Color.White;
            meineSpiele_button.Image = (Image)resources.GetObject("meineSpiele_button.Image");
            meineSpiele_button.ImageAlign = ContentAlignment.MiddleLeft;
            meineSpiele_button.ImeMode = ImeMode.NoControl;
            meineSpiele_button.Location = new Point(0, 200);
            meineSpiele_button.MaximumSize = new Size(430, 100);
            meineSpiele_button.MinimumSize = new Size(430, 100);
            meineSpiele_button.Name = "meineSpiele_button";
            meineSpiele_button.RightToLeft = RightToLeft.No;
            meineSpiele_button.Size = new Size(430, 100);
            meineSpiele_button.TabIndex = 4;
            meineSpiele_button.Text = "Meine Spiele";
            meineSpiele_button.TextImageRelation = TextImageRelation.ImageBeforeText;
            meineSpiele_button.UseVisualStyleBackColor = false;
            meineSpiele_button.Click += MeineSpiele_button_Click;
            // 
            // neuesSpielHinzufügen_button
            // 
            neuesSpielHinzufügen_button.AutoSize = true;
            neuesSpielHinzufügen_button.BackColor = Color.FromArgb(0, 0, 64);
            neuesSpielHinzufügen_button.Cursor = Cursors.Hand;
            neuesSpielHinzufügen_button.FlatAppearance.BorderColor = Color.White;
            neuesSpielHinzufügen_button.FlatStyle = FlatStyle.Flat;
            neuesSpielHinzufügen_button.Font = new Font("Agency FB", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            neuesSpielHinzufügen_button.ForeColor = Color.White;
            neuesSpielHinzufügen_button.Image = (Image)resources.GetObject("neuesSpielHinzufügen_button.Image");
            neuesSpielHinzufügen_button.ImageAlign = ContentAlignment.MiddleLeft;
            neuesSpielHinzufügen_button.ImeMode = ImeMode.NoControl;
            neuesSpielHinzufügen_button.Location = new Point(0, 315);
            neuesSpielHinzufügen_button.MaximumSize = new Size(430, 100);
            neuesSpielHinzufügen_button.MinimumSize = new Size(430, 100);
            neuesSpielHinzufügen_button.Name = "neuesSpielHinzufügen_button";
            neuesSpielHinzufügen_button.RightToLeft = RightToLeft.No;
            neuesSpielHinzufügen_button.Size = new Size(430, 100);
            neuesSpielHinzufügen_button.TabIndex = 5;
            neuesSpielHinzufügen_button.Text = "Neues Spiel hinzufügen";
            neuesSpielHinzufügen_button.TextImageRelation = TextImageRelation.ImageBeforeText;
            neuesSpielHinzufügen_button.UseVisualStyleBackColor = false;
            neuesSpielHinzufügen_button.Click += NeuesSpielHinzufügen_button_Click;
            // 
            // logo_label
            // 
            logo_label.BackColor = Color.FromArgb(0, 0, 64);
            logo_label.Font = new Font("Agency FB", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            logo_label.ForeColor = Color.White;
            logo_label.ImeMode = ImeMode.NoControl;
            logo_label.Location = new Point(0, 0);
            logo_label.Name = "logo_label";
            logo_label.Size = new Size(430, 120);
            logo_label.TabIndex = 1;
            logo_label.Text = "ForcePlay";
            logo_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // exit_button
            // 
            exit_button.AutoSize = true;
            exit_button.BackColor = Color.FromArgb(0, 0, 64);
            exit_button.Cursor = Cursors.Hand;
            exit_button.FlatAppearance.BorderColor = Color.White;
            exit_button.FlatStyle = FlatStyle.Flat;
            exit_button.Font = new Font("Agency FB", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            exit_button.ForeColor = Color.White;
            exit_button.Image = (Image)resources.GetObject("exit_button.Image");
            exit_button.ImageAlign = ContentAlignment.MiddleLeft;
            exit_button.ImeMode = ImeMode.NoControl;
            exit_button.Location = new Point(0, 430);
            exit_button.MaximumSize = new Size(430, 100);
            exit_button.MinimumSize = new Size(430, 100);
            exit_button.Name = "exit_button";
            exit_button.RightToLeft = RightToLeft.No;
            exit_button.Size = new Size(430, 100);
            exit_button.TabIndex = 6;
            exit_button.Text = "Verlassen";
            exit_button.TextImageRelation = TextImageRelation.ImageBeforeText;
            exit_button.UseVisualStyleBackColor = false;
            exit_button.Click += Exit_button_Click;
            // 
            // navigationBar_panel
            // 
            navigationBar_panel.BackColor = Color.FromArgb(0, 0, 64);
            navigationBar_panel.Controls.Add(meineSpiele_button);
            navigationBar_panel.Dock = DockStyle.Left;
            navigationBar_panel.Location = new Point(0, 0);
            navigationBar_panel.Name = "navigationBar_panel";
            navigationBar_panel.Size = new Size(430, 777);
            navigationBar_panel.TabIndex = 7;
            // 
            // content_panel
            // 
            content_panel.Dock = DockStyle.Fill;
            content_panel.Location = new Point(430, 0);
            content_panel.Name = "content_panel";
            content_panel.Size = new Size(974, 777);
            content_panel.TabIndex = 8;
            // 
            // Menue
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.Silver;
            ClientSize = new Size(1404, 777);
            ControlBox = false;
            Controls.Add(content_panel);
            Controls.Add(exit_button);
            Controls.Add(logo_label);
            Controls.Add(neuesSpielHinzufügen_button);
            Controls.Add(navigationBar_panel);
            Name = "Menue";
            WindowState = FormWindowState.Maximized;
            navigationBar_panel.ResumeLayout(false);
            navigationBar_panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button meineSpiele_button;
        private Button neuesSpielHinzufügen_button;
        private Label logo_label;
        private Button exit_button;
        private Panel navigationBar_panel;
        private Panel content_panel;
    }
}
