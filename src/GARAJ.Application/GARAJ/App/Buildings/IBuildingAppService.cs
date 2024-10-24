using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using GARAJ.GARAJ.App.Buildings.Dto;
using GARAJ.GARAJ.Domain.Buildings.Input;

namespace GARAJ.GARAJ.App.Buildings;

public interface IBuildingAppService : IApplicationService
{
    Task<BuildingDto> GetAsync(Guid id);
    Task<List<BuildingDto>> GetAllAsync();
    Task<BuildingDto> CreateAsync(BuildingCreateInput input);
    Task<BuildingDto> UpdateAsync(BuildingUpdateInput input);
    Task<BuildingDto> DeleteAsync(Guid id);
}