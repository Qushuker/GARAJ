using System.Threading.Tasks;
using GARAJ.Configuration.Dto;

namespace GARAJ.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
