namespace BarMan
{
    partial class FormSuppliers_Add_Edit
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
            btnCansel = new System.Windows.Forms.Button();
            btnOK = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            tbVehicleNumber = new System.Windows.Forms.TextBox();
            tbVehicleType = new System.Windows.Forms.TextBox();
            tbTell = new System.Windows.Forms.TextBox();
            tbIDCod = new System.Windows.Forms.TextBox();
            tbName = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // btnCansel
            // 
            btnCansel.Location = new System.Drawing.Point(50, 409);
            btnCansel.Name = "btnCansel";
            btnCansel.Size = new System.Drawing.Size(68, 33);
            btnCansel.TabIndex = 6;
            btnCansel.Text = "انصراف";
            btnCansel.UseVisualStyleBackColor = true;
            btnCansel.Click += btnCansel_Click;
            // 
            // btnOK
            // 
            btnOK.Location = new System.Drawing.Point(290, 409);
            btnOK.Name = "btnOK";
            btnOK.Size = new System.Drawing.Size(68, 33);
            btnOK.TabIndex = 5;
            btnOK.Text = "ثبت";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(345, 126);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(40, 15);
            label5.TabIndex = 9;
            label5.Text = "کدملی";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(341, 87);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(55, 15);
            label4.TabIndex = 10;
            label4.Text = "نام خریدار";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(341, 167);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(63, 15);
            label3.TabIndex = 11;
            label3.Text = " تلفن همراه";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(346, 300);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(54, 15);
            label2.TabIndex = 12;
            label2.Text = "توضیحات";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(349, 214);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(36, 15);
            label1.TabIndex = 13;
            label1.Text = "Email";
            // 
            // tbVehicleNumber
            // 
            tbVehicleNumber.Location = new System.Drawing.Point(51, 251);
            tbVehicleNumber.Multiline = true;
            tbVehicleNumber.Name = "tbVehicleNumber";
            tbVehicleNumber.Size = new System.Drawing.Size(289, 102);
            tbVehicleNumber.TabIndex = 4;
            // 
            // tbVehicleType
            // 
            tbVehicleType.Location = new System.Drawing.Point(50, 206);
            tbVehicleType.Name = "tbVehicleType";
            tbVehicleType.Size = new System.Drawing.Size(289, 23);
            tbVehicleType.TabIndex = 3;
            // 
            // tbTell
            // 
            tbTell.Location = new System.Drawing.Point(51, 159);
            tbTell.Name = "tbTell";
            tbTell.Size = new System.Drawing.Size(289, 23);
            tbTell.TabIndex = 2;
            // 
            // tbIDCod
            // 
            tbIDCod.Location = new System.Drawing.Point(51, 118);
            tbIDCod.Name = "tbIDCod";
            tbIDCod.Size = new System.Drawing.Size(289, 23);
            tbIDCod.TabIndex = 1;
            // 
            // tbName
            // 
            tbName.Location = new System.Drawing.Point(51, 79);
            tbName.Name = "tbName";
            tbName.Size = new System.Drawing.Size(289, 23);
            tbName.TabIndex = 0;
            // 
            // FormSuppliers_Add_Edit
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(431, 489);
            Controls.Add(btnCansel);
            Controls.Add(btnOK);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbVehicleNumber);
            Controls.Add(tbVehicleType);
            Controls.Add(tbTell);
            Controls.Add(tbIDCod);
            Controls.Add(tbName);
            KeyPreview = true;
            Name = "FormSuppliers_Add_Edit";
            Text = "اضافه کردن خریدار";
            Load += FormSuppliers_Add_Edit_Load;
            KeyDown += FormSuppliers_Add_Edit_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnCansel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbVehicleNumber;
        private System.Windows.Forms.TextBox tbVehicleType;
        private System.Windows.Forms.TextBox tbTell;
        private System.Windows.Forms.TextBox tbIDCod;
        private System.Windows.Forms.TextBox tbName;
    }
}