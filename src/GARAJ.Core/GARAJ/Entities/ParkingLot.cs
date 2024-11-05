using System;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using GARAJ.GARAJ.Enums;
using GARAJ.GARAJ.Interfaces;

namespace GARAJ.GARAJ.Entities;

public class ParkingLot : Entity<Guid>, IPosition
{
    #region Relations

    [ForeignKey(nameof(Parking))]
    public Guid ParkingId { get; set; }

    public Parking Parking { get; set; }

    #endregion

    #region General

    public TransportType TransportType { get; set; }

    #endregion

    #region Position
    public float XPos { get; set; }
    public float YPos { get; set; }
    #endregion
}