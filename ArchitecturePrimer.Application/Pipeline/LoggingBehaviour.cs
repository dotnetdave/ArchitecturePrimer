using System.Threading;
using System.Threading.Tasks;
using MediatR;
using NLog;

namespace ArchitecturePrimer.Application.Pipeline
{
    public class LoggingBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    {
        private readonly ILogger logger;

        public LoggingBehaviour(ILogger logger)
        {
            this.logger = logger;
        }

        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            logger.Info($"Request from {request.GetType().Name} : {request}");
            var response = await next();
            return response;
        }
    }
}