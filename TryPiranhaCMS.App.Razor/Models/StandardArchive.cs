using Piranha.AttributeBuilder;
using Piranha.Models;

namespace TryPiranhaCMS.App.Razor.Models
{
    [PageType(Title = "Standard archive", IsArchive = true)]
    public class StandardArchive : Page<StandardArchive>
    {
    }
}