using efsol_api.Models;
using System.Collections.Generic;

namespace efsol_api.DTOs.Questionary
{
    public class AnswersRequest
    {
        public List<AnswerModel> Answers { get; set; }
    }
}
