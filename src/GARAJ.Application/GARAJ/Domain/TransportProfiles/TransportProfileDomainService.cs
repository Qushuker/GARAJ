using System;
using System.Linq;
using System.Threading.Tasks;
using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.Domain.Uow;
using GARAJ.GARAJ.Domain.TransportProfiles.Input;
using GARAJ.GARAJ.Entities;
using GARAJ.GARAJ.Enums;
using Microsoft.EntityFrameworkCore;

namespace GARAJ.GARAJ.Domain.TransportProfiles;

public class TransportProfileDomainService: DomainService, ITransportProfileDomainService
{
    private readonly IRepository<TransportProfile, Guid> _transportProfileRepository;

    public TransportProfileDomainService(IRepository<TransportProfile, Guid> transportProfileRepository)
    {
        _transportProfileRepository = transportProfileRepository;
    }
    [UnitOfWork]
    public async Task<TransportProfile> CreateAsync(TransportProfileCreateInput input)
    {
        return await _transportProfileRepository.InsertAsync(
                ObjectMapper.Map<TransportProfile>(input)
                );
    }
    [UnitOfWork]
    public async Task<TransportProfile> UpdateAsync(TransportProfileUpdateInput input)
    {
        TransportProfile transportProfile = await _transportProfileRepository
            .Query(e => e.Where(o => o.Id == input.Id))
            .FirstOrDefaultAsync();
        
        if (transportProfile == null)
            throw new EntityNotFoundException();
        
        ObjectMapper.Map(input, transportProfile);
        
        return transportProfile;
    }
    [UnitOfWork]
    public async Task<TransportProfile> DeleteAsync(Guid id)
    {
        TransportProfile transportProfile = await _transportProfileRepository
            .Query(e => e.Where(o => o.Id == id))
            .AsNoTracking()
            .FirstOrDefaultAsync();
        
        if (transportProfile == null)
            throw new EntityNotFoundException();
        
        await _transportProfileRepository.DeleteAsync(transportProfile);
        
        return transportProfile;
    }
}