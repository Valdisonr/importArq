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
    public partial class frmDuplicidade : sisBen.frmModel03
    {
        public frmDuplicidade()
        {
            InitializeComponent();

            HideNew = true;
            HideView = true;
           HideModify = true;
        }

        private void frmDuplicidade_Load(object sender, EventArgs e)
        {
            listduplicado();
            
        }

        void listduplicado()
        {
            DataTable dtcli = new DataTable();
            Connection objcliente = new Connection();
            objcliente.storedProcedure("listDuplicidade");
            // objcliente.addParameter("@identificador", SqlDbType.VarChar, txtIdent.Text);
            objcliente.execute();
            dtcli = objcliente.getDataTable();
            gv.DataSource = null;
            gv.DataSource = dtcli.DefaultView;
            gv.AutoGenerateColumns = false;
            gv.Refresh();

            //   txtIdent.Focus();    


        }
        void delpessoa()
        {
            Connection objCost = new Connection();

            objCost.storedProcedure("pessoaDel");
            objCost.addParameter("@id", SqlDbType.Int, gv.CurrentRow.Cells[0].Value.ToString());
            objCost.addParameterOutput("@result", SqlDbType.VarChar, 255);
            objCost.execute();
            if (objCost.getParameter("@result").ToString() != "OK")
            {
                MessageBox.Show(objCost.getParameter("@result").ToString());
            }


        }
        
        public override void btnDelete_Click(object sender, EventArgs e)
        {
            
            if (!gvEmpty())
            {
                if (gv.CurrentRow.Cells[2].Value != null)
                    if (MessageBox.Show("Deseja Mesmo Apagar o Registro ? \n" + gv.CurrentRow.Cells[2].Value.ToString(), "Atenção !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        delpessoa();
                        //txtIdent.Focus();
                     //   listduplicado();
                        if (gvEmpty())
                        {
                            this.Dispose();
                        }
                        
                    }
            }
        }

        private void frmDuplicidade_Shown(object sender, EventArgs e)
        {
            if (gvEmpty())
            {
               // listduplicado();
                Dispose();
                MessageBox.Show("Não existe dados a serem carregados!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                 }
            
        }
    }
}
