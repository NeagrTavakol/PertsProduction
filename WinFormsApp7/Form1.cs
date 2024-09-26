using WinFormsApp7.Models;

namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        private ProductionParts_DBContext _context;
        private ProductionOrder _currentOrder;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void btnProductionReForm_Click(object sender, EventArgs e)
        {
            ProductionReportForm productionReportForm = new ProductionReportForm();
            productionReportForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DuplicateOrdersReportForm duplicateOrdersReportForm = new DuplicateOrdersReportForm();
            duplicateOrdersReportForm.ShowDialog();
        }
    }
}