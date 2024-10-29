using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using GARAJ.GARAJ.App.Buildings.Dto;
using GARAJ.GARAJ.App.PhysicalAddresses.Dto;
using GARAJ.GARAJ.Domain.Buildings.Input;
using GARAJ.GARAJ.Domain.PhysicalAddresses;
using GARAJ.GARAJ.Domain.PhysicalAddresses.Input;
using GARAJ.GARAJ.Entities;
using Microsoft.EntityFrameworkCore;

namespace GARAJ.GARAJ.App.PhysicalAddresses;

public class PhysicalAddressAppService : ApplicationService, IPhysicalAddressAppService
{
    #region DI

    private readonly IPhysicalAddressDomainService _physicalAddressDomainService;
    private readonly IRepository<PhysicalAddress, Guid> _physicalAddressRepository;


    public PhysicalAddressAppService(
        IPhysicalAddressDomainService physicalAddressDomainService,
        IRepository<PhysicalAddress, Guid> physicalAddressRepository)
    {
        _physicalAddressDomainService = physicalAddressDomainService;
        _physicalAddressRepository = physicalAddressRepository;
    }

    #endregion


    public async Task<PhysicalAddressDto> GetAsync(Guid id)
    {
        return await _physicalAddressRepository
            .Query(e => e.Where(o => o.Id == id))
            .AsNoTracking()
            .Select(o => ObjectMapper.Map<PhysicalAddressDto>(o))
            .FirstOrDefaultAsync();
    }


    public async Task<List<PhysicalAddressDto>> GetAllAsync()
    {
        return await _physicalAddressRepository
            .Query(e => e.Where(o => true))
            .AsNoTracking()
            .Select(o => ObjectMapper.Map<PhysicalAddressDto>(o))
            .ToListAsync();
    }


    [UnitOfWork]
    public async Task<PhysicalAddressDto> CreateAsync(PhysicalAddressCreateInput input)
    {
        PhysicalAddress physicalAddress = await _physicalAddressDomainService.CreateAsync(input);
        
        return ObjectMapper.Map<PhysicalAddressDto>(physicalAddress);
    }


    [UnitOfWork]
    public async Task<PhysicalAddressDto> UpdateAsync(PhysicalAddressUpdateInput input)
    {
        PhysicalAddress physicalAddress = await _physicalAddressDomainService.UpdateAsync(input);

        return ObjectMapper.Map<PhysicalAddressDto>(physicalAddress);
    }


    [UnitOfWork]
    public async Task<PhysicalAddressDto> DeleteAsync(Guid id)
    {
        PhysicalAddress physicalAddress = await _physicalAddressDomainService.DeleteAsync(id);

        return ObjectMapper.Map<PhysicalAddressDto>(physicalAddress);
    }
}