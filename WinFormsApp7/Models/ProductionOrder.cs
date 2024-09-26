using System;
using System.Collections.Generic;

namespace WinFormsApp7.Models
{
    public partial class ProductionOrder
    {
        public ProductionOrder()
        {
            ProductionSteps = new HashSet<ProductionStep>();
        }

        public int ProductionOrderId { get; set; }
        public int PartId { get; set; }
        public DateTime OrderDate { get; set; }
        public int NumberOfinput { get; set; }

        public virtual Part Part { get; set; } = null!;
        public virtual ICollection<ProductionStep> ProductionSteps { get; set; }
    }
}
