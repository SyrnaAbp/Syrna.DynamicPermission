using Microsoft.AspNetCore.Mvc;
using System;

using System.ComponentModel.DataAnnotations;

namespace Syrna.DynamicPermission.Web.Pages.DynamicPermission.PermissionDefinitions.PermissionDefinition.ViewModels
{
    public class EditPermissionDefinitionViewModel
    {
        [Display(Name = "PermissionDefinitionId")]
        [HiddenInput]
        public string Id { get; set; }

        [Display(Name = "PermissionDefinitionDisplayName")]
        public string DisplayName { get; set; }

        [Display(Name = "PermissionDefinitionDescription")]
        public string Description { get; set; }

        [Display(Name = "PermissionDefinitionIsPublic")]
        public bool IsPublic { get; set; }

        [HiddenInput()]
        public string ConcurrencyStamp { get; set; }
    }
}