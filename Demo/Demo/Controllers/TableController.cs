﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL;
using Demo.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;

namespace Demo.Controllers
{
    [Route("api/Table")]
    public class TableController : Controller
    {
       // private readonly IHttpContextAccessor _httpContextAccessor;       
        #region Declare
        private IUnitOfWork _unitOfWork;
        readonly ILogger _logger;
        #endregion
        #region Constructer
        public TableController(IUnitOfWork unitOfWork, ILogger<TableController> logger)//, HttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            //this._httpContextAccessor = httpContextAccessor;
        }
        #endregion
        public IActionResult Index()
        {
            ////read cookie from IHttpContextAccessor  
            //string cookieValueFromContext = _httpContextAccessor.HttpContext.Request.Cookies["key"];
            ////read cookie from Request object  
            //string cookieValueFromReq = Request.Cookies["Key"];
            ////set the key value in Cookie  
            //Set("kay", "Hello from cookie", 10);
            ////Delete the cookie object  
            //Remove("Key");
            return View();
            
        }
        public string GetCookie(string key)
        {
            return Request.Cookies[key];
        }      
        public void Set(string key, string value, int? expireTime)
        {
            CookieOptions option = new CookieOptions();
            if (expireTime.HasValue)
                option.Expires = DateTime.Now.AddMinutes(expireTime.Value);
            else
                option.Expires = DateTime.Now.AddMilliseconds(10);
            Response.Cookies.Append(key, value, option);
        }     
        public void Remove(string key)
        {
            Response.Cookies.Delete(key);
        }

        #region API
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
        [HttpPost]
        [Route("Delete")]
        public bool DeleteTable(string table)
        {
            if (ModelState.IsValid)
            {
                bool result = false;
                if (string.IsNullOrWhiteSpace(table))
                    return false;
                switch (table)
                {
                    case "LOP":
                        {
                            result = _unitOfWork.Lop.DeleteClass();
                            break;   
                        }
                    case "MONHOC":
                        {
                            result = _unitOfWork.MonHoc.DeleteSubject();
                            break;
                        }
                    case "GIAOVIEN":
                        {
                            result = _unitOfWork.GiaoVien.DeleteTeacher();
                            break;
                        }
                    case "PHANCONG":
                        {
                            result = _unitOfWork.PhanCong.DeleteRoster();
                            break;
                        }
                    case "DIEUKIEN":
                        {
                            result = _unitOfWork.DieuKien.DeleteRoster();
                            break;
                        }
                    default:
                        return false;
                }                
                string user = Request.Cookies["User"];
                if (user == null) user = "";
                _unitOfWork.ThayDoi.AddChange(user, table);
                return result;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}