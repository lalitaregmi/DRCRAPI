using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Models.Model;
using Service;

namespace DrCrAPI.Controllers
{
    [Route("api/[Controller] "), EnableCors("CorsPolicy")]
    [ApiController]

    public class CreateCompanyController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CreateCompanyController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpPost] //Post annotation  is for create 
        [Route("~/api/admin/company")] // harek controller ko end point farak huna parxa.
        public async Task<dynamic> CreateCompany(CreateCompany category) //
        {
            var data = await _unitOfWork.createcomservice.CreateCom(category);
            // iunit of work ma declare gareko property le service ko method(BlogCat) call.
            return Ok(data);

        }
    }
}
