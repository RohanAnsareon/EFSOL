using AutoMapper;
using efsol_api.Data;
using efsol_api.Data.Entities;
using efsol_api.Models;
using efsol_api.Services.Abstractions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace efsol_api.Services
{
    public class QuestionaryService : IQuestionaryService
    {
        private readonly EFSOLDbContext _context;
        private readonly IMapper _mapper;

        public QuestionaryService(EFSOLDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task AddAsync(List<AnswerModel> answers)
        {
            var userCode = Guid.NewGuid();
            await _context.Answers.AddRangeAsync(answers.Select(a => new Answer
            {
                Content = a.Content,
                QuestionId = a.QuestionId,
                UserCode = userCode
            }));

            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<QuestionModel>> GetAsync() => _mapper.Map<IEnumerable<QuestionModel>>(await _context.Questions.ToListAsync());
    }
}
