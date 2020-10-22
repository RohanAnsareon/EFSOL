using EFSOL.Application.Models;
using System.Collections.Generic;

namespace EFSOL.API.DTOs
{
    public class GetQuestionaryResponse
    {
        public List<QuestionModel> Questions { get; set; }
    }
}
