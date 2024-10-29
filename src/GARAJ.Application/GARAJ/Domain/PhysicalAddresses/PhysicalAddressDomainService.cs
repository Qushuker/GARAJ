using System;
using System.Linq;
using System.Threading.Tasks;
using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.Domain.Uow;
using GARAJ.GARAJ.Domain.PhysicalAddresses.Input;
using GARAJ.GARAJ.Entities;
using Microsoft.EntityFrameworkCore;

namespace GARAJ.GARAJ.Domain.PhysicalAddresses;

public class PhysicalAddressDomainService : DomainService, IPhysicalAddressDomainService
{
    #region DI

    private readonly IRepository<PhysicalAddress, Guid> _physicalAddressRepository;


    public PhysicalAddressDomainService(IRepository<PhysicalAddress, Guid> physicalAddressRepository)
    {
        _physicalAddressRepository = physicalAddressRepository;
    }

    #endregion
    
    [UnitOfWork]
    public async Task<PhysicalAddress> CreateAsync(PhysicalAddressCreateInput input)
    {
        return await _physicalAddressRepository.InsertAsync(
            ObjectMapper.Map<PhysicalAddress>(input)
        );
    }


    [UnitOfWork]
    public async Task<PhysicalAddress> UpdateAsync(PhysicalAddressUpdateInput input)
    {
        PhysicalAddress physicalAddress = await _physicalAddressRepository
            .Query(e => e.Where(o => o.Id == input.Id))
            .FirstOrDefaultAsync();

        if (physicalAddress == null)
            throw new EntityNotFoundException();

        ObjectMapper.Map(input, physicalAddress);

        return physicalAddress;
    }


    [UnitOfWork]
    public async Task<PhysicalAddress> DeleteAsync(Guid id)
    {
        PhysicalAddress physicalAddress = await _physicalAddressRepository
            .Query(e => e.Where(o => o.Id == id))
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (physicalAddress == null)
            throw new EntityNotFoundException();

        await _physicalAddressRepository.DeleteAsync(physicalAddress);

        return physicalAddress;
    }
}