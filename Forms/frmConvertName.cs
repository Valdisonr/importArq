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
    public partial class frmConvertName : sisBen.Model.frmModel04
    {
        public frmConvertName()
        {
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            caixaAltaup();
        }

        void caixaAltaup()
        {
            ErrorMessage = "Aguarde...convertendo dados !!!";
            DataTable dtcli = new DataTable();
            Connection objcliente = new Connection();
            objcliente.storedProcedure("caixaAlta");
            // objcliente.addParameter("@identificador", SqlDbType.VarChar, txtIdent.Text);
            objcliente.execute();
            dtcli = objcliente.getDataTable();
            gv.DataSource = null;
            gv.DataSource = dtcli.DefaultView;
            gv.AutoGenerateColumns = false;
            gv.Refresh();
            ErrorMessage = string.Empty;

        
        }

        void listName()
        {
            ErrorMessage = "Aguarde...carregando dados !!!";
            DataTable dtcli = new DataTable();
            Connection objcliente = new Connection();
            objcliente.storedProcedure("listName");
            // objcliente.addParameter("@identificador", SqlDbType.VarChar, txtIdent.Text);
            objcliente.execute();
            dtcli = objcliente.getDataTable();
            gv.DataSource = null;
            gv.DataSource = dtcli.DefaultView;
            gv.AutoGenerateColumns = false;
            gv.Refresh();
            ErrorMessage = string.Empty;

        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listName();
        }
        void caixaAltabaixaup()
        {
            ErrorMessage = "Aguarde...convertendo Dados !!!";
            DataTable dtcli = new DataTable();
            Connection objcliente = new Connection();
            objcliente.storedProcedure("caixaAltabaixaup");
            // objcliente.addParameter("@identificador", SqlDbType.VarChar, txtIdent.Text);
            objcliente.execute();
            dtcli = objcliente.getDataTable();
            gv.DataSource = null;
            gv.DataSource = dtcli.DefaultView;
            gv.AutoGenerateColumns = false;
            gv.Refresh();
            ErrorMessage = string.Empty;
        
        }
        private void frmConvertName_Load(object sender, EventArgs e)
        {
           
                switch (Action)
             {
               case operation.BTNALTA:
                   
                    caixaAltaup();
                    break;
                 case operation.btnAltaBaixa:
                 
                    caixaAltabaixaup();                 

                   break;
                 //case operation.VIEW:
                 //    setValueField();
                 //    setViewField();
                 //    break;
             }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAltaBaixa_Click(object sender, EventArgs e)
        {
             caixaAltabaixaup();
        }
    }
}
