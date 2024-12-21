using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Syrna.DynamicPermission.PermissionDefinitions;
using Syrna.DynamicPermission.PermissionDefinitions.Dtos;
using Syrna.DynamicPermission.Web.Pages.DynamicPermission.PermissionDefinitions.PermissionDefinition.ViewModels;

namespace Syrna.DynamicPermission.Web.Pages.DynamicPermission.PermissionDefinitions.PermissionDefinition
{
    public class EditModalModel : DynamicPermissionPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public string Id { get; set; }

        [BindProperty]
        public EditPermissionDefinitionViewModel ViewModel { get; set; }

        private readonly IPermissionDefinitionAppService _service;

        public EditModalModel(IPermissionDefinitionAppService service)
        {
            _service = service;
        }

        public virtual async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<PermissionDefinitionDto, EditPermissionDefinitionViewModel>(dto);
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<EditPermissionDefinitionViewModel, UpdatePermissionDefinitionDto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}