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
            easterEgg = new Button();
            info_button = new Button();
            content_panel = new Panel();
            navigationBar_panel.SuspendLayout();
            SuspendLayout();
            // 
            // meineSpiele_button
            // 
            meineSpiele_button.BackColor = Color.FromArgb(0, 0, 64);
            meineSpiele_button.Cursor = Cursors.Hand;
            meineSpiele_button.FlatAppearance.BorderColor = Color.White;
            resources.ApplyResources(meineSpiele_button, "meineSpiele_button");
            meineSpiele_button.ForeColor = Color.White;
            meineSpiele_button.Name = "meineSpiele_button";
            meineSpiele_button.UseVisualStyleBackColor = false;
            meineSpiele_button.Click += MeineSpiele_button_Click;
            // 
            // neuesSpielHinzufügen_button
            // 
            neuesSpielHinzufügen_button.BackColor = Color.FromArgb(0, 0, 64);
            neuesSpielHinzufügen_button.Cursor = Cursors.Hand;
            neuesSpielHinzufügen_button.FlatAppearance.BorderColor = Color.White;
            resources.ApplyResources(neuesSpielHinzufügen_button, "neuesSpielHinzufügen_button");
            neuesSpielHinzufügen_button.ForeColor = Color.White;
            neuesSpielHinzufügen_button.Name = "neuesSpielHinzufügen_button";
            neuesSpielHinzufügen_button.UseVisualStyleBackColor = false;
            neuesSpielHinzufügen_button.Click += NeuesSpielHinzufügen_button_Click;
            // 
            // logo_label
            // 
            logo_label.BackColor = Color.FromArgb(0, 0, 64);
            resources.ApplyResources(logo_label, "logo_label");
            logo_label.ForeColor = Color.White;
            logo_label.Name = "logo_label";
            // 
            // exit_button
            // 
            exit_button.BackColor = Color.FromArgb(0, 0, 64);
            exit_button.Cursor = Cursors.Hand;
            exit_button.FlatAppearance.BorderColor = Color.White;
            resources.ApplyResources(exit_button, "exit_button");
            exit_button.ForeColor = Color.White;
            exit_button.Name = "exit_button";
            exit_button.UseVisualStyleBackColor = false;
            exit_button.Click += Exit_button_Click;
            // 
            // navigationBar_panel
            // 
            navigationBar_panel.BackColor = Color.FromArgb(0, 0, 64);
            navigationBar_panel.Controls.Add(easterEgg);
            navigationBar_panel.Controls.Add(info_button);
            navigationBar_panel.Controls.Add(logo_label);
            navigationBar_panel.Controls.Add(meineSpiele_button);
            resources.ApplyResources(navigationBar_panel, "navigationBar_panel");
            navigationBar_panel.Name = "navigationBar_panel";
            // 
            // easterEgg
            // 
            easterEgg.Cursor = Cursors.Hand;
            resources.ApplyResources(easterEgg, "easterEgg");
            easterEgg.ForeColor = Color.White;
            easterEgg.Name = "easterEgg";
            easterEgg.UseVisualStyleBackColor = true;
            easterEgg.Click += easterEgg_Click;
            // 
            // info_button
            // 
            info_button.Cursor = Cursors.Hand;
            resources.ApplyResources(info_button, "info_button");
            info_button.ForeColor = Color.White;
            info_button.Name = "info_button";
            info_button.UseVisualStyleBackColor = false;
            info_button.Click += Infobutton_Click;
            // 
            // content_panel
            // 
            resources.ApplyResources(content_panel, "content_panel");
            content_panel.Name = "content_panel";
            content_panel.Paint += content_panel_Paint;
            // 
            // Menue
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.Silver;
            ControlBox = false;
            Controls.Add(content_panel);
            Controls.Add(exit_button);
            Controls.Add(neuesSpielHinzufügen_button);
            Controls.Add(navigationBar_panel);
            Name = "Menue";
            WindowState = FormWindowState.Maximized;
            navigationBar_panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button meineSpiele_button;
        private Button neuesSpielHinzufügen_button;
        private Label logo_label;
        private Button exit_button;
        private Panel navigationBar_panel;
        private Panel content_panel;
        private Button info_button;
        private Button easterEgg;
    }
}
