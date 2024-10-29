using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using GARAJ.GARAJ.App.PhysicalAddresses.Dto;
using GARAJ.GARAJ.Domain.PhysicalAddresses.Input;

namespace GARAJ.GARAJ.App;

public interface IPhysicalAddressAppService : IApplicationService
{
    Task<PhysicalAddressDto> GetAsync(Guid id);
    Task<List<PhysicalAddressDto>> GetAllAsync();
    Task<PhysicalAddressDto> CreateAsync(PhysicalAddressCreateInput input);
    Task<PhysicalAddressDto> UpdateAsync(PhysicalAddressUpdateInput input);
    Task<PhysicalAddressDto> DeleteAsync(Guid id);
}