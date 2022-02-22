using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using daoDLL;

namespace sysBen
{
    public partial class frmBloquear : sisBen.Model.frmModel04
    {
        public frmBloquear()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ErrorMessage = "Aguarde...listando Dados !!!";
            DataTable dtcli = new DataTable();
            Connection objcliente = new Connection();
            objcliente.storedProcedure("anteriorDay");
            // objcliente.addParameter("@identificador", SqlDbType.VarChar, txtIdent.Text);
            objcliente.addParameter("@dtinicial", SqlDbType.DateTime, DateTime.Parse(dtinicial.Text));
            objcliente.execute();
            dtcli = objcliente.getDataTable();
            gv.DataSource = null;
            gv.DataSource = dtcli.DefaultView;
            gv.AutoGenerateColumns = false;
            gv.Refresh();
            ErrorMessage = string.Empty;
        }

        private void frmBloquear_Load(object sender, EventArgs e)
        {

        }




        private void btnAlta_Click(object sender, EventArgs e)
        {
            ErrorMessage = "Aguarde...listando Dados !!!";
            DataTable dtcli = new DataTable();
            Connection objcliente = new Connection();
            objcliente.storedProcedure("bloquearAcesso");
            objcliente.addParameter("@dtinicial", SqlDbType.DateTime, DateTime.Parse(dtinicial.Text));
            // objcliente.addParameter("@identificador", SqlDbType.VarChar, txtIdent.Text);
            objcliente.execute();
            dtcli = objcliente.getDataTable();
            gv.DataSource = null;
            gv.DataSource = dtcli.DefaultView;
            gv.AutoGenerateColumns = false;
            gv.Refresh();
            ErrorMessage = string.Empty;
        }
    }
}
