using System.Collections.Generic;
using GARAJ.Abp.Roles.Dto;

namespace GARAJ.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
