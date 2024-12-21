using System;
using Volo.Abp.Domain.Entities;
using Volo.Abp.ObjectExtending;

namespace Syrna.DynamicPermission.PermissionDefinitions.Dtos
{
    [Serializable]
    public class UpdatePermissionDefinitionDto : CreateOrUpdatePermissionDefinitionDto, IHasConcurrencyStamp
    {
        public string ConcurrencyStamp { get; set; }
    }
}