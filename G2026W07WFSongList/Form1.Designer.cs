using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace G2026W07WFSongList
{
    partial class Form1
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
            listSong = new ListBox();
            button1 = new Button();
            txtTitle = new TextBox();
            txtArtist = new TextBox();
            txtRating = new TextBox();
            SuspendLayout();
            // 
            // listSong
            // 
            listSong.FormattingEnabled = true;
            listSong.Location = new Point(218, 30);
            listSong.Name = "listSong";
            listSong.Size = new Size(323, 244);
            listSong.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(498, 248);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "추가";
            button1.UseVisualStyleBackColor = true;
            button1.Click += OnAdd;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(252, 244);
            txtTitle.Name = "textTitle";
            txtTitle.PlaceholderText = "제목";
            txtTitle.Size = new Size(100, 27);
            txtTitle.TabIndex = 2;
            // 
            // txtArtist
            // 
            txtArtist.Location = new Point(358, 244);
            txtArtist.Name = "txtArtist";
            txtArtist.PlaceholderText = "가수";
            txtArtist.Size = new Size(100, 27);
            txtArtist.TabIndex = 3;
            // 
            // txtRating
            // 
            txtRating.Location = new Point(441, 211);
            txtRating.Name = "txtRating";
            txtRating.PlaceholderText = "평점";
            txtRating.Size = new Size(100, 27);
            txtRating.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtRating);
            Controls.Add(this.txtArtist);
            Controls.Add(this.txtTitle);
            Controls.Add(button1);
            Controls.Add(listSong);
            Name = "Form1";
            Text = "애창곡";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listSong;
        private Button button1;
        private TextBox txtArtist;
        private TextBox txtTitle;
        private TextBox txtRating;
    }
}
