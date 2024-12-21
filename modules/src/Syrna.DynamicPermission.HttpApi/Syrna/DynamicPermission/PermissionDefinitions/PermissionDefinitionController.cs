using System;
using Syrna.DynamicPermission.PermissionDefinitions.Dtos;
using Volo.Abp.Application.Dtos;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;

namespace Syrna.DynamicPermission.PermissionDefinitions
{
    [RemoteService(Name = SyrnaDynamicPermissionRemoteServiceConsts.RemoteServiceName)]
    [Route("/api/abp/dynamic-permission/permission-definition")]
    public class PermissionDefinitionController : DynamicPermissionController, IPermissionDefinitionAppService
    {
        private readonly IPermissionDefinitionAppService _service;

        public PermissionDefinitionController(IPermissionDefinitionAppService service)
        {
            _service = service;
        }

        [HttpPost]
        [Route("")]
        public virtual Task<PermissionDefinitionDto> CreateAsync(CreateOrUpdatePermissionDefinitionDto input)
        {
            return _service.CreateAsync(input);
        }

        [HttpPut]
        [Route("{Name}")]
        public virtual Task<PermissionDefinitionDto> UpdateAsync(string id, CreateOrUpdatePermissionDefinitionDto input)
        {
            return _service.UpdateAsync(id, input);
        }

        [HttpDelete]
        [Route("{Name}")]
        public virtual Task DeleteAsync(string id)
        {
            return _service.DeleteAsync(id);
        }

        [HttpGet]
        [Route("{Name}")]
        public virtual Task<PermissionDefinitionDto> GetAsync(string id)
        {
            return _service.GetAsync(id);
        }

        [HttpGet]
        [Route("")]
        public virtual Task<PagedResultDto<PermissionDefinitionDto>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            return _service.GetListAsync(input);
        }
    }
}