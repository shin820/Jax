using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jax.Models
{
    public class QuestionOption
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public string Key { get; set; }
        public string Name { get; set; }
    }
}
