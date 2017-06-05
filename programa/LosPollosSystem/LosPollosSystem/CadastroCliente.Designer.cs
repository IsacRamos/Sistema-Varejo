namespace LosPollosSystem
{
    partial class CadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroCliente));
            this.pOLLOSDataSet = new LosPollosSystem.POLLOSDataSet();
            this.cLIENTESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTESTableAdapter = new LosPollosSystem.POLLOSDataSetTableAdapters.CLIENTESTableAdapter();
            this.tableAdapterManager = new LosPollosSystem.POLLOSDataSetTableAdapters.TableAdapterManager();
            this.GrbCadastroCli = new System.Windows.Forms.GroupBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.txtpais = new System.Windows.Forms.TextBox();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.txtfone = new System.Windows.Forms.TextBox();
            this.txtddd = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.brnInserirCli = new System.Windows.Forms.Button();
            this.btnDeletarCli = new System.Windows.Forms.Button();
            this.brnAlterarCli = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCPF = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pOLLOSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESBindingSource)).BeginInit();
            this.GrbCadastroCli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCPF)).BeginInit();
            this.SuspendLayout();
            // 
            // pOLLOSDataSet
            // 
            this.pOLLOSDataSet.DataSetName = "POLLOSDataSet";
            this.pOLLOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cLIENTESBindingSource
            // 
            this.cLIENTESBindingSource.DataMember = "CLIENTES";
            this.cLIENTESBindingSource.DataSource = this.pOLLOSDataSet;
            // 
            // cLIENTESTableAdapter
            // 
            this.cLIENTESTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CLIENTESTableAdapter = this.cLIENTESTableAdapter;
            this.tableAdapterManager.ESTOQUETableAdapter = null;
            this.tableAdapterManager.PAISESTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LosPollosSystem.POLLOSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOTableAdapter = null;
            // 
            // GrbCadastroCli
            // 
            this.GrbCadastroCli.Controls.Add(this.txtCPF);
            this.GrbCadastroCli.Controls.Add(this.label9);
            this.GrbCadastroCli.Controls.Add(this.label8);
            this.GrbCadastroCli.Controls.Add(this.label7);
            this.GrbCadastroCli.Controls.Add(this.label6);
            this.GrbCadastroCli.Controls.Add(this.label5);
            this.GrbCadastroCli.Controls.Add(this.label4);
            this.GrbCadastroCli.Controls.Add(this.label3);
            this.GrbCadastroCli.Controls.Add(this.label2);
            this.GrbCadastroCli.Controls.Add(this.label1);
            this.GrbCadastroCli.Controls.Add(this.txtcidade);
            this.GrbCadastroCli.Controls.Add(this.txtestado);
            this.GrbCadastroCli.Controls.Add(this.txtpais);
            this.GrbCadastroCli.Controls.Add(this.txtendereco);
            this.GrbCadastroCli.Controls.Add(this.txtfone);
            this.GrbCadastroCli.Controls.Add(this.txtddd);
            this.GrbCadastroCli.Controls.Add(this.txtemail);
            this.GrbCadastroCli.Controls.Add(this.txtcliente);
            this.GrbCadastroCli.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbCadastroCli.Location = new System.Drawing.Point(12, 12);
            this.GrbCadastroCli.Name = "GrbCadastroCli";
            this.GrbCadastroCli.Size = new System.Drawing.Size(552, 370);
            this.GrbCadastroCli.TabIndex = 0;
            this.GrbCadastroCli.TabStop = false;
            this.GrbCadastroCli.Text = "Cadastro";
            this.GrbCadastroCli.Enter += new System.EventHandler(this.GrbCadastroCli_Enter);
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(88, 49);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(151, 22);
            this.txtCPF.TabIndex = 2;
            this.txtCPF.TextChanged += new System.EventHandler(this.txtCPF_TextChanged);
            this.txtCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCPF_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 14);
            this.label9.TabIndex = 24;
            this.label9.Text = "CPF:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 14);
            this.label8.TabIndex = 23;
            this.label8.Text = "CIDADE:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 14);
            this.label7.TabIndex = 22;
            this.label7.Text = "ESTADO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 14);
            this.label6.TabIndex = 21;
            this.label6.Text = "PAIS:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 14);
            this.label5.TabIndex = 20;
            this.label5.Text = "ENDEREÇO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 14);
            this.label4.TabIndex = 19;
            this.label4.Text = "TELEFONE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 14);
            this.label3.TabIndex = 18;
            this.label3.Text = "DDD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 14);
            this.label2.TabIndex = 17;
            this.label2.Text = "EMAIL:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 16;
            this.label1.Text = "NOME:";
            // 
            // txtcidade
            // 
            this.txtcidade.Location = new System.Drawing.Point(88, 245);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(100, 22);
            this.txtcidade.TabIndex = 9;
            // 
            // txtestado
            // 
            this.txtestado.Location = new System.Drawing.Point(88, 217);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(100, 22);
            this.txtestado.TabIndex = 8;
            // 
            // txtpais
            // 
            this.txtpais.Location = new System.Drawing.Point(88, 189);
            this.txtpais.Name = "txtpais";
            this.txtpais.Size = new System.Drawing.Size(100, 22);
            this.txtpais.TabIndex = 7;
            // 
            // txtendereco
            // 
            this.txtendereco.Location = new System.Drawing.Point(88, 161);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(320, 22);
            this.txtendereco.TabIndex = 6;
            // 
            // txtfone
            // 
            this.txtfone.Location = new System.Drawing.Point(88, 133);
            this.txtfone.Name = "txtfone";
            this.txtfone.Size = new System.Drawing.Size(151, 22);
            this.txtfone.TabIndex = 5;
            this.txtfone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfone_KeyPress);
            // 
            // txtddd
            // 
            this.txtddd.Location = new System.Drawing.Point(88, 105);
            this.txtddd.Name = "txtddd";
            this.txtddd.Size = new System.Drawing.Size(100, 22);
            this.txtddd.TabIndex = 4;
            this.txtddd.TextChanged += new System.EventHandler(this.txtddd_TextChanged);
            this.txtddd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtddd_KeyPress);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(88, 77);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(279, 22);
            this.txtemail.TabIndex = 3;
            // 
            // txtcliente
            // 
            this.txtcliente.Location = new System.Drawing.Point(89, 21);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Size = new System.Drawing.Size(279, 22);
            this.txtcliente.TabIndex = 1;
            // 
            // brnInserirCli
            // 
            this.brnInserirCli.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnInserirCli.Location = new System.Drawing.Point(582, 99);
            this.brnInserirCli.Name = "brnInserirCli";
            this.brnInserirCli.Size = new System.Drawing.Size(90, 44);
            this.brnInserirCli.TabIndex = 2;
            this.brnInserirCli.Text = "Cadastrar";
            this.brnInserirCli.UseVisualStyleBackColor = true;
            this.brnInserirCli.Click += new System.EventHandler(this.brnInserirCli_Click);
            // 
            // btnDeletarCli
            // 
            this.btnDeletarCli.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarCli.Location = new System.Drawing.Point(582, 149);
            this.btnDeletarCli.Name = "btnDeletarCli";
            this.btnDeletarCli.Size = new System.Drawing.Size(90, 44);
            this.btnDeletarCli.TabIndex = 3;
            this.btnDeletarCli.Text = "Deletar";
            this.btnDeletarCli.UseVisualStyleBackColor = true;
            this.btnDeletarCli.Click += new System.EventHandler(this.btnDeletarCli_Click);
            // 
            // brnAlterarCli
            // 
            this.brnAlterarCli.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnAlterarCli.Location = new System.Drawing.Point(582, 199);
            this.brnAlterarCli.Name = "brnAlterarCli";
            this.brnAlterarCli.Size = new System.Drawing.Size(90, 44);
            this.brnAlterarCli.TabIndex = 4;
            this.brnAlterarCli.Text = "Alterar";
            this.brnAlterarCli.UseVisualStyleBackColor = true;
            this.brnAlterarCli.Click += new System.EventHandler(this.brnAlterarCli_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(582, 249);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(90, 44);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(285, 388);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(279, 44);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.Location = new System.Drawing.Point(582, 49);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(90, 44);
            this.btnConsulta.TabIndex = 1;
            this.btnConsulta.Text = "Pesquisar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LosPollosSystem.Properties.Resources.Los_Pollos_Hermanos_logo_600x257;
            this.pictureBox1.Location = new System.Drawing.Point(711, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(628, 269);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // lblCPF
            // 
            this.lblCPF.Image = global::LosPollosSystem.Properties.Resources.RMIVS3;
            this.lblCPF.Location = new System.Drawing.Point(889, 311);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(279, 113);
            this.lblCPF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.lblCPF.TabIndex = 26;
            this.lblCPF.TabStop = false;
            // 
            // CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1535, 707);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.brnInserirCli);
            this.Controls.Add(this.btnDeletarCli);
            this.Controls.Add(this.brnAlterarCli);
            this.Controls.Add(this.GrbCadastroCli);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroCliente";
            this.Text = "Cadastro de Cliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CadastroCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pOLLOSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESBindingSource)).EndInit();
            this.GrbCadastroCli.ResumeLayout(false);
            this.GrbCadastroCli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCPF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private POLLOSDataSet pOLLOSDataSet;
        private System.Windows.Forms.BindingSource cLIENTESBindingSource;
        private POLLOSDataSetTableAdapters.CLIENTESTableAdapter cLIENTESTableAdapter;
        private POLLOSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox GrbCadastroCli;
        private System.Windows.Forms.Button brnInserirCli;
        private System.Windows.Forms.Button btnDeletarCli;
        private System.Windows.Forms.Button brnAlterarCli;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.TextBox txtestado;
        private System.Windows.Forms.TextBox txtpais;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.TextBox txtfone;
        private System.Windows.Forms.TextBox txtddd;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox lblCPF;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label label9;
    }
}