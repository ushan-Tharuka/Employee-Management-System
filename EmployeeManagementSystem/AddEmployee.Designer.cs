namespace EmployeeManagementSystem
{
    partial class AddEmployee
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel2 = new Panel();
            label7 = new Label();
            addEmployee_status = new ComboBox();
            addEmployee_clearBtn = new Button();
            addEmployee_deleteBtn = new Button();
            addEmployee_updateBtn = new Button();
            addEmployee_addBtn = new Button();
            addEmployee_importBtn = new Button();
            label6 = new Label();
            addEmployee_position = new ComboBox();
            addEmployee_picture = new PictureBox();
            addEmployee_phonenumber = new TextBox();
            label5 = new Label();
            label4 = new Label();
            addEmployee_fullname = new TextBox();
            label3 = new Label();
            addEmployee_gender = new ComboBox();
            addEmployee_id = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addEmployee_picture).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(25, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(792, 243);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(742, 173);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 19);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 1;
            label1.Text = "Employee's Data";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(addEmployee_status);
            panel2.Controls.Add(addEmployee_clearBtn);
            panel2.Controls.Add(addEmployee_deleteBtn);
            panel2.Controls.Add(addEmployee_updateBtn);
            panel2.Controls.Add(addEmployee_addBtn);
            panel2.Controls.Add(addEmployee_importBtn);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(addEmployee_position);
            panel2.Controls.Add(addEmployee_picture);
            panel2.Controls.Add(addEmployee_phonenumber);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(addEmployee_fullname);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(addEmployee_gender);
            panel2.Controls.Add(addEmployee_id);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(25, 286);
            panel2.Name = "panel2";
            panel2.Size = new Size(792, 229);
            panel2.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(322, 116);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 17;
            label7.Text = "Status";
            // 
            // addEmployee_status
            // 
            addEmployee_status.FormattingEnabled = true;
            addEmployee_status.Items.AddRange(new object[] { "Active", "Inactive" });
            addEmployee_status.Location = new Point(422, 113);
            addEmployee_status.Name = "addEmployee_status";
            addEmployee_status.Size = new Size(151, 28);
            addEmployee_status.TabIndex = 16;
            // 
            // addEmployee_clearBtn
            // 
            addEmployee_clearBtn.Location = new Point(526, 176);
            addEmployee_clearBtn.Name = "addEmployee_clearBtn";
            addEmployee_clearBtn.Size = new Size(129, 40);
            addEmployee_clearBtn.TabIndex = 15;
            addEmployee_clearBtn.Text = "Clear";
            addEmployee_clearBtn.UseVisualStyleBackColor = true;
            addEmployee_clearBtn.Click += addEmployee_clearBtn_Click;
            // 
            // addEmployee_deleteBtn
            // 
            addEmployee_deleteBtn.Location = new Point(382, 176);
            addEmployee_deleteBtn.Name = "addEmployee_deleteBtn";
            addEmployee_deleteBtn.Size = new Size(129, 40);
            addEmployee_deleteBtn.TabIndex = 14;
            addEmployee_deleteBtn.Text = "Delete";
            addEmployee_deleteBtn.UseVisualStyleBackColor = true;
            addEmployee_deleteBtn.Click += addEmployee_deleteBtn_Click;
            // 
            // addEmployee_updateBtn
            // 
            addEmployee_updateBtn.Location = new Point(237, 176);
            addEmployee_updateBtn.Name = "addEmployee_updateBtn";
            addEmployee_updateBtn.Size = new Size(129, 40);
            addEmployee_updateBtn.TabIndex = 13;
            addEmployee_updateBtn.Text = "Update";
            addEmployee_updateBtn.UseVisualStyleBackColor = true;
            addEmployee_updateBtn.Click += addEmployee_updateBtn_Click;
            // 
            // addEmployee_addBtn
            // 
            addEmployee_addBtn.Location = new Point(88, 176);
            addEmployee_addBtn.Name = "addEmployee_addBtn";
            addEmployee_addBtn.Size = new Size(129, 40);
            addEmployee_addBtn.TabIndex = 12;
            addEmployee_addBtn.Text = "Add";
            addEmployee_addBtn.UseVisualStyleBackColor = true;
            addEmployee_addBtn.Click += addEmployee_addBtn_Click;
            // 
            // addEmployee_importBtn
            // 
            addEmployee_importBtn.Location = new Point(672, 153);
            addEmployee_importBtn.Name = "addEmployee_importBtn";
            addEmployee_importBtn.Size = new Size(94, 29);
            addEmployee_importBtn.TabIndex = 11;
            addEmployee_importBtn.Text = "Import";
            addEmployee_importBtn.UseVisualStyleBackColor = true;
            addEmployee_importBtn.Click += addEmployee_importBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(322, 76);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 10;
            label6.Text = "Position";
            // 
            // addEmployee_position
            // 
            addEmployee_position.FormattingEnabled = true;
            addEmployee_position.Items.AddRange(new object[] { "Frontend Developer", "Backend Developer", "Full stack Developer", "QA Engineer", "Web developer", "UI/UX designer" });
            addEmployee_position.Location = new Point(422, 73);
            addEmployee_position.Name = "addEmployee_position";
            addEmployee_position.Size = new Size(151, 28);
            addEmployee_position.TabIndex = 9;
            // 
            // addEmployee_picture
            // 
            addEmployee_picture.Location = new Point(674, 32);
            addEmployee_picture.Name = "addEmployee_picture";
            addEmployee_picture.Size = new Size(92, 104);
            addEmployee_picture.SizeMode = PictureBoxSizeMode.StretchImage;
            addEmployee_picture.TabIndex = 8;
            addEmployee_picture.TabStop = false;
            // 
            // addEmployee_phonenumber
            // 
            addEmployee_phonenumber.Location = new Point(436, 29);
            addEmployee_phonenumber.Name = "addEmployee_phonenumber";
            addEmployee_phonenumber.Size = new Size(151, 27);
            addEmployee_phonenumber.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(322, 32);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 6;
            label5.Text = "Phone Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 122);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 5;
            label4.Text = "Gender";
            // 
            // addEmployee_fullname
            // 
            addEmployee_fullname.Location = new Point(128, 73);
            addEmployee_fullname.Name = "addEmployee_fullname";
            addEmployee_fullname.Size = new Size(151, 27);
            addEmployee_fullname.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 73);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 3;
            label3.Text = "Name";
            label3.Click += label3_Click;
            // 
            // addEmployee_gender
            // 
            addEmployee_gender.FormattingEnabled = true;
            addEmployee_gender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            addEmployee_gender.Location = new Point(128, 119);
            addEmployee_gender.Name = "addEmployee_gender";
            addEmployee_gender.Size = new Size(151, 28);
            addEmployee_gender.TabIndex = 2;
            // 
            // addEmployee_id
            // 
            addEmployee_id.Location = new Point(128, 25);
            addEmployee_id.Name = "addEmployee_id";
            addEmployee_id.Size = new Size(151, 27);
            addEmployee_id.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 25);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 0;
            label2.Text = "Employee ID";
            // 
            // AddEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AddEmployee";
            Size = new Size(850, 545);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)addEmployee_picture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label4;
        private TextBox addEmployee_fullname;
        private Label label3;
        private ComboBox addEmployee_gender;
        private TextBox addEmployee_id;
        private Label label2;
        private Button addEmployee_clearBtn;
        private Button addEmployee_deleteBtn;
        private Button addEmployee_updateBtn;
        private Button addEmployee_addBtn;
        private Button addEmployee_importBtn;
        private Label label6;
        private ComboBox addEmployee_position;
        private PictureBox addEmployee_picture;
        private TextBox addEmployee_phonenumber;
        private Label label5;
        private Label label7;
        private ComboBox addEmployee_status;
        private DataGridView dataGridView1;
    }
}
