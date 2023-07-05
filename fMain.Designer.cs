namespace QuanlyCafe
{
    partial class fMain
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
            this.flpFmain = new System.Windows.Forms.FlowLayoutPanel();
            this.tbAccount = new System.Windows.Forms.TabPage();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.txtAccountUserName = new System.Windows.Forms.TextBox();
            this.cbbAccountStatus = new System.Windows.Forms.ComboBox();
            this.txtAccountId = new System.Windows.Forms.TextBox();
            this.txtAccountPassword = new System.Windows.Forms.TextBox();
            this.txtAccountDisplayName = new System.Windows.Forms.TextBox();
            this.tpFood = new System.Windows.Forms.TabPage();
            this.dgvFood = new System.Windows.Forms.DataGridView();
            this.btnCreateFood = new System.Windows.Forms.Button();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.ccbFoodStatus = new System.Windows.Forms.ComboBox();
            this.txtFoodId = new System.Windows.Forms.TextBox();
            this.cbbFoodCategory = new System.Windows.Forms.ComboBox();
            this.txtFoodPrice = new System.Windows.Forms.NumericUpDown();
            this.tpCategory = new System.Windows.Forms.TabPage();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.btnCreateCategory = new System.Windows.Forms.Button();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.cbbCategoryStatus = new System.Windows.Forms.ComboBox();
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.tpTable = new System.Windows.Forms.TabPage();
            this.dtvTable = new System.Windows.Forms.DataGridView();
            this.btnCreateTable = new System.Windows.Forms.Button();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.cbbTableStatus = new System.Windows.Forms.ComboBox();
            this.txtTableId = new System.Windows.Forms.TextBox();
            this.cbbAreaTable = new System.Windows.Forms.ComboBox();
            this.tpArea = new System.Windows.Forms.TabPage();
            this.dgvArea = new System.Windows.Forms.DataGridView();
            this.btnCreateArea = new System.Windows.Forms.Button();
            this.txtAreaName = new System.Windows.Forms.TextBox();
            this.ccbAreaStatus = new System.Windows.Forms.ComboBox();
            this.txtAreaId = new System.Windows.Forms.TextBox();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.flpFmain.SuspendLayout();
            this.tbAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.tpFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFoodPrice)).BeginInit();
            this.tpCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.tpTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvTable)).BeginInit();
            this.tpArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArea)).BeginInit();
            this.tcMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpFmain
            // 
            this.flpFmain.Controls.Add(this.tcMain);
            this.flpFmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpFmain.Location = new System.Drawing.Point(0, 0);
            this.flpFmain.Name = "flpFmain";
            this.flpFmain.Size = new System.Drawing.Size(784, 461);
            this.flpFmain.TabIndex = 0;
            // 
            // tbAccount
            // 
            this.tbAccount.Controls.Add(this.txtAccountDisplayName);
            this.tbAccount.Controls.Add(this.txtAccountPassword);
            this.tbAccount.Controls.Add(this.txtAccountId);
            this.tbAccount.Controls.Add(this.txtAccountUserName);
            this.tbAccount.Controls.Add(this.cbbAccountStatus);
            this.tbAccount.Controls.Add(this.btnCreateAccount);
            this.tbAccount.Controls.Add(this.dgvAccount);
            this.tbAccount.Location = new System.Drawing.Point(4, 22);
            this.tbAccount.Name = "tbAccount";
            this.tbAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tbAccount.Size = new System.Drawing.Size(761, 420);
            this.tbAccount.TabIndex = 5;
            this.tbAccount.Text = "Tài khoản";
            this.tbAccount.UseVisualStyleBackColor = true;
            // 
            // dgvAccount
            // 
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Location = new System.Drawing.Point(0, 104);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.Size = new System.Drawing.Size(761, 316);
            this.dgvAccount.TabIndex = 2;
            this.dgvAccount.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAccount_CellFormatting);
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(602, 3);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(75, 50);
            this.btnCreateAccount.TabIndex = 5;
            this.btnCreateAccount.Text = "Thêm";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // txtAccountUserName
            // 
            this.txtAccountUserName.Location = new System.Drawing.Point(234, 7);
            this.txtAccountUserName.Name = "txtAccountUserName";
            this.txtAccountUserName.Size = new System.Drawing.Size(178, 20);
            this.txtAccountUserName.TabIndex = 10;
            // 
            // cbbAccountStatus
            // 
            this.cbbAccountStatus.FormattingEnabled = true;
            this.cbbAccountStatus.Location = new System.Drawing.Point(418, 6);
            this.cbbAccountStatus.Name = "cbbAccountStatus";
            this.cbbAccountStatus.Size = new System.Drawing.Size(178, 21);
            this.cbbAccountStatus.TabIndex = 11;
            // 
            // txtAccountId
            // 
            this.txtAccountId.Enabled = false;
            this.txtAccountId.Location = new System.Drawing.Point(50, 7);
            this.txtAccountId.Name = "txtAccountId";
            this.txtAccountId.Size = new System.Drawing.Size(178, 20);
            this.txtAccountId.TabIndex = 12;
            this.txtAccountId.Visible = false;
            // 
            // txtAccountPassword
            // 
            this.txtAccountPassword.Location = new System.Drawing.Point(234, 33);
            this.txtAccountPassword.Name = "txtAccountPassword";
            this.txtAccountPassword.Size = new System.Drawing.Size(178, 20);
            this.txtAccountPassword.TabIndex = 13;
            // 
            // txtAccountDisplayName
            // 
            this.txtAccountDisplayName.Location = new System.Drawing.Point(418, 33);
            this.txtAccountDisplayName.Name = "txtAccountDisplayName";
            this.txtAccountDisplayName.Size = new System.Drawing.Size(178, 20);
            this.txtAccountDisplayName.TabIndex = 14;
            // 
            // tpFood
            // 
            this.tpFood.Controls.Add(this.txtFoodPrice);
            this.tpFood.Controls.Add(this.cbbFoodCategory);
            this.tpFood.Controls.Add(this.txtFoodId);
            this.tpFood.Controls.Add(this.txtFoodName);
            this.tpFood.Controls.Add(this.ccbFoodStatus);
            this.tpFood.Controls.Add(this.btnCreateFood);
            this.tpFood.Controls.Add(this.dgvFood);
            this.tpFood.Location = new System.Drawing.Point(4, 22);
            this.tpFood.Name = "tpFood";
            this.tpFood.Padding = new System.Windows.Forms.Padding(3);
            this.tpFood.Size = new System.Drawing.Size(761, 420);
            this.tpFood.TabIndex = 3;
            this.tpFood.Text = "Món ăn";
            this.tpFood.UseVisualStyleBackColor = true;
            // 
            // dgvFood
            // 
            this.dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFood.Location = new System.Drawing.Point(0, 104);
            this.dgvFood.Name = "dgvFood";
            this.dgvFood.Size = new System.Drawing.Size(761, 316);
            this.dgvFood.TabIndex = 2;
            // 
            // btnCreateFood
            // 
            this.btnCreateFood.Location = new System.Drawing.Point(602, 3);
            this.btnCreateFood.Name = "btnCreateFood";
            this.btnCreateFood.Size = new System.Drawing.Size(75, 49);
            this.btnCreateFood.TabIndex = 5;
            this.btnCreateFood.Text = "Thêm";
            this.btnCreateFood.UseVisualStyleBackColor = true;
            this.btnCreateFood.Click += new System.EventHandler(this.btnCreateFood_Click);
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(231, 6);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(178, 20);
            this.txtFoodName.TabIndex = 10;
            // 
            // ccbFoodStatus
            // 
            this.ccbFoodStatus.FormattingEnabled = true;
            this.ccbFoodStatus.Location = new System.Drawing.Point(415, 5);
            this.ccbFoodStatus.Name = "ccbFoodStatus";
            this.ccbFoodStatus.Size = new System.Drawing.Size(178, 21);
            this.ccbFoodStatus.TabIndex = 11;
            // 
            // txtFoodId
            // 
            this.txtFoodId.Enabled = false;
            this.txtFoodId.Location = new System.Drawing.Point(47, 6);
            this.txtFoodId.Name = "txtFoodId";
            this.txtFoodId.Size = new System.Drawing.Size(178, 20);
            this.txtFoodId.TabIndex = 12;
            this.txtFoodId.Visible = false;
            // 
            // cbbFoodCategory
            // 
            this.cbbFoodCategory.FormattingEnabled = true;
            this.cbbFoodCategory.Location = new System.Drawing.Point(415, 31);
            this.cbbFoodCategory.Name = "cbbFoodCategory";
            this.cbbFoodCategory.Size = new System.Drawing.Size(178, 21);
            this.cbbFoodCategory.TabIndex = 14;
            // 
            // txtFoodPrice
            // 
            this.txtFoodPrice.Location = new System.Drawing.Point(231, 32);
            this.txtFoodPrice.Name = "txtFoodPrice";
            this.txtFoodPrice.Size = new System.Drawing.Size(178, 20);
            this.txtFoodPrice.TabIndex = 15;
            // 
            // tpCategory
            // 
            this.tpCategory.Controls.Add(this.txtCategoryId);
            this.tpCategory.Controls.Add(this.txtCategoryName);
            this.tpCategory.Controls.Add(this.cbbCategoryStatus);
            this.tpCategory.Controls.Add(this.btnCreateCategory);
            this.tpCategory.Controls.Add(this.dgvCategory);
            this.tpCategory.Location = new System.Drawing.Point(4, 22);
            this.tpCategory.Name = "tpCategory";
            this.tpCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tpCategory.Size = new System.Drawing.Size(761, 420);
            this.tpCategory.TabIndex = 2;
            this.tpCategory.Text = "Loại món ăn";
            this.tpCategory.UseVisualStyleBackColor = true;
            // 
            // dgvCategory
            // 
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Location = new System.Drawing.Point(0, 104);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.Size = new System.Drawing.Size(761, 316);
            this.dgvCategory.TabIndex = 1;
            // 
            // btnCreateCategory
            // 
            this.btnCreateCategory.Location = new System.Drawing.Point(602, 3);
            this.btnCreateCategory.Name = "btnCreateCategory";
            this.btnCreateCategory.Size = new System.Drawing.Size(75, 23);
            this.btnCreateCategory.TabIndex = 5;
            this.btnCreateCategory.Text = "Thêm";
            this.btnCreateCategory.UseVisualStyleBackColor = true;
            this.btnCreateCategory.Click += new System.EventHandler(this.btnCreateCategory_Click);
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(234, 7);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(178, 20);
            this.txtCategoryName.TabIndex = 7;
            // 
            // cbbCategoryStatus
            // 
            this.cbbCategoryStatus.FormattingEnabled = true;
            this.cbbCategoryStatus.Location = new System.Drawing.Point(418, 6);
            this.cbbCategoryStatus.Name = "cbbCategoryStatus";
            this.cbbCategoryStatus.Size = new System.Drawing.Size(178, 21);
            this.cbbCategoryStatus.TabIndex = 8;
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.Enabled = false;
            this.txtCategoryId.Location = new System.Drawing.Point(50, 7);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.Size = new System.Drawing.Size(178, 20);
            this.txtCategoryId.TabIndex = 9;
            this.txtCategoryId.Visible = false;
            // 
            // tpTable
            // 
            this.tpTable.Controls.Add(this.cbbAreaTable);
            this.tpTable.Controls.Add(this.txtTableId);
            this.tpTable.Controls.Add(this.txtTableName);
            this.tpTable.Controls.Add(this.cbbTableStatus);
            this.tpTable.Controls.Add(this.btnCreateTable);
            this.tpTable.Controls.Add(this.dtvTable);
            this.tpTable.Location = new System.Drawing.Point(4, 22);
            this.tpTable.Name = "tpTable";
            this.tpTable.Padding = new System.Windows.Forms.Padding(3);
            this.tpTable.Size = new System.Drawing.Size(761, 420);
            this.tpTable.TabIndex = 1;
            this.tpTable.Text = "Bàn ăn";
            this.tpTable.UseVisualStyleBackColor = true;
            // 
            // dtvTable
            // 
            this.dtvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvTable.Location = new System.Drawing.Point(0, 104);
            this.dtvTable.Name = "dtvTable";
            this.dtvTable.Size = new System.Drawing.Size(761, 316);
            this.dtvTable.TabIndex = 1;
            // 
            // btnCreateTable
            // 
            this.btnCreateTable.Location = new System.Drawing.Point(602, 3);
            this.btnCreateTable.Name = "btnCreateTable";
            this.btnCreateTable.Size = new System.Drawing.Size(75, 51);
            this.btnCreateTable.TabIndex = 5;
            this.btnCreateTable.Text = "Thêm";
            this.btnCreateTable.UseVisualStyleBackColor = true;
            this.btnCreateTable.Click += new System.EventHandler(this.btnCreateTable_Click);
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(418, 34);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(178, 20);
            this.txtTableName.TabIndex = 7;
            // 
            // cbbTableStatus
            // 
            this.cbbTableStatus.FormattingEnabled = true;
            this.cbbTableStatus.Location = new System.Drawing.Point(418, 6);
            this.cbbTableStatus.Name = "cbbTableStatus";
            this.cbbTableStatus.Size = new System.Drawing.Size(178, 21);
            this.cbbTableStatus.TabIndex = 8;
            // 
            // txtTableId
            // 
            this.txtTableId.Enabled = false;
            this.txtTableId.Location = new System.Drawing.Point(234, 34);
            this.txtTableId.Name = "txtTableId";
            this.txtTableId.Size = new System.Drawing.Size(178, 20);
            this.txtTableId.TabIndex = 9;
            this.txtTableId.Visible = false;
            // 
            // cbbAreaTable
            // 
            this.cbbAreaTable.FormattingEnabled = true;
            this.cbbAreaTable.Location = new System.Drawing.Point(234, 7);
            this.cbbAreaTable.Name = "cbbAreaTable";
            this.cbbAreaTable.Size = new System.Drawing.Size(178, 21);
            this.cbbAreaTable.TabIndex = 10;
            // 
            // tpArea
            // 
            this.tpArea.Controls.Add(this.txtAreaId);
            this.tpArea.Controls.Add(this.txtAreaName);
            this.tpArea.Controls.Add(this.ccbAreaStatus);
            this.tpArea.Controls.Add(this.btnCreateArea);
            this.tpArea.Controls.Add(this.dgvArea);
            this.tpArea.Location = new System.Drawing.Point(4, 22);
            this.tpArea.Name = "tpArea";
            this.tpArea.Padding = new System.Windows.Forms.Padding(3);
            this.tpArea.Size = new System.Drawing.Size(761, 420);
            this.tpArea.TabIndex = 0;
            this.tpArea.Text = "Khu vực";
            this.tpArea.UseVisualStyleBackColor = true;
            // 
            // dgvArea
            // 
            this.dgvArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArea.Location = new System.Drawing.Point(0, 104);
            this.dgvArea.Name = "dgvArea";
            this.dgvArea.Size = new System.Drawing.Size(761, 316);
            this.dgvArea.TabIndex = 0;
            // 
            // btnCreateArea
            // 
            this.btnCreateArea.Location = new System.Drawing.Point(602, 3);
            this.btnCreateArea.Name = "btnCreateArea";
            this.btnCreateArea.Size = new System.Drawing.Size(75, 23);
            this.btnCreateArea.TabIndex = 2;
            this.btnCreateArea.Text = "Thêm";
            this.btnCreateArea.UseVisualStyleBackColor = true;
            this.btnCreateArea.Click += new System.EventHandler(this.btnCreateArea_Click);
            // 
            // txtAreaName
            // 
            this.txtAreaName.Location = new System.Drawing.Point(234, 7);
            this.txtAreaName.Name = "txtAreaName";
            this.txtAreaName.Size = new System.Drawing.Size(178, 20);
            this.txtAreaName.TabIndex = 4;
            // 
            // ccbAreaStatus
            // 
            this.ccbAreaStatus.FormattingEnabled = true;
            this.ccbAreaStatus.Location = new System.Drawing.Point(418, 6);
            this.ccbAreaStatus.Name = "ccbAreaStatus";
            this.ccbAreaStatus.Size = new System.Drawing.Size(178, 21);
            this.ccbAreaStatus.TabIndex = 5;
            // 
            // txtAreaId
            // 
            this.txtAreaId.Enabled = false;
            this.txtAreaId.Location = new System.Drawing.Point(50, 7);
            this.txtAreaId.Name = "txtAreaId";
            this.txtAreaId.Size = new System.Drawing.Size(178, 20);
            this.txtAreaId.TabIndex = 6;
            this.txtAreaId.Visible = false;
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpArea);
            this.tcMain.Controls.Add(this.tpTable);
            this.tcMain.Controls.Add(this.tpCategory);
            this.tcMain.Controls.Add(this.tpFood);
            this.tcMain.Controls.Add(this.tbAccount);
            this.tcMain.Location = new System.Drawing.Point(3, 3);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(769, 446);
            this.tcMain.TabIndex = 0;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.flpFmain);
            this.Name = "fMain";
            this.Text = "fMain";
            this.flpFmain.ResumeLayout(false);
            this.tbAccount.ResumeLayout(false);
            this.tbAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.tpFood.ResumeLayout(false);
            this.tpFood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFoodPrice)).EndInit();
            this.tpCategory.ResumeLayout(false);
            this.tpCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.tpTable.ResumeLayout(false);
            this.tpTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvTable)).EndInit();
            this.tpArea.ResumeLayout(false);
            this.tpArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArea)).EndInit();
            this.tcMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpFmain;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpArea;
        private System.Windows.Forms.TextBox txtAreaId;
        private System.Windows.Forms.TextBox txtAreaName;
        private System.Windows.Forms.ComboBox ccbAreaStatus;
        private System.Windows.Forms.Button btnCreateArea;
        private System.Windows.Forms.DataGridView dgvArea;
        private System.Windows.Forms.TabPage tpTable;
        private System.Windows.Forms.ComboBox cbbAreaTable;
        private System.Windows.Forms.TextBox txtTableId;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.ComboBox cbbTableStatus;
        private System.Windows.Forms.Button btnCreateTable;
        private System.Windows.Forms.DataGridView dtvTable;
        private System.Windows.Forms.TabPage tpCategory;
        private System.Windows.Forms.TextBox txtCategoryId;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.ComboBox cbbCategoryStatus;
        private System.Windows.Forms.Button btnCreateCategory;
        private System.Windows.Forms.DataGridView dgvCategory;
        private System.Windows.Forms.TabPage tpFood;
        private System.Windows.Forms.NumericUpDown txtFoodPrice;
        private System.Windows.Forms.ComboBox cbbFoodCategory;
        private System.Windows.Forms.TextBox txtFoodId;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.ComboBox ccbFoodStatus;
        private System.Windows.Forms.Button btnCreateFood;
        private System.Windows.Forms.DataGridView dgvFood;
        private System.Windows.Forms.TabPage tbAccount;
        private System.Windows.Forms.TextBox txtAccountDisplayName;
        private System.Windows.Forms.TextBox txtAccountPassword;
        private System.Windows.Forms.TextBox txtAccountId;
        private System.Windows.Forms.TextBox txtAccountUserName;
        private System.Windows.Forms.ComboBox cbbAccountStatus;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.DataGridView dgvAccount;
    }
}