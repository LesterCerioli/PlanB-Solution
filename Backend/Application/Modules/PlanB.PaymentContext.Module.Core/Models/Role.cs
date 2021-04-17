using Microsoft.AspNetCore.Identity;
using PlanB.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanB.PaymentContext.Module.Core.Models
{
    public class Role : IdentityRole<long>, IEntityWithTypedId<long>
    {
        public long Id => throw new NotImplementedException();
    }
}
