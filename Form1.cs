namespace project_reboque
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gerarOrçamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Make_budget make_Budget = new Make_budget();
            make_Budget.ShowDialog();
        }

        private void gerarNFEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NFE_GEN nfe_gen = new NFE_GEN();
            nfe_gen.ShowDialog();
        }

        private void orçamentosPassadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            budgetMananger budgetMananger = new budgetMananger();
            budgetMananger.ShowDialog();
        }
    }
}