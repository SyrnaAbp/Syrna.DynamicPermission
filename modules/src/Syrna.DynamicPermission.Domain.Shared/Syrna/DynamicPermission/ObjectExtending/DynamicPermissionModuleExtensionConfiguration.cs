using System;
using Volo.Abp.ObjectExtending.Modularity;

namespace Syrna.DynamicPermission.ObjectExtending;

public class DynamicPermissionModuleExtensionConfiguration : ModuleExtensionConfiguration
{
    public DynamicPermissionModuleExtensionConfiguration ConfigurePermissionDefinition(
        Action<EntityExtensionConfiguration> configureAction)
    {
        return this.ConfigureEntity(
            DynamicPermissionModuleExtensionConsts.EntityNames.PermissionDefinition,
            configureAction
        );
    }
}
