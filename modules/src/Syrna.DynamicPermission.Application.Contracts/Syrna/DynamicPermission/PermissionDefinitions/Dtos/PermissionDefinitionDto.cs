using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Entities;

namespace Syrna.DynamicPermission.PermissionDefinitions.Dtos
{
    [Serializable]
    public class PermissionDefinitionDto : ExtensibleEntityDto<string>, IHasConcurrencyStamp
    {
        public string DisplayName { get; set; }

        public string Description { get; set; }

        public bool IsPublic { get; set; }

        public string ConcurrencyStamp { get; set; }
    }
}