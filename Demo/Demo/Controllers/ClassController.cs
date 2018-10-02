using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL;
using DAL.Models;
using Demo.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Demo.Controllers
{
    [Produces("application/json")]
    [Route("api/class")]
    public class ClassController : Controller
    {
        private IUnitOfWork _unitOfWork;
        readonly ILogger _logger;
        readonly IEmailSender _emailer;


        public ClassController(IUnitOfWork unitOfWork, ILogger<CustomerController> logger, IEmailSender emailer)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _emailer = emailer;
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
        // GET: api/values
        [HttpGet]
        [Route("classes")]
        public IActionResult Get()
        {
            var allClass = _unitOfWork.Lop.GetAllClassData();
            return Ok(allClass);
        }
        [HttpPost]
        [Route("add")]
        public IActionResult AddClass([FromBody] Lop lop)
        {
            if (ModelState.IsValid)
            {
                if (lop == null )
                    return BadRequest(ModelState);
                var addCustomers = _unitOfWork.Lop.AddClass(lop);
                return Ok(addCustomers);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}