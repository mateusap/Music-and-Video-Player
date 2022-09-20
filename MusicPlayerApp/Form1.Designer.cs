namespace MusicPlayerApp
{
    partial class musicPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(musicPlayer));
            this.listBoxMusic = new System.Windows.Forms.ListBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lblFooter = new System.Windows.Forms.Label();
            this.MediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxMusic
            // 
            this.listBoxMusic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxMusic.FormattingEnabled = true;
            this.listBoxMusic.ItemHeight = 16;
            this.listBoxMusic.Location = new System.Drawing.Point(520, 12);
            this.listBoxMusic.Name = "listBoxMusic";
            this.listBoxMusic.Size = new System.Drawing.Size(120, 164);
            this.listBoxMusic.TabIndex = 1;
            this.listBoxMusic.SelectedIndexChanged += new System.EventHandler(this.listBoxMusic_SelectedIndexChanged);
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.Location = new System.Drawing.Point(520, 182);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(120, 40);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lblFooter
            // 
            this.lblFooter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFooter.AutoSize = true;
            this.lblFooter.Location = new System.Drawing.Point(9, 225);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(157, 13);
            this.lblFooter.TabIndex = 4;
            this.lblFooter.Text = "Desenvolvido por: Mateus Silva";
            // 
            // MediaPlayer
            // 
            this.MediaPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MediaPlayer.Enabled = true;
            this.MediaPlayer.Location = new System.Drawing.Point(12, 12);
            this.MediaPlayer.Name = "MediaPlayer";
            this.MediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaPlayer.OcxState")));
            this.MediaPlayer.Size = new System.Drawing.Size(484, 210);
            this.MediaPlayer.TabIndex = 3;
            // 
            // musicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(653, 244);
            this.Controls.Add(this.lblFooter);
            this.Controls.Add(this.MediaPlayer);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.listBoxMusic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "musicPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Player";
            this.Load += new System.EventHandler(this.musicPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxMusic;
        private System.Windows.Forms.Button btnSelect;
        private AxWMPLib.AxWindowsMediaPlayer MediaPlayer;
        private System.Windows.Forms.Label lblFooter;
    }
}

