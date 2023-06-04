using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Models.Model;
using Service;

namespace DrCrAPI.Controllers
{
    [Route("api/[Controller] "), EnableCors("CorsPolicy")]
    [ApiController]

    public class ChangePasswordController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWork;
        public ChangePasswordController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpPost] //Post annotation  is for create 
        [Route("~/api/change-password")] // harek controller ko end point farak huna parxa.
        public async Task<dynamic> CreatePassword(ChangePassword category) //
        {
            var data = await _unitOfWork.changepassservice.ChangePass(category);
            // iunit of work ma declare gareko property le service ko method(BlogCat) call.
            return Ok(data);
        }

    }
}
