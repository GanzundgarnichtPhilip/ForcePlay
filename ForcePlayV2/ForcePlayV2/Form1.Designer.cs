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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Buttons_Leiste = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Buttons_Leiste)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.button2, "button2");
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Buttons_Leiste
            // 
            this.Buttons_Leiste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.Buttons_Leiste, "Buttons_Leiste");
            this.Buttons_Leiste.Name = "Buttons_Leiste";
            this.Buttons_Leiste.TabStop = false;
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.Logo, "Logo");
            this.Logo.ForeColor = System.Drawing.Color.White;
            this.Logo.Name = "Logo";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.button3, "button3");
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Menue
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Silver;
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Buttons_Leiste);
            this.Name = "Menue";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.Buttons_Leiste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button button1;
        private Button button2;
        private PictureBox Buttons_Leiste;
        private Label Logo;
        private Button button3;
    }
}