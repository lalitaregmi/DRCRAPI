using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Models.Model;
using Service;

namespace DrCrAPI.Controllers
{
    [Route("api/[Controller]"), EnableCors("CorsPolicy")]//base route for controller[controller] is 

    [ApiController]
    public class ReferenceController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ReferenceController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // attributed routing and method to access service
        [HttpPost, Route("~/api/admin/ref-values")]
        public async Task<IActionResult> Createreference(Reference category)
        {
            // IActionResult=return type ,return sort of result that can be 
            //interpreted by  asp.net to generate an appropriate HTTP response

            var data = _unitOfWork.ReferenceService.CreateReference(category);
            return Ok(data);


        }


    }

}