using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFSOL.API.DTOs
{
    public class PostQuestionaryRequest
    {
        public Dictionary<Guid, string> QuestionIdAnswer { get; set; }
    }
}
