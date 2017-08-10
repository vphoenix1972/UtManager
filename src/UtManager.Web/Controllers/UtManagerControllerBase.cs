using System;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using UtManager.Core.Exceptions;
using UtManager.Utils;
using UtManager.Web.Models;

namespace UtManager.Web.Controllers
{
    public abstract class UtManagerControllerBase : Controller
    {
        [NonAction]
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.Exception != null && context.ExceptionHandled != true)
            {
                OnException(context.Exception, context);
                return;
            }

            base.OnActionExecuted(context);
        }

        protected virtual void OnException([NotNull] Exception e, [NotNull] ActionExecutedContext context)
        {
            var result = new WebApiErrorModel();

            var error = new WebApiError();
            if (e is UtManagerException)
            {
                error.Code = (int) ((UtManagerException) e).Code;
            }
            error.Message = e.Message;

            result.Errors.Add(error);

            var actionResult = new ObjectResult(result);
            actionResult.StatusCode = (int) HttpStatusCode.InternalServerError;

            context.Result = actionResult;
            context.ExceptionHandled = true;
        }
    }
}