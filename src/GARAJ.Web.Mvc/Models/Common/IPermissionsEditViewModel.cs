using System.Collections.Generic;
using GARAJ.Roles.Dto;

namespace GARAJ.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}