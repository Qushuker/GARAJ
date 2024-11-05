using System;
using System.Linq;
using System.Threading.Tasks;
using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.Domain.Uow;
using GARAJ.GARAJ.Domain.ParkingLots.Input;
using GARAJ.GARAJ.Domain.Parkings;
using GARAJ.GARAJ.Domain.Parkings.Input;
using GARAJ.GARAJ.Entities;
using Microsoft.EntityFrameworkCore;

namespace GARAJ.GARAJ.Domain.ParkingLots;

public class ParkingDomainService : DomainService, IParkingDomainService
{
    #region DI

    private readonly IRepository<Parking, Guid> _parkingRepository;


    public ParkingDomainService(IRepository<Parking, Guid> parkingRepository)
    {
        _parkingRepository = parkingRepository;
    }

    #endregion
    
    [UnitOfWork]
    public async Task<Parking> CreateAsync(ParkingCreateInput input)
    {
        return await _parkingRepository.InsertAsync(
            ObjectMapper.Map<Parking>(input)
        );
    }


    [UnitOfWork]
    public async Task<Parking> UpdateAsync(ParkingUpdateInput input)
    {
        Parking parking = await _parkingRepository
            .Query(e => e.Where(o => o.Id == input.Id))
            .FirstOrDefaultAsync();

        if (parking == null)
            throw new EntityNotFoundException();

        ObjectMapper.Map(input, parking);

        return parking;
    }


    [UnitOfWork]
    public async Task<Parking> DeleteAsync(Guid id)
    {
        Parking parking = await _parkingRepository
            .Query(e => e.Where(o => o.Id == id))
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (parking == null)
            throw new EntityNotFoundException();

        await _parkingRepository.DeleteAsync(parking);

        return parking;
    }
}