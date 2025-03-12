
namespace EmployeeManagementSystem
{
    partial class RegisterForm
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
            login_showPass = new CheckBox();
            signup_Btn = new Button();
            signup_password = new TextBox();
            label4 = new Label();
            signup_username = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            signup_loginBtn = new Button();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // login_showPass
            // 
            login_showPass.AutoSize = true;
            login_showPass.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_showPass.Location = new Point(551, 313);
            login_showPass.Name = "login_showPass";
            login_showPass.Size = new Size(130, 22);
            login_showPass.TabIndex = 17;
            login_showPass.Text = "Show Password";
            login_showPass.UseVisualStyleBackColor = true;
            login_showPass.CheckedChanged += signup_showPass_CheckedChanged;
            // 
            // signup_Btn
            // 
            signup_Btn.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_Btn.Location = new Point(470, 354);
            signup_Btn.Name = "signup_Btn";
            signup_Btn.Size = new Size(137, 45);
            signup_Btn.TabIndex = 16;
            signup_Btn.Text = "SIGNUP";
            signup_Btn.UseVisualStyleBackColor = true;
            signup_Btn.Click += signup_Btn_Click;
            // 
            // signup_password
            // 
            signup_password.Location = new Point(401, 263);
            signup_password.Multiline = true;
            signup_password.Name = "signup_password";
            signup_password.PasswordChar = '*';
            signup_password.Size = new Size(282, 34);
            signup_password.TabIndex = 15;
            signup_password.TextChanged += signup_password_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(401, 230);
            label4.Name = "label4";
            label4.Size = new Size(87, 21);
            label4.TabIndex = 14;
            label4.Text = "Password:";
            // 
            // signup_username
            // 
            signup_username.Location = new Point(401, 174);
            signup_username.Multiline = true;
            signup_username.Name = "signup_username";
            signup_username.Size = new Size(282, 34);
            signup_username.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(401, 141);
            label3.Name = "label3";
            label3.Size = new Size(96, 21);
            label3.TabIndex = 12;
            label3.Text = "Username: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(401, 55);
            label2.Name = "label2";
            label2.Size = new Size(196, 31);
            label2.TabIndex = 11;
            label2.Text = "Register Account";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(688, 9);
            label1.Name = "label1";
            label1.Size = new Size(20, 21);
            label1.TabIndex = 10;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(signup_loginBtn);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(357, 484);
            panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(105, 163);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(37, 55);
            label6.Name = "label6";
            label6.Size = new Size(290, 24);
            label6.TabIndex = 2;
            label6.Text = "Employee Management System";
            // 
            // signup_loginBtn
            // 
            signup_loginBtn.Location = new Point(77, 418);
            signup_loginBtn.Name = "signup_loginBtn";
            signup_loginBtn.Size = new Size(176, 39);
            signup_loginBtn.TabIndex = 1;
            signup_loginBtn.Text = "LOGIN";
            signup_loginBtn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(87, 379);
            label5.Name = "label5";
            label5.Size = new Size(135, 20);
            label5.TabIndex = 0;
            label5.Text = "Login your account";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 484);
            Controls.Add(login_showPass);
            Controls.Add(signup_Btn);
            Controls.Add(signup_password);
            Controls.Add(label4);
            Controls.Add(signup_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            Text = "RegisterForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void signup_showPass_CheckedChanged(object sender, EventArgs e)
        {
            signup_password.PasswordChar = login_showPass.Checked ? '\0' : '*';
            throw new NotImplementedException();
        }

        #endregion

        private CheckBox login_showPass;
        private Button signup_Btn;
        private TextBox signup_password;
        private Label label4;
        private TextBox signup_username;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label6;
        private Button signup_loginBtn;
        private Label label5;
    }
}