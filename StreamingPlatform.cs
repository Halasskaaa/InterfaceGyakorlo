using InterfaceGyakorlo;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntGyako_StreamingSzolgaltato
{
    public class StreamingPlatform
    {
        private List<IContent> contents = new List<IContent>();

        public void addContent(IContent content)
        {
            contents.Add(content);
        }

        public IContent getLongestContent()
        {
            if (contents.Count == 0)
            {
                return null;
            }

            IContent longest = contents[0];

            foreach (IContent content in contents)
            {
                if (content.getLength() > longest.getLength())
                {
                    longest = content;
                }
            }
            return longest;
        }
    }
}
