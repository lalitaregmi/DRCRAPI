using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Models.Model;
using Service;

namespace DrCrAPI.Controllers
{
    [Route("api/[Controller] "), EnableCors("CorsPolicy")]
    [ApiController]

    public class CreateAccountController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CreateAccountController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpPost] //Post annotation  is for create 
        [Route("~/api/admin/account")] // harek controller ko end point farak huna parxa.
        public async Task<dynamic> CreateAcc(CreateAccount category) //
        {
            var data = await _unitOfWork.createaccservice.CreateAcc(category);
            // iunit of work ma declare gareko property le service ko method(BlogCat) call.
            return Ok(data);
        }
    }
}
