using System;
using System.Collections.Generic;
using System.Linq;
using DotVVM.Framework.Hosting;

namespace DotVVM.Framework.Runtime.Filters.PresenterFilters.ActionFilters
{
    /// <summary>
    /// Allows to modify the response when an exception occurs.
    /// </summary>
    public abstract class ExceptionFilterAttribute : ActionFilterAttribute
    {

        /// <summary>
        /// Called after the command is invoked.
        /// </summary>
        protected internal override void OnCommandExecuted(IDotvvmRequestContext context, ActionInfo actionInfo, Exception exception)
        {
            if (exception != null)
            {
                OnCommandException(context, actionInfo, exception);
            }
        }

        /// <summary>
        /// Called when the exception occurs during the command invocation.
        /// </summary>
        protected virtual void OnCommandException(IDotvvmRequestContext context, ActionInfo actionInfo, Exception ex)
        {
        }

    }
}