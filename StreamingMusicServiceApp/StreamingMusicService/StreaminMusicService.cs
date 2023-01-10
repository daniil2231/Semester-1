using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingMusicService
{
    public class StreamingMusicService
    {
        private int songIdSeeder;
        private string name;
        private List<Song> songs;
        private List<User> users = new List<User>();
        //private List<Playlist> playlists = new List<Playlist>();

        public StreamingMusicService(string name)
        {
            this.songIdSeeder = 1;
            this.name = name;
            this.songs = new List<Song>();
        }

        public void AddSong(string artist, string title, int durationInSeconds)
        {
            this.songs.Add(new Song(this.songIdSeeder, artist, title, durationInSeconds));
            this.songIdSeeder++;
        }
        //not sure what this method can be used for
        public Song GetSong(int id)
        {
            foreach (Song s in this.songs)
            {
                if (id == s.GetId())
                { return s; }
            }
            return null;
        }

        public List<Song> GetSongs()
        {
            return this.songs;
        }
        //not sure what this method can be used for
        public List<Song> GetSongs(string artist)
        {
            List<Song> foundSongs = new List<Song>();
            foreach (Song s in this.songs)
            {
                if(artist == s.GetArtist())
                { foundSongs.Add(s); }
            }
            return foundSongs;
        }

        public void AddUser(string name, string email, string address)
        {
            users.Add(new User(name, email, address));
        }
        //not sure what this method can be used for
        public User GetUser(string email)
        {
            User userToReturn = new User("", "");
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].GetEmail() == email)
                {
                    userToReturn = users[i];
                }
            }
            return userToReturn;
        }

        public List<User> GetUsers()
        {
            List<User> userListToReturn = new List<User>();

            for (int i = 0; i < users.Count; i++)
            {
                userListToReturn.Add(users[i]);
            }
            return userListToReturn;
        }

        public string GetInfo()
        {
            return $"Streaming Music service: {this.name} ({this.songs.Count} songs)";
        }
    }
}
