using System;
using System.Threading.Tasks;
using Abp.Domain.Services;
using GARAJ.GARAJ.Domain.ParkingLots.Input;
using GARAJ.GARAJ.Entities;

namespace GARAJ.GARAJ.Domain.ParkingLots;

public interface IParkingLotDomainService : IDomainService
{
    Task<ParkingLot> CreateAsync(ParkingLotCreateInput input);
    Task<ParkingLot> UpdateAsync(ParkingLotUpdateInput input);
    Task<ParkingLot> DeleteAsync(Guid id);
}