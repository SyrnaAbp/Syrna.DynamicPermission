using System;
using System.ComponentModel;
using Volo.Abp.ObjectExtending;
namespace Syrna.DynamicPermission.PermissionDefinitions.Dtos
{
    [Serializable]
    public class CreateOrUpdatePermissionDefinitionDto : ExtensibleObject
    {
        public string Id { get; set; }

        public string DisplayName { get; set; }

        public string Description { get; set; }

        public bool IsPublic { get; set; }
        protected CreateOrUpdatePermissionDefinitionDto()
         : base(setDefaultsForExtraProperties: false)
        {
        }
    }
}