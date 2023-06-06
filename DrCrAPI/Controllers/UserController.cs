using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Models.Model;
using Service;

namespace DrCrAPI.Controllers
{
    [Route("api/[Controller]"), EnableCors("CorsPolicy")]//base route for controller[controller] is 

    [ApiController]

    public class UserController : Controller
    {


        private readonly IUnitOfWork _unitOfWork;
        public UserController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // attributed routing and method to access service
        [HttpPost, Route("~/api/admin/user")]
        public async Task<IActionResult> Createuser(User category)
        {
            // IActionResult=return type ,return sort of result that can be 
            //interpreted by  asp.net to generate an appropriate HTTP response

            var data = _unitOfWork.userService.CreateUser(category);
            return Ok(data);


        }
    }
}