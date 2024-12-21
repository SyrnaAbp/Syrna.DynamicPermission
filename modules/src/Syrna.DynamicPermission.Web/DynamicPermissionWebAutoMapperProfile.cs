using Syrna.DynamicPermission.PermissionDefinitions.Dtos;
using AutoMapper;
using Syrna.DynamicPermission.Web.Pages.DynamicPermission.PermissionDefinitions.PermissionDefinition.ViewModels;

namespace Syrna.DynamicPermission.Web
{
    public class DynamicPermissionWebAutoMapperProfile : Profile
    {
        public DynamicPermissionWebAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<PermissionDefinitionDto, CreateEditPermissionDefinitionViewModel>();
            CreateMap<CreateEditPermissionDefinitionViewModel, CreateUpdatePermissionDefinitionDto>();
        }
    }
}
