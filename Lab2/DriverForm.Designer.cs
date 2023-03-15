namespace Lab2
{
    partial class DriverForm
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
            this.tEmployee_Id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lEmployee_Id = new System.Windows.Forms.Label();
            this.tCar_Id = new System.Windows.Forms.TextBox();
            this.tDriver_Experience = new System.Windows.Forms.TextBox();
            this.tDriver_Class = new System.Windows.Forms.TextBox();
            this.lCar_Id = new System.Windows.Forms.Label();
            this.lDriver_Experience = new System.Windows.Forms.Label();
            this.lDriver_Class = new System.Windows.Forms.Label();
            this.tDriver_Surname = new System.Windows.Forms.TextBox();
            this.tDriver_Name = new System.Windows.Forms.TextBox();
            this.tDriver_Id = new System.Windows.Forms.TextBox();
            this.lDriver_Surname = new System.Windows.Forms.Label();
            this.lDriver_Name = new System.Windows.Forms.Label();
            this.lDriver_id = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Select = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.DriverGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DriverGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tEmployee_Id);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lEmployee_Id);
            this.groupBox1.Controls.Add(this.tCar_Id);
            this.groupBox1.Controls.Add(this.tDriver_Experience);
            this.groupBox1.Controls.Add(this.tDriver_Class);
            this.groupBox1.Controls.Add(this.lCar_Id);
            this.groupBox1.Controls.Add(this.lDriver_Experience);
            this.groupBox1.Controls.Add(this.lDriver_Class);
            this.groupBox1.Controls.Add(this.tDriver_Surname);
            this.groupBox1.Controls.Add(this.tDriver_Name);
            this.groupBox1.Controls.Add(this.tDriver_Id);
            this.groupBox1.Controls.Add(this.lDriver_Surname);
            this.groupBox1.Controls.Add(this.lDriver_Name);
            this.groupBox1.Controls.Add(this.lDriver_id);
            this.groupBox1.Location = new System.Drawing.Point(2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(1111, 174);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driver Data";
            // 
            // tEmployee_Id
            // 
            this.tEmployee_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tEmployee_Id.Location = new System.Drawing.Point(902, 69);
            this.tEmployee_Id.Name = "tEmployee_Id";
            this.tEmployee_Id.Size = new System.Drawing.Size(199, 27);
            this.tEmployee_Id.TabIndex = 15;
            this.tEmployee_Id.TextChanged += new System.EventHandler(this.tEmployee_Id_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(843, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 13;
            // 
            // lEmployee_Id
            // 
            this.lEmployee_Id.AutoSize = true;
            this.lEmployee_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lEmployee_Id.Location = new System.Drawing.Point(757, 72);
            this.lEmployee_Id.Name = "lEmployee_Id";
            this.lEmployee_Id.Size = new System.Drawing.Size(105, 20);
            this.lEmployee_Id.TabIndex = 12;
            this.lEmployee_Id.Text = "Employee Id:";
            // 
            // tCar_Id
            // 
            this.tCar_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tCar_Id.Location = new System.Drawing.Point(535, 115);
            this.tCar_Id.Name = "tCar_Id";
            this.tCar_Id.Size = new System.Drawing.Size(199, 27);
            this.tCar_Id.TabIndex = 11;
            this.tCar_Id.TextChanged += new System.EventHandler(this.tCar_Id_TextChanged);
            // 
            // tDriver_Experience
            // 
            this.tDriver_Experience.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tDriver_Experience.Location = new System.Drawing.Point(535, 69);
            this.tDriver_Experience.Name = "tDriver_Experience";
            this.tDriver_Experience.Size = new System.Drawing.Size(199, 27);
            this.tDriver_Experience.TabIndex = 10;
            this.tDriver_Experience.TextChanged += new System.EventHandler(this.tDriver_Experience_TextChanged);
            // 
            // tDriver_Class
            // 
            this.tDriver_Class.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tDriver_Class.Location = new System.Drawing.Point(535, 22);
            this.tDriver_Class.Name = "tDriver_Class";
            this.tDriver_Class.Size = new System.Drawing.Size(199, 27);
            this.tDriver_Class.TabIndex = 9;
            this.tDriver_Class.TextChanged += new System.EventHandler(this.tDriver_Class_TextChanged);
            // 
            // lCar_Id
            // 
            this.lCar_Id.AutoSize = true;
            this.lCar_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCar_Id.Location = new System.Drawing.Point(470, 117);
            this.lCar_Id.Name = "lCar_Id";
            this.lCar_Id.Size = new System.Drawing.Size(59, 20);
            this.lCar_Id.TabIndex = 8;
            this.lCar_Id.Text = "Car Id:";
            // 
            // lDriver_Experience
            // 
            this.lDriver_Experience.AutoSize = true;
            this.lDriver_Experience.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lDriver_Experience.Location = new System.Drawing.Point(381, 74);
            this.lDriver_Experience.Name = "lDriver_Experience";
            this.lDriver_Experience.Size = new System.Drawing.Size(148, 20);
            this.lDriver_Experience.TabIndex = 7;
            this.lDriver_Experience.Text = "Driver Experience:";
            // 
            // lDriver_Class
            // 
            this.lDriver_Class.AutoSize = true;
            this.lDriver_Class.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lDriver_Class.Location = new System.Drawing.Point(421, 25);
            this.lDriver_Class.Name = "lDriver_Class";
            this.lDriver_Class.Size = new System.Drawing.Size(108, 20);
            this.lDriver_Class.TabIndex = 6;
            this.lDriver_Class.Text = "Driver Class:";
            // 
            // tDriver_Surname
            // 
            this.tDriver_Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tDriver_Surname.Location = new System.Drawing.Point(171, 115);
            this.tDriver_Surname.Name = "tDriver_Surname";
            this.tDriver_Surname.Size = new System.Drawing.Size(199, 27);
            this.tDriver_Surname.TabIndex = 5;
            this.tDriver_Surname.TextChanged += new System.EventHandler(this.tDriver_Surname_TextChanged);
            // 
            // tDriver_Name
            // 
            this.tDriver_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tDriver_Name.Location = new System.Drawing.Point(171, 72);
            this.tDriver_Name.Name = "tDriver_Name";
            this.tDriver_Name.Size = new System.Drawing.Size(199, 27);
            this.tDriver_Name.TabIndex = 4;
            this.tDriver_Name.TextChanged += new System.EventHandler(this.tDriver_Name_TextChanged);
            // 
            // tDriver_Id
            // 
            this.tDriver_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tDriver_Id.Location = new System.Drawing.Point(171, 22);
            this.tDriver_Id.Name = "tDriver_Id";
            this.tDriver_Id.Size = new System.Drawing.Size(199, 27);
            this.tDriver_Id.TabIndex = 3;
            this.tDriver_Id.TextChanged += new System.EventHandler(this.tDriver_Id_TextChanged);
            // 
            // lDriver_Surname
            // 
            this.lDriver_Surname.AutoSize = true;
            this.lDriver_Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lDriver_Surname.Location = new System.Drawing.Point(6, 119);
            this.lDriver_Surname.Name = "lDriver_Surname";
            this.lDriver_Surname.Size = new System.Drawing.Size(132, 20);
            this.lDriver_Surname.TabIndex = 2;
            this.lDriver_Surname.Text = "Driver Surname:";
            // 
            // lDriver_Name
            // 
            this.lDriver_Name.AutoSize = true;
            this.lDriver_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lDriver_Name.Location = new System.Drawing.Point(27, 72);
            this.lDriver_Name.Name = "lDriver_Name";
            this.lDriver_Name.Size = new System.Drawing.Size(109, 20);
            this.lDriver_Name.TabIndex = 1;
            this.lDriver_Name.Text = "Driver Name:";
            // 
            // lDriver_id
            // 
            this.lDriver_id.AutoSize = true;
            this.lDriver_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lDriver_id.Location = new System.Drawing.Point(58, 25);
            this.lDriver_id.Name = "lDriver_id";
            this.lDriver_id.Size = new System.Drawing.Size(78, 20);
            this.lDriver_id.TabIndex = 0;
            this.lDriver_id.Text = "Driver Id:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Delete);
            this.groupBox2.Controls.Add(this.Update);
            this.groupBox2.Controls.Add(this.Select);
            this.groupBox2.Controls.Add(this.Insert);
            this.groupBox2.Location = new System.Drawing.Point(2, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1111, 78);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buttons";
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(610, 21);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(222, 43);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(311, 21);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(228, 43);
            this.Update.TabIndex = 2;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Select
            // 
            this.Select.Location = new System.Drawing.Point(902, 21);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(202, 43);
            this.Select.TabIndex = 1;
            this.Select.Text = "Select";
            this.Select.UseVisualStyleBackColor = true;
            this.Select.Click += new System.EventHandler(this.Select_Click);
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(6, 21);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(217, 43);
            this.Insert.TabIndex = 0;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // DriverGridView
            // 
            this.DriverGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DriverGridView.Location = new System.Drawing.Point(2, 246);
            this.DriverGridView.Name = "DriverGridView";
            this.DriverGridView.RowHeadersWidth = 51;
            this.DriverGridView.RowTemplate.Height = 24;
            this.DriverGridView.Size = new System.Drawing.Size(1111, 201);
            this.DriverGridView.TabIndex = 4;
            this.DriverGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DriverGridView_CellContentClick);
            // 
            // DriverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 450);
            this.Controls.Add(this.DriverGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DriverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DriverForm";
            this.Load += new System.EventHandler(this.DriverForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DriverGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tEmployee_Id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lEmployee_Id;
        private System.Windows.Forms.TextBox tCar_Id;
        private System.Windows.Forms.TextBox tDriver_Experience;
        private System.Windows.Forms.TextBox tDriver_Class;
        private System.Windows.Forms.Label lCar_Id;
        private System.Windows.Forms.Label lDriver_Experience;
        private System.Windows.Forms.Label lDriver_Class;
        private System.Windows.Forms.TextBox tDriver_Surname;
        private System.Windows.Forms.TextBox tDriver_Name;
        private System.Windows.Forms.TextBox tDriver_Id;
        private System.Windows.Forms.Label lDriver_Surname;
        private System.Windows.Forms.Label lDriver_Name;
        private System.Windows.Forms.Label lDriver_id;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Select;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.DataGridView DriverGridView;
    }
}