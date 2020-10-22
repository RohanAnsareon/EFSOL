using EFSOL.Application.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFSOL.Application.Services.Abstractions
{
    public interface IQuestionaryService
    {
        IEnumerable<QuestionModel> Get();

        //void Add()
    }
}
