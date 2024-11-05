using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using GARAJ.GARAJ.App.ParkingLots.Dto;
using GARAJ.GARAJ.Domain.ParkingLots;
using GARAJ.GARAJ.Domain.ParkingLots.Input;
using GARAJ.GARAJ.Entities;
using Microsoft.EntityFrameworkCore;

namespace GARAJ.GARAJ.App.ParkingLots;

public class ParkingLotAppService : ApplicationService, IParkingLotAppService
{
    #region DI

    private readonly ParkingLotDomainService _parkingLotDomainService;
    private readonly IRepository<ParkingLot, Guid> _parkingLotRepository;


    public ParkingLotAppService(
        ParkingLotDomainService parkingLotDomainService,
        IRepository<ParkingLot, Guid> parkingLotRepository)
    {
        _parkingLotDomainService = parkingLotDomainService;
        _parkingLotRepository = parkingLotRepository;
    }

    #endregion


    public async Task<ParkingLotDto> GetAsync(Guid id)
    {
        return await _parkingLotRepository
            .Query(e => e.Where(o => o.Id == id))
            .AsNoTracking()
            .Select(o => ObjectMapper.Map<ParkingLotDto>(o))
            .FirstOrDefaultAsync();
    }


    public async Task<List<ParkingLotDto>> GetAllAsync()
    {
        return await _parkingLotRepository
            .Query(e => e.Where(o => true))
            .AsNoTracking()
            .Select(o => ObjectMapper.Map<ParkingLotDto>(o))
            .ToListAsync();
    }


    [UnitOfWork]
    public async Task<ParkingLotDto> CreateAsync(ParkingLotCreateInput input)
    {
        ParkingLot parkingLot = await _parkingLotDomainService.CreateAsync(input);
        
        return ObjectMapper.Map<ParkingLotDto>(parkingLot);
    }


    [UnitOfWork]
    public async Task<ParkingLotDto> UpdateAsync(ParkingLotUpdateInput input)
    {
        ParkingLot parkingLot = await _parkingLotDomainService.UpdateAsync(input);

        return ObjectMapper.Map<ParkingLotDto>(parkingLot);
    }


    [UnitOfWork]
    public async Task<ParkingLotDto> DeleteAsync(Guid id)
    {
        ParkingLot parkingLot = await _parkingLotDomainService.DeleteAsync(id);

        return ObjectMapper.Map<ParkingLotDto>(parkingLot);
    }

}