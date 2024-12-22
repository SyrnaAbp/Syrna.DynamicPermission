$(function () {

    var l = abp.localization.getResource('SyrnaDynamicPermission');

    var service = syrna.dynamicPermission.permissionDefinitions.permissionDefinition;
    var createModal = new abp.ModalManager(abp.appPath + 'DynamicPermission/PermissionDefinitions/PermissionDefinition/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'DynamicPermission/PermissionDefinitions/PermissionDefinition/EditModal');

    var dataTable = $('#PermissionDefinitionTable').DataTable(abp.libs.datatables.normalizeConfiguration({
        processing: true,
        serverSide: true,
        paging: true,
        searching: false,
        autoWidth: false,
        scrollCollapse: true,
        order: [[0, "asc"]],
        ajax: abp.libs.datatables.createAjax(service.getList),
        columnDefs: [
            {
                rowAction: {
                    items:
                        [
                            {
                                text: l('Edit'),
                                visible: abp.auth.isGranted('Syrna.DynamicPermission.PermissionDefinition.Update'),
                                action: function (data) {
                                    editModal.open({
                                        id: data.record.id
                                    });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('Syrna.DynamicPermission.PermissionDefinition.Delete'),
                                confirmMessage: function (data) {
                                    return l('PermissionDefinitionDeletionConfirmationMessage', data.record.id);
                                },
                                action: function (data) {
                                    service.delete({
                                        id: data.record.id
                                    })
                                        .then(function () {
                                            abp.notify.info(l('SuccessfullyDeleted'));
                                            dataTable.ajax.reload();
                                        });
                                }
                            }
                        ]
                }
            },
            {
                title: l('PermissionDefinitionId'),
                data: "id"
            },
            {
                title: l('PermissionDefinitionDisplayName'),
                data: "displayName"
            },
            {
                title: l('PermissionDefinitionDescription'),
                data: "description"
            },
            {
                title: l('PermissionDefinitionIsPublic'),
                data: "isPublic"
            },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewPermissionDefinitionButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
