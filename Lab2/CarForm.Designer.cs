namespace Lab2
{
    partial class CarForm
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
            this.tCar_Condition = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tCar_Cargo_Type = new System.Windows.Forms.TextBox();
            this.tCar_Load = new System.Windows.Forms.TextBox();
            this.tCar_Number = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tCar_Model = new System.Windows.Forms.TextBox();
            this.tCar_Mark = new System.Windows.Forms.TextBox();
            this.tCar_Id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Delete = new System.Windows.Forms.Button();
            this.Select = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataCarView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCarView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tCar_Condition);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tCar_Cargo_Type);
            this.groupBox1.Controls.Add(this.tCar_Load);
            this.groupBox1.Controls.Add(this.tCar_Number);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tCar_Model);
            this.groupBox1.Controls.Add(this.tCar_Mark);
            this.groupBox1.Controls.Add(this.tCar_Id);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1099, 174);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Car Data";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tCar_Condition
            // 
            this.tCar_Condition.Location = new System.Drawing.Point(818, 68);
            this.tCar_Condition.Name = "tCar_Condition";
            this.tCar_Condition.Size = new System.Drawing.Size(196, 22);
            this.tCar_Condition.TabIndex = 13;
            this.tCar_Condition.TextChanged += new System.EventHandler(this.tCar_Condition_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(694, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Car Condition:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // tCar_Cargo_Type
            // 
            this.tCar_Cargo_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tCar_Cargo_Type.Location = new System.Drawing.Point(466, 119);
            this.tCar_Cargo_Type.Name = "tCar_Cargo_Type";
            this.tCar_Cargo_Type.Size = new System.Drawing.Size(199, 27);
            this.tCar_Cargo_Type.TabIndex = 11;
            this.tCar_Cargo_Type.TextChanged += new System.EventHandler(this.tCar_Cargo_Type_TextChanged);
            // 
            // tCar_Load
            // 
            this.tCar_Load.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tCar_Load.Location = new System.Drawing.Point(466, 72);
            this.tCar_Load.Name = "tCar_Load";
            this.tCar_Load.Size = new System.Drawing.Size(199, 27);
            this.tCar_Load.TabIndex = 10;
            this.tCar_Load.TextChanged += new System.EventHandler(this.tCar_Load_TextChanged);
            // 
            // tCar_Number
            // 
            this.tCar_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tCar_Number.Location = new System.Drawing.Point(466, 26);
            this.tCar_Number.Name = "tCar_Number";
            this.tCar_Number.Size = new System.Drawing.Size(199, 27);
            this.tCar_Number.TabIndex = 9;
            this.tCar_Number.TextChanged += new System.EventHandler(this.tCar_Number_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(322, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Car Cargo Type:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(365, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Car Load:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(343, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Car Number:";
            // 
            // tCar_Model
            // 
            this.tCar_Model.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tCar_Model.Location = new System.Drawing.Point(117, 119);
            this.tCar_Model.Name = "tCar_Model";
            this.tCar_Model.Size = new System.Drawing.Size(199, 27);
            this.tCar_Model.TabIndex = 5;
            this.tCar_Model.TextChanged += new System.EventHandler(this.tCar_Model_TextChanged);
            // 
            // tCar_Mark
            // 
            this.tCar_Mark.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tCar_Mark.Location = new System.Drawing.Point(117, 72);
            this.tCar_Mark.Name = "tCar_Mark";
            this.tCar_Mark.Size = new System.Drawing.Size(199, 27);
            this.tCar_Mark.TabIndex = 4;
            this.tCar_Mark.TextChanged += new System.EventHandler(this.tCar_Mark_TextChanged);
            // 
            // tCar_Id
            // 
            this.tCar_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tCar_Id.Location = new System.Drawing.Point(117, 26);
            this.tCar_Id.Name = "tCar_Id";
            this.tCar_Id.Size = new System.Drawing.Size(199, 27);
            this.tCar_Id.TabIndex = 3;
            this.tCar_Id.TextChanged += new System.EventHandler(this.tCar_Id_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Car Model:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(16, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Car Mark:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(40, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car Id:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Delete);
            this.groupBox2.Controls.Add(this.Select);
            this.groupBox2.Controls.Add(this.Update);
            this.groupBox2.Controls.Add(this.Insert);
            this.groupBox2.Location = new System.Drawing.Point(4, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1099, 68);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buttons";
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(582, 21);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(228, 40);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Select
            // 
            this.Select.Location = new System.Drawing.Point(865, 21);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(228, 40);
            this.Select.TabIndex = 2;
            this.Select.Text = "Select";
            this.Select.UseVisualStyleBackColor = true;
            this.Select.Click += new System.EventHandler(this.Select_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(301, 21);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(228, 40);
            this.Update.TabIndex = 1;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(6, 21);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(228, 40);
            this.Insert.TabIndex = 0;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataCarView);
            this.groupBox3.Location = new System.Drawing.Point(4, 260);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1099, 243);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data";
            // 
            // dataCarView
            // 
            this.dataCarView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCarView.Location = new System.Drawing.Point(0, 21);
            this.dataCarView.Name = "dataCarView";
            this.dataCarView.RowHeadersWidth = 51;
            this.dataCarView.RowTemplate.Height = 24;
            this.dataCarView.Size = new System.Drawing.Size(1092, 221);
            this.dataCarView.TabIndex = 0;
            this.dataCarView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCarView_CellContentClick);
            // 
            // CarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 515);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CarForm";
            this.Load += new System.EventHandler(this.CarForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataCarView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tCar_Id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tCar_Cargo_Type;
        private System.Windows.Forms.TextBox tCar_Load;
        private System.Windows.Forms.TextBox tCar_Number;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tCar_Model;
        private System.Windows.Forms.TextBox tCar_Mark;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Select;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.DataGridView dataCarView;
        private System.Windows.Forms.TextBox tCar_Condition;
    }
}