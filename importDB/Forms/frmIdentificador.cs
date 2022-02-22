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
    public partial class frmIdentificador : sisBen.frmModel03
    {
        const int ID = 0;
        public frmIdentificador()
        {
            InitializeComponent();
            HideNew = true;
            HideView = true;
            HideModify = true;
        }

        private void frmIdentificador_Load(object sender, EventArgs e)
        {
            this.Refresh();
           // zeroesq();
            listIdentificador();
        }

        void listIdentificador()

        { 

          DataTable dtcli= new DataTable();
            Connection objcliente = new Connection();
            objcliente.storedProcedure("listIdentificador");
            objcliente.addParameter("@identificador", SqlDbType.VarChar, txtIdent.Text);
            objcliente.execute();
            dtcli = objcliente.getDataTable();
            gv.DataSource = null;
            gv.DataSource = dtcli.DefaultView;
            gv.AutoGenerateColumns = false;
            gv.Refresh();

            txtIdent.Focus();           
          
           
          
            
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            if (!gvEmpty())
            {
                if (gv.CurrentRow.Cells[2].Value != null)
                    if (MessageBox.Show("Deseja Mesmo Apagar o Registro ? \n" + gv.CurrentRow.Cells[2].Value.ToString(), "Atenção !!!", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                      identDelete();
                      listIdentificador();
                      txtIdent.Focus();
                      this.Dispose();
                    }
            }
        }
        void identDelete()
        {


            Connection objCost = new Connection();

            objCost.storedProcedure("IdentDel");
            objCost.addParameter("@identifica", SqlDbType.VarChar, gv.CurrentRow.Cells[2].Value.ToString());
            objCost.addParameterOutput("@result", SqlDbType.VarChar, 255);
            objCost.execute();
            if (objCost.getParameter("@result").ToString() != "OK")
            {
                MessageBox.Show(objCost.getParameter("@result").ToString());
            }


        }

        private void frmIdentificador_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtIdent.Text))
                {

                    txtIdent.Focus();
                    return;
                }
                else
                {
                    listIdentificador();
                }

            }
        }
        //void  zeroesq()
        //    {
        //    txtIdent.Text = txtIdent.Text.TrimStart(new Char[] { '0' });
        //}
        private void txtIdent_Leave(object sender, EventArgs e)
        {

            string teste = txtIdent.Text;
       txtIdent.Text = teste.TrimStart('0');
            //se o campo nome cliente tiver alguma coisa escrita
            

            // s = "58757843950000120465875468465874567456745674000004000"
            //tirar expaços na esquerda e a direita
            // txtIdent.Text = S('000');
           // txtIdent.Text.TrimStart('0');
        }

        
        private void txtIdent_KeyPress(object sender, KeyPressEventArgs e)
        {



            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            string teste = txtIdent.Text;
            txtIdent.Text = teste.TrimStart('0');
        }
        }
    }

