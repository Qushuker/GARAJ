using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;
using GARAJ.GARAJ.Entities;
using GARAJ.GARAJ.Enums;

namespace GARAJ.GARAJ.Domain.Parkings.Input;
[AutoMap(typeof(Parking))]
public class ParkingCreateInput
{
    #region Relations
    
    [Required]
    public Guid PhysicalAddressId { get; set; }
    
    #endregion


    #region General
    
    public Dictionary<TransportType, int> ParkingLots { get; set; }
    
    #endregion
    
    
}