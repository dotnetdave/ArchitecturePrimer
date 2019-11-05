using ArchitecturePrimer.Application.ViewModels.Home;
using MediatR;

namespace ArchitecturePrimer.Application.Home.Queries
{
    public class GetHomeQuery : IRequest<HomeViewModel>
    {
        public override string ToString()
        {
            return "No request values";
        }
    }
}