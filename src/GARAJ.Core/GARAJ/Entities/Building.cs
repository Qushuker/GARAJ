using System;
using Abp.Domain.Entities;

namespace GARAJ.GARAJ.Entities;

public class Building : Entity<Guid>
{
    #region Address

    public string City { get; set; }
    public string Street { get; set; }
    public string BuildingNumber { get; set; }

    #endregion


    #region Description

    public int Levels { get; set; }
    public int PeopleCount { get; set; }
    public int FlatsCount { get; set; }

    #endregion
}