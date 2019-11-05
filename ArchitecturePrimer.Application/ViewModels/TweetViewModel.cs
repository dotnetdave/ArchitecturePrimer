namespace ArchitecturePrimer.Application.ViewModels
{
    public class TweetViewModel
    {
        public string CreatedAt { get; set; }
        public string Link { get; set; }
        public string Text { get; set; }
        public string TwitterUserName { get; set; }
        public string TwitterUserScreenName { get; set; }
        public int TwitterUserTweetsCount { get; set; }
    }
}