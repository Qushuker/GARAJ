using System;
using System.Linq;
using System.Threading.Tasks;
using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.Domain.Uow;
using GARAJ.GARAJ.Domain.ParkingLots.Input;
using GARAJ.GARAJ.Entities;
using Microsoft.EntityFrameworkCore;

namespace GARAJ.GARAJ.Domain.ParkingLots;

public class ParkingLotDomainService : DomainService, IParkingLotDomainService
{
    #region DI

    private readonly IRepository<ParkingLot, Guid> _parkinglotRepository;


    public ParkingLotDomainService(IRepository<ParkingLot, Guid> buildingRepository)
    {
        _buildingRepository = buildingRepository;
    }

    #endregion
    
    private object _buildingRepository;

    [UnitOfWork]
    public async Task<ParkingLot> CreateAsync(ParkingLotCreateInput input)
    {
        return await _parkinglotRepository.InsertAsync(
            ObjectMapper.Map<ParkingLot>(input)
        );
    }


    [UnitOfWork]
    public async Task<ParkingLot> UpdateAsync(ParkingLotUpdateInput input)
    {
        ParkingLot parkinglot = await _parkinglotRepository
            .Query(e => e.Where(o => o.Id == input.Id))
            .FirstOrDefaultAsync();

        if (parkinglot == null)
            throw new EntityNotFoundException();

        ObjectMapper.Map(input, parkinglot);

        return parkinglot;
    }


    [UnitOfWork]
    public async Task<ParkingLot> DeleteAsync(Guid id)
    {
        ParkingLot parkinglot = await _parkinglotRepository
            .Query(e => e.Where(o => o.Id == id))
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (parkinglot == null)
            throw new EntityNotFoundException();

        await _parkinglotRepository.DeleteAsync(parkinglot);

        return parkinglot;
    }
}