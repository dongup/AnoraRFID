using Microsoft.AspNetCore.Identity;

namespace AnoraRFID.DataAccess.DAL.Entities.Identity
{
    public class UserClaimEntity : IdentityUserClaim<int>
    {
        public bool IsDeleted { get; set; }
    }
}
