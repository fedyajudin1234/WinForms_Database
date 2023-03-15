namespace Lab2
{
    partial class OrderForm
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
            this.tDriver_Id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lDriver_Id = new System.Windows.Forms.Label();
            this.tClient_Id = new System.Windows.Forms.TextBox();
            this.lClient_Id = new System.Windows.Forms.Label();
            this.tOrder_Id = new System.Windows.Forms.TextBox();
            this.lOrder_id = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Select = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.OrdersGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tDriver_Id);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lDriver_Id);
            this.groupBox1.Controls.Add(this.tClient_Id);
            this.groupBox1.Controls.Add(this.lClient_Id);
            this.groupBox1.Controls.Add(this.tOrder_Id);
            this.groupBox1.Controls.Add(this.lOrder_id);
            this.groupBox1.Location = new System.Drawing.Point(1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(1054, 74);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Data";
            // 
            // tDriver_Id
            // 
            this.tDriver_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tDriver_Id.Location = new System.Drawing.Point(806, 25);
            this.tDriver_Id.Name = "tDriver_Id";
            this.tDriver_Id.Size = new System.Drawing.Size(199, 27);
            this.tDriver_Id.TabIndex = 15;
            this.tDriver_Id.TextChanged += new System.EventHandler(this.tDriver_Id_TextChanged);
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
            // lDriver_Id
            // 
            this.lDriver_Id.AutoSize = true;
            this.lDriver_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lDriver_Id.Location = new System.Drawing.Point(722, 28);
            this.lDriver_Id.Name = "lDriver_Id";
            this.lDriver_Id.Size = new System.Drawing.Size(78, 20);
            this.lDriver_Id.TabIndex = 12;
            this.lDriver_Id.Text = "Driver Id:";
            // 
            // tClient_Id
            // 
            this.tClient_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tClient_Id.Location = new System.Drawing.Point(458, 25);
            this.tClient_Id.Name = "tClient_Id";
            this.tClient_Id.Size = new System.Drawing.Size(199, 27);
            this.tClient_Id.TabIndex = 9;
            this.tClient_Id.TextChanged += new System.EventHandler(this.tClient_Id_TextChanged);
            // 
            // lClient_Id
            // 
            this.lClient_Id.AutoSize = true;
            this.lClient_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lClient_Id.Location = new System.Drawing.Point(377, 30);
            this.lClient_Id.Name = "lClient_Id";
            this.lClient_Id.Size = new System.Drawing.Size(75, 20);
            this.lClient_Id.TabIndex = 6;
            this.lClient_Id.Text = "Client Id:";
            // 
            // tOrder_Id
            // 
            this.tOrder_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tOrder_Id.Location = new System.Drawing.Point(141, 25);
            this.tOrder_Id.Name = "tOrder_Id";
            this.tOrder_Id.Size = new System.Drawing.Size(199, 27);
            this.tOrder_Id.TabIndex = 3;
            this.tOrder_Id.TextChanged += new System.EventHandler(this.tOrder_Id_TextChanged);
            // 
            // lOrder_id
            // 
            this.lOrder_id.AutoSize = true;
            this.lOrder_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lOrder_id.Location = new System.Drawing.Point(60, 28);
            this.lOrder_id.Name = "lOrder_id";
            this.lOrder_id.Size = new System.Drawing.Size(75, 20);
            this.lOrder_id.TabIndex = 0;
            this.lOrder_id.Text = "Order Id:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Delete);
            this.groupBox2.Controls.Add(this.Update);
            this.groupBox2.Controls.Add(this.Select);
            this.groupBox2.Controls.Add(this.Insert);
            this.groupBox2.Location = new System.Drawing.Point(1, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1054, 78);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buttons";
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(588, 21);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(212, 43);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(297, 21);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(219, 43);
            this.Update.TabIndex = 2;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Select
            // 
            this.Select.Location = new System.Drawing.Point(856, 21);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(192, 43);
            this.Select.TabIndex = 1;
            this.Select.Text = "Select";
            this.Select.UseVisualStyleBackColor = true;
            this.Select.Click += new System.EventHandler(this.Select_Click);
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(6, 21);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(214, 43);
            this.Insert.TabIndex = 0;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // OrdersGridView
            // 
            this.OrdersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersGridView.Location = new System.Drawing.Point(1, 150);
            this.OrdersGridView.Name = "OrdersGridView";
            this.OrdersGridView.RowHeadersWidth = 51;
            this.OrdersGridView.RowTemplate.Height = 24;
            this.OrdersGridView.Size = new System.Drawing.Size(1054, 297);
            this.OrdersGridView.TabIndex = 6;
            this.OrdersGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrdersGridView_CellContentClick);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 450);
            this.Controls.Add(this.OrdersGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tDriver_Id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lDriver_Id;
        private System.Windows.Forms.TextBox tClient_Id;
        private System.Windows.Forms.Label lClient_Id;
        private System.Windows.Forms.TextBox tOrder_Id;
        private System.Windows.Forms.Label lOrder_id;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Select;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.DataGridView OrdersGridView;
    }
}