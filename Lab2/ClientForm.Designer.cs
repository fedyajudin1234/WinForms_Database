namespace Lab2
{
    partial class ClientForm
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
            this.tClient_Price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lClient_Price = new System.Windows.Forms.Label();
            this.tClient_Destination_Order = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lClient_Destination_Order = new System.Windows.Forms.Label();
            this.tClient_Cargo = new System.Windows.Forms.TextBox();
            this.tClient_Order_Date = new System.Windows.Forms.TextBox();
            this.tClient_Phone = new System.Windows.Forms.TextBox();
            this.lClient_Cargo = new System.Windows.Forms.Label();
            this.lClient_Order_Date = new System.Windows.Forms.Label();
            this.lClient_Phone = new System.Windows.Forms.Label();
            this.tClient_Address = new System.Windows.Forms.TextBox();
            this.tClient_Surname = new System.Windows.Forms.TextBox();
            this.tClient_Id = new System.Windows.Forms.TextBox();
            this.lClient_Address = new System.Windows.Forms.Label();
            this.lClient_Surname = new System.Windows.Forms.Label();
            this.lClient_id = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Select = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.ClientGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tClient_Price);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lClient_Price);
            this.groupBox1.Controls.Add(this.tClient_Destination_Order);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lClient_Destination_Order);
            this.groupBox1.Controls.Add(this.tClient_Cargo);
            this.groupBox1.Controls.Add(this.tClient_Order_Date);
            this.groupBox1.Controls.Add(this.tClient_Phone);
            this.groupBox1.Controls.Add(this.lClient_Cargo);
            this.groupBox1.Controls.Add(this.lClient_Order_Date);
            this.groupBox1.Controls.Add(this.lClient_Phone);
            this.groupBox1.Controls.Add(this.tClient_Address);
            this.groupBox1.Controls.Add(this.tClient_Surname);
            this.groupBox1.Controls.Add(this.tClient_Id);
            this.groupBox1.Controls.Add(this.lClient_Address);
            this.groupBox1.Controls.Add(this.lClient_Surname);
            this.groupBox1.Controls.Add(this.lClient_id);
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(1130, 174);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client Data";
            // 
            // tClient_Price
            // 
            this.tClient_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tClient_Price.Location = new System.Drawing.Point(925, 72);
            this.tClient_Price.Name = "tClient_Price";
            this.tClient_Price.Size = new System.Drawing.Size(199, 27);
            this.tClient_Price.TabIndex = 18;
            this.tClient_Price.TextChanged += new System.EventHandler(this.tClient_Price_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(810, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 17;
            // 
            // lClient_Price
            // 
            this.lClient_Price.AutoSize = true;
            this.lClient_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lClient_Price.Location = new System.Drawing.Point(818, 75);
            this.lClient_Price.Name = "lClient_Price";
            this.lClient_Price.Size = new System.Drawing.Size(101, 20);
            this.lClient_Price.TabIndex = 16;
            this.lClient_Price.Text = "Client Price:";
            // 
            // tClient_Destination_Order
            // 
            this.tClient_Destination_Order.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tClient_Destination_Order.Location = new System.Drawing.Point(923, 27);
            this.tClient_Destination_Order.Name = "tClient_Destination_Order";
            this.tClient_Destination_Order.Size = new System.Drawing.Size(199, 27);
            this.tClient_Destination_Order.TabIndex = 15;
            this.tClient_Destination_Order.TextChanged += new System.EventHandler(this.tClient_Destination_Order_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(808, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 13;
            // 
            // lClient_Destination_Order
            // 
            this.lClient_Destination_Order.AutoSize = true;
            this.lClient_Destination_Order.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lClient_Destination_Order.Location = new System.Drawing.Point(722, 28);
            this.lClient_Destination_Order.Name = "lClient_Destination_Order";
            this.lClient_Destination_Order.Size = new System.Drawing.Size(195, 20);
            this.lClient_Destination_Order.TabIndex = 12;
            this.lClient_Destination_Order.Text = "Client Destination Order:";
            // 
            // tClient_Cargo
            // 
            this.tClient_Cargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tClient_Cargo.Location = new System.Drawing.Point(506, 115);
            this.tClient_Cargo.Name = "tClient_Cargo";
            this.tClient_Cargo.Size = new System.Drawing.Size(199, 27);
            this.tClient_Cargo.TabIndex = 11;
            this.tClient_Cargo.TextChanged += new System.EventHandler(this.tClient_Cargo_TextChanged);
            // 
            // tClient_Order_Date
            // 
            this.tClient_Order_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tClient_Order_Date.Location = new System.Drawing.Point(506, 69);
            this.tClient_Order_Date.Name = "tClient_Order_Date";
            this.tClient_Order_Date.Size = new System.Drawing.Size(199, 27);
            this.tClient_Order_Date.TabIndex = 10;
            this.tClient_Order_Date.TextChanged += new System.EventHandler(this.tClient_Order_Date_TextChanged);
            // 
            // tClient_Phone
            // 
            this.tClient_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tClient_Phone.Location = new System.Drawing.Point(506, 25);
            this.tClient_Phone.Name = "tClient_Phone";
            this.tClient_Phone.Size = new System.Drawing.Size(199, 27);
            this.tClient_Phone.TabIndex = 9;
            this.tClient_Phone.TextChanged += new System.EventHandler(this.tClient_Phone_TextChanged);
            // 
            // lClient_Cargo
            // 
            this.lClient_Cargo.AutoSize = true;
            this.lClient_Cargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lClient_Cargo.Location = new System.Drawing.Point(393, 121);
            this.lClient_Cargo.Name = "lClient_Cargo";
            this.lClient_Cargo.Size = new System.Drawing.Size(107, 20);
            this.lClient_Cargo.TabIndex = 8;
            this.lClient_Cargo.Text = "Client Cargo:";
            // 
            // lClient_Order_Date
            // 
            this.lClient_Order_Date.AutoSize = true;
            this.lClient_Order_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lClient_Order_Date.Location = new System.Drawing.Point(354, 75);
            this.lClient_Order_Date.Name = "lClient_Order_Date";
            this.lClient_Order_Date.Size = new System.Drawing.Size(146, 20);
            this.lClient_Order_Date.TabIndex = 7;
            this.lClient_Order_Date.Text = "Client Order Date:";
            // 
            // lClient_Phone
            // 
            this.lClient_Phone.AutoSize = true;
            this.lClient_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lClient_Phone.Location = new System.Drawing.Point(391, 28);
            this.lClient_Phone.Name = "lClient_Phone";
            this.lClient_Phone.Size = new System.Drawing.Size(109, 20);
            this.lClient_Phone.TabIndex = 6;
            this.lClient_Phone.Text = "Client Phone:";
            // 
            // tClient_Address
            // 
            this.tClient_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tClient_Address.Location = new System.Drawing.Point(141, 118);
            this.tClient_Address.Name = "tClient_Address";
            this.tClient_Address.Size = new System.Drawing.Size(199, 27);
            this.tClient_Address.TabIndex = 5;
            this.tClient_Address.TextChanged += new System.EventHandler(this.tClient_Address_TextChanged);
            // 
            // tClient_Surname
            // 
            this.tClient_Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tClient_Surname.Location = new System.Drawing.Point(141, 75);
            this.tClient_Surname.Name = "tClient_Surname";
            this.tClient_Surname.Size = new System.Drawing.Size(199, 27);
            this.tClient_Surname.TabIndex = 4;
            this.tClient_Surname.TextChanged += new System.EventHandler(this.tClient_Surname_TextChanged);
            // 
            // tClient_Id
            // 
            this.tClient_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tClient_Id.Location = new System.Drawing.Point(141, 25);
            this.tClient_Id.Name = "tClient_Id";
            this.tClient_Id.Size = new System.Drawing.Size(199, 27);
            this.tClient_Id.TabIndex = 3;
            this.tClient_Id.TextChanged += new System.EventHandler(this.tClient_Id_TextChanged);
            // 
            // lClient_Address
            // 
            this.lClient_Address.AutoSize = true;
            this.lClient_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lClient_Address.Location = new System.Drawing.Point(11, 121);
            this.lClient_Address.Name = "lClient_Address";
            this.lClient_Address.Size = new System.Drawing.Size(124, 20);
            this.lClient_Address.TabIndex = 2;
            this.lClient_Address.Text = "Client Address:";
            // 
            // lClient_Surname
            // 
            this.lClient_Surname.AutoSize = true;
            this.lClient_Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lClient_Surname.Location = new System.Drawing.Point(6, 75);
            this.lClient_Surname.Name = "lClient_Surname";
            this.lClient_Surname.Size = new System.Drawing.Size(129, 20);
            this.lClient_Surname.TabIndex = 1;
            this.lClient_Surname.Text = "Client Surname:";
            // 
            // lClient_id
            // 
            this.lClient_id.AutoSize = true;
            this.lClient_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lClient_id.Location = new System.Drawing.Point(60, 28);
            this.lClient_id.Name = "lClient_id";
            this.lClient_id.Size = new System.Drawing.Size(75, 20);
            this.lClient_id.TabIndex = 0;
            this.lClient_id.Text = "Client Id:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Delete);
            this.groupBox2.Controls.Add(this.Update);
            this.groupBox2.Controls.Add(this.Select);
            this.groupBox2.Controls.Add(this.Insert);
            this.groupBox2.Location = new System.Drawing.Point(1, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1130, 78);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buttons";
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(628, 21);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(238, 43);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(309, 21);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(249, 43);
            this.Update.TabIndex = 2;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Select
            // 
            this.Select.Location = new System.Drawing.Point(908, 21);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(214, 43);
            this.Select.TabIndex = 1;
            this.Select.Text = "Select";
            this.Select.UseVisualStyleBackColor = true;
            this.Select.Click += new System.EventHandler(this.Select_Click);
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(6, 21);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(237, 43);
            this.Insert.TabIndex = 0;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // ClientGridView
            // 
            this.ClientGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientGridView.Location = new System.Drawing.Point(1, 251);
            this.ClientGridView.Name = "ClientGridView";
            this.ClientGridView.RowHeadersWidth = 51;
            this.ClientGridView.RowTemplate.Height = 24;
            this.ClientGridView.Size = new System.Drawing.Size(1130, 199);
            this.ClientGridView.TabIndex = 5;
            this.ClientGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientGridView_CellContentClick);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 450);
            this.Controls.Add(this.ClientGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientForm";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClientGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tClient_Destination_Order;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lClient_Destination_Order;
        private System.Windows.Forms.TextBox tClient_Cargo;
        private System.Windows.Forms.TextBox tClient_Order_Date;
        private System.Windows.Forms.TextBox tClient_Phone;
        private System.Windows.Forms.Label lClient_Cargo;
        private System.Windows.Forms.Label lClient_Order_Date;
        private System.Windows.Forms.Label lClient_Phone;
        private System.Windows.Forms.TextBox tClient_Address;
        private System.Windows.Forms.TextBox tClient_Surname;
        private System.Windows.Forms.TextBox tClient_Id;
        private System.Windows.Forms.Label lClient_Address;
        private System.Windows.Forms.Label lClient_Surname;
        private System.Windows.Forms.Label lClient_id;
        private System.Windows.Forms.TextBox tClient_Price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lClient_Price;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Select;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.DataGridView ClientGridView;
    }
}