using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceGyakorlo
{
    public class Movie : IContent
    {
        private Video video;

        public Movie(Video video)
        {
            this.video = video;
        }

        public string getTitle()
        {
            return video.getTitle();
        }

        public int getLength()
        {
            return video.getLength();
        }
    }
}
