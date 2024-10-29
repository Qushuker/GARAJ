using System;
using System.Linq;
using System.Threading.Tasks;
using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.Domain.Uow;
using GARAJ.GARAJ.Domain.Buildings.Input;
using GARAJ.GARAJ.Entities;
using Microsoft.EntityFrameworkCore;

namespace GARAJ.GARAJ.Domain.Buildings;

public class BuildingDomainService : DomainService, IBuildingDomainService
{
    #region DI

    private readonly IRepository<Building, Guid> _buildingRepository;


    public BuildingDomainService(IRepository<Building, Guid> buildingRepository)
    {
        _buildingRepository = buildingRepository;
    }

    #endregion


    [UnitOfWork]
    public async Task<Building> CreateAsync(BuildingCreateInput input)
    {
        return await _buildingRepository.InsertAsync(
            ObjectMapper.Map<Building>(input)
        );
    }


    [UnitOfWork]
    public async Task<Building> UpdateAsync(BuildingUpdateInput input)
    {
        Building building = await _buildingRepository
            .Query(e => e.Where(o => o.Id == input.Id))
            .FirstOrDefaultAsync();

        if (building == null)
            throw new EntityNotFoundException();

        ObjectMapper.Map(input, building);

        return building;
    }


    [UnitOfWork]
    public async Task<Building> DeleteAsync(Guid id)
    {
        Building building = await _buildingRepository
            .Query(e => e.Where(o => o.Id == id))
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (building == null)
            throw new EntityNotFoundException();

        await _buildingRepository.DeleteAsync(building);

        return building;
    }
}