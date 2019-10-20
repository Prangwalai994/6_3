using System;
using System.Collections.Generic;

namespace Refactoring6_2.Mocking
{
    public interface IVideoRepository
    {
        IEnumerable<video> GetUnprocessedVideos();
    }
    public class VideoRepository : IVideoRepository
    {
        public IEnumerable<Video> GetUnprocessedVideos()
        {
            using (var context = new VideoContext())
            {
                var videos =
                (from video in context.Videos
                 where !video.IsProcessed
                 select video).ToList();

                return videos;
            }
        }
    }
}

