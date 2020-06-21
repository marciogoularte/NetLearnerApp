﻿using NetLearner.SharedLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetLearner.Api.Infrastructure
{
    public interface ISampleRepository
    {
        List<LearningResource> LearningResources();
        List<LearningResource> GetByPartialName(string nameSubstring);
    }
}
