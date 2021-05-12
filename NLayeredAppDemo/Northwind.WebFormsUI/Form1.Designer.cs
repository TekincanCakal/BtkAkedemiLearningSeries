
namespace Northwind.WebFormsUI
{
    partial class Form1
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
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbAdd = new System.Windows.Forms.TabPage();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxQuentityPerUnitAdd = new System.Windows.Forms.TextBox();
            this.tbxUnitsInStockAdd = new System.Windows.Forms.TextBox();
            this.tbxUnitPriceAdd = new System.Windows.Forms.TextBox();
            this.cbxCategoryIdAdd = new System.Windows.Forms.ComboBox();
            this.tbxProductNameAdd = new System.Windows.Forms.TextBox();
            this.lblQuentityPerUnitAdd = new System.Windows.Forms.Label();
            this.lblUnitsInStockAdd = new System.Windows.Forms.Label();
            this.lblUnitPriceAdd = new System.Windows.Forms.Label();
            this.lblCategoryIdAdd = new System.Windows.Forms.Label();
            this.lblProductNameAdd = new System.Windows.Forms.Label();
            this.tpSearch = new System.Windows.Forms.TabPage();
            this.tbUpdate = new System.Windows.Forms.TabPage();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxQuentityPerUnitUpdate = new System.Windows.Forms.TextBox();
            this.tbxUnitsInStockUpdate = new System.Windows.Forms.TextBox();
            this.tbxUnitPriceUpdate = new System.Windows.Forms.TextBox();
            this.cbxCategoryIdUpdate = new System.Windows.Forms.ComboBox();
            this.tbxProductNameUpdate = new System.Windows.Forms.TextBox();
            this.lblQuentityPerUnitUpdate = new System.Windows.Forms.Label();
            this.lblUnitsInStockUpdate = new System.Windows.Forms.Label();
            this.lblUnitPriceUpdate = new System.Windows.Forms.Label();
            this.lblCategoryIdUpdate = new System.Windows.Forms.Label();
            this.lblProductNameUpdate = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tbAdd.SuspendLayout();
            this.tpSearch.SuspendLayout();
            this.tbUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProduct
            // 
            this.dgwProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(12, 251);
            this.dgwProduct.Margin = new System.Windows.Forms.Padding(4);
            this.dgwProduct.MultiSelect = false;
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.ReadOnly = true;
            this.dgwProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwProduct.Size = new System.Drawing.Size(495, 265);
            this.dgwProduct.TabIndex = 0;
            this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(96, 42);
            this.tbxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(423, 26);
            this.tbxSearch.TabIndex = 1;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(7, 45);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(81, 19);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Ürün Adı";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(96, 7);
            this.cbxCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(423, 27);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(7, 10);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(81, 19);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Kategori";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbAdd);
            this.tabControl1.Controls.Add(this.tpSearch);
            this.tabControl1.Controls.Add(this.tbUpdate);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(534, 236);
            this.tabControl1.TabIndex = 4;
            // 
            // tbAdd
            // 
            this.tbAdd.Controls.Add(this.btnAdd);
            this.tbAdd.Controls.Add(this.tbxQuentityPerUnitAdd);
            this.tbAdd.Controls.Add(this.tbxUnitsInStockAdd);
            this.tbAdd.Controls.Add(this.tbxUnitPriceAdd);
            this.tbAdd.Controls.Add(this.cbxCategoryIdAdd);
            this.tbAdd.Controls.Add(this.tbxProductNameAdd);
            this.tbAdd.Controls.Add(this.lblQuentityPerUnitAdd);
            this.tbAdd.Controls.Add(this.lblUnitsInStockAdd);
            this.tbAdd.Controls.Add(this.lblUnitPriceAdd);
            this.tbAdd.Controls.Add(this.lblCategoryIdAdd);
            this.tbAdd.Controls.Add(this.lblProductNameAdd);
            this.tbAdd.Location = new System.Drawing.Point(4, 28);
            this.tbAdd.Name = "tbAdd";
            this.tbAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tbAdd.Size = new System.Drawing.Size(526, 204);
            this.tbAdd.TabIndex = 1;
            this.tbAdd.Text = "Ekle";
            this.tbAdd.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(117, 168);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(398, 26);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxQuentityPerUnitAdd
            // 
            this.tbxQuentityPerUnitAdd.Location = new System.Drawing.Point(117, 135);
            this.tbxQuentityPerUnitAdd.Name = "tbxQuentityPerUnitAdd";
            this.tbxQuentityPerUnitAdd.Size = new System.Drawing.Size(398, 26);
            this.tbxQuentityPerUnitAdd.TabIndex = 9;
            // 
            // tbxUnitsInStockAdd
            // 
            this.tbxUnitsInStockAdd.Location = new System.Drawing.Point(117, 103);
            this.tbxUnitsInStockAdd.Name = "tbxUnitsInStockAdd";
            this.tbxUnitsInStockAdd.Size = new System.Drawing.Size(398, 26);
            this.tbxUnitsInStockAdd.TabIndex = 8;
            // 
            // tbxUnitPriceAdd
            // 
            this.tbxUnitPriceAdd.Location = new System.Drawing.Point(117, 71);
            this.tbxUnitPriceAdd.Name = "tbxUnitPriceAdd";
            this.tbxUnitPriceAdd.Size = new System.Drawing.Size(398, 26);
            this.tbxUnitPriceAdd.TabIndex = 7;
            // 
            // cbxCategoryIdAdd
            // 
            this.cbxCategoryIdAdd.FormattingEnabled = true;
            this.cbxCategoryIdAdd.Location = new System.Drawing.Point(117, 38);
            this.cbxCategoryIdAdd.Name = "cbxCategoryIdAdd";
            this.cbxCategoryIdAdd.Size = new System.Drawing.Size(398, 27);
            this.cbxCategoryIdAdd.TabIndex = 6;
            // 
            // tbxProductNameAdd
            // 
            this.tbxProductNameAdd.Location = new System.Drawing.Point(117, 6);
            this.tbxProductNameAdd.Name = "tbxProductNameAdd";
            this.tbxProductNameAdd.Size = new System.Drawing.Size(398, 26);
            this.tbxProductNameAdd.TabIndex = 5;
            // 
            // lblQuentityPerUnitAdd
            // 
            this.lblQuentityPerUnitAdd.AutoSize = true;
            this.lblQuentityPerUnitAdd.Location = new System.Drawing.Point(3, 138);
            this.lblQuentityPerUnitAdd.Name = "lblQuentityPerUnitAdd";
            this.lblQuentityPerUnitAdd.Size = new System.Drawing.Size(108, 19);
            this.lblQuentityPerUnitAdd.TabIndex = 4;
            this.lblQuentityPerUnitAdd.Text = "Birim Adedi";
            // 
            // lblUnitsInStockAdd
            // 
            this.lblUnitsInStockAdd.AutoSize = true;
            this.lblUnitsInStockAdd.Location = new System.Drawing.Point(3, 106);
            this.lblUnitsInStockAdd.Name = "lblUnitsInStockAdd";
            this.lblUnitsInStockAdd.Size = new System.Drawing.Size(99, 19);
            this.lblUnitsInStockAdd.TabIndex = 3;
            this.lblUnitsInStockAdd.Text = "Stok Adedi";
            // 
            // lblUnitPriceAdd
            // 
            this.lblUnitPriceAdd.AutoSize = true;
            this.lblUnitPriceAdd.Location = new System.Drawing.Point(3, 74);
            this.lblUnitPriceAdd.Name = "lblUnitPriceAdd";
            this.lblUnitPriceAdd.Size = new System.Drawing.Size(54, 19);
            this.lblUnitPriceAdd.TabIndex = 2;
            this.lblUnitPriceAdd.Text = "Fiyat";
            // 
            // lblCategoryIdAdd
            // 
            this.lblCategoryIdAdd.AutoSize = true;
            this.lblCategoryIdAdd.Location = new System.Drawing.Point(3, 41);
            this.lblCategoryIdAdd.Name = "lblCategoryIdAdd";
            this.lblCategoryIdAdd.Size = new System.Drawing.Size(81, 19);
            this.lblCategoryIdAdd.TabIndex = 1;
            this.lblCategoryIdAdd.Text = "Kategori";
            // 
            // lblProductNameAdd
            // 
            this.lblProductNameAdd.AutoSize = true;
            this.lblProductNameAdd.Location = new System.Drawing.Point(3, 9);
            this.lblProductNameAdd.Name = "lblProductNameAdd";
            this.lblProductNameAdd.Size = new System.Drawing.Size(81, 19);
            this.lblProductNameAdd.TabIndex = 0;
            this.lblProductNameAdd.Text = "Ürün Adı";
            // 
            // tpSearch
            // 
            this.tpSearch.Controls.Add(this.tbxSearch);
            this.tpSearch.Controls.Add(this.cbxCategory);
            this.tpSearch.Controls.Add(this.lblSearch);
            this.tpSearch.Controls.Add(this.lblCategory);
            this.tpSearch.Location = new System.Drawing.Point(4, 28);
            this.tpSearch.Name = "tpSearch";
            this.tpSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tpSearch.Size = new System.Drawing.Size(526, 204);
            this.tpSearch.TabIndex = 0;
            this.tpSearch.Text = "Ara";
            this.tpSearch.UseVisualStyleBackColor = true;
            // 
            // tbUpdate
            // 
            this.tbUpdate.Controls.Add(this.btnUpdate);
            this.tbUpdate.Controls.Add(this.tbxQuentityPerUnitUpdate);
            this.tbUpdate.Controls.Add(this.tbxUnitsInStockUpdate);
            this.tbUpdate.Controls.Add(this.tbxUnitPriceUpdate);
            this.tbUpdate.Controls.Add(this.cbxCategoryIdUpdate);
            this.tbUpdate.Controls.Add(this.tbxProductNameUpdate);
            this.tbUpdate.Controls.Add(this.lblQuentityPerUnitUpdate);
            this.tbUpdate.Controls.Add(this.lblUnitsInStockUpdate);
            this.tbUpdate.Controls.Add(this.lblUnitPriceUpdate);
            this.tbUpdate.Controls.Add(this.lblCategoryIdUpdate);
            this.tbUpdate.Controls.Add(this.lblProductNameUpdate);
            this.tbUpdate.Location = new System.Drawing.Point(4, 28);
            this.tbUpdate.Name = "tbUpdate";
            this.tbUpdate.Size = new System.Drawing.Size(526, 204);
            this.tbUpdate.TabIndex = 2;
            this.tbUpdate.Text = "Güncelle";
            this.tbUpdate.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(117, 172);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(398, 26);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxQuentityPerUnitUpdate
            // 
            this.tbxQuentityPerUnitUpdate.Location = new System.Drawing.Point(117, 139);
            this.tbxQuentityPerUnitUpdate.Name = "tbxQuentityPerUnitUpdate";
            this.tbxQuentityPerUnitUpdate.Size = new System.Drawing.Size(398, 26);
            this.tbxQuentityPerUnitUpdate.TabIndex = 20;
            // 
            // tbxUnitsInStockUpdate
            // 
            this.tbxUnitsInStockUpdate.Location = new System.Drawing.Point(117, 107);
            this.tbxUnitsInStockUpdate.Name = "tbxUnitsInStockUpdate";
            this.tbxUnitsInStockUpdate.Size = new System.Drawing.Size(398, 26);
            this.tbxUnitsInStockUpdate.TabIndex = 19;
            // 
            // tbxUnitPriceUpdate
            // 
            this.tbxUnitPriceUpdate.Location = new System.Drawing.Point(117, 75);
            this.tbxUnitPriceUpdate.Name = "tbxUnitPriceUpdate";
            this.tbxUnitPriceUpdate.Size = new System.Drawing.Size(398, 26);
            this.tbxUnitPriceUpdate.TabIndex = 18;
            // 
            // cbxCategoryIdUpdate
            // 
            this.cbxCategoryIdUpdate.FormattingEnabled = true;
            this.cbxCategoryIdUpdate.Location = new System.Drawing.Point(117, 42);
            this.cbxCategoryIdUpdate.Name = "cbxCategoryIdUpdate";
            this.cbxCategoryIdUpdate.Size = new System.Drawing.Size(398, 27);
            this.cbxCategoryIdUpdate.TabIndex = 17;
            // 
            // tbxProductNameUpdate
            // 
            this.tbxProductNameUpdate.Location = new System.Drawing.Point(117, 10);
            this.tbxProductNameUpdate.Name = "tbxProductNameUpdate";
            this.tbxProductNameUpdate.Size = new System.Drawing.Size(398, 26);
            this.tbxProductNameUpdate.TabIndex = 16;
            // 
            // lblQuentityPerUnitUpdate
            // 
            this.lblQuentityPerUnitUpdate.AutoSize = true;
            this.lblQuentityPerUnitUpdate.Location = new System.Drawing.Point(3, 142);
            this.lblQuentityPerUnitUpdate.Name = "lblQuentityPerUnitUpdate";
            this.lblQuentityPerUnitUpdate.Size = new System.Drawing.Size(108, 19);
            this.lblQuentityPerUnitUpdate.TabIndex = 15;
            this.lblQuentityPerUnitUpdate.Text = "Birim Adedi";
            // 
            // lblUnitsInStockUpdate
            // 
            this.lblUnitsInStockUpdate.AutoSize = true;
            this.lblUnitsInStockUpdate.Location = new System.Drawing.Point(3, 110);
            this.lblUnitsInStockUpdate.Name = "lblUnitsInStockUpdate";
            this.lblUnitsInStockUpdate.Size = new System.Drawing.Size(99, 19);
            this.lblUnitsInStockUpdate.TabIndex = 14;
            this.lblUnitsInStockUpdate.Text = "Stok Adedi";
            // 
            // lblUnitPriceUpdate
            // 
            this.lblUnitPriceUpdate.AutoSize = true;
            this.lblUnitPriceUpdate.Location = new System.Drawing.Point(3, 78);
            this.lblUnitPriceUpdate.Name = "lblUnitPriceUpdate";
            this.lblUnitPriceUpdate.Size = new System.Drawing.Size(54, 19);
            this.lblUnitPriceUpdate.TabIndex = 13;
            this.lblUnitPriceUpdate.Text = "Fiyat";
            // 
            // lblCategoryIdUpdate
            // 
            this.lblCategoryIdUpdate.AutoSize = true;
            this.lblCategoryIdUpdate.Location = new System.Drawing.Point(3, 45);
            this.lblCategoryIdUpdate.Name = "lblCategoryIdUpdate";
            this.lblCategoryIdUpdate.Size = new System.Drawing.Size(81, 19);
            this.lblCategoryIdUpdate.TabIndex = 12;
            this.lblCategoryIdUpdate.Text = "Kategori";
            // 
            // lblProductNameUpdate
            // 
            this.lblProductNameUpdate.AutoSize = true;
            this.lblProductNameUpdate.Location = new System.Drawing.Point(3, 13);
            this.lblProductNameUpdate.Name = "lblProductNameUpdate";
            this.lblProductNameUpdate.Size = new System.Drawing.Size(81, 19);
            this.lblProductNameUpdate.TabIndex = 11;
            this.lblProductNameUpdate.Text = "Ürün Adı";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(514, 254);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(28, 260);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 526);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dgwProduct);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tbAdd.ResumeLayout(false);
            this.tbAdd.PerformLayout();
            this.tpSearch.ResumeLayout(false);
            this.tpSearch.PerformLayout();
            this.tbUpdate.ResumeLayout(false);
            this.tbUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbAdd;
        private System.Windows.Forms.Label lblUnitsInStockAdd;
        private System.Windows.Forms.Label lblUnitPriceAdd;
        private System.Windows.Forms.Label lblCategoryIdAdd;
        private System.Windows.Forms.Label lblProductNameAdd;
        private System.Windows.Forms.TabPage tpSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxQuentityPerUnitAdd;
        private System.Windows.Forms.TextBox tbxUnitsInStockAdd;
        private System.Windows.Forms.TextBox tbxUnitPriceAdd;
        private System.Windows.Forms.ComboBox cbxCategoryIdAdd;
        private System.Windows.Forms.TextBox tbxProductNameAdd;
        private System.Windows.Forms.Label lblQuentityPerUnitAdd;
        private System.Windows.Forms.TabPage tbUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxQuentityPerUnitUpdate;
        private System.Windows.Forms.TextBox tbxUnitsInStockUpdate;
        private System.Windows.Forms.TextBox tbxUnitPriceUpdate;
        private System.Windows.Forms.ComboBox cbxCategoryIdUpdate;
        private System.Windows.Forms.TextBox tbxProductNameUpdate;
        private System.Windows.Forms.Label lblQuentityPerUnitUpdate;
        private System.Windows.Forms.Label lblUnitsInStockUpdate;
        private System.Windows.Forms.Label lblUnitPriceUpdate;
        private System.Windows.Forms.Label lblCategoryIdUpdate;
        private System.Windows.Forms.Label lblProductNameUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}

