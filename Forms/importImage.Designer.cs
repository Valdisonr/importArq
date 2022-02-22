namespace sysBen
{
    partial class importImage
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
            this.btn_Process = new System.Windows.Forms.Button();
            this.btn_Abrir = new System.Windows.Forms.Button();
            this.txtPlan = new System.Windows.Forms.TextBox();
            this.dgvImg = new System.Windows.Forms.DataGridView();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.qtd = new System.Windows.Forms.Label();
            this.lbmessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImg)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.barr);
            this.groupBox1.Controls.Add(this.btn_Process);
            this.groupBox1.Controls.Add(this.btn_Abrir);
            this.groupBox1.Controls.Add(this.txtPlan);
            this.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 101);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // barr
            // 
            this.barr.Location = new System.Drawing.Point(7, 54);
            this.barr.Name = "barr";
            this.barr.Size = new System.Drawing.Size(199, 34);
            this.barr.TabIndex = 14;
            // 
            // btn_Process
            // 
            this.btn_Process.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Process.Location = new System.Drawing.Point(354, 54);
            this.btn_Process.Name = "btn_Process";
            this.btn_Process.Size = new System.Drawing.Size(122, 34);
            this.btn_Process.TabIndex = 13;
            this.btn_Process.Text = "&Importar";
            this.btn_Process.UseVisualStyleBackColor = true;
            this.btn_Process.Click += new System.EventHandler(this.btn_Process_Click);
            // 
            // btn_Abrir
            // 
            this.btn_Abrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Abrir.Location = new System.Drawing.Point(354, 14);
            this.btn_Abrir.Name = "btn_Abrir";
            this.btn_Abrir.Size = new System.Drawing.Size(122, 34);
            this.btn_Abrir.TabIndex = 12;
            this.btn_Abrir.Text = "&Selecionar Fotos";
            this.btn_Abrir.UseVisualStyleBackColor = true;
            this.btn_Abrir.Click += new System.EventHandler(this.btn_Abrir_Click);
            // 
            // txtPlan
            // 
            this.txtPlan.Enabled = false;
            this.txtPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlan.Location = new System.Drawing.Point(6, 27);
            this.txtPlan.Name = "txtPlan";
            this.txtPlan.Size = new System.Drawing.Size(303, 20);
            this.txtPlan.TabIndex = 1;
            // 
            // dgvImg
            // 
            this.dgvImg.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvImg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImg.Location = new System.Drawing.Point(12, 299);
            this.dgvImg.Name = "dgvImg";
            this.dgvImg.Size = new System.Drawing.Size(279, 156);
            this.dgvImg.TabIndex = 3;
            this.dgvImg.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvImg_DataBindingComplete);
            this.dgvImg.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvImg_RowsAdded);
            // 
            // ofd1
            // 
            this.ofd1.FileName = "ofd1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 119);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(513, 174);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // qtd
            // 
            this.qtd.AutoSize = true;
            this.qtd.Location = new System.Drawing.Point(532, 46);
            this.qtd.Name = "qtd";
            this.qtd.Size = new System.Drawing.Size(10, 13);
            this.qtd.TabIndex = 5;
            this.qtd.Text = ".";
            // 
            // lbmessage
            // 
            this.lbmessage.AutoSize = true;
            this.lbmessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmessage.ForeColor = System.Drawing.Color.Red;
            this.lbmessage.Location = new System.Drawing.Point(308, 299);
            this.lbmessage.Name = "lbmessage";
            this.lbmessage.Size = new System.Drawing.Size(14, 20);
            this.lbmessage.TabIndex = 6;
            this.lbmessage.Text = ".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Último registro";
            // 
            // importImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 460);
            this.Controls.Add(this.lbmessage);
            this.Controls.Add(this.qtd);
            this.Controls.Add(this.dgvImg);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "importImage";
            this.Load += new System.EventHandler(this.importImage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar barr;
        private System.Windows.Forms.Button btn_Process;
        private System.Windows.Forms.Button btn_Abrir;
        private System.Windows.Forms.TextBox txtPlan;
        private System.Windows.Forms.DataGridView dgvImg;
        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label qtd;
        private System.Windows.Forms.Label lbmessage;
        private System.Windows.Forms.Label label1;
    }
}