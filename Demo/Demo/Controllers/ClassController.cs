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
        [ProducesResponseType(200, Type = typeof(List<Lop>))]        
        [HttpGet]
        [Route("classes")]
        public IActionResult Get()
        {
            List<Lop> allClass = _unitOfWork.Lop.GetAllClassData();            
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
        
    }
}