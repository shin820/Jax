﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jax.Data
{
    public class Survey
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Question> Questions { get; set; }
    }
}
