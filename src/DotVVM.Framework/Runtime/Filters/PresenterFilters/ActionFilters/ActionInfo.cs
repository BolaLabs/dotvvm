using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using DotVVM.Framework.Controls;
using DotVVM.Framework.Binding;
using DotVVM.Framework.Binding.Expressions;

namespace DotVVM.Framework.Runtime.Filters.PresenterFilters.ActionFilters
{
    public class ActionInfo
    {
        public BindingExpression Binding { get; set; }
        public bool IsControlCommand { get; internal set; }

        public Func<object> Action { get; set; }
    }
}