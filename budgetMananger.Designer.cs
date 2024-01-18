namespace project_reboque
{
    partial class budgetMananger
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgv_budget = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_budget).BeginInit();
            SuspendLayout();
            // 
            // dgv_budget
            // 
            dgv_budget.AllowUserToAddRows = false;
            dgv_budget.AllowUserToDeleteRows = false;
            dgv_budget.AllowUserToOrderColumns = true;
            dgv_budget.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_budget.Location = new Point(12, 12);
            dgv_budget.Name = "dgv_budget";
            dgv_budget.ReadOnly = true;
            dgv_budget.RowTemplate.Height = 25;
            dgv_budget.Size = new Size(386, 370);
            dgv_budget.TabIndex = 0;
            // 
            // budgetMananger
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 394);
            Controls.Add(dgv_budget);
            Name = "budgetMananger";
            Text = "budgetMananger";
            Load += budgetMananger_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_budget).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_budget;
    }
}