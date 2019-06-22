namespace IntelliFactorySystem
{
    partial class N2Produto
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
            System.Windows.Forms.Label idProdutoLabel;
            System.Windows.Forms.Label nomeProdutoLabel;
            System.Windows.Forms.Label categoriaProdutoLabel;
            System.Windows.Forms.Label quantidadeProdutoEstoqueLabel;
            System.Windows.Forms.Label descricaoProdutoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(N2Produto));
            this.intelliFactoryDatabaseDataSet1 = new IntelliFactorySystem.IntelliFactoryDatabaseDataSet1();
            this.produtoComputadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoComputadorTableAdapter = new IntelliFactorySystem.IntelliFactoryDatabaseDataSet1TableAdapters.ProdutoComputadorTableAdapter();
            this.tableAdapterManager = new IntelliFactorySystem.IntelliFactoryDatabaseDataSet1TableAdapters.TableAdapterManager();
            this.produtoComputadorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.produtoComputadorBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idProdutoTextBox = new System.Windows.Forms.TextBox();
            this.nomeProdutoTextBox = new System.Windows.Forms.TextBox();
            this.categoriaProdutoTextBox = new System.Windows.Forms.TextBox();
            this.quantidadeProdutoEstoqueTextBox = new System.Windows.Forms.TextBox();
            this.descricaoProdutoTextBox = new System.Windows.Forms.TextBox();
            this.produtoComputadorDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            idProdutoLabel = new System.Windows.Forms.Label();
            nomeProdutoLabel = new System.Windows.Forms.Label();
            categoriaProdutoLabel = new System.Windows.Forms.Label();
            quantidadeProdutoEstoqueLabel = new System.Windows.Forms.Label();
            descricaoProdutoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.intelliFactoryDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoComputadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoComputadorBindingNavigator)).BeginInit();
            this.produtoComputadorBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoComputadorDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idProdutoLabel
            // 
            idProdutoLabel.AutoSize = true;
            idProdutoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idProdutoLabel.Location = new System.Drawing.Point(73, 108);
            idProdutoLabel.Name = "idProdutoLabel";
            idProdutoLabel.Size = new System.Drawing.Size(123, 20);
            idProdutoLabel.TabIndex = 1;
            idProdutoLabel.Text = "Id do Produto:";
            // 
            // nomeProdutoLabel
            // 
            nomeProdutoLabel.AutoSize = true;
            nomeProdutoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeProdutoLabel.Location = new System.Drawing.Point(73, 144);
            nomeProdutoLabel.Name = "nomeProdutoLabel";
            nomeProdutoLabel.Size = new System.Drawing.Size(153, 20);
            nomeProdutoLabel.TabIndex = 3;
            nomeProdutoLabel.Text = "Nome do Produto:";
            // 
            // categoriaProdutoLabel
            // 
            categoriaProdutoLabel.AutoSize = true;
            categoriaProdutoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            categoriaProdutoLabel.Location = new System.Drawing.Point(73, 180);
            categoriaProdutoLabel.Name = "categoriaProdutoLabel";
            categoriaProdutoLabel.Size = new System.Drawing.Size(185, 20);
            categoriaProdutoLabel.TabIndex = 5;
            categoriaProdutoLabel.Text = "Categoria do Produto:";
            // 
            // quantidadeProdutoEstoqueLabel
            // 
            quantidadeProdutoEstoqueLabel.AutoSize = true;
            quantidadeProdutoEstoqueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            quantidadeProdutoEstoqueLabel.Location = new System.Drawing.Point(73, 216);
            quantidadeProdutoEstoqueLabel.Name = "quantidadeProdutoEstoqueLabel";
            quantidadeProdutoEstoqueLabel.Size = new System.Drawing.Size(297, 20);
            quantidadeProdutoEstoqueLabel.TabIndex = 7;
            quantidadeProdutoEstoqueLabel.Text = "Quantidade de Produto no Estoque:";
            // 
            // descricaoProdutoLabel
            // 
            descricaoProdutoLabel.AutoSize = true;
            descricaoProdutoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descricaoProdutoLabel.Location = new System.Drawing.Point(73, 252);
            descricaoProdutoLabel.Name = "descricaoProdutoLabel";
            descricaoProdutoLabel.Size = new System.Drawing.Size(187, 20);
            descricaoProdutoLabel.TabIndex = 9;
            descricaoProdutoLabel.Text = "Descricão do Produto:";
            // 
            // intelliFactoryDatabaseDataSet1
            // 
            this.intelliFactoryDatabaseDataSet1.DataSetName = "IntelliFactoryDatabaseDataSet1";
            this.intelliFactoryDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtoComputadorBindingSource
            // 
            this.produtoComputadorBindingSource.DataMember = "ProdutoComputador";
            this.produtoComputadorBindingSource.DataSource = this.intelliFactoryDatabaseDataSet1;
            // 
            // produtoComputadorTableAdapter
            // 
            this.produtoComputadorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.ComponenteTableAdapter = null;
            this.tableAdapterManager.ControleGarantiaTableAdapter = null;
            this.tableAdapterManager.ControlePedidoCompraTableAdapter = null;
            this.tableAdapterManager.ControleQualidadeTableAdapter = null;
            this.tableAdapterManager.FornecedorTableAdapter = null;
            this.tableAdapterManager.FuncionarioTableAdapter = null;
            this.tableAdapterManager.GarantiaTableAdapter = null;
            this.tableAdapterManager.LoginTableAdapter = null;
            this.tableAdapterManager.LoteMontagemTableAdapter = null;
            this.tableAdapterManager.ProdutoComputadorTableAdapter = this.produtoComputadorTableAdapter;
            this.tableAdapterManager.UpdateOrder = IntelliFactorySystem.IntelliFactoryDatabaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // produtoComputadorBindingNavigator
            // 
            this.produtoComputadorBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.produtoComputadorBindingNavigator.BindingSource = this.produtoComputadorBindingSource;
            this.produtoComputadorBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.produtoComputadorBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.produtoComputadorBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.produtoComputadorBindingNavigatorSaveItem});
            this.produtoComputadorBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.produtoComputadorBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.produtoComputadorBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.produtoComputadorBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.produtoComputadorBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.produtoComputadorBindingNavigator.Name = "produtoComputadorBindingNavigator";
            this.produtoComputadorBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.produtoComputadorBindingNavigator.Size = new System.Drawing.Size(692, 25);
            this.produtoComputadorBindingNavigator.TabIndex = 0;
            this.produtoComputadorBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
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
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // produtoComputadorBindingNavigatorSaveItem
            // 
            this.produtoComputadorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.produtoComputadorBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("produtoComputadorBindingNavigatorSaveItem.Image")));
            this.produtoComputadorBindingNavigatorSaveItem.Name = "produtoComputadorBindingNavigatorSaveItem";
            this.produtoComputadorBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.produtoComputadorBindingNavigatorSaveItem.Text = "Save Data";
            this.produtoComputadorBindingNavigatorSaveItem.Click += new System.EventHandler(this.produtoComputadorBindingNavigatorSaveItem_Click);
            // 
            // idProdutoTextBox
            // 
            this.idProdutoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoComputadorBindingSource, "IdProduto", true));
            this.idProdutoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idProdutoTextBox.Location = new System.Drawing.Point(213, 108);
            this.idProdutoTextBox.Name = "idProdutoTextBox";
            this.idProdutoTextBox.Size = new System.Drawing.Size(337, 26);
            this.idProdutoTextBox.TabIndex = 2;
            // 
            // nomeProdutoTextBox
            // 
            this.nomeProdutoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoComputadorBindingSource, "NomeProduto", true));
            this.nomeProdutoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeProdutoTextBox.Location = new System.Drawing.Point(240, 144);
            this.nomeProdutoTextBox.Name = "nomeProdutoTextBox";
            this.nomeProdutoTextBox.Size = new System.Drawing.Size(310, 26);
            this.nomeProdutoTextBox.TabIndex = 4;
            // 
            // categoriaProdutoTextBox
            // 
            this.categoriaProdutoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoComputadorBindingSource, "CategoriaProduto", true));
            this.categoriaProdutoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriaProdutoTextBox.Location = new System.Drawing.Point(276, 180);
            this.categoriaProdutoTextBox.Name = "categoriaProdutoTextBox";
            this.categoriaProdutoTextBox.Size = new System.Drawing.Size(274, 26);
            this.categoriaProdutoTextBox.TabIndex = 6;
            // 
            // quantidadeProdutoEstoqueTextBox
            // 
            this.quantidadeProdutoEstoqueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoComputadorBindingSource, "QuantidadeProdutoEstoque", true));
            this.quantidadeProdutoEstoqueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantidadeProdutoEstoqueTextBox.Location = new System.Drawing.Point(378, 216);
            this.quantidadeProdutoEstoqueTextBox.Name = "quantidadeProdutoEstoqueTextBox";
            this.quantidadeProdutoEstoqueTextBox.Size = new System.Drawing.Size(172, 26);
            this.quantidadeProdutoEstoqueTextBox.TabIndex = 8;
            // 
            // descricaoProdutoTextBox
            // 
            this.descricaoProdutoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoComputadorBindingSource, "DescricaoProduto", true));
            this.descricaoProdutoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoProdutoTextBox.Location = new System.Drawing.Point(266, 252);
            this.descricaoProdutoTextBox.Name = "descricaoProdutoTextBox";
            this.descricaoProdutoTextBox.Size = new System.Drawing.Size(284, 26);
            this.descricaoProdutoTextBox.TabIndex = 10;
            // 
            // produtoComputadorDataGridView
            // 
            this.produtoComputadorDataGridView.AutoGenerateColumns = false;
            this.produtoComputadorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produtoComputadorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.produtoComputadorDataGridView.DataSource = this.produtoComputadorBindingSource;
            this.produtoComputadorDataGridView.Location = new System.Drawing.Point(52, 400);
            this.produtoComputadorDataGridView.Name = "produtoComputadorDataGridView";
            this.produtoComputadorDataGridView.Size = new System.Drawing.Size(580, 220);
            this.produtoComputadorDataGridView.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdProduto";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdProduto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NomeProduto";
            this.dataGridViewTextBoxColumn2.HeaderText = "NomeProduto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CategoriaProduto";
            this.dataGridViewTextBoxColumn3.HeaderText = "CategoriaProduto";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "QuantidadeProdutoEstoque";
            this.dataGridViewTextBoxColumn4.HeaderText = "QuantidadeProdutoEstoque";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DescricaoProduto";
            this.dataGridViewTextBoxColumn5.HeaderText = "DescricaoProduto";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(561, 326);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 33);
            this.button7.TabIndex = 22;
            this.button7.Text = "Anterior";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(431, 326);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 33);
            this.button8.TabIndex = 21;
            this.button8.Text = "Próximo";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(305, 326);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 33);
            this.button9.TabIndex = 20;
            this.button9.Text = "Remover";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(181, 326);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 33);
            this.button10.TabIndex = 19;
            this.button10.Text = "Salvar";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(56, 326);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 33);
            this.button11.TabIndex = 18;
            this.button11.Text = "Novo";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 26);
            this.label1.TabIndex = 23;
            this.label1.Text = "PRODUTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(625, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "_________________________________________________________________________________" +
    "______________________";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(597, 38);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 33);
            this.button6.TabIndex = 25;
            this.button6.Text = "Sair";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // N2Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IntelliFactorySystem.Properties.Resources.BACKGROUND;
            this.ClientSize = new System.Drawing.Size(692, 685);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.produtoComputadorDataGridView);
            this.Controls.Add(idProdutoLabel);
            this.Controls.Add(this.idProdutoTextBox);
            this.Controls.Add(nomeProdutoLabel);
            this.Controls.Add(this.nomeProdutoTextBox);
            this.Controls.Add(categoriaProdutoLabel);
            this.Controls.Add(this.categoriaProdutoTextBox);
            this.Controls.Add(quantidadeProdutoEstoqueLabel);
            this.Controls.Add(this.quantidadeProdutoEstoqueTextBox);
            this.Controls.Add(descricaoProdutoLabel);
            this.Controls.Add(this.descricaoProdutoTextBox);
            this.Controls.Add(this.produtoComputadorBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "N2Produto";
            this.Text = "Produto";
            this.Load += new System.EventHandler(this.N2Produto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.intelliFactoryDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoComputadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoComputadorBindingNavigator)).EndInit();
            this.produtoComputadorBindingNavigator.ResumeLayout(false);
            this.produtoComputadorBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoComputadorDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private IntelliFactoryDatabaseDataSet1 intelliFactoryDatabaseDataSet1;
        private System.Windows.Forms.BindingSource produtoComputadorBindingSource;
        private IntelliFactoryDatabaseDataSet1TableAdapters.ProdutoComputadorTableAdapter produtoComputadorTableAdapter;
        private IntelliFactoryDatabaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator produtoComputadorBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton produtoComputadorBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idProdutoTextBox;
        private System.Windows.Forms.TextBox nomeProdutoTextBox;
        private System.Windows.Forms.TextBox categoriaProdutoTextBox;
        private System.Windows.Forms.TextBox quantidadeProdutoEstoqueTextBox;
        private System.Windows.Forms.TextBox descricaoProdutoTextBox;
        private System.Windows.Forms.DataGridView produtoComputadorDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button6;
    }
}