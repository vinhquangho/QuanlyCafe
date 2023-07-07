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
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpArea = new System.Windows.Forms.TabPage();
            this.btnUpdateArea = new System.Windows.Forms.Button();
            this.txtAreaId = new System.Windows.Forms.TextBox();
            this.txtAreaName = new System.Windows.Forms.TextBox();
            this.ccbAreaStatus = new System.Windows.Forms.ComboBox();
            this.btnCreateArea = new System.Windows.Forms.Button();
            this.dgvArea = new System.Windows.Forms.DataGridView();
            this.tpTable = new System.Windows.Forms.TabPage();
            this.btnUpdateTable = new System.Windows.Forms.Button();
            this.cbbAreaTable = new System.Windows.Forms.ComboBox();
            this.txtTableId = new System.Windows.Forms.TextBox();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.cbbTableStatus = new System.Windows.Forms.ComboBox();
            this.btnCreateTable = new System.Windows.Forms.Button();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.tpCategory = new System.Windows.Forms.TabPage();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.cbbCategoryStatus = new System.Windows.Forms.ComboBox();
            this.btnCreateCategory = new System.Windows.Forms.Button();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.tpFood = new System.Windows.Forms.TabPage();
            this.btnUpdateFood = new System.Windows.Forms.Button();
            this.txtFoodPrice = new System.Windows.Forms.NumericUpDown();
            this.cbbFoodCategory = new System.Windows.Forms.ComboBox();
            this.txtFoodId = new System.Windows.Forms.TextBox();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.ccbFoodStatus = new System.Windows.Forms.ComboBox();
            this.btnCreateFood = new System.Windows.Forms.Button();
            this.dgvFood = new System.Windows.Forms.DataGridView();
            this.tbAccount = new System.Windows.Forms.TabPage();
            this.btnUpdateAccount = new System.Windows.Forms.Button();
            this.txtAccountDisplayName = new System.Windows.Forms.TextBox();
            this.txtAccountPassword = new System.Windows.Forms.TextBox();
            this.txtAccountId = new System.Windows.Forms.TextBox();
            this.txtAccountUserName = new System.Windows.Forms.TextBox();
            this.cbbAccountStatus = new System.Windows.Forms.ComboBox();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.flpFmain.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tpArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArea)).BeginInit();
            this.tpTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.tpCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.tpFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFoodPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
            this.tbAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
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
            this.tcMain.SelectedIndexChanged += new System.EventHandler(this.tcMain_SelectedIndexChanged);
            // 
            // tpArea
            // 
            this.tpArea.Controls.Add(this.btnUpdateArea);
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
            // btnUpdateArea
            // 
            this.btnUpdateArea.Location = new System.Drawing.Point(680, 8);
            this.btnUpdateArea.Name = "btnUpdateArea";
            this.btnUpdateArea.Size = new System.Drawing.Size(75, 21);
            this.btnUpdateArea.TabIndex = 7;
            this.btnUpdateArea.Text = "Sửa";
            this.btnUpdateArea.UseVisualStyleBackColor = true;
            this.btnUpdateArea.Click += new System.EventHandler(this.btnUpdateArea_Click);
            // 
            // txtAreaId
            // 
            this.txtAreaId.Enabled = false;
            this.txtAreaId.Location = new System.Drawing.Point(6, 8);
            this.txtAreaId.Name = "txtAreaId";
            this.txtAreaId.Size = new System.Drawing.Size(50, 20);
            this.txtAreaId.TabIndex = 6;
            this.txtAreaId.TextChanged += new System.EventHandler(this.txtAreaId_TextChanged);
            // 
            // txtAreaName
            // 
            this.txtAreaName.Location = new System.Drawing.Point(58, 8);
            this.txtAreaName.Name = "txtAreaName";
            this.txtAreaName.Size = new System.Drawing.Size(354, 20);
            this.txtAreaName.TabIndex = 4;
            // 
            // ccbAreaStatus
            // 
            this.ccbAreaStatus.FormattingEnabled = true;
            this.ccbAreaStatus.Location = new System.Drawing.Point(418, 8);
            this.ccbAreaStatus.Name = "ccbAreaStatus";
            this.ccbAreaStatus.Size = new System.Drawing.Size(178, 21);
            this.ccbAreaStatus.TabIndex = 5;
            // 
            // btnCreateArea
            // 
            this.btnCreateArea.Location = new System.Drawing.Point(602, 8);
            this.btnCreateArea.Name = "btnCreateArea";
            this.btnCreateArea.Size = new System.Drawing.Size(75, 21);
            this.btnCreateArea.TabIndex = 2;
            this.btnCreateArea.Text = "Thêm";
            this.btnCreateArea.UseVisualStyleBackColor = true;
            this.btnCreateArea.Click += new System.EventHandler(this.btnCreateArea_Click);
            // 
            // dgvArea
            // 
            this.dgvArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArea.Location = new System.Drawing.Point(0, 104);
            this.dgvArea.Name = "dgvArea";
            this.dgvArea.Size = new System.Drawing.Size(761, 316);
            this.dgvArea.TabIndex = 0;
            this.dgvArea.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArea_CellContentClick);
            this.dgvArea.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvArea_CellFormatting);
            // 
            // tpTable
            // 
            this.tpTable.Controls.Add(this.btnUpdateTable);
            this.tpTable.Controls.Add(this.cbbAreaTable);
            this.tpTable.Controls.Add(this.txtTableId);
            this.tpTable.Controls.Add(this.txtTableName);
            this.tpTable.Controls.Add(this.cbbTableStatus);
            this.tpTable.Controls.Add(this.btnCreateTable);
            this.tpTable.Controls.Add(this.dgvTable);
            this.tpTable.Location = new System.Drawing.Point(4, 22);
            this.tpTable.Name = "tpTable";
            this.tpTable.Padding = new System.Windows.Forms.Padding(3);
            this.tpTable.Size = new System.Drawing.Size(761, 420);
            this.tpTable.TabIndex = 1;
            this.tpTable.Text = "Bàn ăn";
            this.tpTable.UseVisualStyleBackColor = true;
            // 
            // btnUpdateTable
            // 
            this.btnUpdateTable.Location = new System.Drawing.Point(680, 8);
            this.btnUpdateTable.Name = "btnUpdateTable";
            this.btnUpdateTable.Size = new System.Drawing.Size(75, 21);
            this.btnUpdateTable.TabIndex = 11;
            this.btnUpdateTable.Text = "Sửa";
            this.btnUpdateTable.UseVisualStyleBackColor = true;
            this.btnUpdateTable.Click += new System.EventHandler(this.btnUpdateTable_Click);
            // 
            // cbbAreaTable
            // 
            this.cbbAreaTable.FormattingEnabled = true;
            this.cbbAreaTable.Location = new System.Drawing.Point(267, 8);
            this.cbbAreaTable.Name = "cbbAreaTable";
            this.cbbAreaTable.Size = new System.Drawing.Size(160, 21);
            this.cbbAreaTable.TabIndex = 10;
            // 
            // txtTableId
            // 
            this.txtTableId.Enabled = false;
            this.txtTableId.Location = new System.Drawing.Point(6, 8);
            this.txtTableId.Name = "txtTableId";
            this.txtTableId.Size = new System.Drawing.Size(50, 20);
            this.txtTableId.TabIndex = 9;
            this.txtTableId.TextChanged += new System.EventHandler(this.txtTableId_TextChanged);
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(62, 8);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(199, 20);
            this.txtTableName.TabIndex = 7;
            // 
            // cbbTableStatus
            // 
            this.cbbTableStatus.FormattingEnabled = true;
            this.cbbTableStatus.Location = new System.Drawing.Point(433, 8);
            this.cbbTableStatus.Name = "cbbTableStatus";
            this.cbbTableStatus.Size = new System.Drawing.Size(160, 21);
            this.cbbTableStatus.TabIndex = 8;
            // 
            // btnCreateTable
            // 
            this.btnCreateTable.Location = new System.Drawing.Point(599, 8);
            this.btnCreateTable.Name = "btnCreateTable";
            this.btnCreateTable.Size = new System.Drawing.Size(75, 21);
            this.btnCreateTable.TabIndex = 5;
            this.btnCreateTable.Text = "Thêm";
            this.btnCreateTable.UseVisualStyleBackColor = true;
            this.btnCreateTable.Click += new System.EventHandler(this.btnCreateTable_Click);
            // 
            // dgvTable
            // 
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Location = new System.Drawing.Point(0, 104);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.Size = new System.Drawing.Size(761, 316);
            this.dgvTable.TabIndex = 1;
            this.dgvTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTable_CellContentClick);
            this.dgvTable.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTable_CellFormatting);
            // 
            // tpCategory
            // 
            this.tpCategory.Controls.Add(this.btnUpdateCategory);
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
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.Location = new System.Drawing.Point(680, 8);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(75, 21);
            this.btnUpdateCategory.TabIndex = 12;
            this.btnUpdateCategory.Text = "Sửa";
            this.btnUpdateCategory.UseVisualStyleBackColor = true;
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.Enabled = false;
            this.txtCategoryId.Location = new System.Drawing.Point(6, 8);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.Size = new System.Drawing.Size(50, 20);
            this.txtCategoryId.TabIndex = 9;
            this.txtCategoryId.TextChanged += new System.EventHandler(this.txtCategoryId_TextChanged);
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(62, 8);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(339, 20);
            this.txtCategoryName.TabIndex = 7;
            // 
            // cbbCategoryStatus
            // 
            this.cbbCategoryStatus.FormattingEnabled = true;
            this.cbbCategoryStatus.Location = new System.Drawing.Point(407, 8);
            this.cbbCategoryStatus.Name = "cbbCategoryStatus";
            this.cbbCategoryStatus.Size = new System.Drawing.Size(186, 21);
            this.cbbCategoryStatus.TabIndex = 8;
            // 
            // btnCreateCategory
            // 
            this.btnCreateCategory.Location = new System.Drawing.Point(599, 8);
            this.btnCreateCategory.Name = "btnCreateCategory";
            this.btnCreateCategory.Size = new System.Drawing.Size(75, 21);
            this.btnCreateCategory.TabIndex = 5;
            this.btnCreateCategory.Text = "Thêm";
            this.btnCreateCategory.UseVisualStyleBackColor = true;
            this.btnCreateCategory.Click += new System.EventHandler(this.btnCreateCategory_Click);
            // 
            // dgvCategory
            // 
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Location = new System.Drawing.Point(0, 108);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.Size = new System.Drawing.Size(761, 312);
            this.dgvCategory.TabIndex = 1;
            this.dgvCategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategory_CellContentClick);
            this.dgvCategory.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCategory_CellFormatting);
            // 
            // tpFood
            // 
            this.tpFood.Controls.Add(this.btnUpdateFood);
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
            // btnUpdateFood
            // 
            this.btnUpdateFood.Location = new System.Drawing.Point(703, 6);
            this.btnUpdateFood.Name = "btnUpdateFood";
            this.btnUpdateFood.Size = new System.Drawing.Size(50, 24);
            this.btnUpdateFood.TabIndex = 16;
            this.btnUpdateFood.Text = "Sửa";
            this.btnUpdateFood.UseVisualStyleBackColor = true;
            this.btnUpdateFood.Click += new System.EventHandler(this.btnUpdateFood_Click);
            // 
            // txtFoodPrice
            // 
            this.txtFoodPrice.Location = new System.Drawing.Point(208, 8);
            this.txtFoodPrice.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.txtFoodPrice.Name = "txtFoodPrice";
            this.txtFoodPrice.Size = new System.Drawing.Size(140, 20);
            this.txtFoodPrice.TabIndex = 15;
            // 
            // cbbFoodCategory
            // 
            this.cbbFoodCategory.FormattingEnabled = true;
            this.cbbFoodCategory.Location = new System.Drawing.Point(500, 8);
            this.cbbFoodCategory.Name = "cbbFoodCategory";
            this.cbbFoodCategory.Size = new System.Drawing.Size(140, 21);
            this.cbbFoodCategory.TabIndex = 14;
            // 
            // txtFoodId
            // 
            this.txtFoodId.Enabled = false;
            this.txtFoodId.Location = new System.Drawing.Point(6, 8);
            this.txtFoodId.Name = "txtFoodId";
            this.txtFoodId.Size = new System.Drawing.Size(50, 20);
            this.txtFoodId.TabIndex = 12;
            this.txtFoodId.TextChanged += new System.EventHandler(this.txtFoodId_TextChanged);
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(62, 8);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(140, 20);
            this.txtFoodName.TabIndex = 10;
            // 
            // ccbFoodStatus
            // 
            this.ccbFoodStatus.FormattingEnabled = true;
            this.ccbFoodStatus.Location = new System.Drawing.Point(354, 8);
            this.ccbFoodStatus.Name = "ccbFoodStatus";
            this.ccbFoodStatus.Size = new System.Drawing.Size(140, 21);
            this.ccbFoodStatus.TabIndex = 11;
            // 
            // btnCreateFood
            // 
            this.btnCreateFood.Location = new System.Drawing.Point(646, 6);
            this.btnCreateFood.Name = "btnCreateFood";
            this.btnCreateFood.Size = new System.Drawing.Size(50, 24);
            this.btnCreateFood.TabIndex = 5;
            this.btnCreateFood.Text = "Thêm";
            this.btnCreateFood.UseVisualStyleBackColor = true;
            this.btnCreateFood.Click += new System.EventHandler(this.btnCreateFood_Click);
            // 
            // dgvFood
            // 
            this.dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFood.Location = new System.Drawing.Point(0, 104);
            this.dgvFood.Name = "dgvFood";
            this.dgvFood.Size = new System.Drawing.Size(761, 316);
            this.dgvFood.TabIndex = 2;
            this.dgvFood.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFood_CellContentClick);
            this.dgvFood.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvFood_CellFormatting);
            // 
            // tbAccount
            // 
            this.tbAccount.Controls.Add(this.btnUpdateAccount);
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
            // btnUpdateAccount
            // 
            this.btnUpdateAccount.Location = new System.Drawing.Point(703, 6);
            this.btnUpdateAccount.Name = "btnUpdateAccount";
            this.btnUpdateAccount.Size = new System.Drawing.Size(50, 24);
            this.btnUpdateAccount.TabIndex = 15;
            this.btnUpdateAccount.Text = "Sửa";
            this.btnUpdateAccount.UseVisualStyleBackColor = true;
            this.btnUpdateAccount.Click += new System.EventHandler(this.btnUpdateAccount_Click);
            // 
            // txtAccountDisplayName
            // 
            this.txtAccountDisplayName.Location = new System.Drawing.Point(500, 8);
            this.txtAccountDisplayName.Name = "txtAccountDisplayName";
            this.txtAccountDisplayName.Size = new System.Drawing.Size(140, 20);
            this.txtAccountDisplayName.TabIndex = 14;
            // 
            // txtAccountPassword
            // 
            this.txtAccountPassword.Location = new System.Drawing.Point(208, 8);
            this.txtAccountPassword.Name = "txtAccountPassword";
            this.txtAccountPassword.Size = new System.Drawing.Size(140, 20);
            this.txtAccountPassword.TabIndex = 13;
            // 
            // txtAccountId
            // 
            this.txtAccountId.Enabled = false;
            this.txtAccountId.Location = new System.Drawing.Point(6, 8);
            this.txtAccountId.Name = "txtAccountId";
            this.txtAccountId.Size = new System.Drawing.Size(50, 20);
            this.txtAccountId.TabIndex = 12;
            this.txtAccountId.TextChanged += new System.EventHandler(this.txtAccountId_TextChanged);
            // 
            // txtAccountUserName
            // 
            this.txtAccountUserName.Location = new System.Drawing.Point(62, 8);
            this.txtAccountUserName.Name = "txtAccountUserName";
            this.txtAccountUserName.Size = new System.Drawing.Size(140, 20);
            this.txtAccountUserName.TabIndex = 10;
            // 
            // cbbAccountStatus
            // 
            this.cbbAccountStatus.FormattingEnabled = true;
            this.cbbAccountStatus.Location = new System.Drawing.Point(354, 8);
            this.cbbAccountStatus.Name = "cbbAccountStatus";
            this.cbbAccountStatus.Size = new System.Drawing.Size(140, 21);
            this.cbbAccountStatus.TabIndex = 11;
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(646, 6);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(50, 24);
            this.btnCreateAccount.TabIndex = 5;
            this.btnCreateAccount.Text = "Thêm";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // dgvAccount
            // 
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Location = new System.Drawing.Point(0, 104);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.Size = new System.Drawing.Size(761, 316);
            this.dgvAccount.TabIndex = 2;
            this.dgvAccount.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccount_CellContentClick);
            this.dgvAccount.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvaccount_cellformatting);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.flpFmain);
            this.Name = "fMain";
            this.Text = "fMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fMain_FormClosed);
            this.flpFmain.ResumeLayout(false);
            this.tcMain.ResumeLayout(false);
            this.tpArea.ResumeLayout(false);
            this.tpArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArea)).EndInit();
            this.tpTable.ResumeLayout(false);
            this.tpTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.tpCategory.ResumeLayout(false);
            this.tpCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.tpFood.ResumeLayout(false);
            this.tpFood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFoodPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).EndInit();
            this.tbAccount.ResumeLayout(false);
            this.tbAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvTable;
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
        private System.Windows.Forms.Button btnUpdateArea;
        private System.Windows.Forms.Button btnUpdateTable;
        private System.Windows.Forms.Button btnUpdateCategory;
        private System.Windows.Forms.Button btnUpdateFood;
        private System.Windows.Forms.Button btnUpdateAccount;
    }
}