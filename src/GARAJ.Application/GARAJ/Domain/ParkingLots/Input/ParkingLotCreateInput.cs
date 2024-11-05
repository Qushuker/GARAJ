using System;
using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;
using GARAJ.GARAJ.Entities;
using GARAJ.GARAJ.Enums;
using GARAJ.GARAJ.Regex;

namespace GARAJ.GARAJ.Domain.ParkingLots.Input;
[AutoMap(typeof(ParkingLot))]
public class ParkingLotCreateInput
{
    #region Relations
    
    [Required]
    public Guid ParkingId { get; set; }

    #endregion


    #region General

    [Required]
    public TransportType TransportType { get; set; }

    #endregion
    
    #region Position

    public float XPos { get; set; }
    public float YPos { get; set; }

    #endregion
    
    
}