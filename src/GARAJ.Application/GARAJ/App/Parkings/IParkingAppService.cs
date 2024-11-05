using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GARAJ.GARAJ.Domain.Parkings.Input;

namespace GARAJ.GARAJ.App.Parkings.Dto;

public interface IParkingAppService
{
    Task<ParkingDto> GetAsync(Guid id);
    Task<List<ParkingDto>> GetAllAsync();
    Task<ParkingDto> CreateAsync(ParkingCreateInput input);
    Task<ParkingDto> UpdateAsync(ParkingUpdateInput input);
    Task<ParkingDto> DeleteAsync(Guid id);
}