using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanB.PaymentContext.Module.Core.Models
{
    public class StudentGroupUser
    {
        public long UserId { get; set; }

        public User User { get; set; }

        public long StudentGroupId { get; set; }

        public StudentGroup StudentGroup { get; set; }
    }
}
