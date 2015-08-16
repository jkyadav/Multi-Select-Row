using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiSelectGrid
{
    public partial class DataGridViewUC : DataGridView
    {
        public DataGridViewUC()
        {
            InitializeComponent();
        }



        protected override void OnCellMouseDown(DataGridViewCellMouseEventArgs e)
        {
            this.Rows[e.RowIndex].Selected = !this.Rows[e.RowIndex].Selected;
            //base.OnMouseDown(e);
        }

        protected override void OnCellMouseClick(DataGridViewCellMouseEventArgs e)
        {
            //base.OnMouseClick(e);
        }

        protected override void OnDataSourceChanged(EventArgs e)
        {
            base.OnDataSourceChanged(e);
        }
    }
}
