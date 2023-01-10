namespace StreamingMusicService
{
    partial class Form1
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
            this.lbSongs = new System.Windows.Forms.ListBox();
            this.tbArtist = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbDuration = new System.Windows.Forms.TextBox();
            this.btnAddSong = new System.Windows.Forms.Button();
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.tcSongsAndUsers = new System.Windows.Forms.TabControl();
            this.tabSongs = new System.Windows.Forms.TabPage();
            this.lblPlaylistName = new System.Windows.Forms.Label();
            this.tbPlaylistName = new System.Windows.Forms.TextBox();
            this.btnShowSongsInPlaylist = new System.Windows.Forms.Button();
            this.btnShowAllSongs = new System.Windows.Forms.Button();
            this.btnRemoveFromPlaylist = new System.Windows.Forms.Button();
            this.lbPlaylistSongs = new System.Windows.Forms.ListBox();
            this.btnAddToPlaylist = new System.Windows.Forms.Button();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.btnRemoveSelectedPlaylist = new System.Windows.Forms.Button();
            this.btnAddPlaylist = new System.Windows.Forms.Button();
            this.lblAddPlaylistName = new System.Windows.Forms.Label();
            this.tbAddPlaylistName = new System.Windows.Forms.TextBox();
            this.lbUserPlaylists = new System.Windows.Forms.ListBox();
            this.lbAllUsers = new System.Windows.Forms.ListBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.lblAddAddress = new System.Windows.Forms.Label();
            this.lblAddEmail = new System.Windows.Forms.Label();
            this.lblAddUser = new System.Windows.Forms.Label();
            this.tbAddAddress = new System.Windows.Forms.TextBox();
            this.tbAddEmail = new System.Windows.Forms.TextBox();
            this.tbAddUser = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.lblStreamingServiceInfo = new System.Windows.Forms.Label();
            this.btnShowPlaylists = new System.Windows.Forms.Button();
            this.tcSongsAndUsers.SuspendLayout();
            this.tabSongs.SuspendLayout();
            this.tabUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbSongs
            // 
            this.lbSongs.FormattingEnabled = true;
            this.lbSongs.ItemHeight = 16;
            this.lbSongs.Location = new System.Drawing.Point(35, 158);
            this.lbSongs.Name = "lbSongs";
            this.lbSongs.Size = new System.Drawing.Size(325, 148);
            this.lbSongs.TabIndex = 0;
            // 
            // tbArtist
            // 
            this.tbArtist.Location = new System.Drawing.Point(104, 38);
            this.tbArtist.Name = "tbArtist";
            this.tbArtist.Size = new System.Drawing.Size(142, 22);
            this.tbArtist.TabIndex = 2;
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(104, 66);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(142, 22);
            this.tbTitle.TabIndex = 3;
            // 
            // tbDuration
            // 
            this.tbDuration.Location = new System.Drawing.Point(104, 95);
            this.tbDuration.Name = "tbDuration";
            this.tbDuration.Size = new System.Drawing.Size(142, 22);
            this.tbDuration.TabIndex = 4;
            // 
            // btnAddSong
            // 
            this.btnAddSong.Location = new System.Drawing.Point(119, 123);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(109, 31);
            this.btnAddSong.TabIndex = 5;
            this.btnAddSong.Text = "Add song";
            this.btnAddSong.UseVisualStyleBackColor = true;
            this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Location = new System.Drawing.Point(54, 41);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(44, 17);
            this.lblArtist.TabIndex = 6;
            this.lblArtist.Text = "Artist:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(59, 71);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(39, 17);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Title:";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(32, 98);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(66, 17);
            this.lblDuration.TabIndex = 8;
            this.lblDuration.Text = "Duration:";
            // 
            // tcSongsAndUsers
            // 
            this.tcSongsAndUsers.Controls.Add(this.tabSongs);
            this.tcSongsAndUsers.Controls.Add(this.tabUsers);
            this.tcSongsAndUsers.Location = new System.Drawing.Point(1, 29);
            this.tcSongsAndUsers.Name = "tcSongsAndUsers";
            this.tcSongsAndUsers.SelectedIndex = 0;
            this.tcSongsAndUsers.Size = new System.Drawing.Size(741, 474);
            this.tcSongsAndUsers.TabIndex = 9;
            // 
            // tabSongs
            // 
            this.tabSongs.Controls.Add(this.lblPlaylistName);
            this.tabSongs.Controls.Add(this.tbPlaylistName);
            this.tabSongs.Controls.Add(this.btnShowSongsInPlaylist);
            this.tabSongs.Controls.Add(this.btnShowAllSongs);
            this.tabSongs.Controls.Add(this.btnRemoveFromPlaylist);
            this.tabSongs.Controls.Add(this.lbPlaylistSongs);
            this.tabSongs.Controls.Add(this.btnAddToPlaylist);
            this.tabSongs.Controls.Add(this.lbSongs);
            this.tabSongs.Controls.Add(this.lblDuration);
            this.tabSongs.Controls.Add(this.lblTitle);
            this.tabSongs.Controls.Add(this.tbArtist);
            this.tabSongs.Controls.Add(this.lblArtist);
            this.tabSongs.Controls.Add(this.tbTitle);
            this.tabSongs.Controls.Add(this.btnAddSong);
            this.tabSongs.Controls.Add(this.tbDuration);
            this.tabSongs.Location = new System.Drawing.Point(4, 25);
            this.tabSongs.Name = "tabSongs";
            this.tabSongs.Padding = new System.Windows.Forms.Padding(3);
            this.tabSongs.Size = new System.Drawing.Size(733, 445);
            this.tabSongs.TabIndex = 0;
            this.tabSongs.Text = "Songs";
            this.tabSongs.UseVisualStyleBackColor = true;
            // 
            // lblPlaylistName
            // 
            this.lblPlaylistName.AutoSize = true;
            this.lblPlaylistName.Location = new System.Drawing.Point(283, 315);
            this.lblPlaylistName.Name = "lblPlaylistName";
            this.lblPlaylistName.Size = new System.Drawing.Size(95, 17);
            this.lblPlaylistName.TabIndex = 18;
            this.lblPlaylistName.Text = "Playlist name:";
            // 
            // tbPlaylistName
            // 
            this.tbPlaylistName.Location = new System.Drawing.Point(384, 312);
            this.tbPlaylistName.Name = "tbPlaylistName";
            this.tbPlaylistName.Size = new System.Drawing.Size(100, 22);
            this.tbPlaylistName.TabIndex = 17;
            // 
            // btnShowSongsInPlaylist
            // 
            this.btnShowSongsInPlaylist.Location = new System.Drawing.Point(490, 368);
            this.btnShowSongsInPlaylist.Name = "btnShowSongsInPlaylist";
            this.btnShowSongsInPlaylist.Size = new System.Drawing.Size(189, 27);
            this.btnShowSongsInPlaylist.TabIndex = 16;
            this.btnShowSongsInPlaylist.Text = "Show songs in playlist";
            this.btnShowSongsInPlaylist.UseVisualStyleBackColor = true;
            // 
            // btnShowAllSongs
            // 
            this.btnShowAllSongs.Location = new System.Drawing.Point(91, 366);
            this.btnShowAllSongs.Name = "btnShowAllSongs";
            this.btnShowAllSongs.Size = new System.Drawing.Size(186, 31);
            this.btnShowAllSongs.TabIndex = 12;
            this.btnShowAllSongs.Text = "Show all songs";
            this.btnShowAllSongs.UseVisualStyleBackColor = true;
            this.btnShowAllSongs.Click += new System.EventHandler(this.btnShowAllSongs_Click);
            // 
            // btnRemoveFromPlaylist
            // 
            this.btnRemoveFromPlaylist.Location = new System.Drawing.Point(490, 313);
            this.btnRemoveFromPlaylist.Name = "btnRemoveFromPlaylist";
            this.btnRemoveFromPlaylist.Size = new System.Drawing.Size(189, 50);
            this.btnRemoveFromPlaylist.TabIndex = 11;
            this.btnRemoveFromPlaylist.Text = "Remove selected song from playlist";
            this.btnRemoveFromPlaylist.UseVisualStyleBackColor = true;
            this.btnRemoveFromPlaylist.Click += new System.EventHandler(this.btnRemoveFromFavorites_Click);
            // 
            // lbPlaylistSongs
            // 
            this.lbPlaylistSongs.FormattingEnabled = true;
            this.lbPlaylistSongs.HorizontalScrollbar = true;
            this.lbPlaylistSongs.ItemHeight = 16;
            this.lbPlaylistSongs.Location = new System.Drawing.Point(415, 158);
            this.lbPlaylistSongs.Name = "lbPlaylistSongs";
            this.lbPlaylistSongs.Size = new System.Drawing.Size(311, 148);
            this.lbPlaylistSongs.TabIndex = 10;
            // 
            // btnAddToPlaylist
            // 
            this.btnAddToPlaylist.Location = new System.Drawing.Point(91, 312);
            this.btnAddToPlaylist.Name = "btnAddToPlaylist";
            this.btnAddToPlaylist.Size = new System.Drawing.Size(186, 51);
            this.btnAddToPlaylist.TabIndex = 9;
            this.btnAddToPlaylist.Text = "Add selected song to the playlist in the textbox";
            this.btnAddToPlaylist.UseVisualStyleBackColor = true;
            this.btnAddToPlaylist.Click += new System.EventHandler(this.btnAddToFavorites_Click);
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.btnShowPlaylists);
            this.tabUsers.Controls.Add(this.btnRemoveSelectedPlaylist);
            this.tabUsers.Controls.Add(this.btnAddPlaylist);
            this.tabUsers.Controls.Add(this.lblAddPlaylistName);
            this.tabUsers.Controls.Add(this.tbAddPlaylistName);
            this.tabUsers.Controls.Add(this.lbUserPlaylists);
            this.tabUsers.Controls.Add(this.lbAllUsers);
            this.tabUsers.Controls.Add(this.btnAddUser);
            this.tabUsers.Controls.Add(this.lblAddAddress);
            this.tabUsers.Controls.Add(this.lblAddEmail);
            this.tabUsers.Controls.Add(this.lblAddUser);
            this.tabUsers.Controls.Add(this.tbAddAddress);
            this.tabUsers.Controls.Add(this.tbAddEmail);
            this.tabUsers.Controls.Add(this.tbAddUser);
            this.tabUsers.Location = new System.Drawing.Point(4, 25);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsers.Size = new System.Drawing.Size(733, 445);
            this.tabUsers.TabIndex = 1;
            this.tabUsers.Text = "Users";
            this.tabUsers.UseVisualStyleBackColor = true;
            // 
            // btnRemoveSelectedPlaylist
            // 
            this.btnRemoveSelectedPlaylist.Location = new System.Drawing.Point(225, 361);
            this.btnRemoveSelectedPlaylist.Name = "btnRemoveSelectedPlaylist";
            this.btnRemoveSelectedPlaylist.Size = new System.Drawing.Size(130, 57);
            this.btnRemoveSelectedPlaylist.TabIndex = 12;
            this.btnRemoveSelectedPlaylist.Text = "Remove selected playlist";
            this.btnRemoveSelectedPlaylist.UseVisualStyleBackColor = true;
            this.btnRemoveSelectedPlaylist.Visible = false;
            this.btnRemoveSelectedPlaylist.Click += new System.EventHandler(this.btnRemoveSelectedPlaylist_Click);
            // 
            // btnAddPlaylist
            // 
            this.btnAddPlaylist.Location = new System.Drawing.Point(104, 265);
            this.btnAddPlaylist.Name = "btnAddPlaylist";
            this.btnAddPlaylist.Size = new System.Drawing.Size(109, 29);
            this.btnAddPlaylist.TabIndex = 11;
            this.btnAddPlaylist.Text = "Add playlist";
            this.btnAddPlaylist.UseVisualStyleBackColor = true;
            this.btnAddPlaylist.Click += new System.EventHandler(this.btnAddPlaylist_Click);
            // 
            // lblAddPlaylistName
            // 
            this.lblAddPlaylistName.AutoSize = true;
            this.lblAddPlaylistName.Location = new System.Drawing.Point(59, 225);
            this.lblAddPlaylistName.Name = "lblAddPlaylistName";
            this.lblAddPlaylistName.Size = new System.Drawing.Size(95, 17);
            this.lblAddPlaylistName.TabIndex = 10;
            this.lblAddPlaylistName.Text = "Playlist name:";
            // 
            // tbAddPlaylistName
            // 
            this.tbAddPlaylistName.Location = new System.Drawing.Point(160, 222);
            this.tbAddPlaylistName.Name = "tbAddPlaylistName";
            this.tbAddPlaylistName.Size = new System.Drawing.Size(100, 22);
            this.tbAddPlaylistName.TabIndex = 9;
            // 
            // lbUserPlaylists
            // 
            this.lbUserPlaylists.FormattingEnabled = true;
            this.lbUserPlaylists.ItemHeight = 16;
            this.lbUserPlaylists.Location = new System.Drawing.Point(361, 222);
            this.lbUserPlaylists.Name = "lbUserPlaylists";
            this.lbUserPlaylists.Size = new System.Drawing.Size(240, 196);
            this.lbUserPlaylists.TabIndex = 8;
            // 
            // lbAllUsers
            // 
            this.lbAllUsers.FormattingEnabled = true;
            this.lbAllUsers.ItemHeight = 16;
            this.lbAllUsers.Location = new System.Drawing.Point(361, 18);
            this.lbAllUsers.Name = "lbAllUsers";
            this.lbAllUsers.Size = new System.Drawing.Size(240, 148);
            this.lbAllUsers.TabIndex = 7;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(149, 131);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(95, 35);
            this.btnAddUser.TabIndex = 6;
            this.btnAddUser.Text = "Add user";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // lblAddAddress
            // 
            this.lblAddAddress.AutoSize = true;
            this.lblAddAddress.Location = new System.Drawing.Point(57, 97);
            this.lblAddAddress.Name = "lblAddAddress";
            this.lblAddAddress.Size = new System.Drawing.Size(92, 17);
            this.lblAddAddress.TabIndex = 5;
            this.lblAddAddress.Text = "Add address:";
            // 
            // lblAddEmail
            // 
            this.lblAddEmail.AutoSize = true;
            this.lblAddEmail.Location = new System.Drawing.Point(75, 69);
            this.lblAddEmail.Name = "lblAddEmail";
            this.lblAddEmail.Size = new System.Drawing.Size(74, 17);
            this.lblAddEmail.TabIndex = 4;
            this.lblAddEmail.Text = "Add email:";
            // 
            // lblAddUser
            // 
            this.lblAddUser.AutoSize = true;
            this.lblAddUser.Location = new System.Drawing.Point(80, 40);
            this.lblAddUser.Name = "lblAddUser";
            this.lblAddUser.Size = new System.Drawing.Size(69, 17);
            this.lblAddUser.TabIndex = 3;
            this.lblAddUser.Text = "Add user:";
            // 
            // tbAddAddress
            // 
            this.tbAddAddress.Location = new System.Drawing.Point(149, 94);
            this.tbAddAddress.Name = "tbAddAddress";
            this.tbAddAddress.Size = new System.Drawing.Size(154, 22);
            this.tbAddAddress.TabIndex = 2;
            // 
            // tbAddEmail
            // 
            this.tbAddEmail.Location = new System.Drawing.Point(149, 66);
            this.tbAddEmail.Name = "tbAddEmail";
            this.tbAddEmail.Size = new System.Drawing.Size(154, 22);
            this.tbAddEmail.TabIndex = 1;
            // 
            // tbAddUser
            // 
            this.tbAddUser.Location = new System.Drawing.Point(149, 37);
            this.tbAddUser.Name = "tbAddUser";
            this.tbAddUser.Size = new System.Drawing.Size(154, 22);
            this.tbAddUser.TabIndex = 0;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(484, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(46, 17);
            this.lblUser.TabIndex = 14;
            this.lblUser.Text = "User: ";
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(536, 6);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(100, 22);
            this.tbUser.TabIndex = 13;
            // 
            // lblStreamingServiceInfo
            // 
            this.lblStreamingServiceInfo.AutoSize = true;
            this.lblStreamingServiceInfo.Location = new System.Drawing.Point(106, 9);
            this.lblStreamingServiceInfo.Name = "lblStreamingServiceInfo";
            this.lblStreamingServiceInfo.Size = new System.Drawing.Size(158, 17);
            this.lblStreamingServiceInfo.TabIndex = 12;
            this.lblStreamingServiceInfo.Text = "*Streaming service info*";
            // 
            // btnShowPlaylists
            // 
            this.btnShowPlaylists.Location = new System.Drawing.Point(225, 327);
            this.btnShowPlaylists.Name = "btnShowPlaylists";
            this.btnShowPlaylists.Size = new System.Drawing.Size(130, 28);
            this.btnShowPlaylists.TabIndex = 13;
            this.btnShowPlaylists.Text = "Show all playlists";
            this.btnShowPlaylists.UseVisualStyleBackColor = true;
            this.btnShowPlaylists.Click += new System.EventHandler(this.btnShowPlaylists_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 504);
            this.Controls.Add(this.lblStreamingServiceInfo);
            this.Controls.Add(this.tcSongsAndUsers);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.lblUser);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "The death of Spotify";
            this.tcSongsAndUsers.ResumeLayout(false);
            this.tabSongs.ResumeLayout(false);
            this.tabSongs.PerformLayout();
            this.tabUsers.ResumeLayout(false);
            this.tabUsers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbSongs;
        private System.Windows.Forms.TextBox tbArtist;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbDuration;
        private System.Windows.Forms.Button btnAddSong;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.TabControl tcSongsAndUsers;
        private System.Windows.Forms.TabPage tabSongs;
        private System.Windows.Forms.Button btnAddToPlaylist;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.Button btnRemoveFromPlaylist;
        private System.Windows.Forms.ListBox lbPlaylistSongs;
        private System.Windows.Forms.TextBox tbAddUser;
        private System.Windows.Forms.Button btnShowAllSongs;
        private System.Windows.Forms.ListBox lbAllUsers;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label lblAddAddress;
        private System.Windows.Forms.Label lblAddEmail;
        private System.Windows.Forms.Label lblAddUser;
        private System.Windows.Forms.TextBox tbAddAddress;
        private System.Windows.Forms.TextBox tbAddEmail;
        private System.Windows.Forms.Label lblStreamingServiceInfo;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Label lblPlaylistName;
        private System.Windows.Forms.TextBox tbPlaylistName;
        private System.Windows.Forms.Button btnShowSongsInPlaylist;
        private System.Windows.Forms.Button btnRemoveSelectedPlaylist;
        private System.Windows.Forms.Button btnAddPlaylist;
        private System.Windows.Forms.Label lblAddPlaylistName;
        private System.Windows.Forms.TextBox tbAddPlaylistName;
        private System.Windows.Forms.ListBox lbUserPlaylists;
        private System.Windows.Forms.Button btnShowPlaylists;
    }
}

