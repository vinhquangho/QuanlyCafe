namespace QuanlyCafe
{
    partial class fTableManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTableManager));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStripAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripReport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.tArea = new System.Windows.Forms.TabControl();
            this.btnSwipTable = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.brnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.numericeCount = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtService = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pFood = new System.Windows.Forms.Panel();
            this.treeViewCategory = new System.Windows.Forms.TreeView();
            this.listViewFood = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.listViewBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericeCount)).BeginInit();
            this.pFood.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripAdmin,
            this.menuStripReport,
            this.menuStripLogout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStripAdmin
            // 
            this.menuStripAdmin.Name = "menuStripAdmin";
            this.menuStripAdmin.Size = new System.Drawing.Size(60, 20);
            this.menuStripAdmin.Text = "Quan lý";
            this.menuStripAdmin.Click += new System.EventHandler(this.menuStripAdmin_Click);
            // 
            // menuStripReport
            // 
            this.menuStripReport.Name = "menuStripReport";
            this.menuStripReport.Size = new System.Drawing.Size(61, 20);
            this.menuStripReport.Text = "Báo cáo";
            this.menuStripReport.Click += new System.EventHandler(this.menuStripReport_Click);
            // 
            // menuStripLogout
            // 
            this.menuStripLogout.Name = "menuStripLogout";
            this.menuStripLogout.Size = new System.Drawing.Size(73, 20);
            this.menuStripLogout.Text = "Đăng xuất";
            this.menuStripLogout.Click += new System.EventHandler(this.menuStripLogout_Click);
            // 
            // tArea
            // 
            this.tArea.Location = new System.Drawing.Point(12, 30);
            this.tArea.Name = "tArea";
            this.tArea.Padding = new System.Drawing.Point(0, 0);
            this.tArea.SelectedIndex = 0;
            this.tArea.Size = new System.Drawing.Size(525, 525);
            this.tArea.TabIndex = 0;
            // 
            // btnSwipTable
            // 
            this.btnSwipTable.Location = new System.Drawing.Point(947, 358);
            this.btnSwipTable.Name = "btnSwipTable";
            this.btnSwipTable.Size = new System.Drawing.Size(108, 50);
            this.btnSwipTable.TabIndex = 17;
            this.btnSwipTable.Text = "Chuyển bàn";
            this.btnSwipTable.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnSwipTable.UseVisualStyleBackColor = true;
            this.btnSwipTable.Click += new System.EventHandler(this.btnSwipTable_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPayment.Location = new System.Drawing.Point(947, 302);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(108, 50);
            this.btnPayment.TabIndex = 16;
            this.btnPayment.Text = "Thanh toán";
            this.btnPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(947, 246);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(108, 50);
            this.btnPrint.TabIndex = 15;
            this.btnPrint.Text = "In hóa đơn";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // brnDelete
            // 
            this.brnDelete.Location = new System.Drawing.Point(947, 190);
            this.brnDelete.Name = "brnDelete";
            this.brnDelete.Size = new System.Drawing.Size(108, 50);
            this.brnDelete.TabIndex = 14;
            this.brnDelete.Text = "Xóa";
            this.brnDelete.UseVisualStyleBackColor = true;
            this.brnDelete.Click += new System.EventHandler(this.brnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(947, 134);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 50);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Giảm";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(947, 79);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 50);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // numericeCount
            // 
            this.numericeCount.Location = new System.Drawing.Point(947, 53);
            this.numericeCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericeCount.Name = "numericeCount";
            this.numericeCount.Size = new System.Drawing.Size(108, 20);
            this.numericeCount.TabIndex = 11;
            this.numericeCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericeCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(944, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Số lượng:";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(644, 498);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(297, 57);
            this.txtNote.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(537, 498);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ghi chú:";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(644, 453);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(297, 24);
            this.txtTotal.TabIndex = 8;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(644, 413);
            this.txtDiscount.Multiline = true;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(297, 24);
            this.txtDiscount.TabIndex = 7;
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // txtService
            // 
            this.txtService.Location = new System.Drawing.Point(644, 373);
            this.txtService.Multiline = true;
            this.txtService.Name = "txtService";
            this.txtService.Size = new System.Drawing.Size(297, 24);
            this.txtService.TabIndex = 6;
            this.txtService.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtService.TextChanged += new System.EventHandler(this.txtService_TextChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(644, 333);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(297, 24);
            this.txtPrice.TabIndex = 5;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(537, 453);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tổng tiền:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(537, 413);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Giảm giá:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(537, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phí dịch vụ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(537, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tiền hàng:";
            // 
            // pFood
            // 
            this.pFood.Controls.Add(this.treeViewCategory);
            this.pFood.Location = new System.Drawing.Point(1061, 31);
            this.pFood.Name = "pFood";
            this.pFood.Size = new System.Drawing.Size(200, 209);
            this.pFood.TabIndex = 3;
            // 
            // treeViewCategory
            // 
            this.treeViewCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewCategory.Location = new System.Drawing.Point(0, 0);
            this.treeViewCategory.Name = "treeViewCategory";
            this.treeViewCategory.Size = new System.Drawing.Size(200, 209);
            this.treeViewCategory.TabIndex = 0;
            this.treeViewCategory.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewCategory_AfterSelect);
            // 
            // listViewFood
            // 
            this.listViewFood.CheckBoxes = true;
            this.listViewFood.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columPrice});
            this.listViewFood.FullRowSelect = true;
            this.listViewFood.GridLines = true;
            this.listViewFood.HideSelection = false;
            this.listViewFood.Location = new System.Drawing.Point(1061, 246);
            this.listViewFood.MultiSelect = false;
            this.listViewFood.Name = "listViewFood";
            this.listViewFood.Size = new System.Drawing.Size(200, 309);
            this.listViewFood.TabIndex = 1;
            this.listViewFood.UseCompatibleStateImageBehavior = false;
            this.listViewFood.View = System.Windows.Forms.View.Details;
            // 
            // columnName
            // 
            this.columnName.Text = "Mặt hàng";
            this.columnName.Width = 90;
            // 
            // columPrice
            // 
            this.columPrice.Text = "Giá tiền";
            this.columPrice.Width = 100;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listViewBill);
            this.panel2.Location = new System.Drawing.Point(541, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 300);
            this.panel2.TabIndex = 18;
            // 
            // listViewBill
            // 
            this.listViewBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewBill.FullRowSelect = true;
            this.listViewBill.GridLines = true;
            this.listViewBill.HideSelection = false;
            this.listViewBill.Location = new System.Drawing.Point(0, 0);
            this.listViewBill.MultiSelect = false;
            this.listViewBill.Name = "listViewBill";
            this.listViewBill.Size = new System.Drawing.Size(400, 300);
            this.listViewBill.TabIndex = 0;
            this.listViewBill.UseCompatibleStateImageBehavior = false;
            this.listViewBill.View = System.Windows.Forms.View.Details;
            this.listViewBill.SelectedIndexChanged += new System.EventHandler(this.listViewBill_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mặt hàng";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 95;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giá tiền";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 100;
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // fTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1264, 561);
            this.Controls.Add(this.listViewFood);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.btnSwipTable);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.tArea);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.txtService);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pFood);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.brnDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.numericeCount);
            this.Controls.Add(this.label6);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fTableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fTableManager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericeCount)).EndInit();
            this.pFood.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuStripAdmin;
        private System.Windows.Forms.ToolStripMenuItem menuStripReport;
        private System.Windows.Forms.ToolStripMenuItem menuStripLogout;
        private System.Windows.Forms.Panel pFood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtService;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown numericeCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button brnDelete;
        private System.Windows.Forms.ListView listViewFood;
        private System.Windows.Forms.TreeView treeViewCategory;
        private System.Windows.Forms.TabControl tArea;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columPrice;
        private System.Windows.Forms.Button btnSwipTable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listViewBill;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
    }
}