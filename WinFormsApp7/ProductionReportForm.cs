using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp7.Models;

namespace WinFormsApp7
{
    public partial class ProductionReportForm : Form
    {
        private ProductionParts_DBContext _context;
        public ProductionReportForm()
        {
            InitializeComponent();
            _context = new ProductionParts_DBContext();
            LoadReports();
        }
        private void LoadReports()
        {
            var completedOrders = _context.ProductionOrders
                .Where(o => o.ProductionSteps.All(s => s.IsCompleted))
                .Select(o => new
                {
                    o.Part.PartName,
                    o.OrderDate,
                    StepsCount = o.ProductionSteps.Count()
                })
                .ToList();

            dataGridViewReports.DataSource = completedOrders;
        }

    }
}
