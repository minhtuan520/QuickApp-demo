using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Demo.Controllers
{
    [Produces("application/json")]
    [Route("api/Login")]
    public class LoginController : Controller
    {
        #region Declare
        private IUnitOfWork _unitOfWork;
        readonly ILogger _logger;
       
        #endregion
        #region Constructer
        public LoginController(IUnitOfWork unitOfWork, ILogger<LoginController> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;           
        }
        #endregion
        public IActionResult Index()
        {
            if (Request.Cookies["User"] != null)
                Response.Redirect("/Profile");
            return View();
        }

        [HttpPost]
        [Route("Index")]
        public bool[] Index( string User,  string Pass)
        {
            var result = _unitOfWork.TaiKhoan.Login(User, Pass);
            bool[] loginSuccess =new bool[2] { true, true };
            if (result[0] && result[1])
            {
                CookieOptions opt = new CookieOptions();
                opt.Expires = DateTime.Now.AddMinutes(15);
                Response.Cookies.Append("User", User, opt);
            }
            return result;        
        }
    }
}