using System;
using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;
using GARAJ.GARAJ.Entities;

namespace GARAJ.GARAJ.Domain.TransportProfiles.Input;

[AutoMap(typeof(TransportProfile))]
public class TransportProfileUpdateInput
{
    #region Relations

    public Guid? ParkingLotId { get; set; }
    
    [Required]
    public Guid Id { get; set; }

    #endregion
}