using System;
using System.Collections.Generic;
using System.Text;

namespace EFSOL.Infrastructure.Entities
{
    public class Answer
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public Guid QuestionId { get; set; }
        public virtual Question Question { get; set; }

        public string Content { get; set; }
    }
}
