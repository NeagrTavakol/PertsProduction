using System;
using System.Collections.Generic;

namespace WinFormsApp7.Models
{
    public partial class Part
    {
        public Part()
        {
            ProductionOrders = new HashSet<ProductionOrder>();
        }

        public int PartId { get; set; }
        public string PartName { get; set; } = null!;
        public string PdfFilePath { get; set; } = null!;

        public virtual ICollection<ProductionOrder> ProductionOrders { get; set; }
    }
}
