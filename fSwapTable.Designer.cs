namespace QuanlyCafe
{
    partial class fSwapTable
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
            this.pnlFrom = new System.Windows.Forms.Panel();
            this.lvFrom = new System.Windows.Forms.ListView();
            this.pnlTo = new System.Windows.Forms.Panel();
            this.lvTo = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnFrom = new System.Windows.Forms.Button();
            this.btnTo = new System.Windows.Forms.Button();
            this.cbbFrom = new System.Windows.Forms.ComboBox();
            this.cbbTo = new System.Windows.Forms.ComboBox();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlFrom.SuspendLayout();
            this.pnlTo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFrom
            // 
            this.pnlFrom.Controls.Add(this.lvFrom);
            this.pnlFrom.Location = new System.Drawing.Point(12, 49);
            this.pnlFrom.Name = "pnlFrom";
            this.pnlFrom.Size = new System.Drawing.Size(330, 400);
            this.pnlFrom.TabIndex = 0;
            // 
            // lvFrom
            // 
            this.lvFrom.CheckBoxes = true;
            this.lvFrom.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.lvFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvFrom.GridLines = true;
            this.lvFrom.HideSelection = false;
            this.lvFrom.Location = new System.Drawing.Point(0, 0);
            this.lvFrom.Name = "lvFrom";
            this.lvFrom.Size = new System.Drawing.Size(330, 400);
            this.lvFrom.TabIndex = 0;
            this.lvFrom.UseCompatibleStateImageBehavior = false;
            this.lvFrom.View = System.Windows.Forms.View.Details;
            // 
            // pnlTo
            // 
            this.pnlTo.Controls.Add(this.lvTo);
            this.pnlTo.Location = new System.Drawing.Point(442, 49);
            this.pnlTo.Name = "pnlTo";
            this.pnlTo.Size = new System.Drawing.Size(330, 400);
            this.pnlTo.TabIndex = 1;
            // 
            // lvTo
            // 
            this.lvTo.CheckBoxes = true;
            this.lvTo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lvTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvTo.GridLines = true;
            this.lvTo.HideSelection = false;
            this.lvTo.Location = new System.Drawing.Point(0, 0);
            this.lvTo.Name = "lvTo";
            this.lvTo.Size = new System.Drawing.Size(330, 400);
            this.lvTo.TabIndex = 6;
            this.lvTo.UseCompatibleStateImageBehavior = false;
            this.lvTo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mặt hàng";
            this.columnHeader3.Width = 165;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số lượng";
            this.columnHeader4.Width = 160;
            // 
            // btnFrom
            // 
            this.btnFrom.Location = new System.Drawing.Point(348, 174);
            this.btnFrom.Name = "btnFrom";
            this.btnFrom.Size = new System.Drawing.Size(88, 34);
            this.btnFrom.TabIndex = 2;
            this.btnFrom.Text = ">>";
            this.btnFrom.UseVisualStyleBackColor = true;
            this.btnFrom.Click += new System.EventHandler(this.btnFrom_Click);
            // 
            // btnTo
            // 
            this.btnTo.Location = new System.Drawing.Point(348, 242);
            this.btnTo.Name = "btnTo";
            this.btnTo.Size = new System.Drawing.Size(88, 34);
            this.btnTo.TabIndex = 3;
            this.btnTo.Text = "<<";
            this.btnTo.UseVisualStyleBackColor = true;
            this.btnTo.Click += new System.EventHandler(this.btnTo_Click);
            // 
            // cbbFrom
            // 
            this.cbbFrom.FormattingEnabled = true;
            this.cbbFrom.Location = new System.Drawing.Point(12, 12);
            this.cbbFrom.Name = "cbbFrom";
            this.cbbFrom.Size = new System.Drawing.Size(330, 21);
            this.cbbFrom.TabIndex = 4;
            this.cbbFrom.SelectedIndexChanged += new System.EventHandler(this.cbbFrom_SelectedIndexChanged);
            // 
            // cbbTo
            // 
            this.cbbTo.FormattingEnabled = true;
            this.cbbTo.Location = new System.Drawing.Point(442, 12);
            this.cbbTo.Name = "cbbTo";
            this.cbbTo.Size = new System.Drawing.Size(330, 21);
            this.cbbTo.TabIndex = 5;
            this.cbbTo.SelectedIndexChanged += new System.EventHandler(this.cbbTo_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mặt hàng";
            this.columnHeader5.Width = 160;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Số lượng";
            this.columnHeader6.Width = 160;
            // 
            // fSwapTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.cbbTo);
            this.Controls.Add(this.cbbFrom);
            this.Controls.Add(this.btnTo);
            this.Controls.Add(this.btnFrom);
            this.Controls.Add(this.pnlTo);
            this.Controls.Add(this.pnlFrom);
            this.Name = "fSwapTable";
            this.Text = "fSwapTable";
            this.pnlFrom.ResumeLayout(false);
            this.pnlTo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFrom;
        private System.Windows.Forms.Panel pnlTo;
        private System.Windows.Forms.Button btnFrom;
        private System.Windows.Forms.Button btnTo;
        private System.Windows.Forms.ComboBox cbbFrom;
        private System.Windows.Forms.ComboBox cbbTo;
        private System.Windows.Forms.ListView lvFrom;
        private System.Windows.Forms.ListView lvTo;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}