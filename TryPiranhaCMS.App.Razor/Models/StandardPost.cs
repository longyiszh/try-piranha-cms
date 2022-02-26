using Piranha.AttributeBuilder;
using Piranha.Models;

namespace TryPiranhaCMS.App.Razor.Models
{
    [PostType(Title = "Standard post")]
    public class StandardPost  : Post<StandardPost>
    {
    }
}