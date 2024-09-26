using Microsoft.EntityFrameworkCore;
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
    public partial class DuplicateOrdersReportForm : Form
    {
        private ProductionParts_DBContext _context;

        public DuplicateOrdersReportForm()
        {
            InitializeComponent();
            _context = new ProductionParts_DBContext();
            LoadReports();
        }
        private void LoadReports()
        {
            var duplicateOrders = _context.Parts
                .Where(p => p.ProductionOrders.Count() > 1)
                .Select(p => new
                {
                    p.PartName,
                    OrderCount = p.ProductionOrders.Count()
                })
                .ToList();

            dataGridViewReports.DataSource = duplicateOrders;
        }
    }
}
