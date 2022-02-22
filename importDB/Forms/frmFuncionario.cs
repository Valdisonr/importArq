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
    public partial class frmFuncionario : sisBen.Model.frmModel04
    {
        public frmFuncionario()
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
        
        private void loadExcelToDataGrid(string strFilePath)
        {
            try
            {
                string sheet = txtPlan.Text;
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
      

     bool insertFuncionario()
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
                            (row.Cells["Nome"].Value != null &&
                            !row.Cells["Nome"].Value.ToString().Equals(string.Empty)) &&
                            // (row.Cells["RG"].Value != null &&
                            //!row.Cells["RG"].Value.ToString().Equals(string.Empty)) &&
                            // (row.Cells["CPF"].Value != null &&
                            //!row.Cells["CPF"].Value.ToString().Equals(string.Empty)) &&
                            // (row.Cells["Nascimento"].Value != null &&
                            //!row.Cells["Nascimento"].Value.ToString().Equals(string.Empty)) &&
                             (row.Cells["Empresa"].Value != null &&
                           !row.Cells["Empresa"].Value.ToString().Equals(string.Empty)) &&
                           (row.Cells["Classificação"].Value != null &&
                            !row.Cells["Classificação"].Value.ToString().Equals(string.Empty)) &&
                           (row.Cells["Função"].Value != null &&
                           !row.Cells["Função"].Value.ToString().Equals(string.Empty)) &&
                           (row.Cells["Departamento"].Value != null &&
                            !row.Cells["Departamento"].Value.ToString().Equals(string.Empty)) &&
                            (row.Cells["Estado"].Value != null &&
                            !row.Cells["Estado"].Value.ToString().Equals(string.Empty)) &&
                            (row.Cells["Horário"].Value != null &&
                            !row.Cells["Horário"].Value.ToString().Equals(string.Empty))
                            
                            ))

                    {




                        Connection objinsert = new Connection();

                        objinsert.storedProcedure("inupFuncionario");
                        objinsert.addParameter("@n_identificador", SqlDbType.VarChar, (row.Cells[0].Value.ToString()));
                        objinsert.addParameter("@nome", SqlDbType.VarChar, (row.Cells[1].Value.ToString()));
                        //objinsert.addParameter("@rgresp", SqlDbType.VarChar, (row.Cells[2].Value.ToString()));
                        //objinsert.addParameter("@cpfresp", SqlDbType.VarChar, (row.Cells[3].Value.ToString()));
                       // objinsert.addParameter("@Nascimento", SqlDbType.VarChar, (row.Cells[4].Value.ToString()));
                        objinsert.addParameter("@empresaNome", SqlDbType.VarChar, (row.Cells[2].Value.ToString())); 
                        objinsert.addParameter("@classificaoNome", SqlDbType.VarChar, (row.Cells[3].Value.ToString()));                                             
                        objinsert.addParameter("@filtro1Nome", SqlDbType.VarChar, (row.Cells[4].Value.ToString()));//Função
                        objinsert.addParameter("@filtro2Nome", SqlDbType.VarChar, (row.Cells[5].Value.ToString()));//Departamento
                 //       objinsert.addParameter("@estado", SqlDbType.VarChar, (row.Cells[6].Value.ToString()));
                        objinsert.addParameter("@horarioNome", SqlDbType.VarChar, (row.Cells[7].Value.ToString()));//horário
                      //  objinsert.addParameterOutput("@result", SqlDbType.VarChar, 255);
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
            //finally
            {

                //if (result != false)
                //{
                    barr.Visible = false;
                    MessageBox.Show("Dados inseridos com sucesso!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
             //   }

             
            }
            return result;
                  

}
        
        
        
        
    
        private void frmFuncionario_Load(object sender, EventArgs e)
        {
           barr.Visible = false;
            txtPlan.Enabled = true;
            txtPlan.Focus();
     //   sqlCon.ConnectionString = sysBen.Properties.Settings.Default.strConnectionString;

        }

        private void btn_Abrir_Click_1(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtPlan.Text))
            {
                MessageBox.Show("Informe o nome da planilha !!!", "Erro ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPlan.Focus();
                return;
            }
            else
            {

                LoadNewFile();

            }
        }

        private void btn_Process_Click_1(object sender, EventArgs e)
        {
            if (!gvEmpty())
            {

                insertFuncionario();
            }

        }
    }
}
