using System;
using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;
using AutoMapper.Configuration.Annotations;
using GARAJ.GARAJ.Entities;
using GARAJ.GARAJ.Regex;

namespace GARAJ.GARAJ.Domain.Buildings.Input;

[AutoMap(typeof(Building))]
public class BuildingCreateInput
{
    #region Relations
    
    [Required]
    public Guid PhysicalAddressId { get; set; }

    #endregion


    #region General

    [Required]
    [RegularExpression(GRegex.Text)]

    public string Name { get; set; }

    #endregion
}