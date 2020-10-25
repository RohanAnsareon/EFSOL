using efsol_api.Enums;
using System;
using System.Collections.Generic;

namespace efsol_api.Data.Entities
{
    public class Question
    {
        public Guid Id { get; set; }
        public string Content { get; set; }

        public int SortOrder { get; set; }

        public QuestionType Type { get; set; }

        public virtual List<Answer> Answers { get; set; }
    }
}
