using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;
using System.IO;
using daoDLL;


namespace sysBen
{
    public partial class importImage : Form
    {

     
       // byte[] imageDados = null;
        
        public importImage()
        {
            InitializeComponent();
        }
        
        
        private bool gvEmpty()
        {
            bool result = false;
            if (dgvImg.CurrentRow == null || dgvImg.CurrentRow.Cells[0].Value == null)
            {
               // IsError = true;
                  MessageBox.Show( "Não existe dados carregados !!","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Error);
                
                //ErrorMessage = "There is no selected item.";
                result = true;
            }

            return result;
        }
        private void btn_Abrir_Click(object sender, EventArgs e)
        {


            
            
            //define as propriedades do controle 
            //OpenFileDialog
            this.ofd1.Multiselect = true;
            this.ofd1.Title = "Selecionar Fotos";
            ofd1.InitialDirectory = @"C:\Users\f5361091\Pictures";
            //filtra para exibir somente arquivos de imagens
            ofd1.Filter = "Images (*.JPG)|*.JPG|" + "All files (*.*)|*.*";
            ofd1.CheckFileExists = true;
            ofd1.CheckPathExists = true;
            ofd1.FilterIndex = 2;
            ofd1.RestoreDirectory = true;
            ofd1.ReadOnlyChecked = true;
            ofd1.ShowReadOnly = true;

            DialogResult dr = this.ofd1.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                // Le os arquivos selecionados 
                foreach (String file in ofd1.FileNames)
                {


                    //xtPlan.Text = System.IO.Path.GetFileName(file).Replace("", @"").Replace(".JPG", @"");

                 
                    txtPlan.Text = Path.GetFileName(file).Replace(".", @"").Replace("JPG", @"").Replace("jpg",@"");

                   // txtPlan.Text = Path.GetFileName(file).Replace(".", @"").Replace("jpg", @"");             

                    // txtPlan.Text = Path.GetFileName(file).Replace(".JPG ", @"").Replace(" ", @"");
                    //suavariavel = (openFileDialog1.FileName)
                    // cria um PictureBox
                    try
                    {
                        PictureBox pb = new PictureBox();
                        Image Imagem = Image.FromFile(file);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        //para exibir as imagens em tamanho natural 
                        //descomente as linhas abaixo e comente as duas seguintes
                        //pb.Height = loadedImage.Height;
                        //pb.Width = loadedImage.Width;
                        pb.Height = 30;
                        pb.Width = 30;
                        //atribui a imagem ao PictureBox - pb
                        pb.Image = Imagem;
                        //inclui a imagem no containter flowLayoutPanel
                        flowLayoutPanel1.Controls.Add(pb);

                       MemoryStream ms = new MemoryStream();
                        pb.Image.Save(ms, pb.Image.RawFormat);
                        byte[] img = ms.ToArray();
                       // insertImage();

                        if (dgvImg.Rows.Count < 50)
                        {

                            dgvImg.Rows.Add(txtPlan.Text, img);
                        }
                        else
                        {
                            MessageBox.Show("Para esse procedimento é permitido selecionar" + "\n\n" + "50 fotos por importação !!!", "Atencao",MessageBoxButtons.OK,MessageBoxIcon.Error);

                            //lbmessage.Text = ;
                            break;
                        }


                    }
                    catch (SecurityException ex)
                    {
                        // O usuário  não possui permissão para ler arquivos
                        MessageBox.Show("Erro de segurança Contate o administrador de segurança da rede.\n\n" +
                                        "Mensagem : " + ex.Message + "\n\n" +
                                        "Detalhes (enviar ao suporte):\n\n" + ex.StackTrace);
                    }
                    catch (Exception ex)
                    {
                        // Não pode carregar a imagem (problemas de permissão)
                        MessageBox.Show("Não é possível exibir a imagem : " + file.Substring(file.LastIndexOf('\\'))
                                         + ". Você pode não ter permissão para ler o arquivo , ou " +
                                         " ele pode estar corrompido.\n\nErro reportado : " + ex.Message);
                    }
                }
            }
        }
        void loadgrid()
        {
            
            DataGridViewTextBoxColumn dgvid = new DataGridViewTextBoxColumn();
            dgvid.HeaderText = "ID";
            



            DataGridViewImageColumn dgImage = new DataGridViewImageColumn();
            dgImage.HeaderText = "Image";
            dgImage.ImageLayout = DataGridViewImageCellLayout.Stretch;

            

            dgvImg.Columns.Add(dgvid);
            dgvImg.Columns.Add(dgImage);
        


            dgvImg.RowTemplate.Height = 120;
          
            dgvImg.AllowUserToAddRows = false;

            qtd.Text = string.Empty;
        }
        private void importImage_Load(object sender, EventArgs e)
        {


            loadgrid();
        }

        bool insertImage()
        {

            

            bool result = true;
            



                try
                {
                  

                    barr.Minimum = 0;
                    barr.Maximum = dgvImg.Rows.Count;
                    barr.Value = 0;
                    barr.Visible = true;
                    foreach (DataGridViewRow row in dgvImg.Rows)
                    {

                        if ((row.Cells[0].Value != null &&
                               !row.Cells[0].Value.ToString().Equals(String.Empty)) &&
                                (row.Cells[1].Value != null &&
                                !row.Cells[1].Value.ToString().Equals(string.Empty)))
                        {




                            Connection obimg = new Connection();

                            obimg.storedProcedure("insertImage");
                            obimg.addParameter("@identificador", SqlDbType.VarChar, (row.Cells[0].Value.ToString()));


                            byte[] imagedt = (byte[])row.Cells[1].Value;
                          
                            obimg.addParameter("@imagen", SqlDbType.Image, imagedt);
                        //MessageBox.Show("" + imagedt);

                        obimg.execute();



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

                    if (result != false)
                    {
                        barr.Visible = false;
                        MessageBox.Show("Dados inseridos com sucesso!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Dispose();
                    }


                }
                return result;

                      
        }
        
       
       
        private void dgvImg_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
         
        }

        private void dgvImg_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            
                qtd.Text = dgvImg.Rows.Count.ToString() + " Item(s) Selecionado(s)";

            
                
               
            
        }

        private void btn_Process_Click(object sender, EventArgs e)
        {
            if (!gvEmpty())
            {

                insertImage();
            }
        }

        
        
    }
}