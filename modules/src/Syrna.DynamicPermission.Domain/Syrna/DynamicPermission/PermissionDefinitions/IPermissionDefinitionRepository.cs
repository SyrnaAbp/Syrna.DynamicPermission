using System;
using Volo.Abp.Domain.Repositories;

namespace Syrna.DynamicPermission.PermissionDefinitions
{
    public interface IPermissionDefinitionRepository : IRepository<PermissionDefinition>
    {
    }
}