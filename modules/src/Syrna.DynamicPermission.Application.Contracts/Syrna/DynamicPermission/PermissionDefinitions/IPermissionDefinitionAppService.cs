using System;
using Syrna.DynamicPermission.PermissionDefinitions.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Syrna.DynamicPermission.PermissionDefinitions
{
    public interface IPermissionDefinitionAppService :
        ICrudAppService< 
            PermissionDefinitionDto, 
            string, 
            PagedAndSortedResultRequestDto,
            CreateOrUpdatePermissionDefinitionDto,
            CreateOrUpdatePermissionDefinitionDto>
    {

    }
}