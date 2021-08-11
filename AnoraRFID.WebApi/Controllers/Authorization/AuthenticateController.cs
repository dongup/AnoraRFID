using AnoraRFID.DataAccess.DAL;
using AnoraRFID.DataAccess.DAL.Entities.Identity;
using AnoraRFID.DataAccess.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace AnoraRFID.WebApi.Controllers.Authorization
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticateController : ApiControllerBase
    {
        private readonly RoleManager<RoleEntity> roleManager;
        private readonly IConfiguration _configuration;

        public AuthenticateController(AppDbContext context, UserManager<UserEntity> _userManager, RoleManager<RoleEntity> roleManager, IConfiguration configuration) : base(context, _userManager)
        {
            this.roleManager = roleManager;
            _configuration = configuration;
        }

        [HttpPost]
        public ActionResult<ResponseModel> Login()
        {
            rspns.Succeed(CurrentUser);
            return rspns;
        }
    }
}
