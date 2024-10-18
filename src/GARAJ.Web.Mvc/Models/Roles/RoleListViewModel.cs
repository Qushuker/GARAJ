using System.Collections.Generic;
using GARAJ.Roles.Dto;

namespace GARAJ.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
