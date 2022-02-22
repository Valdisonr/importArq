using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace sisBen.Model
{
    public partial class frmModel01 : Form
    {
        public operation Action = new operation();

        protected bool IsError;
        public string title
        {
            get { return lblTitle.Text; }
            set 
            {
                lblTitle.Text = value;
                this.Text = lblTitle.Text;
            }
        }

        public frmModel01()
        {
            InitializeComponent();
        }

        public string ErrorMessage
        {
            get { return frmMessage.Text; }
            set { 
                frmMessage.Text = value;
                frmMessage.Refresh();

                if (IsError)
                {
                    imgError.Image = sysBen.Properties.Resources.icoError;
                    frmMessage.ForeColor = Color.Red;
                }
                else
                {
                    frmMessage.ForeColor = Color.Green;
                   imgError.Image = sysBen.Properties.Resources.icoOk;
                }

                imgError.Visible = !frmMessage.Text.Equals("");

            }
        }

        public bool IsErrorMessage
        {
            set
            {
                IsError = value;
                imgError.Visible = !frmMessage.Text.Equals("");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            ErrorMessage = string.Empty;
        }

        private void frmModel01_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Escape)
            //{
            //    Close();
            //}
        }

        public virtual void frmModel01_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (Action != operation.VIEW && this.Parent == null)
            //{

            //if (MessageBox.Show("Os dados não salvos serão perdidos. \n\n Você deseja fechar?", "SYS-Venda System", MessageBoxButtons.YesNo) == DialogResult.No)
            //{
            //    e.Cancel = true;
            //}
            //}
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }


    }
}