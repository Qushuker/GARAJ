using System;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.AutoMapper;
using GARAJ.GARAJ.Entities;
using GARAJ.GARAJ.Enums;

namespace GARAJ.GARAJ.App.ParkingLots.Dto;
[AutoMap(typeof(ParkingLot))]
public class ParkingLotDto
{
    #region Relations

    [ForeignKey(nameof(ParkingLot))]
    public Guid ParkingId { get; set; }
    
    
    #endregion

    #region General

    public TransportType TransportType { get; set; }

    #endregion

    #region Position
    public float XPos { get; set; }
    public float YPos { get; set; }
    #endregion
}