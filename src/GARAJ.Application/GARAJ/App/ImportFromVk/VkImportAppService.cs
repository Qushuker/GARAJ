using System.Threading.Tasks;
using Abp.Application.Services;
using GARAJ.GARAJ.Domain.Buildings;
using GARAJ.GARAJ.Domain.Buildings.Input;

namespace GARAJ.GARAJ.App.ImportFromVk;

public class VkImportFromProfileInput
{
    public string VkId { get; set; }
    public BuildingCreateInput BuildingCreateInput { get; set; }
}


public class VkImportAppService : IApplicationService
{
    private readonly IBuildingDomainService _buildingDomainService;


    public VkImportAppService(IBuildingDomainService buildingDomainService)
    {
        _buildingDomainService = buildingDomainService;
    }


    public async Task ImportBuildingFromProfile(VkImportFromProfileInput input)
    {
        string vkId = input.VkId;
        _buildingDomainService.CreateAsync(input.BuildingCreateInput);
    }
}