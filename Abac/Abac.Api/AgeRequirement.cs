﻿using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abac.Api
{
    public class AgeRequirement : IAuthorizationRequirement
    {
        protected internal int Age { get; set; }

        public AgeRequirement(int age)
        {
            Age = age;
        }
    }
}
