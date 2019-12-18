namespace MusicPlayer
{
    partial class MusicPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.MinimizeBTN = new System.Windows.Forms.Button();
            this.CloseBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.OpenFolderBTN = new System.Windows.Forms.Button();
            this.PreviousBTN = new System.Windows.Forms.Button();
            this.PlayBTN = new System.Windows.Forms.Button();
            this.NextBTN = new System.Windows.Forms.Button();
            this.ShuffleBTN = new System.Windows.Forms.Button();
            this.IdleTimer = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MusicList = new System.Windows.Forms.ListBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SearchBTN = new System.Windows.Forms.Button();
            this.CrtPlayListBTN = new System.Windows.Forms.Button();
            this.UpgradeBTN = new System.Windows.Forms.Button();
            this.MP3MediaPLayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MP3MediaPLayer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(191)))));
            this.panel1.Controls.Add(this.UpgradeBTN);
            this.panel1.Controls.Add(this.MinimizeBTN);
            this.panel1.Controls.Add(this.CloseBTN);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 58);
            this.panel1.TabIndex = 0;
            // 
            // MinimizeBTN
            // 
            this.MinimizeBTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimizeBTN.FlatAppearance.BorderSize = 0;
            this.MinimizeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeBTN.ForeColor = System.Drawing.Color.White;
            this.MinimizeBTN.Location = new System.Drawing.Point(369, 0);
            this.MinimizeBTN.Name = "MinimizeBTN";
            this.MinimizeBTN.Size = new System.Drawing.Size(41, 58);
            this.MinimizeBTN.TabIndex = 2;
            this.MinimizeBTN.Text = "_";
            this.MinimizeBTN.UseVisualStyleBackColor = true;
            this.MinimizeBTN.Click += new System.EventHandler(this.MinimizeBTN_Click);
            // 
            // CloseBTN
            // 
            this.CloseBTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseBTN.FlatAppearance.BorderSize = 0;
            this.CloseBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBTN.ForeColor = System.Drawing.Color.White;
            this.CloseBTN.Location = new System.Drawing.Point(410, 0);
            this.CloseBTN.Name = "CloseBTN";
            this.CloseBTN.Size = new System.Drawing.Size(41, 58);
            this.CloseBTN.TabIndex = 1;
            this.CloseBTN.Text = "X";
            this.CloseBTN.UseVisualStyleBackColor = true;
            this.CloseBTN.Click += new System.EventHandler(this.CloseBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Music Player";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // OpenFolderBTN
            // 
            this.OpenFolderBTN.Location = new System.Drawing.Point(17, 419);
            this.OpenFolderBTN.Name = "OpenFolderBTN";
            this.OpenFolderBTN.Size = new System.Drawing.Size(75, 23);
            this.OpenFolderBTN.TabIndex = 1;
            this.OpenFolderBTN.Text = "Import";
            this.OpenFolderBTN.UseVisualStyleBackColor = true;
            this.OpenFolderBTN.Click += new System.EventHandler(this.OpenFolderBTN_Click);
            // 
            // PreviousBTN
            // 
            this.PreviousBTN.Location = new System.Drawing.Point(99, 419);
            this.PreviousBTN.Name = "PreviousBTN";
            this.PreviousBTN.Size = new System.Drawing.Size(75, 23);
            this.PreviousBTN.TabIndex = 2;
            this.PreviousBTN.Text = "Previous";
            this.PreviousBTN.UseVisualStyleBackColor = true;
            this.PreviousBTN.Click += new System.EventHandler(this.PreviousBTN_Click);
            // 
            // PlayBTN
            // 
            this.PlayBTN.Location = new System.Drawing.Point(181, 418);
            this.PlayBTN.Name = "PlayBTN";
            this.PlayBTN.Size = new System.Drawing.Size(75, 23);
            this.PlayBTN.TabIndex = 3;
            this.PlayBTN.Text = "Play";
            this.PlayBTN.UseVisualStyleBackColor = true;
            this.PlayBTN.Click += new System.EventHandler(this.PlayBTN_Click);
            // 
            // NextBTN
            // 
            this.NextBTN.Location = new System.Drawing.Point(263, 418);
            this.NextBTN.Name = "NextBTN";
            this.NextBTN.Size = new System.Drawing.Size(75, 23);
            this.NextBTN.TabIndex = 4;
            this.NextBTN.Text = "Next";
            this.NextBTN.UseVisualStyleBackColor = true;
            this.NextBTN.Click += new System.EventHandler(this.NextBTN_Click);
            // 
            // ShuffleBTN
            // 
            this.ShuffleBTN.Location = new System.Drawing.Point(345, 418);
            this.ShuffleBTN.Name = "ShuffleBTN";
            this.ShuffleBTN.Size = new System.Drawing.Size(75, 23);
            this.ShuffleBTN.TabIndex = 5;
            this.ShuffleBTN.Text = "Shuffle";
            this.ShuffleBTN.UseVisualStyleBackColor = true;
            this.ShuffleBTN.Click += new System.EventHandler(this.ShuffleBTN_Click);
            // 
            // IdleTimer
            // 
            this.IdleTimer.Interval = 1000;
            this.IdleTimer.Tick += new System.EventHandler(this.IdleTimer_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(191)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 445);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(451, 29);
            this.panel3.TabIndex = 9;
            // 
            // MusicList
            // 
            this.MusicList.FormattingEnabled = true;
            this.MusicList.Location = new System.Drawing.Point(240, 136);
            this.MusicList.Name = "MusicList";
            this.MusicList.Size = new System.Drawing.Size(199, 264);
            this.MusicList.TabIndex = 10;
            this.MusicList.SelectedIndexChanged += new System.EventHandler(this.MusicList_SelectedIndexChanged);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(240, 110);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(109, 20);
            this.SearchBox.TabIndex = 11;
            // 
            // SearchBTN
            // 
            this.SearchBTN.Location = new System.Drawing.Point(355, 110);
            this.SearchBTN.Name = "SearchBTN";
            this.SearchBTN.Size = new System.Drawing.Size(84, 20);
            this.SearchBTN.TabIndex = 12;
            this.SearchBTN.Text = "Search";
            this.SearchBTN.UseVisualStyleBackColor = true;
            this.SearchBTN.Click += new System.EventHandler(this.SearchBTN_Click);
            // 
            // CrtPlayListBTN
            // 
            this.CrtPlayListBTN.Location = new System.Drawing.Point(240, 81);
            this.CrtPlayListBTN.Name = "CrtPlayListBTN";
            this.CrtPlayListBTN.Size = new System.Drawing.Size(199, 23);
            this.CrtPlayListBTN.TabIndex = 13;
            this.CrtPlayListBTN.Text = "Create Playlist";
            this.CrtPlayListBTN.UseVisualStyleBackColor = true;
            this.CrtPlayListBTN.Click += new System.EventHandler(this.CrtPlayListBTN_Click);
            // 
            // UpgradeBTN
            // 
            this.UpgradeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpgradeBTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.UpgradeBTN.Location = new System.Drawing.Point(159, 0);
            this.UpgradeBTN.Name = "UpgradeBTN";
            this.UpgradeBTN.Size = new System.Drawing.Size(63, 58);
            this.UpgradeBTN.TabIndex = 14;
            this.UpgradeBTN.Text = "Upgrade";
            this.UpgradeBTN.UseVisualStyleBackColor = true;
            this.UpgradeBTN.Click += new System.EventHandler(this.UpgradeBTN_Click);
            // 
            // MP3MediaPLayer
            // 
            this.MP3MediaPLayer.Enabled = true;
            this.MP3MediaPLayer.Location = new System.Drawing.Point(13, 81);
            this.MP3MediaPLayer.Name = "MP3MediaPLayer";
            this.MP3MediaPLayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MP3MediaPLayer.OcxState")));
            this.MP3MediaPLayer.Size = new System.Drawing.Size(221, 318);
            this.MP3MediaPLayer.TabIndex = 7;
            // 
            // MusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 474);
            this.Controls.Add(this.CrtPlayListBTN);
            this.Controls.Add(this.SearchBTN);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.MusicList);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.MP3MediaPLayer);
            this.Controls.Add(this.ShuffleBTN);
            this.Controls.Add(this.NextBTN);
            this.Controls.Add(this.PlayBTN);
            this.Controls.Add(this.PreviousBTN);
            this.Controls.Add(this.OpenFolderBTN);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MusicPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MP3MediaPLayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CloseBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OpenFolderBTN;
        private System.Windows.Forms.Button PreviousBTN;
        private System.Windows.Forms.Button PlayBTN;
        private System.Windows.Forms.Button NextBTN;
        private System.Windows.Forms.Button ShuffleBTN;
        private System.Windows.Forms.Button MinimizeBTN;
        private System.Windows.Forms.Timer IdleTimer;
        private AxWMPLib.AxWindowsMediaPlayer MP3MediaPLayer;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.OpenFileDialog ofdPlayer;
        private System.Windows.Forms.ListBox MusicList;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button SearchBTN;
        private System.Windows.Forms.Button CrtPlayListBTN;
        private System.Windows.Forms.Button UpgradeBTN;
    }
}

