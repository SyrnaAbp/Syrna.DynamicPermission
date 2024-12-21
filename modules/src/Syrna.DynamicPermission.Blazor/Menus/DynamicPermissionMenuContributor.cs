using System.Collections.Generic;
using System.Threading.Tasks;
using Syrna.DynamicPermission.Localization;
using Syrna.DynamicPermission.Permissions;
using Volo.Abp.UI.Navigation;

namespace Syrna.DynamicPermission.Blazor.Menus
{
    public class DynamicPermissionMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
        }

        private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            var l = context.GetLocalizer<DynamicPermissionResource>();

            var abpDynamicPermissionMenuItem = context.Menu.GetAdministration().Items.GetOrAdd(
                i => i.Name == DynamicPermissionMenus.Prefix,
                () => new ApplicationMenuItem(DynamicPermissionMenus.Prefix, l["Menu:SyrnaDynamicPermission"],
                    icon: "fa fa-user-shield")
            );

            if (await context.IsGrantedAsync(DynamicPermissionPermissions.PermissionDefinition.Default))
            {
                abpDynamicPermissionMenuItem.AddItem(
                    new ApplicationMenuItem(DynamicPermissionMenus.PermissionDefinition, l["Menu:PermissionDefinition"],
                        "/DynamicPermission/PermissionDefinitions/PermissionDefinition")
                );
            }
        }
    }
}