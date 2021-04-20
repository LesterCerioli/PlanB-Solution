using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanB.PaymentContext.Module.Core.Areas.Core.ViewModels
{
    public class ThemeListItem
    {
        public string Name { get; set; }

        public string DisplayName { get; set; }

        public string ThumbnailUrl { get; set; }

        public bool IsCurrent { get; set; }
    }
}
