namespace Lab2
{
    partial class EmployeeForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tEmployee_Hire_Date = new System.Windows.Forms.TextBox();
            this.tEmployee_Hire_Number = new System.Windows.Forms.TextBox();
            this.tEmployee_Salary = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tEmployee_Job = new System.Windows.Forms.TextBox();
            this.tEmployee_Date_of_Birth = new System.Windows.Forms.TextBox();
            this.tEmployee_Address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tEmployee_Surname = new System.Windows.Forms.TextBox();
            this.tEmployee_Name = new System.Windows.Forms.TextBox();
            this.tEmployee_Id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lEmployee_id = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.EmployeeGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tEmployee_Hire_Date);
            this.groupBox1.Controls.Add(this.tEmployee_Hire_Number);
            this.groupBox1.Controls.Add(this.tEmployee_Salary);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tEmployee_Job);
            this.groupBox1.Controls.Add(this.tEmployee_Date_of_Birth);
            this.groupBox1.Controls.Add(this.tEmployee_Address);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tEmployee_Surname);
            this.groupBox1.Controls.Add(this.tEmployee_Name);
            this.groupBox1.Controls.Add(this.tEmployee_Id);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lEmployee_id);
            this.groupBox1.Location = new System.Drawing.Point(0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(1259, 174);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Data";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tEmployee_Hire_Date
            // 
            this.tEmployee_Hire_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tEmployee_Hire_Date.Location = new System.Drawing.Point(1037, 114);
            this.tEmployee_Hire_Date.Name = "tEmployee_Hire_Date";
            this.tEmployee_Hire_Date.Size = new System.Drawing.Size(199, 27);
            this.tEmployee_Hire_Date.TabIndex = 17;
            this.tEmployee_Hire_Date.TextChanged += new System.EventHandler(this.tEmployee_Hire_Date_TextChanged);
            // 
            // tEmployee_Hire_Number
            // 
            this.tEmployee_Hire_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tEmployee_Hire_Number.Location = new System.Drawing.Point(1037, 67);
            this.tEmployee_Hire_Number.Name = "tEmployee_Hire_Number";
            this.tEmployee_Hire_Number.Size = new System.Drawing.Size(199, 27);
            this.tEmployee_Hire_Number.TabIndex = 16;
            this.tEmployee_Hire_Number.TextChanged += new System.EventHandler(this.tEmployee_Hire_Number_TextChanged);
            // 
            // tEmployee_Salary
            // 
            this.tEmployee_Salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tEmployee_Salary.Location = new System.Drawing.Point(1037, 21);
            this.tEmployee_Salary.Name = "tEmployee_Salary";
            this.tEmployee_Salary.Size = new System.Drawing.Size(199, 27);
            this.tEmployee_Salary.TabIndex = 15;
            this.tEmployee_Salary.TextChanged += new System.EventHandler(this.tEmployee_Salary_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(866, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Employee Hire Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(843, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Employee Hire Number:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(892, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Employee Salary:";
            // 
            // tEmployee_Job
            // 
            this.tEmployee_Job.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tEmployee_Job.Location = new System.Drawing.Point(621, 115);
            this.tEmployee_Job.Name = "tEmployee_Job";
            this.tEmployee_Job.Size = new System.Drawing.Size(199, 27);
            this.tEmployee_Job.TabIndex = 11;
            this.tEmployee_Job.TextChanged += new System.EventHandler(this.tEmployee_Job_TextChanged);
            // 
            // tEmployee_Date_of_Birth
            // 
            this.tEmployee_Date_of_Birth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tEmployee_Date_of_Birth.Location = new System.Drawing.Point(621, 69);
            this.tEmployee_Date_of_Birth.Name = "tEmployee_Date_of_Birth";
            this.tEmployee_Date_of_Birth.Size = new System.Drawing.Size(199, 27);
            this.tEmployee_Date_of_Birth.TabIndex = 10;
            this.tEmployee_Date_of_Birth.TextChanged += new System.EventHandler(this.tEmployee_Date_of_Birth_TextChanged);
            // 
            // tEmployee_Address
            // 
            this.tEmployee_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tEmployee_Address.Location = new System.Drawing.Point(621, 22);
            this.tEmployee_Address.Name = "tEmployee_Address";
            this.tEmployee_Address.Size = new System.Drawing.Size(199, 27);
            this.tEmployee_Address.TabIndex = 9;
            this.tEmployee_Address.TextChanged += new System.EventHandler(this.tEmployee_Address_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(496, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Employee Job:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(427, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Employee Date of Birth:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(461, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Employee Address:";
            // 
            // tEmployee_Surname
            // 
            this.tEmployee_Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tEmployee_Surname.Location = new System.Drawing.Point(171, 115);
            this.tEmployee_Surname.Name = "tEmployee_Surname";
            this.tEmployee_Surname.Size = new System.Drawing.Size(199, 27);
            this.tEmployee_Surname.TabIndex = 5;
            this.tEmployee_Surname.TextChanged += new System.EventHandler(this.tEmployee_Surname_TextChanged);
            // 
            // tEmployee_Name
            // 
            this.tEmployee_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tEmployee_Name.Location = new System.Drawing.Point(171, 72);
            this.tEmployee_Name.Name = "tEmployee_Name";
            this.tEmployee_Name.Size = new System.Drawing.Size(199, 27);
            this.tEmployee_Name.TabIndex = 4;
            this.tEmployee_Name.TextChanged += new System.EventHandler(this.tEmployee_Name_TextChanged);
            // 
            // tEmployee_Id
            // 
            this.tEmployee_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tEmployee_Id.Location = new System.Drawing.Point(171, 22);
            this.tEmployee_Id.Name = "tEmployee_Id";
            this.tEmployee_Id.Size = new System.Drawing.Size(199, 27);
            this.tEmployee_Id.TabIndex = 3;
            this.tEmployee_Id.TextChanged += new System.EventHandler(this.tEmployee_Id_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Employee Surname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(27, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee Name:";
            // 
            // lEmployee_id
            // 
            this.lEmployee_id.AutoSize = true;
            this.lEmployee_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lEmployee_id.Location = new System.Drawing.Point(58, 25);
            this.lEmployee_id.Name = "lEmployee_id";
            this.lEmployee_id.Size = new System.Drawing.Size(105, 20);
            this.lEmployee_id.TabIndex = 0;
            this.lEmployee_id.Text = "Employee Id:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(0, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1259, 78);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buttons";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(640, 21);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(302, 43);
            this.button4.TabIndex = 3;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Delete_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(315, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(307, 43);
            this.button3.TabIndex = 2;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Update_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(971, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(277, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "Select";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Select_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(276, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Insert_Click);
            // 
            // EmployeeGridView
            // 
            this.EmployeeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeGridView.Location = new System.Drawing.Point(0, 264);
            this.EmployeeGridView.Name = "EmployeeGridView";
            this.EmployeeGridView.RowHeadersWidth = 51;
            this.EmployeeGridView.RowTemplate.Height = 24;
            this.EmployeeGridView.Size = new System.Drawing.Size(1259, 192);
            this.EmployeeGridView.TabIndex = 3;
            this.EmployeeGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeGridView_CellContentClick);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 458);
            this.Controls.Add(this.EmployeeGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tEmployee_Hire_Date;
        private System.Windows.Forms.TextBox tEmployee_Hire_Number;
        private System.Windows.Forms.TextBox tEmployee_Salary;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tEmployee_Job;
        private System.Windows.Forms.TextBox tEmployee_Date_of_Birth;
        private System.Windows.Forms.TextBox tEmployee_Address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tEmployee_Surname;
        private System.Windows.Forms.TextBox tEmployee_Name;
        private System.Windows.Forms.TextBox tEmployee_Id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lEmployee_id;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView EmployeeGridView;
    }
}