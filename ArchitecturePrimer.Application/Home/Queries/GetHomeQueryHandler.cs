using System.Collections.Generic;
using System.Linq;
using ArchitecturePrimer.Application.ViewModels.Home;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using ArchitecturePrimer.Application.ViewModels;

using ArchitecturePrimer.Persistence;

namespace ArchitecturePrimer.Application.Home.Queries
{
    public class GetHomeQueryHandler : IRequestHandler<GetHomeQuery, HomeViewModel>
    {
        private readonly IDbContext context;
        private readonly IDateTime datetime;
        private readonly IMapper mapper;
        private readonly ITweet tweets;

        public GetHomeQueryHandler(IMapper mapper, IDbContext context, IDateTime datetime, ITweet tweets)
        {
            this.mapper = mapper;
            this.context = context;
            this.datetime = datetime;
            this.tweets = tweets;
        }

        public Task<HomeViewModel> Handle(GetHomeQuery request, CancellationToken cancellationToken)
        {
            var homeModel = context.GetHomeData();

            homeModel.Features = context.GetHomeFeaturesData().Where(f => f.PostedDate < datetime.Now).ToList();

            var homeViewModel = mapper.Map<HomeViewModel>(homeModel);

            homeViewModel.Tweets = mapper.Map<IEnumerable<TweetViewModel>>(tweets.GetTweets());

            return Task.FromResult(homeViewModel);
        }
    }
}