using System;
using Xunit;
using PlaylistWeb.Models;

namespace PlaylistTests
{
    public class PlaylistTest
    {
        [Fact]
        public void Create()
        {
            //arrange
            PlaylistWeb.Models.Playlists playlist = new PlaylistWeb.Models.Playlists
            {
                Name = "Fun Playlist",
                Description = "For having fun",
                Genre = "Hip Hop",
                CreatedAt = DateTime.Now
            };

            //act
            var testCatVM = testCat.GetViewModel();

            playlist.GetViewModel
            //Assert
            Assert.IsType<CatViewModel>(testCatVM);
            Assert.NotNull(testCatVM);
            Assert.NotEmpty(testCatVM.PictureURL);

         

        }
    }
}
