using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class AccountController : ApiController
    {
       

        [Route("api/User/Register")]
        [HttpPost]
        public IHttpActionResult Register(AccountModel model)
        {
           
            var user = new User() {
                UserName = model.UserName,
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Password = model.Password
            };

            var result = _service.Create(model); //assumed there is service in domain layer  named _service.Create(...) for Create an User record
           
                       
            return result.Success
                ? Json(new { Message = "Ok" })
                : Json(new { Message = "Error" });
        }
    }
}
