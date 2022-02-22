namespace sysBen
{
    partial class FormMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.stIP = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsdata = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.importarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.responsávelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fotosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.identificadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunosDuplicadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cAMPONOMEMAISCULOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.camposNulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bloquearAcessoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patrimonioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsUser,
            this.stIP,
            this.tsdata});
            this.statusStrip1.Location = new System.Drawing.Point(0, 301);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(584, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // tsUser
            // 
            this.tsUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsUser.ForeColor = System.Drawing.Color.Red;
            this.tsUser.Name = "tsUser";
            this.tsUser.Size = new System.Drawing.Size(115, 17);
            this.tsUser.Text = "TI La Salle - Manaus";
            // 
            // stIP
            // 
            this.stIP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stIP.ForeColor = System.Drawing.Color.MidnightBlue;
            this.stIP.Name = "stIP";
            this.stIP.Size = new System.Drawing.Size(10, 17);
            this.stIP.Text = ".";
            // 
            // tsdata
            // 
            this.tsdata.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsdata.ForeColor = System.Drawing.Color.Red;
            this.tsdata.Name = "tsdata";
            this.tsdata.Size = new System.Drawing.Size(16, 17);
            this.tsdata.Text = "D";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::sysBen.Properties.Resources.foto_lasalle;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(3, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 216);
            this.panel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(128, -28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 25);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button1.Location = new System.Drawing.Point(172, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "&Aluno";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button2.Location = new System.Drawing.Point(426, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 40);
            this.button2.TabIndex = 5;
            this.button2.Text = "&Responsável";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(3, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(569, 52);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button3.Location = new System.Drawing.Point(299, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 40);
            this.button3.TabIndex = 7;
            this.button3.Text = "&Funcionário";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "ImportDB";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importarToolStripMenuItem,
            this.ferramentasToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(584, 24);
            this.menuStrip2.TabIndex = 5;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // importarToolStripMenuItem
            // 
            this.importarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunoToolStripMenuItem,
            this.funcionárioToolStripMenuItem,
            this.responsávelToolStripMenuItem,
            this.fotosToolStripMenuItem});
            this.importarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importarToolStripMenuItem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.importarToolStripMenuItem.Name = "importarToolStripMenuItem";
            this.importarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.importarToolStripMenuItem.Text = "&Importar";
            // 
            // alunoToolStripMenuItem
            // 
            this.alunoToolStripMenuItem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
            this.alunoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.alunoToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.alunoToolStripMenuItem.Text = "Aluno";
            this.alunoToolStripMenuItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // funcionárioToolStripMenuItem
            // 
            this.funcionárioToolStripMenuItem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            this.funcionárioToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.funcionárioToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.funcionárioToolStripMenuItem.Text = "Funcionário";
            this.funcionárioToolStripMenuItem.Click += new System.EventHandler(this.button3_Click);
            // 
            // responsávelToolStripMenuItem
            // 
            this.responsávelToolStripMenuItem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.responsávelToolStripMenuItem.Name = "responsávelToolStripMenuItem";
            this.responsávelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.responsávelToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.responsávelToolStripMenuItem.Text = "Responsável";
            this.responsávelToolStripMenuItem.Click += new System.EventHandler(this.button2_Click);
            // 
            // fotosToolStripMenuItem
            // 
            this.fotosToolStripMenuItem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.fotosToolStripMenuItem.Name = "fotosToolStripMenuItem";
            this.fotosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.fotosToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.fotosToolStripMenuItem.Text = "&Fotos";
            this.fotosToolStripMenuItem.Click += new System.EventHandler(this.fotosToolStripMenuItem_Click);
            // 
            // ferramentasToolStripMenuItem
            // 
            this.ferramentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.identificadorToolStripMenuItem,
            this.alunosDuplicadosToolStripMenuItem,
            this.cAMPONOMEMAISCULOToolStripMenuItem,
            this.camposNulosToolStripMenuItem,
            this.bloquearAcessoToolStripMenuItem,
            this.patrimonioToolStripMenuItem});
            this.ferramentasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ferramentasToolStripMenuItem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            this.ferramentasToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.ferramentasToolStripMenuItem.Text = "&Manutenção";
            // 
            // identificadorToolStripMenuItem
            // 
            this.identificadorToolStripMenuItem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.identificadorToolStripMenuItem.Name = "identificadorToolStripMenuItem";
            this.identificadorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.identificadorToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.identificadorToolStripMenuItem.Text = "identificador";
            this.identificadorToolStripMenuItem.Click += new System.EventHandler(this.identificadorToolStripMenuItem_Click);
            // 
            // alunosDuplicadosToolStripMenuItem
            // 
            this.alunosDuplicadosToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.alunosDuplicadosToolStripMenuItem.Name = "alunosDuplicadosToolStripMenuItem";
            this.alunosDuplicadosToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.alunosDuplicadosToolStripMenuItem.Text = "&Cadastro Duplicado";
            this.alunosDuplicadosToolStripMenuItem.Click += new System.EventHandler(this.alunosDuplicadosToolStripMenuItem_Click);
            // 
            // cAMPONOMEMAISCULOToolStripMenuItem
            // 
            this.cAMPONOMEMAISCULOToolStripMenuItem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cAMPONOMEMAISCULOToolStripMenuItem.Name = "cAMPONOMEMAISCULOToolStripMenuItem";
            this.cAMPONOMEMAISCULOToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.cAMPONOMEMAISCULOToolStripMenuItem.Text = "Converter Campos";
            this.cAMPONOMEMAISCULOToolStripMenuItem.Click += new System.EventHandler(this.cAMPONOMEMAISCULOToolStripMenuItem_Click);
            // 
            // camposNulosToolStripMenuItem
            // 
            this.camposNulosToolStripMenuItem.ForeColor = System.Drawing.Color.DarkBlue;
            this.camposNulosToolStripMenuItem.Name = "camposNulosToolStripMenuItem";
            this.camposNulosToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.camposNulosToolStripMenuItem.Text = "Campos Nulos";
            this.camposNulosToolStripMenuItem.Click += new System.EventHandler(this.camposNulosToolStripMenuItem_Click);
            // 
            // bloquearAcessoToolStripMenuItem
            // 
            this.bloquearAcessoToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.bloquearAcessoToolStripMenuItem.Name = "bloquearAcessoToolStripMenuItem";
            this.bloquearAcessoToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.bloquearAcessoToolStripMenuItem.Text = "&Bloquear Acesso";
            this.bloquearAcessoToolStripMenuItem.Click += new System.EventHandler(this.bloquearAcessoToolStripMenuItem_Click);
            // 
            // patrimonioToolStripMenuItem
            // 
            this.patrimonioToolStripMenuItem.ForeColor = System.Drawing.Color.DarkBlue;
            this.patrimonioToolStripMenuItem.Name = "patrimonioToolStripMenuItem";
            this.patrimonioToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.patrimonioToolStripMenuItem.Text = "&Patrimônio";
            this.patrimonioToolStripMenuItem.Click += new System.EventHandler(this.patrimonioToolStripMenuItem_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 323);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImportDB v.1.2";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel tsUser;
        private System.Windows.Forms.ToolStripStatusLabel stIP;
        private System.Windows.Forms.ToolStripStatusLabel tsdata;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem importarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem responsávelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ferramentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem identificadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fotosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunosDuplicadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cAMPONOMEMAISCULOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem camposNulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bloquearAcessoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patrimonioToolStripMenuItem;
    }
}