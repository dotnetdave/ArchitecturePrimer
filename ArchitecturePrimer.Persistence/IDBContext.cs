using System.Collections.Generic;
using ArchitecturePrimer.Domain;

namespace ArchitecturePrimer.Persistence
{
    public interface IDbContext
    {
        HomeModel GetHomeData();

        List<HomeFeatureModel> GetHomeFeaturesData();
    }
}