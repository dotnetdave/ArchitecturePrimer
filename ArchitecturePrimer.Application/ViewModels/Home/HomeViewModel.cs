using System.Collections.Generic;
using ArchitecturePrimer.Domain;

namespace ArchitecturePrimer.Application.ViewModels.Home
{
    public class HomeViewModel
    {
        public List<HomeFeatureViewModel> Features;
        public string Description { get; set; }
        public string HeroText { get; set; }
        public string Title { get; set; }
        public IEnumerable<TweetViewModel> Tweets { get; set; }
    }
}