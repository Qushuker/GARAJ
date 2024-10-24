using System.Threading.Tasks;
using GARAJ.Abp.Configuration.Dto;

namespace GARAJ.Abp.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
