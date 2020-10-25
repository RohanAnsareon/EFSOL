using efsol_api.Enums;
using System;

namespace efsol_api.Models
{
    public class QuestionModel
    {
        public Guid Id { get; set; }
        public string Content { get; set; }
        public QuestionType Type { get; set; }
    }
}
