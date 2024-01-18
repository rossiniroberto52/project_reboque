using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_reboque
{
    public partial class budgetMananger : Form
    {
        public budgetMananger()
        {
            InitializeComponent();
        }

        private void budgetMananger_Load(object sender, EventArgs e)
        {
            dgv_budget.DataSource = Banco.GetDataFromBudget();
            dgv_budget.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_budget.Columns[0].Width = 45;
            dgv_budget.Columns[1].Width = 105;
            dgv_budget.Columns[2].Width = 75;
            dgv_budget.Columns[3].Width = 85;

        }
    }
}
