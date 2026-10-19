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
            btnAdd = new Button();
            txtTitle = new TextBox();
            txtArtist = new TextBox();
            txtRating = new TextBox();
            txtSelected = new TextBox();
            btnDelete = new Button();
            txtFilter = new TextBox();
            SuspendLayout();
            // 
            // listSong
            // 
            listSong.FormattingEnabled = true;
            listSong.Location = new Point(218, 39);
            listSong.Name = "listSong";
            listSong.Size = new Size(439, 264);
            listSong.TabIndex = 0;
            listSong.Click += OnYouTube;
            listSong.SelectedIndexChanged += OnChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(538, 260);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "추가";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += OnAdd;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(218, 220);
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "제목";
            txtTitle.Size = new Size(100, 27);
            txtTitle.TabIndex = 2;
            // 
            // txtArtist
            // 
            txtArtist.Location = new Point(324, 223);
            txtArtist.Name = "txtArtist";
            txtArtist.PlaceholderText = "가수";
            txtArtist.Size = new Size(100, 27);
            txtArtist.TabIndex = 3;
            // 
            // txtRating
            // 
            txtRating.Location = new Point(430, 223);
            txtRating.Name = "txtRating";
            txtRating.PlaceholderText = "평점";
            txtRating.Size = new Size(100, 27);
            txtRating.TabIndex = 4;
            // 
            // txtSelected
            // 
            txtSelected.Location = new Point(238, 256);
            txtSelected.Name = "txtSelected";
            txtSelected.PlaceholderText = "삭제를 위한 선택한 노래";
            txtSelected.ReadOnly = true;
            txtSelected.Size = new Size(245, 27);
            txtSelected.TabIndex = 5;
            txtSelected.Visible = false;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(536, 231);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "삭제";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += onDelete;
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(218, 7);
            txtFilter.Name = "txtFilter";
            txtFilter.PlaceholderText = "제목 또는 가수 검색";
            txtFilter.Size = new Size(439, 27);
            txtFilter.TabIndex = 7;
            txtFilter.TextChanged += OnFilterChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtFilter);
            Controls.Add(btnDelete);
            Controls.Add(txtSelected);
            Controls.Add(txtRating);
            Controls.Add(txtArtist);
            Controls.Add(txtTitle);
            Controls.Add(btnAdd);
            Controls.Add(listSong);
            Name = "Form1";
            Text = "애창곡";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listSong;
        private Button btnAdd;
        private TextBox txtArtist;
        private TextBox txtTitle;
        private TextBox txtRating;
        private TextBox txtSelected;
        private Button btnDelete;
        private TextBox txtFilter;
    }
}
