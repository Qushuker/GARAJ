using System;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace GARAJ.GARAJ.Entities;

public class PhysicalAddress : Entity<Guid>
{
    #region Relations

    [ForeignKey(nameof(Building))]
    public Guid? BuildingId { get; set; }
    public Building Building { get; set; }

    #endregion
    
    #region General

    public string City { get; set; }
    public string Street { get; set; }
    public string Number { get; set; }

    #endregion
}