using System;
using System.Threading.Tasks;
using Abp.Domain.Services;
using GARAJ.GARAJ.Domain.PhysicalAddresses.Input;
using GARAJ.GARAJ.Entities;

namespace GARAJ.GARAJ.Domain.PhysicalAddresses;

public interface IPhysicalAddressDomainService : IDomainService
{
    Task<PhysicalAddress> CreateAsync(PhysicalAddressCreateInput input);
    Task<PhysicalAddress> UpdateAsync(PhysicalAddressUpdateInput input);
    Task<PhysicalAddress> DeleteAsync(Guid id);
}