using Syrna.DynamicPermission.PermissionDefinitions;
using Syrna.DynamicPermission.PermissionDefinitions.Dtos;
using AutoMapper;

namespace Syrna.DynamicPermission
{
    public class DynamicPermissionApplicationAutoMapperProfile : Profile
    {
        public DynamicPermissionApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<PermissionDefinition, PermissionDefinitionDto>();
            CreateMap<CreateUpdatePermissionDefinitionDto, PermissionDefinition>(MemberList.Source);
        }
    }
}
