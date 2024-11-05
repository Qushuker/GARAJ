using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using AutoMapper.Internal.Mappers;
using GARAJ.GARAJ.App.Parkings.Dto;
using GARAJ.GARAJ.Domain.ParkingLots;
using GARAJ.GARAJ.Domain.Parkings.Input;
using GARAJ.GARAJ.Entities;
using Microsoft.EntityFrameworkCore;

namespace GARAJ.GARAJ.App.Parkings;

public class ParkingAppService : ApplicationService, IParkingAppService
{
    #region DI

    private readonly ParkingDomainService _parkingDomainService;
    private readonly IRepository<Parking, Guid> _parkingRepository;


    public ParkingAppService(
        ParkingDomainService parkingDomainService,
        IRepository<Parking, Guid> parkingRepository)
    {
        _parkingDomainService = parkingDomainService;
        _parkingRepository = parkingRepository;
    }

    #endregion


    public async Task<ParkingDto> GetAsync(Guid id)
    {
        return await _parkingRepository
            .Query(e => e.Where(o => o.Id == id))
            .AsNoTracking()
            .Select(o => ObjectMapper.Map<ParkingDto>(o))
            .FirstOrDefaultAsync();
    }


    public async Task<List<ParkingDto>> GetAllAsync()
    {
        return await _parkingRepository
            .Query(e => e.Where(o => true))
            .AsNoTracking()
            .Select(o => ObjectMapper.Map<ParkingDto>(o))
            .ToListAsync();
    }


    [UnitOfWork]
    public async Task<ParkingDto> CreateAsync(ParkingCreateInput input)
    {
        Parking parking = await _parkingDomainService.CreateAsync(input);
        
        return ObjectMapper.Map<ParkingDto>(parking);
    }


    [UnitOfWork]
    public async Task<ParkingDto> UpdateAsync(ParkingUpdateInput input)
    {
        Parking parking = await _parkingDomainService.UpdateAsync(input);

        return ObjectMapper.Map<ParkingDto>(parking);
    }


    [UnitOfWork]
    public async Task<ParkingDto> DeleteAsync(Guid id)
    {
        Parking parking = await _parkingDomainService.DeleteAsync(id);

        return ObjectMapper.Map<ParkingDto>(parking);
    }

}