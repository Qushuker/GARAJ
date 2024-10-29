using System;
using System.ComponentModel.DataAnnotations;

namespace GARAJ.GARAJ.Domain.PhysicalAddresses.Input;

public class PhysicalAddressUpdateInput
{
    #region Relations

    [Required]
    public Guid Id { get; set; }
    
    public Guid? BuildingId { get; set; }

    #endregion
}