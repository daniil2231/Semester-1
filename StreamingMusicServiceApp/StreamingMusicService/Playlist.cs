using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingMusicService
{
    public class Playlist
    {
        private string name;
        List<Song> songListInPlaylist = new List<Song>();

        public Playlist(string name)
        {
            this.name = name;
        }

        public string GetPlaylistName()
        {
            return this.name;
        }

        public void AddSongToPlaylist(Song s)
        {
            songListInPlaylist.Add(s);
        }

        public void RemoveSongFromPlaylist(Song s)
        {
            songListInPlaylist.Remove(s);
        }

        public string GetPlaylistSongs()
        {
            string songsInPlaylist = "";
            if (songListInPlaylist.Count <= 0)
            {
                songsInPlaylist = $"{this.name} has no songs";
            }
            else
            {
                songsInPlaylist = $"Songs in the {this.name} playlist: \r\n";
                for (int i = 0; i < songListInPlaylist.Count; i++)
                {
                    songsInPlaylist += $"- {songListInPlaylist[i].GetInfo()}";
                }
            }
            return songsInPlaylist;
        } 
    }
}
