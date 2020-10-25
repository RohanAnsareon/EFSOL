using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace efsol_api.Data.Entities
{
    public class Answer
    {
        public Guid Id { get; set; }

        public string Content { get; set; }

        public Guid QuestionId { get; set; }
        public virtual Question Question { get; set; }

        public Guid UserCode { get; set; }
    }
}
