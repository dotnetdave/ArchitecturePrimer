using System;

namespace ArchitecturePrimer.Domain
{
    public class TweetModel
    {
        public DateTime CreatedAt { get; set; }
        public string Link { get; set; }
        public string Text { get; set; }
        public TwitterUser TwitterUser { get; set; }
    }
}