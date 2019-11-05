using System.Collections.Generic;
using ArchitecturePrimer.Domain;

namespace ArchitecturePrimer.Application
{
    public interface ITweet
    {
        IEnumerable<TweetModel> GetTweets();
    }
}