using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingMusicService
{
    public class User
    {
        private string user;
        private string email;
        private string address;
        List<Playlist> playlistList = new List<Playlist>();

        public User(string name, string email)
        {
            this.user = name;
            this.email = email;
        }

        public User(string name, string email, string address)
        {
            this.user = name;
            this.email = email;
            this.address = address;
        }

        public string GetUsername()
        {
            return this.user;
        }

        public string GetEmail()
        {
            return this.email;
        }

        public void AddPlaylist(Playlist playlist)
        {
            playlistList.Add(playlist);
        }
        //i get an index out of range error when i try to implement this
        public void RemovePlaylist(Playlist playlist)
        {
            playlistList.Remove(playlist);
        }

        public List<Playlist> GetPlaylists()
        {
            return playlistList;
        }
    }
}
