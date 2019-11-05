using System;
using System.Collections.Generic;
using ArchitecturePrimer.Application;
using ArchitecturePrimer.Domain;

namespace ArchitecturePrimer.Infrastructure
{
    public class TwitterFetcher : ITweet
    {
        public IEnumerable<TweetModel> GetTweets()
        {
            var tweets = new List<TweetModel>()
            {
                new TweetModel()
                {
                    Link = "https://microsoft.com",
                    CreatedAt = new DateTime(2019,10,27,12,00,00),
                    Text = "Some tweet",
                    TwitterUser = new TwitterUser()
                    {
                        ScreenName = "@microsoft",
                        Name = "Dave",
                        TweetsCount = 1433
                    }
                },
                new TweetModel()
                {
                    Link = "https://ceridian.com",
                    CreatedAt = new DateTime(2019,10,28,11,44,00),
                    Text = "Some tweet",
                    TwitterUser = new TwitterUser()
                    {
                        ScreenName = "@ceridian",
                        Name = "Dave",
                        TweetsCount = 145
                    }
                },
                new TweetModel()
                {
                    Link = "https://twitter.com",
                    CreatedAt = new DateTime(2019,10,29,9,53,00),
                    Text = "Some tweet",
                    TwitterUser = new TwitterUser()
                    {
                        ScreenName = "@google",
                        Name = "Dave",
                        TweetsCount = 1193
                    }
                },       new TweetModel()
                {
                    Link = "https://amazon.com",
                    CreatedAt = new DateTime(2019,10,1,12,1,00),
                    Text = "Some tweet",
                    TwitterUser = new TwitterUser()
                    {
                        ScreenName = "@amazon",
                        Name = "Dave",
                        TweetsCount = 543
                    }
                },
            };

            return tweets;
        }
    }
}