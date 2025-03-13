namespace EmployeeManagementSystem
{
    partial class Salary
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            salary_salary = new TextBox();
            label5 = new Label();
            button3 = new Button();
            button1 = new Button();
            salary_position = new TextBox();
            label4 = new Label();
            salay_name = new TextBox();
            label3 = new Label();
            salary_employeeID = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(salary_salary);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(salary_position);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(salay_name);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(salary_employeeID);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(18, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(251, 502);
            panel1.TabIndex = 0;
            // 
            // salary_salary
            // 
            salary_salary.Location = new Point(22, 301);
            salary_salary.Multiline = true;
            salary_salary.Name = "salary_salary";
            salary_salary.Size = new Size(203, 34);
            salary_salary.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 278);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 17;
            label5.Text = "Salary";
            // 
            // button3
            // 
            button3.Location = new Point(128, 375);
            button3.Name = "button3";
            button3.Size = new Size(97, 35);
            button3.TabIndex = 16;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(22, 375);
            button1.Name = "button1";
            button1.Size = new Size(97, 35);
            button1.TabIndex = 14;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // salary_position
            // 
            salary_position.Location = new Point(22, 234);
            salary_position.Multiline = true;
            salary_position.Name = "salary_position";
            salary_position.Size = new Size(203, 34);
            salary_position.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 211);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 4;
            label4.Text = "Position";
            // 
            // salay_name
            // 
            salay_name.Location = new Point(22, 152);
            salay_name.Multiline = true;
            salay_name.Name = "salay_name";
            salay_name.Size = new Size(203, 34);
            salay_name.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 129);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 2;
            label3.Text = "Full Name";
            // 
            // salary_employeeID
            // 
            salary_employeeID.Location = new Point(22, 72);
            salary_employeeID.Multiline = true;
            salary_employeeID.Name = "salary_employeeID";
            salary_employeeID.Size = new Size(203, 34);
            salary_employeeID.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 49);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 0;
            label2.Text = "Employee ID:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(293, 21);
            panel2.Name = "panel2";
            panel2.Size = new Size(531, 502);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 72);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(498, 338);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 26);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Employee";
            // 
            // Salary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Salary";
            Size = new Size(850, 545);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox salary_position;
        private Label label4;
        private TextBox salay_name;
        private Label label3;
        private TextBox salary_employeeID;
        private Label label2;
        private Panel panel2;
        private Label label1;
        private Button button3;
        private Button button1;
        private TextBox salary_salary;
        private Label label5;
        private DataGridView dataGridView1;
    }
}
