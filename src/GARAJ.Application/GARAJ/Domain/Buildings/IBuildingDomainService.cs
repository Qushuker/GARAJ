using System;
using System.Threading.Tasks;
using Abp.Domain.Services;
using GARAJ.GARAJ.Domain.Buildings.Input;
using GARAJ.GARAJ.Entities;

namespace GARAJ.GARAJ.Domain.Buildings;

public interface IBuildingDomainService : IDomainService
{
    Task<Building> CreateAsync(BuildingCreateInput input);
    Task<Building> UpdateAsync(BuildingUpdateInput input);
    Task<Building> DeleteAsync(Guid id);
}