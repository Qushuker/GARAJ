using System;
using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;
using GARAJ.GARAJ.Entities;
using GARAJ.GARAJ.Regex;

namespace GARAJ.GARAJ.Domain.Buildings.Input;

[AutoMap(typeof(Building))]
public class BuildingUpdateInput
{
    #region Relations

    [Required]
    public Guid Id { get; set; }

    #endregion


    #region General

    [Required]
    [RegularExpression(GRegex.Text)]

    public string Name { get; set; }

    #endregion
}