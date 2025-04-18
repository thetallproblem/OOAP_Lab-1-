using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OOAP_Lab1.ProdSystemForm;

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

        private void saveProdInputs()
        {
            switch (_parentForm.productType)
            {
                case ProductType.Motherboard:
                    var motherboard = _parentForm.currentProduct as Motherboard;

                    if (motherboard != null)
                    {
                        motherboard.saveProdInputs(this);
                    }

                    break;
                case ProductType.Processor:
                    var processor = _parentForm.currentProduct as Processor;

                    if (processor != null)
                    {
                        processor.saveProdInputs(this);
                    }

                    break;
                case ProductType.HardDrive:
                    var harddrive = _parentForm.currentProduct as HardDrive;

                    if (harddrive != null)
                    {
                        harddrive.saveProdInputs(this);
                    }

                    break;
            }
        }

        private void createProduct(object sender, EventArgs e)
        {
            _parentForm.currentProduct.index = Convert.ToInt32(numTextBox_index.Value);
            _parentForm.currentProduct.name = textBox_name.Text;
            _parentForm.currentProduct.cost = Convert.ToDouble(textBox_cost.Text);

            saveProdInputs();

            labelDone.Visible = true;
            _parentForm.products.Add(_parentForm.currentProduct);
        }
    }
}
