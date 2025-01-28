namespace BarMan
{
    partial class FormDriver_Add_Edit
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
            tbName = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            tbTell = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            tbVehicleType = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            tbVehicleNumber = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            btnOK = new System.Windows.Forms.Button();
            btnCansel = new System.Windows.Forms.Button();
            lbtext = new System.Windows.Forms.Label();
            tbIDCod = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tbName
            // 
            tbName.Location = new System.Drawing.Point(3, 20);
            tbName.Name = "tbName";
            tbName.Size = new System.Drawing.Size(289, 23);
            tbName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(345, 195);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(59, 15);
            label1.TabIndex = 1;
            label1.Text = "نوع مشاین";
            // 
            // tbTell
            // 
            tbTell.Location = new System.Drawing.Point(3, 100);
            tbTell.Name = "tbTell";
            tbTell.Size = new System.Drawing.Size(289, 23);
            tbTell.TabIndex = 2;
            tbTell.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(345, 240);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(72, 15);
            label2.TabIndex = 1;
            label2.Text = "شماره ماشین";
            // 
            // tbVehicleType
            // 
            tbVehicleType.Location = new System.Drawing.Point(2, 147);
            tbVehicleType.Name = "tbVehicleType";
            tbVehicleType.Size = new System.Drawing.Size(289, 23);
            tbVehicleType.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(341, 148);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(63, 15);
            label3.TabIndex = 1;
            label3.Text = " تلفن همراه";
            // 
            // tbVehicleNumber
            // 
            tbVehicleNumber.Location = new System.Drawing.Point(3, 192);
            tbVehicleNumber.Name = "tbVehicleNumber";
            tbVehicleNumber.Size = new System.Drawing.Size(289, 23);
            tbVehicleNumber.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(349, 68);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(51, 15);
            label4.TabIndex = 1;
            label4.Text = "نام راننده";
            // 
            // btnOK
            // 
            btnOK.Location = new System.Drawing.Point(265, 302);
            btnOK.Name = "btnOK";
            btnOK.Size = new System.Drawing.Size(68, 33);
            btnOK.TabIndex = 5;
            btnOK.Text = "ثبت";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCansel
            // 
            btnCansel.Location = new System.Drawing.Point(44, 302);
            btnCansel.Name = "btnCansel";
            btnCansel.Size = new System.Drawing.Size(68, 33);
            btnCansel.TabIndex = 6;
            btnCansel.Text = "انصراف";
            btnCansel.UseVisualStyleBackColor = true;
            btnCansel.Click += btnCansel_Click;
            // 
            // lbtext
            // 
            lbtext.AutoSize = true;
            lbtext.Location = new System.Drawing.Point(180, 27);
            lbtext.Name = "lbtext";
            lbtext.Size = new System.Drawing.Size(51, 15);
            lbtext.TabIndex = 1;
            lbtext.Text = "نام راننده";
            // 
            // tbIDCod
            // 
            tbIDCod.Location = new System.Drawing.Point(3, 59);
            tbIDCod.Name = "tbIDCod";
            tbIDCod.Size = new System.Drawing.Size(289, 23);
            tbIDCod.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(349, 107);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(40, 15);
            label5.TabIndex = 1;
            label5.Text = "کدملی";
            // 
            // panel1
            // 
            panel1.Controls.Add(tbName);
            panel1.Controls.Add(tbIDCod);
            panel1.Controls.Add(tbTell);
            panel1.Controls.Add(tbVehicleType);
            panel1.Controls.Add(tbVehicleNumber);
            panel1.Location = new System.Drawing.Point(36, 45);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(307, 227);
            panel1.TabIndex = 7;
            // 
            // FormDriver_Add_Edit
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(441, 392);
            Controls.Add(panel1);
            Controls.Add(btnCansel);
            Controls.Add(btnOK);
            Controls.Add(lbtext);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            KeyPreview = true;
            Name = "FormDriver_Add_Edit";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FormDriver_Add_Edit";
            Load += FormDriver_Add_Edit_Load;
            KeyDown += FormDriver_Add_Edit_KeyDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTell;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbVehicleType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbVehicleNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCansel;
        private System.Windows.Forms.Label lbtext;
        private System.Windows.Forms.TextBox tbIDCod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
    }
}