using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using GARAJ.Configuration.Dto;

namespace GARAJ.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : GARAJAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
