using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class HomeController : Controller
    {
        //private readonly IHttpContextAccessor _httpContextAccessor;

        //public HomeController(IHttpContextAccessor httpContextAccessor)
        //{
        //    this._httpContextAccessor = httpContextAccessor;
        //}
        //public IActionResult Index()
        //{
        //    ViewBag.User = Request.Cookies["User"];
        //    var db = new tkbremake4DbContext();
        //    var Changes = (from r in db.Change select r).ToArray().Reverse();
        //    ViewBag.data = Changes;
        //    return View();
        //}       
        //public string Get(string key)
        //{
        //    return Request.Cookies[key];
        //}       
        //public void Set(string key, string value, int? expireTime)
        //{
        //    CookieOptions option = new CookieOptions();
        //    if (expireTime.HasValue)
        //        option.Expires = DateTime.Now.AddMinutes(expireTime.Value);
        //    else
        //        option.Expires = DateTime.Now.AddMilliseconds(10);
        //    Response.Cookies.Append(key, value, option);
        //}       
        //public void Remove(string key)
        //{
        //    Response.Cookies.Delete(key);
        //}
    }
}