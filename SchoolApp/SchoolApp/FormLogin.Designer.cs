namespace SchoolApp
{
    partial class Form3
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
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label1 = new Label();
            btnLogin = new Button();
            btnToRegister = new Button();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(301, 110);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(163, 29);
            txtPassword.TabIndex = 0;
            txtPassword.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(301, 75);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(163, 29);
            txtUsername.TabIndex = 1;
            txtUsername.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(301, 25);
            label1.Name = "label1";
            label1.Size = new Size(163, 37);
            label1.TabIndex = 2;
            label1.Text = "Form Login";
            label1.Click += label1_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(301, 145);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(163, 34);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnToRegister
            // 
            btnToRegister.Location = new Point(301, 185);
            btnToRegister.Name = "btnToRegister";
            btnToRegister.Size = new Size(163, 30);
            btnToRegister.TabIndex = 4;
            btnToRegister.Text = "To Register";
            btnToRegister.UseVisualStyleBackColor = true;
            btnToRegister.Click += btnToRegister_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnToRegister);
            Controls.Add(btnLogin);
            Controls.Add(label1);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label1;
        private Button btnLogin;
        private Button button1;
        private Button btnToRegister;
    }
}