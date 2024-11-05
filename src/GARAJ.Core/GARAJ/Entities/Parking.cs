using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace GARAJ.GARAJ.Entities;

public class Parking : Entity<Guid>
{
    #region Relations

    [ForeignKey(nameof(PhysicalAddress))]
    public Guid PhysicalAddressId { get; set; }

    public PhysicalAddress PhysicalAddress { get; set; }

    public ICollection<ParkingLot> ParkingLots { get; set; }
    
    #endregion
}