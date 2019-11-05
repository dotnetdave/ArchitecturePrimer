using System.Collections.Generic;

namespace ArchitecturePrimer.Domain
{
    public class HomeModel
    {
        public List<HomeFeatureModel> Features;
        public string Description { get; set; }
        public string HeroText { get; set; }
        public string Title { get; set; }
    }
}