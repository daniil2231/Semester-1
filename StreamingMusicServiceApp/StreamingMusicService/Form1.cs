using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreamingMusicService
{
    public partial class Form1 : Form
    {
        private StreamingMusicService musicSvc;

        public Form1()
        {
            InitializeComponent();
            // Initialize required object
            this.musicSvc = new StreamingMusicService("YoMusicfy");
            // Populate with some songs
            this.musicSvc.AddSong("Queen", "Bohemian Rhapsode", 354);
            this.musicSvc.AddSong("Tjesto", "Red Lights", 262);
            this.musicSvc.AddSong("Lady Gaga", "Shallow", 216);
            this.musicSvc.AddSong("Queen", "Don't Stop Me Now", 218);
            this.musicSvc.AddSong("Hugh Jackman, Keala Settly, NY Orchestram, The Greatest Showman Esemble, Zac Efron, Zendaya", "The Greatest Show", 302);

            this.Text = this.musicSvc.GetInfo();

            lblStreamingServiceInfo.Text = Text;
        }

        private void btnShowAllSongs_Click(object sender, EventArgs e)
        {
            lbSongs.Items.Clear();
            for (int i = 0; i < musicSvc.GetSongs().Count; i++)
            {
                lbSongs.Items.Add(musicSvc.GetSongs()[i].GetInfo());
            }
        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {
            musicSvc.AddSong(tbArtist.Text, tbTitle.Text, Convert.ToInt32(tbDuration.Text));
            lblStreamingServiceInfo.Text = musicSvc.GetInfo();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            lbAllUsers.Items.Clear();
            musicSvc.AddUser(tbAddUser.Text, tbAddEmail.Text, tbAddAddress.Text);
            for (int i = 0; i < musicSvc.GetUsers().Count; i++)
            {
                lbAllUsers.Items.Add(musicSvc.GetUsers()[i].GetUsername());
            }
            lblStreamingServiceInfo.Text = musicSvc.GetInfo();
        }

        private void btnAddToFavorites_Click(object sender, EventArgs e)
        {
            lbPlaylistSongs.Items.Clear();
            for (int i = 0; i < musicSvc.GetUsers().Count; i++)
            {
                if (musicSvc.GetUsers()[i].GetUsername() == tbUser.Text)
                {
                    for (int j = 0; j < musicSvc.GetUsers()[i].GetPlaylists().Count; j++)
                    {
                        if (musicSvc.GetUsers()[i].GetPlaylists()[j].GetPlaylistName() == tbPlaylistName.Text)
                        {
                            musicSvc.GetUsers()[i].GetPlaylists()[j].AddSongToPlaylist(musicSvc.GetSongs()[lbSongs.SelectedIndex]);
                            lbPlaylistSongs.Items.Add(musicSvc.GetUsers()[i].GetPlaylists()[j].GetPlaylistSongs());
                        }
                    }
                }
            }
        }

        private void btnRemoveFromFavorites_Click(object sender, EventArgs e)
        {
            lbPlaylistSongs.Items.Clear();
            for (int i = 0; i < musicSvc.GetUsers().Count; i++)
            {
                if (musicSvc.GetUsers()[i].GetUsername() == tbUser.Text)
                {
                    for (int j = 0; j < musicSvc.GetUsers()[i].GetPlaylists().Count; j++)
                    {
                        if (musicSvc.GetUsers()[i].GetPlaylists()[j].GetPlaylistName() == tbPlaylistName.Text)
                        {
                            musicSvc.GetUsers()[i].GetPlaylists()[j].RemoveSongFromPlaylist(musicSvc.GetSongs()[lbSongs.SelectedIndex]);
                            lbPlaylistSongs.Items.Add(musicSvc.GetUsers()[i].GetPlaylists()[j].GetPlaylistSongs());
                        }
                    }
                }
            }
        }

        private void btnShowPlaylists_Click(object sender, EventArgs e)
        {
            lbUserPlaylists.Items.Clear();
            for (int i = 0; i < musicSvc.GetUsers().Count; i++)
            {
                if (musicSvc.GetUsers()[i].GetUsername() == tbUser.Text)
                {
                    for (int j = 0; j < musicSvc.GetUsers()[i].GetPlaylists().Count; j++)
                    {
                        lbUserPlaylists.Items.Add(musicSvc.GetUsers()[i].GetPlaylists()[j].GetPlaylistName());
                    }
                }
            }
        }

        private void btnAddPlaylist_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < musicSvc.GetUsers().Count; i++)
            {
                if (musicSvc.GetUsers()[i].GetUsername() == tbUser.Text)
                {
                    musicSvc.GetUsers()[i].AddPlaylist(new Playlist(tbAddPlaylistName.Text));
                }
            }
        }
        //i get an index out of range from this for some reason
        private void btnRemoveSelectedPlaylist_Click(object sender, EventArgs e)
        {
            //lbUserPlaylists.Items.Clear();
            //for (int i = 0; i < musicSvc.GetUsers().Count; i++)
            //{
            //    if (musicSvc.GetUsers()[i].GetUsername() == tbUser.Text)
            //    {
            //        musicSvc.GetUsers()[i].RemovePlaylist(musicSvc.GetUsers()[i].GetPlaylists()[lbUserPlaylists.SelectedIndex]);
            //    }
            //}
        }
    }
}
