namespace Gerenciador
{
    partial class VisEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisEstoque));
            this.pOLLOSDataSet = new Gerenciador.POLLOSDataSet();
            this.eSTOQUEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eSTOQUETableAdapter = new Gerenciador.POLLOSDataSetTableAdapters.ESTOQUETableAdapter();
            this.tableAdapterManager = new Gerenciador.POLLOSDataSetTableAdapters.TableAdapterManager();
            this.eSTOQUEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.eSTOQUEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.eSTOQUEDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblproduto = new System.Windows.Forms.Label();
            this.cmbProd = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pOLLOSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTOQUEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTOQUEBindingNavigator)).BeginInit();
            this.eSTOQUEBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eSTOQUEDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pOLLOSDataSet
            // 
            this.pOLLOSDataSet.DataSetName = "POLLOSDataSet";
            this.pOLLOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eSTOQUEBindingSource
            // 
            this.eSTOQUEBindingSource.DataMember = "ESTOQUE";
            this.eSTOQUEBindingSource.DataSource = this.pOLLOSDataSet;
            // 
            // eSTOQUETableAdapter
            // 
            this.eSTOQUETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ESTOQUETableAdapter = this.eSTOQUETableAdapter;
            this.tableAdapterManager.UpdateOrder = Gerenciador.POLLOSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOTableAdapter = null;
            // 
            // eSTOQUEBindingNavigator
            // 
            this.eSTOQUEBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.eSTOQUEBindingNavigator.BindingSource = this.eSTOQUEBindingSource;
            this.eSTOQUEBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.eSTOQUEBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.eSTOQUEBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.eSTOQUEBindingNavigatorSaveItem});
            this.eSTOQUEBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.eSTOQUEBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.eSTOQUEBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.eSTOQUEBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.eSTOQUEBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.eSTOQUEBindingNavigator.Name = "eSTOQUEBindingNavigator";
            this.eSTOQUEBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.eSTOQUEBindingNavigator.Size = new System.Drawing.Size(536, 25);
            this.eSTOQUEBindingNavigator.TabIndex = 0;
            this.eSTOQUEBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // eSTOQUEBindingNavigatorSaveItem
            // 
            this.eSTOQUEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eSTOQUEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("eSTOQUEBindingNavigatorSaveItem.Image")));
            this.eSTOQUEBindingNavigatorSaveItem.Name = "eSTOQUEBindingNavigatorSaveItem";
            this.eSTOQUEBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.eSTOQUEBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.eSTOQUEBindingNavigatorSaveItem.Click += new System.EventHandler(this.eSTOQUEBindingNavigatorSaveItem_Click);
            // 
            // eSTOQUEDataGridView
            // 
            this.eSTOQUEDataGridView.AutoGenerateColumns = false;
            this.eSTOQUEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eSTOQUEDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.eSTOQUEDataGridView.DataSource = this.eSTOQUEBindingSource;
            this.eSTOQUEDataGridView.Location = new System.Drawing.Point(12, 136);
            this.eSTOQUEDataGridView.Name = "eSTOQUEDataGridView";
            this.eSTOQUEDataGridView.Size = new System.Drawing.Size(300, 220);
            this.eSTOQUEDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDESTOQUE";
            this.dataGridViewTextBoxColumn1.HeaderText = "IDESTOQUE";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PRODUTO";
            this.dataGridViewTextBoxColumn2.HeaderText = "PRODUTO";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "QTDE";
            this.dataGridViewTextBoxColumn3.HeaderText = "QTDE";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // lblproduto
            // 
            this.lblproduto.AutoSize = true;
            this.lblproduto.Location = new System.Drawing.Point(12, 56);
            this.lblproduto.Name = "lblproduto";
            this.lblproduto.Size = new System.Drawing.Size(47, 13);
            this.lblproduto.TabIndex = 2;
            this.lblproduto.Text = "Produto:";
            // 
            // cmbProd
            // 
            this.cmbProd.FormattingEnabled = true;
            this.cmbProd.Location = new System.Drawing.Point(65, 53);
            this.cmbProd.Name = "cmbProd";
            this.cmbProd.Size = new System.Drawing.Size(121, 21);
            this.cmbProd.TabIndex = 3;
            this.cmbProd.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // VisEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 368);
            this.Controls.Add(this.cmbProd);
            this.Controls.Add(this.lblproduto);
            this.Controls.Add(this.eSTOQUEDataGridView);
            this.Controls.Add(this.eSTOQUEBindingNavigator);
            this.Name = "VisEstoque";
            this.Text = "Consulta do Estoque";
            this.Load += new System.EventHandler(this.VisEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pOLLOSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTOQUEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTOQUEBindingNavigator)).EndInit();
            this.eSTOQUEBindingNavigator.ResumeLayout(false);
            this.eSTOQUEBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eSTOQUEDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private POLLOSDataSet pOLLOSDataSet;
        private System.Windows.Forms.BindingSource eSTOQUEBindingSource;
        private POLLOSDataSetTableAdapters.ESTOQUETableAdapter eSTOQUETableAdapter;
        private POLLOSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator eSTOQUEBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton eSTOQUEBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView eSTOQUEDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label lblproduto;
        private System.Windows.Forms.ComboBox cmbProd;
    }
}