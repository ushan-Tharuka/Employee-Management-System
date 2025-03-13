namespace EmployeeManagementSystem
{
    partial class Dashboard
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
            panel5 = new Panel();
            label6 = new Label();
            label3 = new Label();
            panel4 = new Panel();
            label5 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            label4 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(25, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 136);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(0, 0, 64);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(540, 21);
            panel5.Name = "panel5";
            panel5.Size = new Size(226, 94);
            panel5.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(188, 18);
            label6.Name = "label6";
            label6.Size = new Size(17, 20);
            label6.TabIndex = 3;
            label6.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(86, 57);
            label3.Name = "label3";
            label3.Size = new Size(136, 20);
            label3.TabIndex = 2;
            label3.Text = "Inactive Employees";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 0, 64);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(283, 21);
            panel4.Name = "panel4";
            panel4.Size = new Size(226, 94);
            panel4.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(195, 18);
            label5.Name = "label5";
            label5.Size = new Size(17, 20);
            label5.TabIndex = 2;
            label5.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(86, 57);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 1;
            label2.Text = "Active Employees";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 0, 64);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(24, 21);
            panel3.Name = "panel3";
            panel3.Size = new Size(226, 94);
            panel3.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(183, 18);
            label4.Name = "label4";
            label4.Size = new Size(17, 20);
            label4.TabIndex = 1;
            label4.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(82, 57);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 0;
            label1.Text = "Total Employees";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Location = new Point(25, 193);
            panel2.Name = "panel2";
            panel2.Size = new Size(801, 329);
            panel2.TabIndex = 1;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Dashboard";
            Size = new Size(850, 545);
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel5;
        private Label label6;
        private Label label3;
        private Panel panel4;
        private Label label5;
        private Label label2;
        private Label label4;
        private Label label1;
    }
}
