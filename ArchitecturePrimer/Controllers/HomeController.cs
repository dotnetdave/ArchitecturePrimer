using ArchitecturePrimer.Application.Home.Queries;
using MediatR;
using System.Threading.Tasks;
using System.Web.Mvc;
using NLog;

namespace ArchitecturePrimer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger logger;
        private readonly IMediator mediator;

        public HomeController(IMediator mediator, ILogger logger)
        {
            this.mediator = mediator;
            this.logger = logger;
        }

        public async Task<ActionResult> Index()
        {
            var model = await mediator.Send(new GetHomeQuery());

            if (model != null)
            {
                return View(model);
            }

            logger.Error("Home model is null");
            return HttpNotFound();
        }
    }
}