using System;
using Abp.AutoMapper;
using GARAJ.GARAJ.Entities;

namespace GARAJ.GARAJ.App.Buildings.Dto;

[AutoMap(typeof(Building))]
public class BuildingDto
{
    public Guid Id { get; set; }


    #region Address

    public string City { get; set; }

    public string Street { get; set; }

    public string BuildingNumber { get; set; }

    #endregion
}