using System.Threading.Tasks;

namespace Syrna.DynamicPermission.Web.Pages.DynamicPermission.PermissionDefinitions.PermissionDefinition
{
    public class IndexModel : DynamicPermissionPageModel
    {
        public virtual async Task OnGetAsync()
        {
            await Task.CompletedTask;
        }
    }
}
