using System;
using Volo.Abp.ObjectExtending.Modularity;

namespace Syrna.DynamicPermission.ObjectExtending;

public static class DynamicPermissionModuleExtensionConfigurationDictionaryExtensions
{
    public static ModuleExtensionConfigurationDictionary ConfigureDynamicPermission(
        this ModuleExtensionConfigurationDictionary modules,
        Action<DynamicPermissionModuleExtensionConfiguration> configureAction)
    {
        return modules.ConfigureModule(
            DynamicPermissionModuleExtensionConsts.ModuleName,
            configureAction
        );
    }
}
