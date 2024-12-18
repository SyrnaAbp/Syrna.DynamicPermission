using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Syrna.DynamicPermission.PermissionDefinitions;
using Syrna.DynamicPermission.PermissionDefinitions.Dtos;
using Syrna.DynamicPermission.Web.Pages.Abp.DynamicPermission.PermissionDefinitions.PermissionDefinition.ViewModels;

namespace Syrna.DynamicPermission.Web.Pages.Abp.DynamicPermission.PermissionDefinitions.PermissionDefinition
{
    public class CreateModalModel : DynamicPermissionPageModel
    {
        [BindProperty]
        public CreateEditPermissionDefinitionViewModel ViewModel { get; set; }

        private readonly IPermissionDefinitionAppService _service;

        public CreateModalModel(IPermissionDefinitionAppService service)
        {
            _service = service;
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditPermissionDefinitionViewModel, CreateUpdatePermissionDefinitionDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}