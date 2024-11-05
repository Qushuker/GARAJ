using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GARAJ.GARAJ.App.ParkingLots.Dto;
using GARAJ.GARAJ.Domain.ParkingLots.Input;

namespace GARAJ.GARAJ.App.ParkingLots;

public interface IParkingLotAppService
{ 
    Task<ParkingLotDto> GetAsync(Guid id);
    Task<List<ParkingLotDto>> GetAllAsync();
    Task<ParkingLotDto> CreateAsync(ParkingLotCreateInput input);
    Task<ParkingLotDto> UpdateAsync(ParkingLotUpdateInput input);
    Task<ParkingLotDto> DeleteAsync(Guid id);
}