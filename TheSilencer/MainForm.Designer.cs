namespace TheSilencer
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtBoxInfo = new System.Windows.Forms.TextBox();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelMusicProgram = new System.Windows.Forms.Label();
            this.labelDelay = new System.Windows.Forms.Label();
            this.textBoxMusicProgram = new System.Windows.Forms.TextBox();
            this.textBoxDelay = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.TheTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtBoxInfo
            // 
            this.txtBoxInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxInfo.Location = new System.Drawing.Point(12, 64);
            this.txtBoxInfo.Multiline = true;
            this.txtBoxInfo.Name = "txtBoxInfo";
            this.txtBoxInfo.ReadOnly = true;
            this.txtBoxInfo.Size = new System.Drawing.Size(360, 67);
            this.txtBoxInfo.TabIndex = 6;
            this.txtBoxInfo.TabStop = false;
            // 
            // labelVersion
            // 
            this.labelVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVersion.Location = new System.Drawing.Point(12, 134);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(360, 18);
            this.labelVersion.TabIndex = 7;
            this.labelVersion.Text = "label1";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelMusicProgram
            // 
            this.labelMusicProgram.AutoSize = true;
            this.labelMusicProgram.Location = new System.Drawing.Point(12, 15);
            this.labelMusicProgram.Name = "labelMusicProgram";
            this.labelMusicProgram.Size = new System.Drawing.Size(79, 13);
            this.labelMusicProgram.TabIndex = 0;
            this.labelMusicProgram.Text = "Music program:";
            // 
            // labelDelay
            // 
            this.labelDelay.AutoSize = true;
            this.labelDelay.Location = new System.Drawing.Point(12, 41);
            this.labelDelay.Name = "labelDelay";
            this.labelDelay.Size = new System.Drawing.Size(59, 13);
            this.labelDelay.TabIndex = 2;
            this.labelDelay.Text = "Delay (ms):";
            // 
            // textBoxMusicProgram
            // 
            this.textBoxMusicProgram.Location = new System.Drawing.Point(97, 12);
            this.textBoxMusicProgram.Name = "textBoxMusicProgram";
            this.textBoxMusicProgram.Size = new System.Drawing.Size(150, 20);
            this.textBoxMusicProgram.TabIndex = 1;
            // 
            // textBoxDelay
            // 
            this.textBoxDelay.Location = new System.Drawing.Point(97, 38);
            this.textBoxDelay.Name = "textBoxDelay";
            this.textBoxDelay.Size = new System.Drawing.Size(75, 20);
            this.textBoxDelay.TabIndex = 3;
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStart.Location = new System.Drawing.Point(297, 10);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // Stop
            // 
            this.Stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Stop.Location = new System.Drawing.Point(297, 36);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(75, 23);
            this.Stop.TabIndex = 5;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // TheTimer
            // 
            this.TheTimer.Tick += new System.EventHandler(this.TheTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxDelay);
            this.Controls.Add(this.textBoxMusicProgram);
            this.Controls.Add(this.labelDelay);
            this.Controls.Add(this.labelMusicProgram);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.txtBoxInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxInfo;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelMusicProgram;
        private System.Windows.Forms.Label labelDelay;
        private System.Windows.Forms.TextBox textBoxMusicProgram;
        private System.Windows.Forms.TextBox textBoxDelay;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Timer TheTimer;
    }
}

