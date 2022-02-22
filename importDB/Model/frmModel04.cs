using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace sisBen.Model
{
    public partial class frmModel04 : sisBen.Model.frmModel01
    {
        protected bool gvEmpty()
        {
            bool result = false;
            if (gv.CurrentRow == null || gv.CurrentRow.Cells[0].Value == null)
            {
                MessageBox.Show("Não há item selecionado. ","Erro!!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
               // ErrorMessage = "There is no selected item.";

                result = true;
            }
            
            return result;
        }
        public frmModel04()
        {
            InitializeComponent();
        }

        private void frmModel02_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        public virtual void gv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            lblItemQty.Text = gv.Rows.Count.ToString() + " Item(s)";
        }

        public virtual void gv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}

