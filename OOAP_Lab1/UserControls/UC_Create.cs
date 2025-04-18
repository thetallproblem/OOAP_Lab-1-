using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOAP_Lab1.UserControls
{
    public partial class UC_Create : UserControl
    {
        ProdSystemForm _parentForm;
        public UC_Create(ProdSystemForm parentForm)
        {
            InitializeComponent();
            labelDone.Visible = false;
            _parentForm = parentForm;
            numTextBox_index.Value = _parentForm.products.Count;
        }

        private void createProduct(object sender, EventArgs e)
        {
            _parentForm.currentProduct.index = Convert.ToInt32(numTextBox_index.Value);
            _parentForm.currentProduct.name = textBox_name.Text;
            _parentForm.currentProduct.cost = Convert.ToDouble(textBox_cost.Text);

            _parentForm.currentProduct.saveProdInputs(this);

            labelDone.Visible = true;
            _parentForm.products.Add(_parentForm.currentProduct);
        }
    }
}
