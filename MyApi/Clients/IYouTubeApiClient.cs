using MyApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyApi.Clients
{
    public interface IYouTubeApiClient
    {
        //+
        public Task<List<Video>> GetSerchByVideoRequest(string request);

        //+
        public Task<LikeVideo> GetVideoInfo(string VideoId);//dell user


        //+
        public Task<List<Video>> GetSerchByArtist(string artist);

        //+
        public Task<List<List<Video>>> GetSerchByGenres();

        //+
        public Task<List<Video>> GetTrendingMusic();


        //public Task<List<Video>> GetPopularSongs();

        //public Task<Playlist> PostPlaylist(string playlistName, List<Video> videos);

        //public Task<bool> PostDate(LikeVideo likeVideo);

        //public Task<List<LikeVideo>> GetAll();

    }
}
