namespace project_reboque
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            menuStrip1 = new MenuStrip();
            nFESToolStripMenuItem = new ToolStripMenuItem();
            gerarNFEToolStripMenuItem = new ToolStripMenuItem();
            orçamentoToolStripMenuItem = new ToolStripMenuItem();
            gerarOrçamentoToolStripMenuItem = new ToolStripMenuItem();
            orçamentosPassadosToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 29F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(276, 143);
            label1.Name = "label1";
            label1.Size = new Size(249, 52);
            label1.TabIndex = 0;
            label1.Text = "Bem vindo(a)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 29F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(195, 204);
            label2.Name = "label2";
            label2.Size = new Size(402, 52);
            label2.TabIndex = 1;
            label2.Text = "em que posso ajudar?";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { nFESToolStripMenuItem, orçamentoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // nFESToolStripMenuItem
            // 
            nFESToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gerarNFEToolStripMenuItem });
            nFESToolStripMenuItem.Name = "nFESToolStripMenuItem";
            nFESToolStripMenuItem.Size = new Size(46, 20);
            nFESToolStripMenuItem.Text = "NFES";
            // 
            // gerarNFEToolStripMenuItem
            // 
            gerarNFEToolStripMenuItem.Name = "gerarNFEToolStripMenuItem";
            gerarNFEToolStripMenuItem.Size = new Size(131, 22);
            gerarNFEToolStripMenuItem.Text = "Gerar NF-E";
            gerarNFEToolStripMenuItem.Click += gerarNFEToolStripMenuItem_Click;
            // 
            // orçamentoToolStripMenuItem
            // 
            orçamentoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gerarOrçamentoToolStripMenuItem, orçamentosPassadosToolStripMenuItem });
            orçamentoToolStripMenuItem.Name = "orçamentoToolStripMenuItem";
            orçamentoToolStripMenuItem.Size = new Size(79, 20);
            orçamentoToolStripMenuItem.Text = "Orçamento";
            // 
            // gerarOrçamentoToolStripMenuItem
            // 
            gerarOrçamentoToolStripMenuItem.Name = "gerarOrçamentoToolStripMenuItem";
            gerarOrçamentoToolStripMenuItem.Size = new Size(188, 22);
            gerarOrçamentoToolStripMenuItem.Text = "Gerar orçamento";
            gerarOrçamentoToolStripMenuItem.Click += gerarOrçamentoToolStripMenuItem_Click;
            // 
            // orçamentosPassadosToolStripMenuItem
            // 
            orçamentosPassadosToolStripMenuItem.Name = "orçamentosPassadosToolStripMenuItem";
            orçamentosPassadosToolStripMenuItem.Size = new Size(188, 22);
            orçamentosPassadosToolStripMenuItem.Text = "orçamentos passados";
            orçamentosPassadosToolStripMenuItem.Click += orçamentosPassadosToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem nFESToolStripMenuItem;
        private ToolStripMenuItem orçamentoToolStripMenuItem;
        private ToolStripMenuItem gerarOrçamentoToolStripMenuItem;
        private ToolStripMenuItem gerarNFEToolStripMenuItem;
        private ToolStripMenuItem orçamentosPassadosToolStripMenuItem;
    }
}