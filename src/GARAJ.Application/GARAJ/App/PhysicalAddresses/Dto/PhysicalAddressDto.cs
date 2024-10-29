using System;
using Abp.AutoMapper;
using GARAJ.GARAJ.Entities;

namespace GARAJ.GARAJ.App.PhysicalAddresses.Dto;

[AutoMap(typeof(PhysicalAddress))]
public class PhysicalAddressDto
{
    #region Relations

    public Guid Id { get; set; }
    public Guid BuildingId { get; set; }

    #endregion
    
    #region General

    public string City { get; set; }
    public string Street { get; set; }
    public string Number { get; set; }

    #endregion
}