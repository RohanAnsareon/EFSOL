using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using efsol_api.DTOs.Exception;
using efsol_api.DTOs.Questionary;
using efsol_api.Models;
using efsol_api.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace efsol_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionaryController : ControllerBase
    {
        private readonly IQuestionaryService _service;

        public QuestionaryController(IQuestionaryService service)
        {
            _service = service;
        }

        [HttpGet]
        [ProducesResponseType(statusCode: 200, type: typeof(IEnumerable<QuestionModel>))]
        [ProducesErrorResponseType(typeof(HttpExceptionResponse))]
        public async Task<IEnumerable<QuestionModel>> Get()
        {
            return await _service.GetAsync();
        }

        [HttpPost]
        [ProducesErrorResponseType(typeof(HttpExceptionResponse))]
        public async Task Post([FromBody] AnswersRequest request)
        {
            _service.AddAsync(request.Answers);
        }
    }
}
