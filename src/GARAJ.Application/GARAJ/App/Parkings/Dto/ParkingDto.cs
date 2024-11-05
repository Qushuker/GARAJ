using System;
using System.Collections.Generic;
using Abp.AutoMapper;
using GARAJ.GARAJ.Entities;

namespace GARAJ.GARAJ.App.Parkings.Dto;

[AutoMap(typeof(Parking))]
public class ParkingDto
{
    #region General

    public Guid PhysicalAddressId { get; set; }
    
    #endregion
}