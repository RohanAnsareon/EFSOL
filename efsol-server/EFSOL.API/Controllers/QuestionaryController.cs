using System;
using System.Threading.Tasks;
using EFSOL.API.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace EFSOL.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionaryController : ControllerBase
    {


        [HttpGet]
        [ProducesResponseType(statusCode: 200, type: typeof(GetQuestionaryResponse))]
        [ProducesErrorResponseType(typeof(HttpErrorResponse))]
        public async Task<GetQuestionaryResponse> Get()
        {
        }

        [HttpPost]
        public async Task Post([FromBody] PostQuestionaryRequest request)
        {
            
        }
    }
}
