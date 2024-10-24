using System;
using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;
using AutoMapper.Configuration.Annotations;
using GARAJ.GARAJ.Entities;
using GARAJ.GARAJ.Regex;

namespace GARAJ.GARAJ.Domain.Buildings.Input;

[AutoMap(typeof(Building))]
public class BuildingUpdateInput
{
    [Ignore]
    public Guid Id { get; set; }
    
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