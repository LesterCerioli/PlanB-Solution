﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace PlanB.Infrastructure.Data
{
    public interface ICustomModelBuilder
    {
        void Build(ModuleBuilder modelBuilder);
    }
}
