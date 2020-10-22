using System;

namespace EFSOL.Infrastructure.Entities
{
    public class Question
    {
        public Guid Id { get; set; }
        public string Content { get; set; }
        public string Type { get; set; }
    }
}
