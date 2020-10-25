using System;

namespace efsol_api.Models
{
    public class AnswerModel
    {
        public Guid QuestionId { get; set; }
        public string Content { get; set; }
    }
}
