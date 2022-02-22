using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace sisBen
{
    public partial class frmGeneralFilter : Form
    {
        private string _filter = String.Empty;
        private DataGridView _gv = new DataGridView();
        public  bool successfuly = false;

        public string filter
        {
            get { return _filter; }
        }

        public frmGeneralFilter()
        {
            InitializeComponent();
        }
        public frmGeneralFilter(string title, DataGridView gridView)
        {
            InitializeComponent();
            this.Text = title;
            _gv = gridView;
            gvLoadFilter();

        }

        

        private void frmGeneralFilter_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _filter = string.Empty;
            successfuly = false;
            Close();
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string _filterAux = String.Empty;
            successfuly = true;
            for (int i = 0; i < gv.Rows.Count; i++)
            {
                if (gv.Rows[i].Cells[3].Value != null && gv.Rows[i].Cells[2].Value != null)
                {
                    string _fieldName = "[" +gv.Rows[i].Cells[0].Value.ToString() + "]";

                    string _operator = gv.Rows[i].Cells[2].Value.ToString();
              
                    string _value = gv.Rows[i].Cells[3].Value.ToString();
                    
                    if (! _filterAux.Equals(""))
                    {
                        _filterAux += " and ";
                    }

                    switch (_operator.ToUpper())
                    { 
                        case "CONTAINS": 
                            _filterAux += " ( " + _fieldName + " like '%" + _value + "%' " + ")";
                            break;
                        case "EQUALS" :
                            _filterAux += " ( " + _fieldName + " = '" + _value + "' " + ")";
                            break;
                        case "DOES NOT CONTAINS":
                            _filterAux += " ( " + _fieldName + " <> '" + _value + "' " + ")";
                            break;
                    }

                    _filter = _filterAux;
                }

            }
            Close();
        }

        void gvLoadFilter()
        {
            for (int i = 0; i < _gv.ColumnCount; i++)
            {
                if (_gv.Columns[i].Visible)
                {
                    string columnName = _gv.Columns[i].HeaderText;
                    string fieldName = _gv.Columns[i].DataPropertyName;

                    gv.Rows.Add(fieldName, columnName, null, null);
                }
            }
        }
    }
}