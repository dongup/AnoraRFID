using Microsoft.AspNetCore.Identity;

namespace AnoraRFID.DataAccess.DAL.Entities.Identity
{
    public class UserTokenEntity : IdentityUserToken<int>
    {
        public bool IsDeleted { get; set; }
    }
}
