using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jax.Models
{
    public class QuestionAnswer
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public int QuestionOptionId { get; set; }
        public string Text { get; set; }
        public bool? IsSelected { get; set; }
        public Question Question { get; set; }
        public QuestionOption QuestionOption { get; set; }
    }
}
