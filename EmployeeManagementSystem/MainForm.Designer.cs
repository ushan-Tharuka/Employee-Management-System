namespace EmployeeManagementSystem
{
    partial class MainForm
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
            panel1 = new Panel();
            label6 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            logout_btn = new Button();
            salary_btn = new Button();
            addEmployee_btn = new Button();
            dashboard_btn = new Button();
            panel3 = new Panel();
            dashboard1 = new Dashboard();
            addEmployee1 = new AddEmployee();
            salary1 = new Salary();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1100, 55);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(12, 19);
            label6.Name = "label6";
            label6.Size = new Size(290, 24);
            label6.TabIndex = 12;
            label6.Text = "Employee Management System";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1065, 14);
            label1.Name = "label1";
            label1.Size = new Size(20, 21);
            label1.TabIndex = 11;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 0, 64);
            panel2.Controls.Add(logout_btn);
            panel2.Controls.Add(salary_btn);
            panel2.Controls.Add(addEmployee_btn);
            panel2.Controls.Add(dashboard_btn);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 55);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 545);
            panel2.TabIndex = 1;
            // 
            // logout_btn
            // 
            logout_btn.BackColor = Color.FromArgb(0, 0, 64);
            logout_btn.Cursor = Cursors.Hand;
            logout_btn.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logout_btn.ForeColor = Color.White;
            logout_btn.Location = new Point(39, 483);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(159, 41);
            logout_btn.TabIndex = 3;
            logout_btn.Text = "LOGOUT";
            logout_btn.UseVisualStyleBackColor = false;
            logout_btn.Click += logout_btn_Click;
            // 
            // salary_btn
            // 
            salary_btn.BackColor = Color.FromArgb(0, 0, 64);
            salary_btn.Cursor = Cursors.Hand;
            salary_btn.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            salary_btn.ForeColor = Color.White;
            salary_btn.Location = new Point(39, 279);
            salary_btn.Name = "salary_btn";
            salary_btn.Size = new Size(159, 41);
            salary_btn.TabIndex = 2;
            salary_btn.Text = "SALARY";
            salary_btn.UseVisualStyleBackColor = false;
            salary_btn.Click += salary_btn_Click;
            // 
            // addEmployee_btn
            // 
            addEmployee_btn.BackColor = Color.FromArgb(0, 0, 64);
            addEmployee_btn.Cursor = Cursors.Hand;
            addEmployee_btn.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addEmployee_btn.ForeColor = Color.White;
            addEmployee_btn.Location = new Point(39, 223);
            addEmployee_btn.Name = "addEmployee_btn";
            addEmployee_btn.Size = new Size(159, 41);
            addEmployee_btn.TabIndex = 1;
            addEmployee_btn.Text = "ADD EMPLOYEE";
            addEmployee_btn.UseVisualStyleBackColor = false;
            addEmployee_btn.Click += addEmployee_btn_Click;
            // 
            // dashboard_btn
            // 
            dashboard_btn.BackColor = Color.FromArgb(0, 0, 64);
            dashboard_btn.Cursor = Cursors.Hand;
            dashboard_btn.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboard_btn.ForeColor = Color.White;
            dashboard_btn.Location = new Point(39, 166);
            dashboard_btn.Name = "dashboard_btn";
            dashboard_btn.Size = new Size(159, 41);
            dashboard_btn.TabIndex = 0;
            dashboard_btn.Text = "DASHBOARD";
            dashboard_btn.UseVisualStyleBackColor = false;
            dashboard_btn.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(dashboard1);
            panel3.Controls.Add(addEmployee1);
            panel3.Controls.Add(salary1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(250, 55);
            panel3.Name = "panel3";
            panel3.Size = new Size(850, 545);
            panel3.TabIndex = 2;
            // 
            // dashboard1
            // 
            dashboard1.Location = new Point(0, 0);
            dashboard1.Name = "dashboard1";
            dashboard1.Size = new Size(1062, 681);
            dashboard1.TabIndex = 2;
            // 
            // addEmployee1
            // 
            addEmployee1.Location = new Point(0, 0);
            addEmployee1.Name = "addEmployee1";
            addEmployee1.Size = new Size(1062, 681);
            addEmployee1.TabIndex = 1;
            // 
            // salary1
            // 
            salary1.Location = new Point(0, 0);
            salary1.Name = "salary1";
            salary1.Size = new Size(1062, 681);
            salary1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 600);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label6;
        private Panel panel2;
        private Button salary_btn;
        private Button addEmployee_btn;
        private Button dashboard_btn;
        private Button logout_btn;
        private Panel panel3;
        private Dashboard dashboard1;
        private AddEmployee addEmployee1;
        private Salary salary1;
    }
}