using System;

using System.ComponentModel.DataAnnotations;

namespace Syrna.DynamicPermission.Web.Pages.DynamicPermission.PermissionDefinitions.PermissionDefinition.ViewModels
{
    public class CreatePermissionDefinitionViewModel
    {
        [Display(Name = "PermissionDefinitionId")]
        public string Id { get; set; }

        [Display(Name = "PermissionDefinitionDisplayName")]
        public string DisplayName { get; set; }

        [Display(Name = "PermissionDefinitionDescription")]
        public string Description { get; set; }

        [Display(Name = "PermissionDefinitionIsPublic")]
        public bool IsPublic { get; set; }
    }
}