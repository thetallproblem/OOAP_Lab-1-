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
    public partial class UC_Show : UserControl
    {
        ProdSystemForm _parentForm;
        public UC_Show(ProdSystemForm parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            for (int i=0; i<_parentForm.products.Count; i++) 
            {
                string index = Convert.ToString(_parentForm.products[i].index);
                string name = _parentForm.products[i].name;
                string cost = Convert.ToString(_parentForm.products[i].cost);
                string type = _parentForm.products[i].getStringKey();

                string[] row = new string[] { index, type,  name, cost};
                dataGridView.Rows.Add(row);
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                labelShowPr.Text = _parentForm.products[e.RowIndex].showInfo();
            }
        }
    }
}
