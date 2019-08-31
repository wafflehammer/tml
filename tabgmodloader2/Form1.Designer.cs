namespace tabgmodloader2
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.titlebar = new System.Windows.Forms.PictureBox();
            this.titlebarletters = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.minButton = new System.Windows.Forms.PictureBox();
            this.vanilla = new System.Windows.Forms.Button();
            this.modded = new System.Windows.Forms.Button();
            this.progressbar = new System.Windows.Forms.PictureBox();
            this.load = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.titlebar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressbar)).BeginInit();
            this.SuspendLayout();
            // 
            // titlebar
            // 
            this.titlebar.BackColor = System.Drawing.Color.Fuchsia;
            this.titlebar.BackgroundImage = global::tabgmodloader2.Properties.Resources._1;
            this.titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlebar.Location = new System.Drawing.Point(0, 0);
            this.titlebar.Name = "titlebar";
            this.titlebar.Size = new System.Drawing.Size(478, 16);
            this.titlebar.TabIndex = 0;
            this.titlebar.TabStop = false;
            this.titlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Titlebar_MouseDown);
            // 
            // titlebarletters
            // 
            this.titlebarletters.BackColor = System.Drawing.Color.Fuchsia;
            this.titlebarletters.Font = new System.Drawing.Font("Wavehaus 42 Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlebarletters.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.titlebarletters.Image = global::tabgmodloader2.Properties.Resources._1;
            this.titlebarletters.Location = new System.Drawing.Point(0, 0);
            this.titlebarletters.Name = "titlebarletters";
            this.titlebarletters.Size = new System.Drawing.Size(152, 16);
            this.titlebarletters.TabIndex = 1;
            this.titlebarletters.Text = "TABG Mod Loader 2";
            this.titlebarletters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.titlebarletters.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Titlebarletters_MouseDown);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
            this.closeButton.Location = new System.Drawing.Point(454, 0);
            this.closeButton.Margin = new System.Windows.Forms.Padding(0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(24, 16);
            this.closeButton.TabIndex = 2;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // minButton
            // 
            this.minButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minButton.BackgroundImage")));
            this.minButton.Location = new System.Drawing.Point(438, 0);
            this.minButton.Margin = new System.Windows.Forms.Padding(0);
            this.minButton.Name = "minButton";
            this.minButton.Size = new System.Drawing.Size(16, 16);
            this.minButton.TabIndex = 3;
            this.minButton.TabStop = false;
            this.minButton.Click += new System.EventHandler(this.MinButton_Click);
            this.minButton.MouseEnter += new System.EventHandler(this.MinButton_MouseEnter);
            this.minButton.MouseLeave += new System.EventHandler(this.MinButton_MouseLeave);
            // 
            // vanilla
            // 
            this.vanilla.BackgroundImage = global::tabgmodloader2.Properties.Resources._3;
            this.vanilla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vanilla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vanilla.Font = new System.Drawing.Font("Wavehaus 42 Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vanilla.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.vanilla.Location = new System.Drawing.Point(12, 22);
            this.vanilla.Name = "vanilla";
            this.vanilla.Size = new System.Drawing.Size(222, 80);
            this.vanilla.TabIndex = 5;
            this.vanilla.Text = "Vanilla";
            this.vanilla.UseVisualStyleBackColor = true;
            this.vanilla.Click += new System.EventHandler(this.Vanilla_Click);
            // 
            // modded
            // 
            this.modded.BackgroundImage = global::tabgmodloader2.Properties.Resources._3;
            this.modded.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modded.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modded.Font = new System.Drawing.Font("Wavehaus 42 Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modded.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.modded.Image = global::tabgmodloader2.Properties.Resources._3;
            this.modded.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.modded.Location = new System.Drawing.Point(244, 22);
            this.modded.Name = "modded";
            this.modded.Size = new System.Drawing.Size(222, 80);
            this.modded.TabIndex = 6;
            this.modded.Text = "Modded";
            this.modded.UseVisualStyleBackColor = true;
            this.modded.Click += new System.EventHandler(this.Modded_Click);
            // 
            // progressbar
            // 
            this.progressbar.Location = new System.Drawing.Point(0, 105);
            this.progressbar.Margin = new System.Windows.Forms.Padding(0);
            this.progressbar.Name = "progressbar";
            this.progressbar.Size = new System.Drawing.Size(0, 16);
            this.progressbar.TabIndex = 7;
            this.progressbar.TabStop = false;
            // 
            // load
            // 
            this.load.AutoSize = true;
            this.load.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.load.Image = global::tabgmodloader2.Properties.Resources._1;
            this.load.Location = new System.Drawing.Point(183, 3);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(62, 13);
            this.load.TabIndex = 8;
            this.load.Text = "Loaded At: ";
            this.load.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.load.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Load_MouseDown);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::tabgmodloader2.Properties.Resources._4;
            this.ClientSize = new System.Drawing.Size(478, 108);
            this.Controls.Add(this.load);
            this.Controls.Add(this.progressbar);
            this.Controls.Add(this.modded);
            this.Controls.Add(this.vanilla);
            this.Controls.Add(this.minButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.titlebarletters);
            this.Controls.Add(this.titlebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "main";
            this.Text = "TABG Mod Loader 2";
            ((System.ComponentModel.ISupportInitialize)(this.titlebar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox titlebar;
        private System.Windows.Forms.Label titlebarletters;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.PictureBox minButton;
        private System.Windows.Forms.Button vanilla;
        private System.Windows.Forms.Button modded;
        private System.Windows.Forms.PictureBox progressbar;
        private System.Windows.Forms.Label load;
    }
}

