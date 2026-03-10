namespace Stock_Manage
{
    partial class frm_produto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_produto));
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_category = new System.Windows.Forms.TextBox();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(78, 30);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(248, 20);
            this.txt_name.TabIndex = 0;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            // 
            // txt_category
            // 
            this.txt_category.Location = new System.Drawing.Point(78, 78);
            this.txt_category.Name = "txt_category";
            this.txt_category.Size = new System.Drawing.Size(248, 20);
            this.txt_category.TabIndex = 1;
            this.txt_category.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(78, 182);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(248, 20);
            this.txt_quantity.TabIndex = 3;
            this.txt_quantity.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(78, 134);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(248, 20);
            this.txt_price.TabIndex = 2;
            this.txt_price.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Category:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quantity:";
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_save.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Image = global::Stock_Manage.Properties.Resources.data_storage__1_;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(94, 217);
            this.btn_save.Name = "btn_save";
            this.btn_save.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_save.Size = new System.Drawing.Size(167, 37);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "Save Product";
            this.btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // frm_produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 276);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_category);
            this.Controls.Add(this.txt_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Management System - Add/Edit";
            this.Load += new System.EventHandler(this.frm_produto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_category;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_save;
    }
}