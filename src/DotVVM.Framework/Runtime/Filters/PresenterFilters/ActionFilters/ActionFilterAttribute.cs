using System;
using System.Collections.Generic;
using System.Linq;
using DotVVM.Framework.Hosting;

namespace DotVVM.Framework.Runtime.Filters.PresenterFilters.ActionFilters
{
    /// <summary>
    /// Allows to add custom logic before and after a command is executed on a ViewModel.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = true)]
    public abstract class ActionFilterAttribute : Attribute
    {

        
        /// <summary>
        /// Called after the viewmodel object is created.
        /// </summary>
        protected internal virtual void OnViewModelCreated(IDotvvmRequestContext context)
        {
        }


        /// <summary>
        /// Called before the command is executed.
        /// </summary>
        protected internal virtual void OnCommandExecuting(IDotvvmRequestContext context, ActionInfo actionInfo)
        {
        }


        /// <summary>
        /// Called after the command is executed.
        /// </summary>
        protected internal virtual void OnCommandExecuted(IDotvvmRequestContext context, ActionInfo actionInfo, Exception exception)
        {
        }

        /// <summary>
        /// Called before the response is rendered.
        /// </summary>
        protected internal virtual void OnResponseRendering(IDotvvmRequestContext context)
        {
        }

        /// <summary>
        /// Called when an exception occurs during the processing of the page events.
        /// </summary>
        protected internal virtual void OnPageException(IDotvvmRequestContext context, Exception exception)
        {
        }
    }
}
