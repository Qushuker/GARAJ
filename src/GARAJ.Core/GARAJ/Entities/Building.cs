using System;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace GARAJ.GARAJ.Entities;

public class Building : Entity<Guid>
{
    #region Address

    [ForeignKey(nameof(PhysicalAddress))]
    public Guid PhysicalAddressId { get; set; }

    public PhysicalAddress PhysicalAddress { get; set; }

    #endregion


    #region General

    public string Name { get; set; }

    #endregion


    #region Description

    public int Levels { get; set; }
    public int PeopleCount { get; set; }
    public int FlatsCount { get; set; }

    #endregion
}