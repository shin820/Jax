﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jax.Data
{
    public class Question
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SurveyId { get; set; }
        public QuestionType Type { get; set; }
        public List<QuestionOption> QuestionOptions { get; set; }
    }
}
