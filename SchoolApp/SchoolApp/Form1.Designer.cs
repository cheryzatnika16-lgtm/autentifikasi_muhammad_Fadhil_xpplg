namespace SchoolApp
{
    partial class txtInstitution
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
            btnSave = new Button();
            textInstitution = new TextBox();
            txtName = new TextBox();
            dgvData = new DataGridView();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(49, 32);
            label1.Name = "label1";
            label1.Size = new Size(118, 30);
            label1.TabIndex = 0;
            label1.Text = "Visitor";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Algerian", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(49, 79);
            label2.Name = "label2";
            label2.Size = new Size(176, 30);
            label2.TabIndex = 1;
            label2.Text = "Institution";
            label2.Click += label2_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Gill Sans Ultra Bold", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(478, 36);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(98, 30);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += button1_Click;
            // 
            // textInstitution
            // 
            textInstitution.Font = new Font("Segoe UI", 13F);
            textInstitution.Location = new Point(246, 82);
            textInstitution.Name = "textInstitution";
            textInstitution.Size = new Size(215, 31);
            textInstitution.TabIndex = 3;
            textInstitution.Text = "Input Institution...";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 13F);
            txtName.Location = new Point(246, 35);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Input Your Name...";
            txtName.Size = new Size(215, 31);
            txtName.TabIndex = 4;
            txtName.TextChanged += textBox2_TextChanged;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(49, 136);
            dgvData.Name = "dgvData";
            dgvData.Size = new Size(412, 175);
            dgvData.TabIndex = 5;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(478, 72);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(98, 37);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(478, 115);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(98, 33);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // txtInstitution
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(dgvData);
            Controls.Add(txtName);
            Controls.Add(textInstitution);
            Controls.Add(btnSave);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "txtInstitution";
            Text = "Input Institution";
            Load += txtInstitution_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnSave;
        private TextBox textInstitution;
        private TextBox txtName;
        private DataGridView dgvData;
        private Button btnUpdate;
        private Button btnDelete;
    }
}
