using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using NLog;

namespace ArchitecturePrimer.Application.Pipeline
{
    public class RequestPerformanceBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    {
        private readonly ILogger logger;
        private readonly Stopwatch timer;

        public RequestPerformanceBehaviour(ILogger logger)
        {
            timer = new Stopwatch();

            this.logger = logger;
        }

        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            timer.Start();
            var response = await next();
            timer.Stop();
            if (timer.ElapsedMilliseconds > 1000)
            {
                var name = typeof(TRequest).Name;
                logger.Warn("Detected Long Running Request: {Name} ({ElapsedMilliseconds} milliseconds) {@Request}", name, timer.ElapsedMilliseconds, request);
            }

            return response;
        }
    }
}