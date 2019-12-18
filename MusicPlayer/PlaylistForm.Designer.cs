﻿namespace MusicPlayer
{
    partial class PlaylistForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MoveToPlyBTN = new System.Windows.Forms.Button();
            this.RemoveSongBtn = new System.Windows.Forms.Button();
            this.CreatePlaylistBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 53);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 225);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Saved Songs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Playlist";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(179, 53);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 225);
            this.listBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Playlist Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 20);
            this.textBox1.TabIndex = 5;
            // 
            // MoveToPlyBTN
            // 
            this.MoveToPlyBTN.Location = new System.Drawing.Point(12, 284);
            this.MoveToPlyBTN.Name = "MoveToPlyBTN";
            this.MoveToPlyBTN.Size = new System.Drawing.Size(120, 23);
            this.MoveToPlyBTN.TabIndex = 6;
            this.MoveToPlyBTN.Text = "Add Song ->";
            this.MoveToPlyBTN.UseVisualStyleBackColor = true;
            // 
            // RemoveSongBtn
            // 
            this.RemoveSongBtn.Location = new System.Drawing.Point(179, 284);
            this.RemoveSongBtn.Name = "RemoveSongBtn";
            this.RemoveSongBtn.Size = new System.Drawing.Size(120, 23);
            this.RemoveSongBtn.TabIndex = 7;
            this.RemoveSongBtn.Text = "<- Remove Song";
            this.RemoveSongBtn.UseVisualStyleBackColor = true;
            // 
            // CreatePlaylistBTN
            // 
            this.CreatePlaylistBTN.Location = new System.Drawing.Point(13, 314);
            this.CreatePlaylistBTN.Name = "CreatePlaylistBTN";
            this.CreatePlaylistBTN.Size = new System.Drawing.Size(286, 31);
            this.CreatePlaylistBTN.TabIndex = 8;
            this.CreatePlaylistBTN.Text = "Create Playlist";
            this.CreatePlaylistBTN.UseVisualStyleBackColor = true;
            // 
            // PlaylistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 357);
            this.Controls.Add(this.CreatePlaylistBTN);
            this.Controls.Add(this.RemoveSongBtn);
            this.Controls.Add(this.MoveToPlyBTN);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PlaylistForm";
            this.Text = "PlaylistForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button MoveToPlyBTN;
        private System.Windows.Forms.Button RemoveSongBtn;
        private System.Windows.Forms.Button CreatePlaylistBTN;
    }
}