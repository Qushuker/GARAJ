using System;
using System.Threading.Tasks;
using Abp.Domain.Services;
using GARAJ.GARAJ.Domain.Parkings.Input;
using GARAJ.GARAJ.Entities;

namespace GARAJ.GARAJ.Domain.Parkings;

public interface IParkingDomainService : IDomainService
{
    Task<Parking> CreateAsync(ParkingCreateInput input);
    Task<Parking> UpdateAsync(ParkingUpdateInput input);
    Task<Parking> DeleteAsync(Guid id);
}