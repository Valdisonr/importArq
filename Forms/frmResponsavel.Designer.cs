namespace sysBen
{
    partial class frmResponsavel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.barr = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Process = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Abrir = new System.Windows.Forms.Button();
            this.txtPlanilha = new System.Windows.Forms.TextBox();
            this.texto = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.barr);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_Process);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_Abrir);
            this.groupBox1.Controls.Add(this.txtPlanilha);
            this.groupBox1.Controls.Add(this.texto);
            this.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 101);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // barr
            // 
            this.barr.Location = new System.Drawing.Point(456, 17);
            this.barr.Name = "barr";
            this.barr.Size = new System.Drawing.Size(199, 23);
            this.barr.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Folha Planilha.:";
            // 
            // btn_Process
            // 
            this.btn_Process.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Process.Location = new System.Drawing.Point(547, 54);
            this.btn_Process.Name = "btn_Process";
            this.btn_Process.Size = new System.Drawing.Size(71, 26);
            this.btn_Process.TabIndex = 13;
            this.btn_Process.Text = "&Importar";
            this.btn_Process.UseVisualStyleBackColor = true;
            this.btn_Process.Click += new System.EventHandler(this.btn_Process_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Local .:";
            // 
            // btn_Abrir
            // 
            this.btn_Abrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Abrir.Location = new System.Drawing.Point(456, 54);
            this.btn_Abrir.Name = "btn_Abrir";
            this.btn_Abrir.Size = new System.Drawing.Size(73, 26);
            this.btn_Abrir.TabIndex = 12;
            this.btn_Abrir.Text = "&Abrir";
            this.btn_Abrir.UseVisualStyleBackColor = true;
            this.btn_Abrir.Click += new System.EventHandler(this.btn_Abrir_Click);
            // 
            // txtPlanilha
            // 
            this.txtPlanilha.Enabled = false;
            this.txtPlanilha.Location = new System.Drawing.Point(118, 19);
            this.txtPlanilha.Name = "txtPlanilha";
            this.txtPlanilha.Size = new System.Drawing.Size(303, 20);
            this.txtPlanilha.TabIndex = 1;
            // 
            // texto
            // 
            this.texto.Enabled = false;
            this.texto.Location = new System.Drawing.Point(118, 57);
            this.texto.Name = "texto";
            this.texto.Size = new System.Drawing.Size(303, 20);
            this.texto.TabIndex = 10;
            // 
            // frmResponsavel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(792, 590);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmResponsavel";
            this.Text = "Responsável";
            this.Load += new System.EventHandler(this.frmResponsavel_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar barr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Process;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Abrir;
        private System.Windows.Forms.TextBox txtPlanilha;
        private System.Windows.Forms.TextBox texto;
    }
}
