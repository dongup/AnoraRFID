using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnoraRFID.DataAccess.DAL.Entities.Identity
{
    public class RoleClaimEntity : IdentityRoleClaim<int>
    {
        public bool IsDeleted { get; set; }
    }
}
