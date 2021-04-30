using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanB.Domain.Entities
{
    public class Content
    {
        public string Name { get; private set; }
        public string MediaTitle { get; private set; }
        public string MetaKeyword { get; private set; }
        public string MetaDescription { get; private set; }
        public bool IsPublished { get; private set; }
        public DateTimeOffset? PublishedOn { get; private set; }

        public bool IsDeleted
        {
            get
            {
                return IsDeleted;
            }

            private set
            {
                IsDeleted = value;
                if (value)
                {
                    IsPublished = false;
                }
            }
        }

        public long CreatedById { get; private set; }
        public User CreatedBy { get; private set; }

        public DateTimeOffset CreatedOn { get; private set; }

        public DateTimeOffset LatestUpdatedOn { get; private set; }

        public long LatestUpdatedById { get; private set; }

        public User LatestUpdatedBy { get; private set; }
    }
}
