using System;
using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;
using GARAJ.GARAJ.Entities;
using GARAJ.GARAJ.Enums;

namespace GARAJ.GARAJ.Domain.Parkings.Input;

[AutoMap(typeof(Parking))]
public class ParkingUpdateInput
{   
    [Required]
    public Guid Id { get; set; }
    
    #region General

    [Required]
    public TransportType TransportType { get; set; }

    #endregion

    #region Position

    public float XPos { get; set; }
    public float YPos { get; set; }

    #endregion
}