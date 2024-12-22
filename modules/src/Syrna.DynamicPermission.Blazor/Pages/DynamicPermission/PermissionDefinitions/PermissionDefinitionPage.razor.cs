using System.Threading.Tasks;
using Blazorise;
using System;
using System.Collections.Generic;
using Volo.Abp.AspNetCore.Components.Web.Extensibility.EntityActions;
using Volo.Abp.AspNetCore.Components.Web.Extensibility.TableColumns;
using Volo.Abp.AspNetCore.Components.Web.Theming.PageToolbars;
using Syrna.DynamicPermission.Permissions;
using Syrna.DynamicPermission.PermissionDefinitions.Dtos;
using Syrna.DynamicPermission.Localization;
using Syrna.DynamicPermission.ObjectExtending;

namespace Syrna.DynamicPermission.Blazor.Pages.DynamicPermission.PermissionDefinitions;

public partial class PermissionDefinitionPage
{
    protected PageToolbar Toolbar { get; } = new();

    protected List<TableColumn> PermissionDefinitionTableColumns => TableColumns.Get<PermissionDefinitionDto>();

    public PermissionDefinitionPage()
    {
        ObjectMapperContext = typeof(SyrnaDynamicPermissionBlazorModule);
        LocalizationResource = typeof(DynamicPermissionResource);

        CreatePolicyName = DynamicPermissionPermissions.PermissionDefinition.Create;
        UpdatePolicyName = DynamicPermissionPermissions.PermissionDefinition.Update;
        DeletePolicyName = DynamicPermissionPermissions.PermissionDefinition.Delete;
    }

    public string CurrentParentId { get; set; } = null;

    protected override async Task GetEntitiesAsync()
    {
        try
        {
            await UpdateGetListInputAsync();
            var result = await AppService.GetListAsync(GetListInput);
            Entities = MapToListViewModel(result.Items);
            TotalCount = (int?)result.TotalCount;
        }
        catch (Exception ex)
        {
            await HandleErrorAsync(ex);
        }
    }
    private IReadOnlyList<PermissionDefinitionDto> MapToListViewModel(IReadOnlyList<PermissionDefinitionDto> dtos)
    {
        return ObjectMapper.Map<IReadOnlyList<PermissionDefinitionDto>, List<PermissionDefinitionDto>>(dtos);
    }

    protected override async ValueTask SetBreadcrumbItemsAsync()
    {
        BreadcrumbItems.Add(new Volo.Abp.BlazoriseUI.BreadcrumbItem(L["Menu:DynamicPermission"].Value));
        await base.SetBreadcrumbItemsAsync();
    }

    protected override ValueTask SetEntityActionsAsync()
    {
        EntityActions
            .Get<PermissionDefinitionDto>()
            .AddRange(new EntityAction[]
            {
                    new EntityAction
                    {
                        Text = L["Edit"],
                        Visible = (data) => HasUpdatePermission,
                        Clicked = async (data) => { await OpenEditModalAsync(data.As<PermissionDefinitionDto>()); }
                    },
                    new EntityAction
                    {
                        Text = L["Delete"],
                        Visible = (data) => HasDeletePermission,
                        Clicked = async (data) => await DeleteEntityAsync(data.As<PermissionDefinitionDto>()),
                        ConfirmationMessage = (data) => GetDeleteConfirmationMessage(data.As<PermissionDefinitionDto>())
                    }
            });

        return base.SetEntityActionsAsync();
    }

    protected override async ValueTask SetTableColumnsAsync()
    {
        PermissionDefinitionTableColumns
            .AddRange(new TableColumn[]
            {
                    new TableColumn
                    {
                        Title = L["Actions"],
                        Actions = EntityActions.Get<PermissionDefinitionDto>(),
                    },
                    new TableColumn
                    {
                        Title = L["PermissionDefinitionId"],
                        Sortable = true,
                        Data = nameof(PermissionDefinitionDto.Id)
                    },
                    new TableColumn
                    {
                        Title = L["PermissionDefinitionDisplayName"],
                        Sortable = true,
                        Data = nameof(PermissionDefinitionDto.DisplayName)
                    },
                    new TableColumn
                    {
                        Title = L["PermissionDefinitionDescription"],
                        Sortable = true,
                        Data = nameof(PermissionDefinitionDto.Description)
                    },
                    new TableColumn
                    {
                        Title = L["PermissionDefinitionIsPublic"],
                        Sortable = true,
                        Data = nameof(PermissionDefinitionDto.IsPublic)
                    },
            });

        PermissionDefinitionTableColumns.AddRange(await GetExtensionTableColumnsAsync(DynamicPermissionModuleExtensionConsts.ModuleName,
            DynamicPermissionModuleExtensionConsts.EntityNames.PermissionDefinition));

        await base.SetTableColumnsAsync();
    }

    protected override async Task SetPermissionsAsync()
    {
        await base.SetPermissionsAsync();
    }

    protected override string GetDeleteConfirmationMessage(PermissionDefinitionDto entity)
    {
        return string.Format(L["PermissionDefinitionDeletionConfirmationMessage"], entity.Id);
    }

    protected override ValueTask SetToolbarItemsAsync()
    {
        Toolbar.AddButton(L["NewPermissionDefinition"],
            OpenCreateModalAsync,
            IconName.Add,
            requiredPolicyName: CreatePolicyName);

        return base.SetToolbarItemsAsync();
    }
}