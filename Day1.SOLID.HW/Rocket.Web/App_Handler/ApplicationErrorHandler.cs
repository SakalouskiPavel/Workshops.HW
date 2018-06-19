using System;
using System.Security.Principal;
using System.Web;
using Common.Logging;

namespace Rocket.Web.App_Handler
{
    public class ApplicationErrorHandler
    {
        private readonly ILog _logger;

        public ApplicationErrorHandler(ILog logger)
        {
            _logger = logger;
        }

        public void Handle(IPrincipal user, HttpRequest request, HttpResponse response, Exception exception)
        {
            // todo MP реализовать кастом обработчик

            _logger.Fatal("ApplicationErrorHandler", exception);
        }
    }
}