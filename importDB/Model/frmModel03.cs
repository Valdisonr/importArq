using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using daoDLL;
namespace sisBen
{
    public partial class frmModel03 : sisBen.Model.frmModel02
    {
        public string Filter = string.Empty;
        
        public frmModel03()
        {
            InitializeComponent();
           
        }

        public virtual void btnNew_Click(object sender, EventArgs e)
        {
            ErrorMessage = string.Empty;
        }

       

       

        public virtual void btnDelete_Click(object sender, EventArgs e)
        {
            ErrorMessage = string.Empty;
        }

        public override void gv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnView_Click(null, null);
        }

        public void btnFilter_Click(object sender, EventArgs e)
        {
            ErrorMessage = string.Empty;
            frmGeneralFilter objFilter = new frmGeneralFilter("Filter ("+ this.title + ")", gv);
            objFilter.StartPosition = FormStartPosition.CenterParent;
            objFilter.ShowDialog();
            if (objFilter.successfuly)
            {
                Filter = objFilter.filter;
                MonitoringFilter();
            
            }
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            Filter = string.Empty;
            ErrorMessage = string.Empty;
            btnClearFilter.Enabled = false;
            MonitoringFilter();
        }

        void MonitoringFilter()
        {

            DataTable dtFilter = new DataTable();
            try
            {
                dtFilter = ((DataView)gv.DataSource).Table;
                dtFilter.DefaultView.RowFilter = Filter;
                gv.DataSource = dtFilter.DefaultView;
                gv.Refresh();
                btnClearFilter.Enabled = !Filter.Equals(string.Empty);

                if (!Filter.Equals(string.Empty))
                {
                    if (gv.Rows.Count > 0)
                    {
                        IsError = false;
                        ErrorMessage = gv.Rows.Count.ToString() + " item(s) found.";
                    }
                    else
                    {
                        IsError = true;
                        ErrorMessage = gv.Rows.Count.ToString() + " item(s) found.";
                    }
                }

                
            }
            catch (Exception ee)
            {
                IsError = true;
                ErrorMessage = ee.Message;
            }
        }

        public override void gv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            base.gv_DataBindingComplete(sender, e);
            btnNew.Enabled = (gv.Rows.Count > 0);
            btnView.Enabled = (gv.Rows.Count > 0);
            btnModify.Enabled = (gv.Rows.Count > 0);
            btnDelete.Enabled = (gv.Rows.Count > 0);
            btnFilter.Enabled = (gv.Rows.Count > 0);             
            btnClearFilter.Enabled = !Filter.Equals(string.Empty);
           
        }

        private void frmModel03_Load(object sender, EventArgs e)
        {
           
        }

        public string CaptionToDeleteButton
        {
            get {
                return btnDelete.Text;
            }
            set
            {
                btnDelete.Text = value;
                btnDelete.AutoSize = true;
            }
        }

        public string CaptionToModifyButton
        {
            get
            {
                return btnModify.Text;
            }
            set
            {
                btnModify.Text = value;
                btnModify.AutoSize = true;
                btnModify.Refresh();
                Point newLocation = new Point();
                newLocation.X = btnModify.Location.X + btnModify.Size.Width + 30;
                newLocation.Y = btnModify.Location.Y;
                btnDelete.Location = newLocation;
                btnDelete.Refresh();
            }
        }

        public string CaptionToNewButton
        {
            get
            {
                return btnNew.Text;
            }
            set
            {
                btnNew.Text = value;
                btnNew.AutoSize = true;
                btnNew.Refresh();
                Point newLocation = new Point();
                newLocation.X = btnNew.Location.X + btnNew.Size.Width + 30;
                newLocation.Y = btnNew.Location.Y;
                btnView.Location = newLocation;
                btnView.Refresh();
            }
        }

  
        public bool HideDelete
        {
            set {
                btnDelete.Visible = ! value;
            }
        }

        public bool HideNew
        {
            set
            {
                btnNew.Visible = !value;
            }
        }

        public bool HideView
        {
            set {

                btnView.Visible = !value;
            }
        
        }
        public bool HideModify
        {
            set {
                btnModify.Visible = !value;
            
            
            }
        
        }
        
        
        public string FormName
        {
            set {
                DataTable dtScreenPermission = new DataTable();
          //  Connection oConn = new Connection();
                //oConn.storedProcedure("MICScreenPermission");
                ////oConn.addParameter("@CompanyId", SqlDbType.Int, Properties.Settings.Default.id_company);
                ////oConn.addParameter("@UserID", SqlDbType.Int, int.Parse(Properties.Settings.Default.UserID));
                //oConn.addParameter("@FormName", SqlDbType.VarChar, value.ToString());
                //oConn.execute();
                //dtScreenPermission = oConn.getDataTable();
                foreach (DataRow row in dtScreenPermission.Rows)
                { 
                    foreach(Control ctrl in Controls)
                    {
                        if (ctrl.GetType().ToString().Equals("System.Windows.Forms.Button"))
                        {
                            if ( ((System.Windows.Forms.Button)ctrl).Tag != null)
                                if (((System.Windows.Forms.Button)ctrl).Tag.ToString().Equals(row["ActionID"].ToString()))
                                {
                                    ((System.Windows.Forms.Button)ctrl).Enabled = true;
                                }
                        }

                    }
                }
                

            }
        }

       public virtual void  btnView_Click(object sender, EventArgs e)
        {
        
            ErrorMessage = string.Empty;
       
        }

       public virtual void btnModify_Click(object sender, EventArgs e)
        {
         ErrorMessage = string.Empty;
        }

      

        
        
        }
    
}


