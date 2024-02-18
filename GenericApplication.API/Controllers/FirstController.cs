using GenericApplication.API.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GenericApplication.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FirstController(IMediator mediatr) : ControllerBase
    {
        [HttpGet(Name = "GetAll")]
        public async Task<IActionResult> Get()
        {
            var response = await mediatr.Send(new GetAllQuery());

            return response.Results == null ? BadRequest() : Ok(response.Results);
        }
    }
}
