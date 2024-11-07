using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Authorization.Users;
using Abp.Extensions;
using GARAJ.GARAJ.Entities;

namespace GARAJ.Abp.Authorization.Users
{
    public class User : AbpUser<User>
    {   
        
        [ForeignKey(nameof(TransportProfile))]
        public Guid TransportProfileId { get; set; }
        public TransportProfile TransportProfile { get; set; }
        
        public const string DefaultPassword = "123qwe";

        public static string CreateRandomPassword()
        {
            return Guid.NewGuid().ToString("N").Truncate(16);
        }

        public static User CreateTenantAdminUser(int tenantId, string emailAddress)
        {
            var user = new User
            {
                TenantId = tenantId,
                UserName = AdminUserName,
                Name = AdminUserName,
                Surname = AdminUserName,
                EmailAddress = emailAddress,
                Roles = new List<UserRole>()
            };

            user.SetNormalizedNames();

            return user;
        }
    }
}
