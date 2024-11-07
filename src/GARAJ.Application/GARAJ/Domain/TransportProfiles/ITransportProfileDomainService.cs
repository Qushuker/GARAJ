using System;
using System.Threading.Tasks;
using Abp.Domain.Services;
using GARAJ.GARAJ.Domain.TransportProfiles.Input;
using GARAJ.GARAJ.Entities;

namespace GARAJ.GARAJ.Domain.TransportProfiles;

public interface ITransportProfileDomainService:IDomainService
{
    Task<TransportProfile> CreateAsync(TransportProfileCreateInput input);
    Task<TransportProfile> UpdateAsync(TransportProfileUpdateInput input);
    Task<TransportProfile> DeleteAsync(Guid id);
}