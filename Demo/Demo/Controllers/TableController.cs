using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL;
using Demo.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Demo.Controllers
{
    [Route("api/Table")]
    public class TableController : Controller
    {
        #region Declare
        private IUnitOfWork _unitOfWork;
        readonly ILogger _logger;

        #endregion
        public TableController(IUnitOfWork unitOfWork, ILogger<TableController> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;         
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("Get")]
        public IActionResult Get(string table)
        {
            if (ModelState.IsValid)
            {
                if (string.IsNullOrWhiteSpace(table))
                    return BadRequest("table cannot be null or empty");               
                switch (table)
                {
                    case "LOP":
                        {
                            
                            return Ok(_unitOfWork.Lop.GetClass());
                        }
                    case "MONHOC":
                        {
                            return Ok(_unitOfWork.MonHoc.GetSubject());
                        }
                    case "GIAOVIEN":
                        {
                            return Ok(_unitOfWork.GiaoVien.GetTeacher());
                        }
                    case "PHANCONG":
                        {
                            return Ok(_unitOfWork.PhanCong.GetRoster());
                        }
                    case "DIEUKIEN":
                        {
                            return Ok(_unitOfWork.DieuKien.GetCondition());
                        } 
                    default: return BadRequest("ERROR");
                }              
            }
            else
            {
                return BadRequest(ModelState);
            }           
        }
    }
}