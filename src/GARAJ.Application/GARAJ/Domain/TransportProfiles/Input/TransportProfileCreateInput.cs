using System;
using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;
using GARAJ.GARAJ.Entities;
using GARAJ.GARAJ.Enums;

namespace GARAJ.GARAJ.Domain.TransportProfiles.Input;

[AutoMap(typeof(TransportProfile))]
public class TransportProfileCreateInput
{
    #region General
    
    [Required]
    public TransportType TransportType {get; set; }
    

    #endregion
}