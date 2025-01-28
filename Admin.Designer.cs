namespace BarMan
{
    partial class Admin
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
            textBox1 = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            comboBox1 = new System.Windows.Forms.ComboBox();
            textBox2 = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            cbPasword = new System.Windows.Forms.CheckBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox1.Location = new System.Drawing.Point(35, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(170, 25);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(211, 63);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(68, 19);
            label1.TabIndex = 1;
            label1.Text = "نام کاربری";
            // 
            // comboBox1
            // 
            comboBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Admin", "Visitor" });
            comboBox1.Location = new System.Drawing.Point(35, 169);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(170, 25);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox2.Location = new System.Drawing.Point(35, 111);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(170, 25);
            textBox2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(211, 114);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(60, 19);
            label2.TabIndex = 1;
            label2.Text = "رمز کاربر";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(210, 175);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(69, 19);
            label3.TabIndex = 1;
            label3.Text = "نقش کاربر";
            // 
            // button1
            // 
            button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button1.Location = new System.Drawing.Point(91, 224);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(70, 32);
            button1.TabIndex = 3;
            button1.Text = "ثبت";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cbPasword
            // 
            cbPasword.AutoSize = true;
            cbPasword.Location = new System.Drawing.Point(35, 137);
            cbPasword.Name = "cbPasword";
            cbPasword.Size = new System.Drawing.Size(77, 19);
            cbPasword.TabIndex = 4;
            cbPasword.Text = "نمایش رمز";
            cbPasword.UseVisualStyleBackColor = true;
            cbPasword.CheckedChanged += cbPasword_CheckedChanged;
            // 
            // Admin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(291, 277);
            Controls.Add(cbPasword);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            KeyPreview = true;
            Name = "Admin";
            Text = "اضافه کردن کاربر";
            KeyDown += Admin_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cbPasword;
    }
}