using System.Reflection.PortableExecutable;
using WinFormsApp7.Models;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.Diagnostics;

namespace WinFormsApp7
{
    public partial class Form2 : Form
    {
        private ProductionParts_DBContext _context;
        private ProductionOrder _currentOrder;
        public Form2()
        {
            InitializeComponent();
            _context = new ProductionParts_DBContext();
            LoadParts();
        }


        private void LoadParts()
        {
            comboBoxParts.DataSource = _context.Parts.ToList();
            comboBoxParts.DisplayMember = "PartName";
            comboBoxParts.ValueMember = "PartID";
        }

        private void btnCreateNewOrder_Click(object sender, EventArgs e)
        {
            int selectedPartId = (int)comboBoxParts.SelectedValue;
            int num =(int) numericUDinput.Value;
            _currentOrder = new ProductionOrder
            {
                PartId = selectedPartId,
                OrderDate = DateTime.Now,
                NumberOfinput = num
            };
            _context.ProductionOrders.Add(_currentOrder);
            _context.SaveChanges();

            dataGridViewSteps.DataSource = null;

        }

        private void LoadSteps()
        {
            dataGridViewSteps.DataSource = _currentOrder.ProductionSteps.ToList();
        }

        private void btnAddStep_Click(object sender, EventArgs e)
        {


        }

        private void btnStartStep_Click(object sender, EventArgs e)
        {
            if (_currentOrder != null)
            {
                var step = new ProductionStep
                {
                    WorkStation = txtWorkStation.Text,
                    IsCompleted = false,
                    StartTime = DateTime.Now,
                    OperatorName = txtOperatorName.Text,
                    ProductionOrder = _currentOrder
                };

                _currentOrder.ProductionSteps.Add(step);
                _context.SaveChanges();
                LoadSteps();

            }
            else
            {
                MessageBox.Show("اول یک سفارش جدید ایجاد کن");
            }
        }

        private void btnShowPdf_Click(object sender, EventArgs e)
        {

        }

        private void btnShowPdf_Click_1(object sender, EventArgs e)
        {
            var selectedPart = (Part)comboBoxParts.SelectedItem;
            /*if (selectedPart != null)
            {
                System.Diagnostics.Process.Start(selectedPart.PdfFilePath);
            }*/
            string pdfFilePath = selectedPart.PdfFilePath;
            if (!string.IsNullOrEmpty(pdfFilePath))
            {
                //  با  استفاده  از  ProcessStartInfo  ،  نوع  برنامه  رو  به  PDF  تعیین  میکنیم 
                ProcessStartInfo startInfo = new ProcessStartInfo(pdfFilePath);
                startInfo.UseShellExecute = true;
                startInfo.Verb = "open";

                //  فایل  رو  با  استفاده  از  Process  باز  میکنیم 
                System.Diagnostics.Process.Start(startInfo);
            }
            else
            {
                //  در  صورت  خالی  بودن  مسیر  ،  پیغام  خطا  نمایش  میدهیم 
                MessageBox.Show("مسیر  فایل  PDF  نامعتبر  هست  .", "خطا");
            }

        }

        private void btnAddStep_Click_1(object sender, EventArgs e)
        {
            var currentStep = _currentOrder.ProductionSteps.FirstOrDefault(s => !s.IsCompleted);
            if (currentStep != null)
            {
                currentStep.IsCompleted = true;
                currentStep.EndTime = DateTime.Now;
                _context.SaveChanges();
                LoadSteps();
            }
        }
    }
}
