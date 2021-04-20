using PlanB.Infrastructure.Models;
using PlanB.PaymentContext.Module.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanB.PaymentContext.Module.Cms.Nodels
{
    public class MenuItem : EntityBase
    {
        public long? ParentId { get; set; }

        public MenuItem Parent { get; set; }

        public IList<MenuItem> Children { get; protected set; } = new List<MenuItem>();

        public long MenuId { get; set; }

        public Menu Menu { get; set; }

        public long? EntityId { get; set; }

        public Entity Entity { get; set; }

        [StringLength(450)]
        public string CustomLink { get; set; }

        [StringLength(450)]
        public string Name { get; set; }

        public int DisplayOrder { get; set; }
    }
}
