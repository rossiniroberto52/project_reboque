namespace project_reboque
{
    partial class Make_budget
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
            label1 = new Label();
            tb_Name = new TextBox();
            label2 = new Label();
            tb_plate = new TextBox();
            label3 = new Label();
            mtb_val = new MaskedTextBox();
            label4 = new Label();
            tb_take_place = new TextBox();
            label5 = new Label();
            tb_leave_place = new TextBox();
            panel1 = new Panel();
            btn_close = new Button();
            btn_save = new Button();
            btn_clear = new Button();
            label6 = new Label();
            tb_veichle_model = new TextBox();
            label7 = new Label();
            tb_local_name = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(181, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome do contratante do serviço:";
            // 
            // tb_Name
            // 
            tb_Name.Location = new Point(12, 27);
            tb_Name.Name = "tb_Name";
            tb_Name.Size = new Size(181, 23);
            tb_Name.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 2;
            label2.Text = "Placa do veiculo:";
            // 
            // tb_plate
            // 
            tb_plate.Location = new Point(12, 71);
            tb_plate.Name = "tb_plate";
            tb_plate.Size = new Size(125, 23);
            tb_plate.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 142);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 4;
            label3.Text = "Valor:";
            // 
            // mtb_val
            // 
            mtb_val.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            mtb_val.Location = new Point(12, 160);
            mtb_val.Mask = "$000";
            mtb_val.Name = "mtb_val";
            mtb_val.Size = new Size(100, 31);
            mtb_val.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(222, 9);
            label4.Name = "label4";
            label4.Size = new Size(147, 15);
            label4.TabIndex = 6;
            label4.Text = "Local de coleta do veiculo:";
            // 
            // tb_take_place
            // 
            tb_take_place.Location = new Point(222, 28);
            tb_take_place.Name = "tb_take_place";
            tb_take_place.Size = new Size(203, 23);
            tb_take_place.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(222, 98);
            label5.Name = "label5";
            label5.Size = new Size(155, 15);
            label5.TabIndex = 8;
            label5.Text = "Local de entrega do veiculo:";
            // 
            // tb_leave_place
            // 
            tb_leave_place.Location = new Point(222, 116);
            tb_leave_place.Name = "tb_leave_place";
            tb_leave_place.Size = new Size(203, 23);
            tb_leave_place.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_close);
            panel1.Controls.Add(btn_save);
            panel1.Controls.Add(btn_clear);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 208);
            panel1.Name = "panel1";
            panel1.Size = new Size(435, 29);
            panel1.TabIndex = 10;
            // 
            // btn_close
            // 
            btn_close.Location = new Point(298, 3);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(127, 23);
            btn_close.TabIndex = 2;
            btn_close.Text = "Fechar";
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(12, 3);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(134, 23);
            btn_save.TabIndex = 1;
            btn_save.Text = "Gerar";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(152, 3);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(140, 23);
            btn_clear.TabIndex = 0;
            btn_clear.Text = "Limpar";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 98);
            label6.Name = "label6";
            label6.Size = new Size(109, 15);
            label6.TabIndex = 11;
            label6.Text = "Modelo do veiculo:";
            // 
            // tb_veichle_model
            // 
            tb_veichle_model.Location = new Point(12, 116);
            tb_veichle_model.Name = "tb_veichle_model";
            tb_veichle_model.Size = new Size(181, 23);
            tb_veichle_model.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(222, 54);
            label7.Name = "label7";
            label7.Size = new Size(202, 15);
            label7.TabIndex = 13;
            label7.Text = "nome da localidade onde foi deixada";
            // 
            // tb_local_name
            // 
            tb_local_name.Location = new Point(222, 71);
            tb_local_name.Name = "tb_local_name";
            tb_local_name.Size = new Size(201, 23);
            tb_local_name.TabIndex = 14;
            // 
            // Make_budget
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 237);
            Controls.Add(tb_local_name);
            Controls.Add(label7);
            Controls.Add(tb_veichle_model);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(tb_leave_place);
            Controls.Add(label5);
            Controls.Add(tb_take_place);
            Controls.Add(label4);
            Controls.Add(mtb_val);
            Controls.Add(label3);
            Controls.Add(tb_plate);
            Controls.Add(label2);
            Controls.Add(tb_Name);
            Controls.Add(label1);
            Name = "Make_budget";
            Text = "Make_budget";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tb_Name;
        private Label label2;
        private TextBox tb_plate;
        private Label label3;
        private MaskedTextBox mtb_val;
        private Label label4;
        private TextBox tb_take_place;
        private Label label5;
        private TextBox tb_leave_place;
        private Panel panel1;
        private Button btn_close;
        private Button btn_save;
        private Button btn_clear;
        private Label label6;
        private TextBox tb_veichle_model;
        private Label label7;
        private TextBox tb_local_name;
    }
}