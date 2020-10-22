using EFSOL.Application.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFSOL.Application.Models
{
    public class QuestionModel
    {
        public Guid Id { get; set; }
        public string Content { get; set; }
        public QuestionType Type { get; set; }
    }
}
