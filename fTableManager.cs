using QuanlyCafe.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyCafe
{
    public partial class fTableManager : Form
    {
        private AppDbContext _dbContext = new AppDbContext();
        public fTableManager()
        {
            InitializeComponent();
            LoadTable();
            LoadCategory();
        }
        private void LoadTable()
        {

            var area = _dbContext.AreaTables.Where(f => f.Status == Status.Active).ToList();
            foreach (var a in area)
            {
                var tabPanel = new TabPage() { Name = $@"tab-${a.Id}", Text = a.Name, Width = 780, Height = 708 };
                var flowLayoutControl = new FlowLayoutPanel() { Name = $@"fp-${a.Id}", Height = 708, Width = 780 };
                tabPanel.Controls.Add(flowLayoutControl);

                var table = _dbContext.Tables.Where(f => f.AreaTableId == a.Id).ToList();
                foreach (var t in table)
                {
                    var btn = new Button() { Name = $"btn-${t.Id}", Text = t.Name, Width = 150, Height = 50, TextAlign = ContentAlignment.MiddleCenter, Tag = t.Id };
                    btn.Click += btnTable_Click;
                    flowLayoutControl.Controls.Add(btn);
                }

                tArea.Controls.Add(tabPanel);
            }
        }
        private void LoadCategory()
        {
            var category = _dbContext.Categories.Where(f => f.Status == Status.Active).ToList();
            foreach(var c in category)
            {
                var node = new TreeNode() { Text = c.Name, Name = $"c-${c.Id}"};
                treeViewCategory.Nodes.Add(node);
            }
        }

        private void menuStripAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            var fmain = new fMain();
            fmain.ShowDialog();
        }
        private void btnTable_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
        }
        private void btnNode_Click()
        {

        }
    }
}
