using AutoMapper;
using efsol_api.Data.Entities;
using efsol_api.Models;

namespace efsol_api.Profiles
{
    public class QuestionProfile : Profile
    {
        public QuestionProfile()
        {
            CreateMap<Question, QuestionModel>();
        }
    }
}
