using AnoraRFID.DataAccess.DAL;
using AnoraRFID.DataAccess.DAL.Entities;
using AnoraRFID.DataAccess.DAL.Entities.Identity;
using AnoraRFID.DataAccess.Models;
using AnoraRFID.DataAccess.Utils;
using AnoraRFID.WebApi.Utils;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AnoraRFID.WebApi.Controllers
{
    public class ApiControllerBase : ControllerBase
    {
        private UserEntity currentUser { get; set; }

        public DateTime now => DateTime.Now;

        public int CurrentUserId => CurrentUser.Id;
        public UserEntity CurrentUser
        {
            get
            {
                var user = HttpContext.Items["User"];
                if (user == null)
                {
                    throw new Exception("Invalid access token!");
                }
                return (UserEntity)user;
            }
        }
        public readonly AppDbContext _context;
        public readonly UserManager<UserEntity> _userManager;
        public readonly RoleManager<RoleEntity> _roleManager;
        public readonly IWebHostEnvironment _webEnvrm;

        public FileHelper _fileHelper;

        public ApiControllerBase(AppDbContext context, UserManager<UserEntity> userManager = null, RoleManager<RoleEntity> roleManager = null, IWebHostEnvironment webEnv = null)
        {
            _userManager = userManager;
            _context = context;
            _roleManager = roleManager;
            _webEnvrm = webEnv;
        }

        public ApiControllerBase()
        {

        }
    }
}
