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
        #region Declare
        private IUnitOfWork _unitOfWork;
        readonly ILogger _logger;
        readonly IEmailSender _emailer; 
        #endregion
        public ClassController(IUnitOfWork unitOfWork, ILogger<CustomerController> logger, IEmailSender emailer)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _emailer = emailer;
        }
        #region API

        [ProducesResponseType(200, Type = typeof(List<Lop>))]
        [HttpGet("get")]
        [Route("get")]
        public IActionResult Get(int page)
        {
            List<Lop> allClass = _unitOfWork.Lop.GetAllClassData(page);
            return Ok(allClass);
        }
        [HttpPost]
        [ProducesResponseType(200, Type = typeof(bool))]
        [ProducesResponseType(400)]
        [Route("add")]
        public IActionResult AddClass([FromBody] string lop)
        {
            if (ModelState.IsValid)
            {
                if (string.IsNullOrWhiteSpace(lop))
                    return BadRequest("lop cannot be null or empty");
                bool addCustomers = _unitOfWork.Lop.AddClass(lop);
                return Ok(addCustomers);
            }
            else
            {
                return BadRequest(ModelState);
            }
        } 
        #endregion

    }
}