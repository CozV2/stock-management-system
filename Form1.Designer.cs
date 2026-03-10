namespace Stock_Manage
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgv_product = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_movements = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_export = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_product
            // 
            this.dgv_product.AllowUserToAddRows = false;
            this.dgv_product.AllowUserToDeleteRows = false;
            this.dgv_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_product.Location = new System.Drawing.Point(423, 71);
            this.dgv_product.Name = "dgv_product";
            this.dgv_product.ReadOnly = true;
            this.dgv_product.RowHeadersVisible = false;
            this.dgv_product.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_product.Size = new System.Drawing.Size(619, 398);
            this.dgv_product.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Nirmala Text", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(464, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 55);
            this.label1.TabIndex = 6;
            this.label1.Text = "Products";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(769, 35);
            this.txt_search.Multiline = true;
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(273, 28);
            this.txt_search.TabIndex = 7;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // btn_movements
            // 
            this.btn_movements.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_movements.Image = global::Stock_Manage.Properties.Resources.fulfillment__1_;
            this.btn_movements.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_movements.Location = new System.Drawing.Point(519, 489);
            this.btn_movements.Name = "btn_movements";
            this.btn_movements.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_movements.Size = new System.Drawing.Size(199, 38);
            this.btn_movements.TabIndex = 10;
            this.btn_movements.Text = "Movements";
            this.btn_movements.UseVisualStyleBackColor = true;
            this.btn_movements.Click += new System.EventHandler(this.btn_movements_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Stock_Manage.Properties.Resources.ready_stock;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(419, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 54);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Stock_Manage.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(738, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_export
            // 
            this.btn_export.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_export.Image = global::Stock_Manage.Properties.Resources.xls__1_;
            this.btn_export.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_export.Location = new System.Drawing.Point(738, 489);
            this.btn_export.Name = "btn_export";
            this.btn_export.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_export.Size = new System.Drawing.Size(199, 38);
            this.btn_export.TabIndex = 4;
            this.btn_export.Text = "Export Data";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Image = global::Stock_Manage.Properties.Resources.bin__1_;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(50, 227);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Padding = new System.Windows.Forms.Padding(20);
            this.btn_delete.Size = new System.Drawing.Size(332, 72);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Delete Product";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Image = global::Stock_Manage.Properties.Resources.pencil__1_;
            this.btn_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_edit.Location = new System.Drawing.Point(50, 149);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Padding = new System.Windows.Forms.Padding(20);
            this.btn_edit.Size = new System.Drawing.Size(332, 72);
            this.btn_edit.TabIndex = 2;
            this.btn_edit.Text = "Edit Product";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Image = global::Stock_Manage.Properties.Resources.plus__1_;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(50, 71);
            this.btn_add.Name = "btn_add";
            this.btn_add.Padding = new System.Windows.Forms.Padding(20);
            this.btn_add.Size = new System.Drawing.Size(332, 72);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Add Product";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditsToolStripMenuItem,
            this.exitProgramToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1079, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.creditsToolStripMenuItem.Text = "About";
            this.creditsToolStripMenuItem.Click += new System.EventHandler(this.creditsToolStripMenuItem_Click);
            // 
            // exitProgramToolStripMenuItem
            // 
            this.exitProgramToolStripMenuItem.Name = "exitProgramToolStripMenuItem";
            this.exitProgramToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.exitProgramToolStripMenuItem.Text = "Exit Program";
            this.exitProgramToolStripMenuItem.Click += new System.EventHandler(this.exitProgramToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 584);
            this.Controls.Add(this.btn_movements);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dgv_product);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_product;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_movements;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitProgramToolStripMenuItem;
    }
}

