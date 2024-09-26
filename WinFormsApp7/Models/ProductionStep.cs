using System;
using System.Collections.Generic;

namespace WinFormsApp7.Models
{
    public partial class ProductionStep
    {
        public int ProductionStepId { get; set; }
        public int ProductionOrderId { get; set; }
        public string WorkStation { get; set; } = null!;
        public bool IsCompleted { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string OperatorName { get; set; } = null!;

        public virtual ProductionOrder ProductionOrder { get; set; } = null!;
    }
}
