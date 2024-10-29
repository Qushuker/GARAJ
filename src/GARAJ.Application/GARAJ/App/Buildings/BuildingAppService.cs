using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using GARAJ.Abp.Authorization;
using GARAJ.GARAJ.App.Buildings.Dto;
using GARAJ.GARAJ.Domain.Buildings;
using GARAJ.GARAJ.Domain.Buildings.Input;
using GARAJ.GARAJ.Entities;
using Microsoft.EntityFrameworkCore;

namespace GARAJ.GARAJ.App.Buildings;

[AbpAuthorize(PermissionNames.Pages_Building)]
public class BuildingAppService : ApplicationService, IBuildingAppService
{
    #region DI

    private readonly IBuildingDomainService _buildingDomainService;
    private readonly IRepository<Building, Guid> _buildingRepository;


    public BuildingAppService(
        IBuildingDomainService buildingDomainService,
        IRepository<Building, Guid> buildingRepository)
    {
        _buildingDomainService = buildingDomainService;
        _buildingRepository = buildingRepository;
    }

    #endregion


    public async Task<BuildingDto> GetAsync(Guid id)
    {
        return await _buildingRepository
            .Query(e => e.Where(o => o.Id == id))
            .AsNoTracking()
            .Select(o => ObjectMapper.Map<BuildingDto>(o))
            .FirstOrDefaultAsync();
    }


    public async Task<List<BuildingDto>> GetAllAsync()
    {
        return await _buildingRepository
            .Query(e => e.Where(o => true))
            .AsNoTracking()
            .Select(o => ObjectMapper.Map<BuildingDto>(o))
            .ToListAsync();
    }


    [UnitOfWork]
    public async Task<BuildingDto> CreateAsync(BuildingCreateInput input)
    {
        Building building = await _buildingDomainService.CreateAsync(input);
        
        return ObjectMapper.Map<BuildingDto>(building);
    }


    [UnitOfWork]
    public async Task<BuildingDto> UpdateAsync(BuildingUpdateInput input)
    {
        Building building = await _buildingDomainService.UpdateAsync(input);

        return ObjectMapper.Map<BuildingDto>(building);
    }


    [UnitOfWork]
    public async Task<BuildingDto> DeleteAsync(Guid id)
    {
        Building building = await _buildingDomainService.DeleteAsync(id);

        return ObjectMapper.Map<BuildingDto>(building);
    }
}