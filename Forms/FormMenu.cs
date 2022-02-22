//using sisBen.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Security;


//using sisBen.Forms;
using sisBen.Model;
using sysBen.Forms;

namespace sysBen
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }
                

       

       

       

     

        private void button1_Click(object sender, EventArgs e)
        {
            

            ImportAluno objalun = new ImportAluno();
            objalun.title = "Alunos";
            objalun.ShowDialog();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            listIP();
         // preparar();
            timer1_Tick(e, e);
           


            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            DateTime DataHora = DateTime.Now;
            tsdata.Text =", "+ DataHora.ToLongDateString() + " - " + DataHora.ToLongTimeString();

                
        //    // DateTime DataHora = DateTime.Now;
        //    tsdata.Text = ":" + DateTime.Now.ToShortDateString();
        //    tshora.Text =  " , " + DateTime.Now.ToLongTimeString();
        ////status.Text = 
        }

        void listIP()
        {
            string nome = System.Net.Dns.GetHostName();
            System.Net.IPAddress[] ip = System.Net.Dns.GetHostAddresses(nome);
           // MessageBox.Show(ip[1].ToString());
            stIP.Text = "[ IP : " + (ip[1].ToString())+" ]";
            tsUser.Text ="Usuário.: "+ Environment.UserName;
       

           
        }

       

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmResponsavel frmresp = new frmResponsavel();
            frmresp.title = "Responsável";
            frmresp.ShowDialog();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmFuncionario frmfunc = new frmFuncionario();
            frmfunc.title = "Funcionário";
            frmfunc.ShowDialog();
        }

        private void identificadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIdentificador frmidenti = new frmIdentificador();
            frmidenti.title = "Identificador";
            frmidenti.ShowDialog();
        }

        private void fotosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            importImage frmimg = new importImage();
            frmimg.Text = "Fotos";
            frmimg.ShowDialog();
            
        }

        private void alunosDuplicadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDuplicidade frmdupli = new frmDuplicidade();
            frmdupli.Text="Pessoas Duplicadas";
           
            frmdupli.ShowDialog();
        }

        private void cAMPONOMEMAISCULOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConvertName frmconvert = new frmConvertName();
            frmconvert.title = "Converter Campos";
            frmconvert.ShowDialog();
        }

        private void camposNulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNulo fnulo = new frmNulo();
            fnulo.title = "Identificador Nulo";
            fnulo.ShowDialog();
        }

        private void bloquearAcessoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBloquear fbloque = new frmBloquear();
            fbloque.title = "Bloquear Acesso";
            fbloque.ShowDialog();
        }

        private void patrimonioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formPatrimonioList frmpatri = new formPatrimonioList();
            frmpatri.title = "Patrimônio";
            frmpatri.ShowDialog();
        }
    }
}
