using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using Microsoft.Office.Interop;
using Excel = Microsoft.Office.Interop.Excel;
using System.Threading.Tasks;

using daoDLL;

namespace sysBen
{
    public partial class ImportAluno : sisBen.Model.frmModel04
    {
        public ImportAluno()
        {
            InitializeComponent();
        }
        private void LoadNewFile()
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel files | *.xls";//"*.xls | All files (*.*)";
            System.Windows.Forms.DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                // ofd.Filter = "Excel files | *.xls";//"*.xls | All files (*.*)";
                texto.Text = ofd.FileName;
                loadExcelToDataGrid(ofd.FileName);

            }
        }
        private void btn_Abrir_Click(object sender, EventArgs e)
        {
            
                if (String.IsNullOrEmpty(txtPlanilha.Text))
                {
                    MessageBox.Show("Informe o nome da planilha !!!", "Erro ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPlanilha.Focus();
                    return;
                }
                else
                {

                    LoadNewFile();
                
            }
        }
        private void loadExcelToDataGrid(string strFilePath)
        {
            try
            {
                string sheet = txtPlanilha.Text;
                String strConnectionString = @"Data Source=" + strFilePath + "; Provider=Microsoft.ACE.OLEDB.12.0;Extended Properties=Excel 12.0;";
                OleDbConnection con = new OleDbConnection(strConnectionString);
                con.Open();
               
                OleDbCommand cmdSelect = new OleDbCommand(@"SELECT * FROM [" + sheet + "$]", con);
                OleDbDataAdapter daCSV = new OleDbDataAdapter();
                daCSV.SelectCommand = cmdSelect;
                DataSet ds = new DataSet();
                daCSV.Fill(ds);
                gv.DataSource = ds.Tables[0];
                
                con.Close();

            }
            catch (Exception eerr)
            {

               // MessageBox.Show("Erro ao ler arquivo" + eerr);
                MessageBox.Show(eerr.Message, "Erro !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Dispose();
            }

            //ao carregar os dados na grid o botão é desabilitado

            if (!gvEmpty())
            {
                btn_Abrir.Enabled = false;
            }

        }
        private void btn_Process_Click(object sender, EventArgs e)
        {
            if (!gvEmpty())
            {

                insertAluno();
            }
        }


     bool insertAluno()
        {

            bool result = true;


            try
            {

                barr.Minimum = 0;
                barr.Maximum = gv.Rows.Count;
                barr.Value = 0;
                barr.Visible = true;
                foreach (DataGridViewRow row in gv.Rows)
                {

                    if (((row.Cells["ID"].Value != null &&
                           !row.Cells["ID"].Value.ToString().Equals(String.Empty)) &&
                            (row.Cells["NOME"].Value != null &&
                            !row.Cells["NOME"].Value.ToString().Equals(string.Empty)) &&                           
                             (row.Cells["EMPRESA"].Value != null &&
                           !row.Cells["EMPRESA"].Value.ToString().Equals(string.Empty)) &&
                            (row.Cells["CLASSIFICAÇÃO"].Value != null &&
                            !row.Cells["CLASSIFICAÇÃO"].Value.ToString().Equals(string.Empty)) &&
                           (row.Cells["FUNÇÃO"].Value != null &&
                           !row.Cells["FUNÇÃO"].Value.ToString().Equals(string.Empty)) &&
                           (row.Cells["DEPARTAMENTO"].Value != null &&
                            !row.Cells["DEPARTAMENTO"].Value.ToString().Equals(string.Empty)) &&
                            (row.Cells["ESTADO"].Value != null &&
                            !row.Cells["ESTADO"].Value.ToString().Equals(string.Empty)) &&
                            (row.Cells["HORÁRIO"].Value != null &&
                            !row.Cells["HORÁRIO"].Value.ToString().Equals(string.Empty))))
                    {

                        string Nidentificador=string.Empty;


                        Connection objinsert = new Connection();

                           objinsert.storedProcedure("insertAluno");
                            Nidentificador = (row.Cells[0].Value.ToString().Replace(".", "").Replace(".", "").Replace("-", "").Trim());
                         //MessageBox.Show(Nidentificador, "Testando insert");


                        objinsert.addParameter("@n_identificador", SqlDbType.VarChar, Nidentificador.TrimStart('0'));
                        objinsert.addParameter("@nome", SqlDbType.VarChar, (row.Cells[1].Value.ToString()));
                        objinsert.addParameter("@empresaNome", SqlDbType.VarChar, (row.Cells[2].Value.ToString()));
                        objinsert.addParameter("@classificaoNome", SqlDbType.VarChar, (row.Cells[3].Value.ToString()));
                        objinsert.addParameter("@filtro1Nome", SqlDbType.VarChar, (row.Cells[4].Value.ToString()));
                        objinsert.addParameter("@filtro2Nome", SqlDbType.VarChar, (row.Cells[5].Value.ToString()));
                        objinsert.addParameter("@horarioNome", SqlDbType.VarChar, (row.Cells[7].Value.ToString()));
                        //objinsert.addParameterOutput("@result", SqlDbType.VarChar, 255);
                        objinsert.execute();

                        barr.Value++;

                        result = true;
                    }
                }
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message, "Erro !!! ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Dispose();
                result = false;
            }
            finally
            {

                if (result != false)
                {
                    barr.Visible = false;
                    MessageBox.Show("Dados inseridos com sucesso!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }

             
            }
            return result;
            
                 

}
        
        
        
        private void ImportAluno_Load(object sender, EventArgs e)
        {
            barr.Visible = false;
            txtPlanilha.Enabled = true;
            txtPlanilha.Focus();

         //   sqlCon.ConnectionString = sysBen.Properties.Settings.Default.strConnectionString;
        }
    }
}
