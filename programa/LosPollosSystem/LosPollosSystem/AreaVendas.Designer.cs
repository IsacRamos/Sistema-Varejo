namespace LosPollosSystem
{
    partial class AreaVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AreaVendas));
            this.lblcodigoprod = new System.Windows.Forms.Label();
            this.txtcodigoprod = new System.Windows.Forms.TextBox();
            this.btnpesquisaprod = new System.Windows.Forms.Button();
            this.pOLLOSDataSet = new LosPollosSystem.POLLOSDataSet();
            this.listProd = new System.Windows.Forms.ListBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtcpf = new System.Windows.Forms.TextBox();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnpescli = new System.Windows.Forms.Button();
            this.btnfinaliza = new System.Windows.Forms.Button();
            this.btnFimVenda = new System.Windows.Forms.Button();
            this.grbVenda = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pOLLOSDataSet)).BeginInit();
            this.grbVenda.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblcodigoprod
            // 
            this.lblcodigoprod.AutoSize = true;
            this.lblcodigoprod.Location = new System.Drawing.Point(6, 108);
            this.lblcodigoprod.Name = "lblcodigoprod";
            this.lblcodigoprod.Size = new System.Drawing.Size(61, 13);
            this.lblcodigoprod.TabIndex = 0;
            this.lblcodigoprod.Text = "PRODUTO";
            // 
            // txtcodigoprod
            // 
            this.txtcodigoprod.Location = new System.Drawing.Point(73, 105);
            this.txtcodigoprod.Name = "txtcodigoprod";
            this.txtcodigoprod.Size = new System.Drawing.Size(100, 20);
            this.txtcodigoprod.TabIndex = 2;
            // 
            // btnpesquisaprod
            // 
            this.btnpesquisaprod.Location = new System.Drawing.Point(320, 133);
            this.btnpesquisaprod.Name = "btnpesquisaprod";
            this.btnpesquisaprod.Size = new System.Drawing.Size(89, 39);
            this.btnpesquisaprod.TabIndex = 5;
            this.btnpesquisaprod.Text = "Pesquisa item";
            this.btnpesquisaprod.UseVisualStyleBackColor = true;
            this.btnpesquisaprod.Click += new System.EventHandler(this.btnpesquisaprod_Click);
            // 
            // pOLLOSDataSet
            // 
            this.pOLLOSDataSet.DataSetName = "POLLOSDataSet";
            this.pOLLOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listProd
            // 
            this.listProd.FormattingEnabled = true;
            this.listProd.Location = new System.Drawing.Point(9, 133);
            this.listProd.Name = "listProd";
            this.listProd.Size = new System.Drawing.Size(305, 264);
            this.listProd.TabIndex = 4;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(6, 16);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 6;
            this.lblCPF.Text = "CPF:";
            // 
            // txtcpf
            // 
            this.txtcpf.Location = new System.Drawing.Point(47, 13);
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(197, 20);
            this.txtcpf.TabIndex = 7;
            // 
            // txtcliente
            // 
            this.txtcliente.Location = new System.Drawing.Point(67, 42);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.ReadOnly = true;
            this.txtcliente.Size = new System.Drawing.Size(197, 20);
            this.txtcliente.TabIndex = 9;
            this.txtcliente.TextChanged += new System.EventHandler(this.txtcliente_TextChanged);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(6, 45);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(55, 13);
            this.lblCliente.TabIndex = 8;
            this.lblCliente.Text = "CLIENTE:";
            // 
            // btnpescli
            // 
            this.btnpescli.Location = new System.Drawing.Point(270, 13);
            this.btnpescli.Name = "btnpescli";
            this.btnpescli.Size = new System.Drawing.Size(89, 39);
            this.btnpescli.TabIndex = 10;
            this.btnpescli.Text = "Pesquisa cliente";
            this.btnpescli.UseVisualStyleBackColor = true;
            this.btnpescli.Click += new System.EventHandler(this.btnpescli_Click);
            // 
            // btnfinaliza
            // 
            this.btnfinaliza.Location = new System.Drawing.Point(320, 178);
            this.btnfinaliza.Name = "btnfinaliza";
            this.btnfinaliza.Size = new System.Drawing.Size(89, 39);
            this.btnfinaliza.TabIndex = 11;
            this.btnfinaliza.Text = "Concluir Item";
            this.btnfinaliza.UseVisualStyleBackColor = true;
            this.btnfinaliza.Click += new System.EventHandler(this.btnfinaliza_Click);
            // 
            // btnFimVenda
            // 
            this.btnFimVenda.Location = new System.Drawing.Point(326, 430);
            this.btnFimVenda.Name = "btnFimVenda";
            this.btnFimVenda.Size = new System.Drawing.Size(170, 39);
            this.btnFimVenda.TabIndex = 12;
            this.btnFimVenda.Text = "Finalizar Venda";
            this.btnFimVenda.UseVisualStyleBackColor = true;
            this.btnFimVenda.Click += new System.EventHandler(this.btnFimVenda_Click);
            // 
            // grbVenda
            // 
            this.grbVenda.Controls.Add(this.lblCPF);
            this.grbVenda.Controls.Add(this.lblcodigoprod);
            this.grbVenda.Controls.Add(this.btnfinaliza);
            this.grbVenda.Controls.Add(this.txtcodigoprod);
            this.grbVenda.Controls.Add(this.btnpescli);
            this.grbVenda.Controls.Add(this.listProd);
            this.grbVenda.Controls.Add(this.txtcliente);
            this.grbVenda.Controls.Add(this.btnpesquisaprod);
            this.grbVenda.Controls.Add(this.lblCliente);
            this.grbVenda.Controls.Add(this.txtcpf);
            this.grbVenda.Location = new System.Drawing.Point(12, 12);
            this.grbVenda.Name = "grbVenda";
            this.grbVenda.Size = new System.Drawing.Size(484, 412);
            this.grbVenda.TabIndex = 13;
            this.grbVenda.TabStop = false;
            this.grbVenda.Text = "Venda";
            // 
            // AreaVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 599);
            this.Controls.Add(this.grbVenda);
            this.Controls.Add(this.btnFimVenda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AreaVendas";
            this.Text = "AreaVendas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AreaVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pOLLOSDataSet)).EndInit();
            this.grbVenda.ResumeLayout(false);
            this.grbVenda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblcodigoprod;
        private System.Windows.Forms.TextBox txtcodigoprod;
        private System.Windows.Forms.Button btnpesquisaprod;
        private POLLOSDataSet pOLLOSDataSet;
        private System.Windows.Forms.ListBox listProd;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtcpf;
        private System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnpescli;
        private System.Windows.Forms.Button btnfinaliza;
        private System.Windows.Forms.Button btnFimVenda;
        private System.Windows.Forms.GroupBox grbVenda;
    }
}