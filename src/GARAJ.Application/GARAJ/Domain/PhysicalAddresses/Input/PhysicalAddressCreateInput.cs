using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;
using GARAJ.GARAJ.Entities;
using GARAJ.GARAJ.Regex;

namespace GARAJ.GARAJ.Domain.PhysicalAddresses.Input;

[AutoMap(typeof(PhysicalAddress))]
public class PhysicalAddressCreateInput
{
    #region General

    [Required]
    [RegularExpression(GRegex.Text)]
    public string City { get; set; }

    [Required]
    [RegularExpression(GRegex.Text)]
    public string Street { get; set; }

    [Required]
    [RegularExpression(GRegex.Text)]
    public string Number { get; set; }

    #endregion
}