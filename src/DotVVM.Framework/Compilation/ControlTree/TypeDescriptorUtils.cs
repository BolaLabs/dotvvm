using System;
using DotVVM.Framework.Compilation.ControlTree.Resolved;
using DotVVM.Framework.Controls;

namespace DotVVM.Framework.Compilation.ControlTree
{
    public static class TypeDescriptorUtils
    {

        public static ITypeDescriptor GetCollectionItemType(ITypeDescriptor type)
        {
            // handle IEnumerables
            var iEnumerableType = type.TryGetArrayElementOrIEnumerableType();
            if (iEnumerableType != null)
            {
                return iEnumerableType;
            }
            
            // handle GridViewDataSet
            if (type.IsAssignableTo(new ResolvedTypeDescriptor(typeof(IDotVVMDataSet))))
            {
                var itemsType = type.TryGetPropertyType(nameof(IDotVVMDataSet.Items));
                return itemsType.TryGetArrayElementOrIEnumerableType();
            }

            throw new NotSupportedException($"The type '{type}' is not a collection or a IDotVVMDataSet!");
        }


    }
}