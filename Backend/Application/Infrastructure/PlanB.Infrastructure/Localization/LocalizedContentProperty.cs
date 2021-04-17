using System.ComponentModel.DataAnnotations;
using PlanB.Infrastructure.Models;

namespace PlanB.Infrastructure.Localization
{
    public class LocalizedContentProperty : EntityBase
    {
        public long EntityId { get; set; }

        [StringLength(450)]
        public string EntityType { get; set; }
        [Required]
        public string CultureId { get; set; }

        [Required]
        [StringLength(450)]
        public string ProperyName { get; set; }

        public string Value { get; set; }
    }
}