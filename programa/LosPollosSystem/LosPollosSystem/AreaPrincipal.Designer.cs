namespace LosPollosSystem
{
    partial class AreaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AreaPrincipal));
            this.btnvendas = new System.Windows.Forms.Button();
            this.btnCadaCliente = new System.Windows.Forms.Button();
            this.btnrelatorios = new System.Windows.Forms.Button();
            this.btnestoque = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnvendas
            // 
            this.btnvendas.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvendas.Location = new System.Drawing.Point(22, 305);
            this.btnvendas.Name = "btnvendas";
            this.btnvendas.Size = new System.Drawing.Size(107, 103);
            this.btnvendas.TabIndex = 0;
            this.btnvendas.Text = "Vendas";
            this.btnvendas.UseVisualStyleBackColor = true;
            this.btnvendas.Click += new System.EventHandler(this.btnvendas_Click);
            // 
            // btnCadaCliente
            // 
            this.btnCadaCliente.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadaCliente.Location = new System.Drawing.Point(136, 306);
            this.btnCadaCliente.Name = "btnCadaCliente";
            this.btnCadaCliente.Size = new System.Drawing.Size(107, 103);
            this.btnCadaCliente.TabIndex = 1;
            this.btnCadaCliente.Text = "Cadastro de Cliente";
            this.btnCadaCliente.UseVisualStyleBackColor = true;
            this.btnCadaCliente.Click += new System.EventHandler(this.btnCadaCliente_Click);
            // 
            // btnrelatorios
            // 
            this.btnrelatorios.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrelatorios.Location = new System.Drawing.Point(249, 305);
            this.btnrelatorios.Name = "btnrelatorios";
            this.btnrelatorios.Size = new System.Drawing.Size(107, 103);
            this.btnrelatorios.TabIndex = 2;
            this.btnrelatorios.Text = "Relatorios";
            this.btnrelatorios.UseVisualStyleBackColor = true;
            this.btnrelatorios.Click += new System.EventHandler(this.btnrelatorios_Click);
            // 
            // btnestoque
            // 
            this.btnestoque.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnestoque.Location = new System.Drawing.Point(362, 306);
            this.btnestoque.Name = "btnestoque";
            this.btnestoque.Size = new System.Drawing.Size(107, 103);
            this.btnestoque.TabIndex = 3;
            this.btnestoque.Text = "Estoque";
            this.btnestoque.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LosPollosSystem.Properties.Resources.RMIVS31;
            this.pictureBox2.Location = new System.Drawing.Point(530, 359);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(96, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LosPollosSystem.Properties.Resources.Los_Pollos_Hermanos_logo_600x257;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(614, 264);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // AreaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 421);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnestoque);
            this.Controls.Add(this.btnrelatorios);
            this.Controls.Add(this.btnCadaCliente);
            this.Controls.Add(this.btnvendas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AreaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AreaPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnvendas;
        private System.Windows.Forms.Button btnCadaCliente;
        private System.Windows.Forms.Button btnrelatorios;
        private System.Windows.Forms.Button btnestoque;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}