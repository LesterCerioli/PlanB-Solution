using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanB.PaymentContext.Module.Core.Areas.Core.ViewModels
{
    public class HomeViewModel
    {
        public IList<WidgetInstanceViewModel> WidgetInstances { get; set; } = new List<WidgetInstanceViewModel>();
    }
}
