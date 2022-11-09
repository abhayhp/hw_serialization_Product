namespace hw_serialization_Product
{
    partial class Form1
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
            this.btnsoapread = new System.Windows.Forms.Button();
            this.btnsoapwrite = new System.Windows.Forms.Button();
            this.btnjsonread = new System.Windows.Forms.Button();
            this.btnjsonwrite = new System.Windows.Forms.Button();
            this.btnxmlread = new System.Windows.Forms.Button();
            this.btnxmlwrite = new System.Windows.Forms.Button();
            this.btnbinaryread = new System.Windows.Forms.Button();
            this.btnbinarywrite = new System.Windows.Forms.Button();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsoapread
            // 
            this.btnsoapread.Location = new System.Drawing.Point(433, 315);
            this.btnsoapread.Name = "btnsoapread";
            this.btnsoapread.Size = new System.Drawing.Size(75, 23);
            this.btnsoapread.TabIndex = 28;
            this.btnsoapread.Text = "Soap Read";
            this.btnsoapread.UseVisualStyleBackColor = true;
            // 
            // btnsoapwrite
            // 
            this.btnsoapwrite.Location = new System.Drawing.Point(293, 315);
            this.btnsoapwrite.Name = "btnsoapwrite";
            this.btnsoapwrite.Size = new System.Drawing.Size(75, 23);
            this.btnsoapwrite.TabIndex = 27;
            this.btnsoapwrite.Text = "Soap Write";
            this.btnsoapwrite.UseVisualStyleBackColor = true;
            // 
            // btnjsonread
            // 
            this.btnjsonread.Location = new System.Drawing.Point(433, 363);
            this.btnjsonread.Name = "btnjsonread";
            this.btnjsonread.Size = new System.Drawing.Size(75, 23);
            this.btnjsonread.TabIndex = 26;
            this.btnjsonread.Text = "Json Read";
            this.btnjsonread.UseVisualStyleBackColor = true;
            // 
            // btnjsonwrite
            // 
            this.btnjsonwrite.Location = new System.Drawing.Point(292, 363);
            this.btnjsonwrite.Name = "btnjsonwrite";
            this.btnjsonwrite.Size = new System.Drawing.Size(75, 23);
            this.btnjsonwrite.TabIndex = 25;
            this.btnjsonwrite.Text = "Json Write";
            this.btnjsonwrite.UseVisualStyleBackColor = true;
            // 
            // btnxmlread
            // 
            this.btnxmlread.Location = new System.Drawing.Point(433, 254);
            this.btnxmlread.Name = "btnxmlread";
            this.btnxmlread.Size = new System.Drawing.Size(75, 23);
            this.btnxmlread.TabIndex = 24;
            this.btnxmlread.Text = "XML Read";
            this.btnxmlread.UseVisualStyleBackColor = true;
            // 
            // btnxmlwrite
            // 
            this.btnxmlwrite.Location = new System.Drawing.Point(293, 254);
            this.btnxmlwrite.Name = "btnxmlwrite";
            this.btnxmlwrite.Size = new System.Drawing.Size(75, 23);
            this.btnxmlwrite.TabIndex = 23;
            this.btnxmlwrite.Text = "Xml Write";
            this.btnxmlwrite.UseVisualStyleBackColor = true;
            // 
            // btnbinaryread
            // 
            this.btnbinaryread.Location = new System.Drawing.Point(433, 206);
            this.btnbinaryread.Name = "btnbinaryread";
            this.btnbinaryread.Size = new System.Drawing.Size(75, 23);
            this.btnbinaryread.TabIndex = 22;
            this.btnbinaryread.Text = "Binary Read";
            this.btnbinaryread.UseVisualStyleBackColor = true;
            // 
            // btnbinarywrite
            // 
            this.btnbinarywrite.Location = new System.Drawing.Point(292, 206);
            this.btnbinarywrite.Name = "btnbinarywrite";
            this.btnbinarywrite.Size = new System.Drawing.Size(75, 23);
            this.btnbinarywrite.TabIndex = 21;
            this.btnbinarywrite.Text = "Binary Write";
            this.btnbinarywrite.UseVisualStyleBackColor = true;
            this.btnbinarywrite.Click += new System.EventHandler(this.btnbinarywrite_Click);
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(408, 154);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 20);
            this.txtSalary.TabIndex = 20;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(408, 112);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Enter Product Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Enter Product Name";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(408, 64);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Enter Product Id";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsoapread);
            this.Controls.Add(this.btnsoapwrite);
            this.Controls.Add(this.btnjsonread);
            this.Controls.Add(this.btnjsonwrite);
            this.Controls.Add(this.btnxmlread);
            this.Controls.Add(this.btnxmlwrite);
            this.Controls.Add(this.btnbinaryread);
            this.Controls.Add(this.btnbinarywrite);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsoapread;
        private System.Windows.Forms.Button btnsoapwrite;
        private System.Windows.Forms.Button btnjsonread;
        private System.Windows.Forms.Button btnjsonwrite;
        private System.Windows.Forms.Button btnxmlread;
        private System.Windows.Forms.Button btnxmlwrite;
        private System.Windows.Forms.Button btnbinaryread;
        private System.Windows.Forms.Button btnbinarywrite;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
    }
}

