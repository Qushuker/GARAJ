using System;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using GARAJ.Abp.Authorization.Users;
using GARAJ.GARAJ.Enums;
using JetBrains.Annotations;

namespace GARAJ.GARAJ.Entities;

public class TransportProfile: Entity<Guid>
{
    #region Relation
    
    [ForeignKey(nameof(User))]
    public long? UserId { get; set; }
    [CanBeNull]
    public User User { get; set; }
    
    [ForeignKey(nameof(ParkingLot))]
    public Guid? ParkingLotId { get; set; } 
    [CanBeNull]
    public ParkingLot ParkingLot { get; set; }
    
    #endregion
    #region General

    public TransportType TransportType {get; set; }
    

    #endregion
    
}