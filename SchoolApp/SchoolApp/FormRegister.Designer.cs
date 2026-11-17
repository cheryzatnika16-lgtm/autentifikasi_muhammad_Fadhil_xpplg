namespace SchoolApp
{
    partial class Form4
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
            txtUserName = new TextBox();
            txtFullName = new TextBox();
            txtPassword = new TextBox();
            btnSumbitRegister = new Button();
            btnNavToLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(290, 23);
            label1.Name = "label1";
            label1.Size = new Size(197, 37);
            label1.TabIndex = 0;
            label1.Text = "Form Register";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(290, 107);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(197, 29);
            txtUserName.TabIndex = 1;
            txtUserName.Text = "Username";
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFullName.Location = new Point(290, 72);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(197, 29);
            txtFullName.TabIndex = 2;
            txtFullName.Text = "Full Name";
            txtFullName.TextChanged += txtFullName_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(290, 142);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(197, 29);
            txtPassword.TabIndex = 3;
            txtPassword.Text = "Password";
            // 
            // btnSumbitRegister
            // 
            btnSumbitRegister.Location = new Point(290, 177);
            btnSumbitRegister.Name = "btnSumbitRegister";
            btnSumbitRegister.Size = new Size(197, 32);
            btnSumbitRegister.TabIndex = 4;
            btnSumbitRegister.Text = "Register";
            btnSumbitRegister.UseVisualStyleBackColor = true;
            btnSumbitRegister.Click += btnSumbitRegister_Click;
            // 
            // btnNavToLogin
            // 
            btnNavToLogin.Location = new Point(290, 215);
            btnNavToLogin.Name = "btnNavToLogin";
            btnNavToLogin.Size = new Size(197, 33);
            btnNavToLogin.TabIndex = 5;
            btnNavToLogin.Text = "To Login";
            btnNavToLogin.UseVisualStyleBackColor = true;
            btnNavToLogin.Click += btnNavToLogin_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNavToLogin);
            Controls.Add(btnSumbitRegister);
            Controls.Add(txtPassword);
            Controls.Add(txtFullName);
            Controls.Add(txtUserName);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUserName;
        private TextBox textBox1;
        private TextBox txtFullName;
        private TextBox txtPassword;
        private TextBox textBox3;
        private Button btnSumbitRegister;
        private Button btnNavToLogin;
    }
}