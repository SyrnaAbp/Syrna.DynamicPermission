using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Shouldly;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.PermissionManagement;
using Volo.Abp.Users;
using Xunit;

namespace Syrna.DynamicPermission.Authorization
{
    public class AuthorizationTests : DynamicPermissionApplicationTestBase
    {
        private readonly ICurrentUser _currentUser;
        private readonly IAuthorizationService _authorizationService;
        private readonly IPermissionManager _permissionManager;

        public AuthorizationTests()
        {
            _currentUser = GetRequiredService<ICurrentUser>();
            _authorizationService = GetRequiredService<IAuthorizationService>();
            _permissionManager = GetRequiredService<IPermissionManager>();
        }

        [Fact]
        public async Task Should_Have_Permission_Grant()
        {
            (await _authorizationService.IsGrantedAsync(DynamicPermissionTestConsts.Permission1Name)).ShouldBe(false);

            await _permissionManager.SetAsync(DynamicPermissionTestConsts.Permission1Name,
                UserPermissionValueProvider.ProviderName, _currentUser.GetId().ToString(), true);

            (await _authorizationService.IsGrantedAsync(DynamicPermissionTestConsts.Permission1Name)).ShouldBe(true);
        }

        [Fact]
        public async Task Should_Not_Have_Permission_Grant()
        {
            await _permissionManager.SetAsync(DynamicPermissionTestConsts.Permission2Name,
                UserPermissionValueProvider.ProviderName, _currentUser.GetId().ToString(), false);

            (await _authorizationService.IsGrantedAsync(DynamicPermissionTestConsts.Permission2Name)).ShouldBe(false);
        }
    }
}