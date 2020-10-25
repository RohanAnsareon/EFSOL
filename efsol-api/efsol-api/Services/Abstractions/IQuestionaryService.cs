using efsol_api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace efsol_api.Services.Abstractions
{
    public interface IQuestionaryService
    {
        Task<IEnumerable<QuestionModel>> GetAsync();

        Task AddAsync(List<AnswerModel> answers);
    }
}
