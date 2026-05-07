using System.Windows.Data;
using YukkuriMovieMaker.ItemEditor;

namespace DynamicEffect
{
    [AttributeUsage(AttributeTargets.Property)]
    internal sealed class RmsWindowVisibleAttribute : Attribute, ICustomVisibilityAttribute2
    {
        public Binding GetBinding(object item, object propertyOwner)
        {
            return new Binding(nameof(ConditionalDynamicsEffect.DetectionMode))
            {
                Source = item,
                Converter = new RmsWindowVisibleConverter(),
            };
        }
    }
}
