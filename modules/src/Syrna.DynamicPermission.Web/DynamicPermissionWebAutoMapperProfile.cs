using Syrna.DynamicPermission.PermissionDefinitions.Dtos;
using Syrna.DynamicPermission.Web.Pages.Abp.DynamicPermission.PermissionDefinitions.PermissionDefinition.ViewModels;
using AutoMapper;

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
