namespace IntelliFactorySystem
{
    partial class N9Pedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(N9Pedidos));
            System.Windows.Forms.Label idPedidoLabel;
            System.Windows.Forms.Label nomeProdutoLabel;
            System.Windows.Forms.Label quantidadeProdutoLabel;
            System.Windows.Forms.Label descricaoProdutoLabel;
            System.Windows.Forms.Label valorProdutoLabel;
            System.Windows.Forms.Label valorPedidoLabel;
            System.Windows.Forms.Label idProdutoComputadorLabel;
            this.intelliFactoryDatabaseDataSet1 = new IntelliFactorySystem.IntelliFactoryDatabaseDataSet1();
            this.controlePedidoCompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controlePedidoCompraTableAdapter = new IntelliFactorySystem.IntelliFactoryDatabaseDataSet1TableAdapters.ControlePedidoCompraTableAdapter();
            this.tableAdapterManager = new IntelliFactorySystem.IntelliFactoryDatabaseDataSet1TableAdapters.TableAdapterManager();
            this.controlePedidoCompraBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.controlePedidoCompraBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.controlePedidoCompraDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPedidoTextBox = new System.Windows.Forms.TextBox();
            this.nomeProdutoTextBox = new System.Windows.Forms.TextBox();
            this.quantidadeProdutoTextBox = new System.Windows.Forms.TextBox();
            this.descricaoProdutoTextBox = new System.Windows.Forms.TextBox();
            this.valorProdutoTextBox = new System.Windows.Forms.TextBox();
            this.valorPedidoTextBox = new System.Windows.Forms.TextBox();
            this.idProdutoComputadorTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            idPedidoLabel = new System.Windows.Forms.Label();
            nomeProdutoLabel = new System.Windows.Forms.Label();
            quantidadeProdutoLabel = new System.Windows.Forms.Label();
            descricaoProdutoLabel = new System.Windows.Forms.Label();
            valorProdutoLabel = new System.Windows.Forms.Label();
            valorPedidoLabel = new System.Windows.Forms.Label();
            idProdutoComputadorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.intelliFactoryDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlePedidoCompraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlePedidoCompraBindingNavigator)).BeginInit();
            this.controlePedidoCompraBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.controlePedidoCompraDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // intelliFactoryDatabaseDataSet1
            // 
            this.intelliFactoryDatabaseDataSet1.DataSetName = "IntelliFactoryDatabaseDataSet1";
            this.intelliFactoryDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // controlePedidoCompraBindingSource
            // 
            this.controlePedidoCompraBindingSource.DataMember = "ControlePedidoCompra";
            this.controlePedidoCompraBindingSource.DataSource = this.intelliFactoryDatabaseDataSet1;
            // 
            // controlePedidoCompraTableAdapter
            // 
            this.controlePedidoCompraTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.ComponenteTableAdapter = null;
            this.tableAdapterManager.ControleGarantiaTableAdapter = null;
            this.tableAdapterManager.ControlePedidoCompraTableAdapter = this.controlePedidoCompraTableAdapter;
            this.tableAdapterManager.ControleQualidadeTableAdapter = null;
            this.tableAdapterManager.FornecedorTableAdapter = null;
            this.tableAdapterManager.FuncionarioTableAdapter = null;
            this.tableAdapterManager.GarantiaTableAdapter = null;
            this.tableAdapterManager.LoginTableAdapter = null;
            this.tableAdapterManager.LoteMontagemTableAdapter = null;
            this.tableAdapterManager.ProdutoComputadorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = IntelliFactorySystem.IntelliFactoryDatabaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // controlePedidoCompraBindingNavigator
            // 
            this.controlePedidoCompraBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.controlePedidoCompraBindingNavigator.BindingSource = this.controlePedidoCompraBindingSource;
            this.controlePedidoCompraBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.controlePedidoCompraBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.controlePedidoCompraBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.controlePedidoCompraBindingNavigatorSaveItem});
            this.controlePedidoCompraBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.controlePedidoCompraBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.controlePedidoCompraBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.controlePedidoCompraBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.controlePedidoCompraBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.controlePedidoCompraBindingNavigator.Name = "controlePedidoCompraBindingNavigator";
            this.controlePedidoCompraBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.controlePedidoCompraBindingNavigator.Size = new System.Drawing.Size(884, 25);
            this.controlePedidoCompraBindingNavigator.TabIndex = 0;
            this.controlePedidoCompraBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // controlePedidoCompraBindingNavigatorSaveItem
            // 
            this.controlePedidoCompraBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.controlePedidoCompraBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("controlePedidoCompraBindingNavigatorSaveItem.Image")));
            this.controlePedidoCompraBindingNavigatorSaveItem.Name = "controlePedidoCompraBindingNavigatorSaveItem";
            this.controlePedidoCompraBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.controlePedidoCompraBindingNavigatorSaveItem.Text = "Save Data";
            this.controlePedidoCompraBindingNavigatorSaveItem.Click += new System.EventHandler(this.controlePedidoCompraBindingNavigatorSaveItem_Click);
            // 
            // controlePedidoCompraDataGridView
            // 
            this.controlePedidoCompraDataGridView.AutoGenerateColumns = false;
            this.controlePedidoCompraDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.controlePedidoCompraDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.controlePedidoCompraDataGridView.DataSource = this.controlePedidoCompraBindingSource;
            this.controlePedidoCompraDataGridView.Location = new System.Drawing.Point(52, 400);
            this.controlePedidoCompraDataGridView.Name = "controlePedidoCompraDataGridView";
            this.controlePedidoCompraDataGridView.Size = new System.Drawing.Size(772, 220);
            this.controlePedidoCompraDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdPedido";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdPedido";
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "QuantidadeProduto";
            this.dataGridViewTextBoxColumn3.HeaderText = "QuantidadeProduto";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DescricaoProduto";
            this.dataGridViewTextBoxColumn4.HeaderText = "DescricaoProduto";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ValorProduto";
            this.dataGridViewTextBoxColumn5.HeaderText = "ValorProduto";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ValorPedido";
            this.dataGridViewTextBoxColumn6.HeaderText = "ValorPedido";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "IdProdutoComputador";
            this.dataGridViewTextBoxColumn7.HeaderText = "IdProdutoComputador";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // idPedidoLabel
            // 
            idPedidoLabel.AutoSize = true;
            idPedidoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idPedidoLabel.Location = new System.Drawing.Point(73, 108);
            idPedidoLabel.Name = "idPedidoLabel";
            idPedidoLabel.Size = new System.Drawing.Size(90, 20);
            idPedidoLabel.TabIndex = 2;
            idPedidoLabel.Text = "Id Pedido:";
            // 
            // idPedidoTextBox
            // 
            this.idPedidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.controlePedidoCompraBindingSource, "IdPedido", true));
            this.idPedidoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idPedidoTextBox.Location = new System.Drawing.Point(170, 105);
            this.idPedidoTextBox.Name = "idPedidoTextBox";
            this.idPedidoTextBox.Size = new System.Drawing.Size(272, 26);
            this.idPedidoTextBox.TabIndex = 3;
            // 
            // nomeProdutoLabel
            // 
            nomeProdutoLabel.AutoSize = true;
            nomeProdutoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeProdutoLabel.Location = new System.Drawing.Point(73, 139);
            nomeProdutoLabel.Name = "nomeProdutoLabel";
            nomeProdutoLabel.Size = new System.Drawing.Size(128, 20);
            nomeProdutoLabel.TabIndex = 4;
            nomeProdutoLabel.Text = "Nome Produto:";
            // 
            // nomeProdutoTextBox
            // 
            this.nomeProdutoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.controlePedidoCompraBindingSource, "NomeProduto", true));
            this.nomeProdutoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeProdutoTextBox.Location = new System.Drawing.Point(208, 137);
            this.nomeProdutoTextBox.Name = "nomeProdutoTextBox";
            this.nomeProdutoTextBox.Size = new System.Drawing.Size(234, 26);
            this.nomeProdutoTextBox.TabIndex = 5;
            // 
            // quantidadeProdutoLabel
            // 
            quantidadeProdutoLabel.AutoSize = true;
            quantidadeProdutoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            quantidadeProdutoLabel.Location = new System.Drawing.Point(73, 173);
            quantidadeProdutoLabel.Name = "quantidadeProdutoLabel";
            quantidadeProdutoLabel.Size = new System.Drawing.Size(175, 20);
            quantidadeProdutoLabel.TabIndex = 6;
            quantidadeProdutoLabel.Text = "Quantidade Produto:";
            // 
            // quantidadeProdutoTextBox
            // 
            this.quantidadeProdutoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.controlePedidoCompraBindingSource, "QuantidadeProduto", true));
            this.quantidadeProdutoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantidadeProdutoTextBox.Location = new System.Drawing.Point(254, 169);
            this.quantidadeProdutoTextBox.Name = "quantidadeProdutoTextBox";
            this.quantidadeProdutoTextBox.Size = new System.Drawing.Size(188, 26);
            this.quantidadeProdutoTextBox.TabIndex = 7;
            // 
            // descricaoProdutoLabel
            // 
            descricaoProdutoLabel.AutoSize = true;
            descricaoProdutoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descricaoProdutoLabel.Location = new System.Drawing.Point(523, 108);
            descricaoProdutoLabel.Name = "descricaoProdutoLabel";
            descricaoProdutoLabel.Size = new System.Drawing.Size(162, 20);
            descricaoProdutoLabel.TabIndex = 8;
            descricaoProdutoLabel.Text = "Descricao Produto:";
            // 
            // descricaoProdutoTextBox
            // 
            this.descricaoProdutoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.controlePedidoCompraBindingSource, "DescricaoProduto", true));
            this.descricaoProdutoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoProdutoTextBox.Location = new System.Drawing.Point(691, 105);
            this.descricaoProdutoTextBox.Multiline = true;
            this.descricaoProdutoTextBox.Name = "descricaoProdutoTextBox";
            this.descricaoProdutoTextBox.Size = new System.Drawing.Size(156, 58);
            this.descricaoProdutoTextBox.TabIndex = 9;
            // 
            // valorProdutoLabel
            // 
            valorProdutoLabel.AutoSize = true;
            valorProdutoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valorProdutoLabel.Location = new System.Drawing.Point(73, 207);
            valorProdutoLabel.Name = "valorProdutoLabel";
            valorProdutoLabel.Size = new System.Drawing.Size(124, 20);
            valorProdutoLabel.TabIndex = 10;
            valorProdutoLabel.Text = "Valor Produto:";
            // 
            // valorProdutoTextBox
            // 
            this.valorProdutoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.controlePedidoCompraBindingSource, "ValorProduto", true));
            this.valorProdutoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorProdutoTextBox.Location = new System.Drawing.Point(204, 201);
            this.valorProdutoTextBox.Name = "valorProdutoTextBox";
            this.valorProdutoTextBox.Size = new System.Drawing.Size(238, 26);
            this.valorProdutoTextBox.TabIndex = 11;
            // 
            // valorPedidoLabel
            // 
            valorPedidoLabel.AutoSize = true;
            valorPedidoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valorPedidoLabel.Location = new System.Drawing.Point(523, 204);
            valorPedidoLabel.Name = "valorPedidoLabel";
            valorPedidoLabel.Size = new System.Drawing.Size(116, 20);
            valorPedidoLabel.TabIndex = 12;
            valorPedidoLabel.Text = "Valor Pedido:";
            valorPedidoLabel.Click += new System.EventHandler(this.valorPedidoLabel_Click);
            // 
            // valorPedidoTextBox
            // 
            this.valorPedidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.controlePedidoCompraBindingSource, "ValorPedido", true));
            this.valorPedidoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorPedidoTextBox.Location = new System.Drawing.Point(645, 201);
            this.valorPedidoTextBox.Name = "valorPedidoTextBox";
            this.valorPedidoTextBox.Size = new System.Drawing.Size(202, 26);
            this.valorPedidoTextBox.TabIndex = 13;
            this.valorPedidoTextBox.TextChanged += new System.EventHandler(this.valorPedidoTextBox_TextChanged);
            // 
            // idProdutoComputadorLabel
            // 
            idProdutoComputadorLabel.AutoSize = true;
            idProdutoComputadorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idProdutoComputadorLabel.Location = new System.Drawing.Point(523, 172);
            idProdutoComputadorLabel.Name = "idProdutoComputadorLabel";
            idProdutoComputadorLabel.Size = new System.Drawing.Size(201, 20);
            idProdutoComputadorLabel.TabIndex = 14;
            idProdutoComputadorLabel.Text = "Id Produto Computador:";
            // 
            // idProdutoComputadorTextBox
            // 
            this.idProdutoComputadorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.controlePedidoCompraBindingSource, "IdProdutoComputador", true));
            this.idProdutoComputadorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idProdutoComputadorTextBox.Location = new System.Drawing.Point(730, 169);
            this.idProdutoComputadorTextBox.Name = "idProdutoComputadorTextBox";
            this.idProdutoComputadorTextBox.Size = new System.Drawing.Size(117, 26);
            this.idProdutoComputadorTextBox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(34, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(817, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "_________________________________________________________________________________" +
    "______________________________________________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(383, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 26);
            this.label1.TabIndex = 30;
            this.label1.Text = "PEDIDOS";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(751, 314);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 33);
            this.button5.TabIndex = 39;
            this.button5.Text = "Anterior";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(573, 314);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 33);
            this.button4.TabIndex = 38;
            this.button4.Text = "Próximo";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(399, 314);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 33);
            this.button3.TabIndex = 37;
            this.button3.Text = "Remover";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(227, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 36;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(54, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 35;
            this.button1.Text = "Novo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(789, 38);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 33);
            this.button6.TabIndex = 40;
            this.button6.Text = "Sair";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // N9Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IntelliFactorySystem.Properties.Resources.BACKGROUND;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(idPedidoLabel);
            this.Controls.Add(this.idPedidoTextBox);
            this.Controls.Add(nomeProdutoLabel);
            this.Controls.Add(this.nomeProdutoTextBox);
            this.Controls.Add(quantidadeProdutoLabel);
            this.Controls.Add(this.quantidadeProdutoTextBox);
            this.Controls.Add(descricaoProdutoLabel);
            this.Controls.Add(this.descricaoProdutoTextBox);
            this.Controls.Add(valorProdutoLabel);
            this.Controls.Add(this.valorProdutoTextBox);
            this.Controls.Add(valorPedidoLabel);
            this.Controls.Add(this.valorPedidoTextBox);
            this.Controls.Add(idProdutoComputadorLabel);
            this.Controls.Add(this.idProdutoComputadorTextBox);
            this.Controls.Add(this.controlePedidoCompraDataGridView);
            this.Controls.Add(this.controlePedidoCompraBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "N9Pedidos";
            this.Text = "N9Pedidos";
            this.Load += new System.EventHandler(this.N9Pedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.intelliFactoryDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlePedidoCompraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlePedidoCompraBindingNavigator)).EndInit();
            this.controlePedidoCompraBindingNavigator.ResumeLayout(false);
            this.controlePedidoCompraBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.controlePedidoCompraDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private IntelliFactoryDatabaseDataSet1 intelliFactoryDatabaseDataSet1;
        private System.Windows.Forms.BindingSource controlePedidoCompraBindingSource;
        private IntelliFactoryDatabaseDataSet1TableAdapters.ControlePedidoCompraTableAdapter controlePedidoCompraTableAdapter;
        private IntelliFactoryDatabaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator controlePedidoCompraBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton controlePedidoCompraBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView controlePedidoCompraDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox idPedidoTextBox;
        private System.Windows.Forms.TextBox nomeProdutoTextBox;
        private System.Windows.Forms.TextBox quantidadeProdutoTextBox;
        private System.Windows.Forms.TextBox descricaoProdutoTextBox;
        private System.Windows.Forms.TextBox valorProdutoTextBox;
        private System.Windows.Forms.TextBox valorPedidoTextBox;
        private System.Windows.Forms.TextBox idProdutoComputadorTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
    }
}