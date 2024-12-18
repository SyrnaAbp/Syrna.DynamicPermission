using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Syrna.DynamicPermission.MainDemo.SettingManagement;

public interface IMainDemoSettingsAppService : IApplicationService
{
    Task<MainDemoSettingsDto> GetAsync();

    Task UpdateAsync(UpdateMainDemoSettingsDto input);
}