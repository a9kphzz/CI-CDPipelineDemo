using LoginDemoforAWS.Context;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginDemoforAWS.Controllers
{
    public class LoginController : Controller
    {
        private readonly AWSContext aWSContext;

        public LoginController(AWSContext _aWSContext)
        {
            aWSContext = _aWSContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult Validate(string email, string password)
        {
            var _admin = aWSContext.UserInfos.Where(s => s.UserName == email && s.PassWord == password);
            if (_admin.Any())
            {
                if (_admin.Where(s => s.PassWord == password).Any())
                {

                    return Json(new { status = true, message = "Login Successfull!" });
                }
                else
                {
                    return Json(new { status = false, message = "Invalid Password!" });
                }
            }
            else
            {
                return Json(new { status = false, message = "Invalid Email!" });
            }
        }
    }
}
