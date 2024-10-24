using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;
using GARAJ.GARAJ.Entities;
using GARAJ.GARAJ.Regex;

namespace GARAJ.GARAJ.Domain.Buildings.Input;

[AutoMap(typeof(Building))]
public class BuildingCreateInput
{
    #region Address

    [Required]
    [RegularExpression(GRegex.Text)]
    public string City { get; set; }

    [Required]
    [RegularExpression(GRegex.Text)]
    public string Street { get; set; }

    [Required]
    [RegularExpression(GRegex.Text)]
    public string BuildingNumber { get; set; }

    #endregion
}