namespace ForcePlayV2
{
    partial class menue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menue));

            this.meineSpiele_button = new System.Windows.Forms.Button();
            this.neuesSpielHinzufügen_button = new System.Windows.Forms.Button();
            this.logo_label = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Button();
            this.navigationBar_panel = new System.Windows.Forms.Panel();
            this.navigationBar_panel.SuspendLayout();

            this.SuspendLayout();
            // 
            // meineSpiele_button
            // 
            this.meineSpiele_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.meineSpiele_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.meineSpiele_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            resources.ApplyResources(this.meineSpiele_button, "meineSpiele_button");
            this.meineSpiele_button.ForeColor = System.Drawing.Color.White;
            this.meineSpiele_button.Name = "meineSpiele_button";
            this.meineSpiele_button.UseVisualStyleBackColor = false;
            // 
            // neuesSpielHinzufügen_button
            // 
            this.neuesSpielHinzufügen_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.neuesSpielHinzufügen_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.neuesSpielHinzufügen_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            resources.ApplyResources(this.neuesSpielHinzufügen_button, "neuesSpielHinzufügen_button");
            this.neuesSpielHinzufügen_button.ForeColor = System.Drawing.Color.White;
            this.neuesSpielHinzufügen_button.Name = "neuesSpielHinzufügen_button";
            this.neuesSpielHinzufügen_button.UseVisualStyleBackColor = false;
            // 
            // logo_label
            // 
            this.logo_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.logo_label, "logo_label");
            this.logo_label.ForeColor = System.Drawing.Color.White;
            this.logo_label.Name = "logo_label";
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.exit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            resources.ApplyResources(this.exit_button, "exit_button");
            this.exit_button.ForeColor = System.Drawing.Color.White;
            this.exit_button.Name = "exit_button";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.button3_Click);
            // 
            // navigationBar_panel
            // 
            this.navigationBar_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.navigationBar_panel.Controls.Add(this.meineSpiele_button);
            resources.ApplyResources(this.navigationBar_panel, "navigationBar_panel");
            this.navigationBar_panel.Name = "navigationBar_panel";
            // 
            // menue
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Silver;
            this.ControlBox = false;
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.logo_label);
            this.Controls.Add(this.neuesSpielHinzufügen_button);
            this.Controls.Add(this.navigationBar_panel);
            this.Name = "menue";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.navigationBar_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Button meineSpiele_button;
        private Button neuesSpielHinzufügen_button;
        private Label logo_label;
        private Button exit_button;
        private Panel navigationBar_panel;
    }
}
