using InterfaceGyakorlo;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntGyako_StreamingSzolgaltato
{
    public class Series : IContent
    {
        private string title;
        private List<Video> videos;

        public Series(string title, Video firstVideo)
        {
            this.title = title;
            this.videos = new List<Video>();
            this.videos.Add(firstVideo);
        }

        public Series(string title, List<Video> videos)
        {
            this.title = title;
            this.videos = new List<Video>(videos);
        }
        public string getTitle()
        {
            return title;
        }
        public int getLength()
        {
            int totalLength = 0;

            foreach (Video video in videos)
            {
                totalLength += video.getLength();
            }

            return totalLength;
        }
    }
}
