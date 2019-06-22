namespace IntelliFactorySystem
{
    partial class N5Clientes
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
            System.Windows.Forms.Label cpf_CNPJLabel;
            System.Windows.Forms.Label nomeCliente_RazaoSocialLabel;
            System.Windows.Forms.Label enderecoClienteLabel;
            System.Windows.Forms.Label telefoneClienteLabel;
            System.Windows.Forms.Label emailClienteLabel;
            System.Windows.Forms.Label idPedidoLabel;
            System.Windows.Forms.Label totalCompraLabel;
            System.Windows.Forms.Label observacaoClientePedidoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(N5Clientes));
            this.intelliFactoryDatabaseDataSet1 = new IntelliFactorySystem.IntelliFactoryDatabaseDataSet1();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new IntelliFactorySystem.IntelliFactoryDatabaseDataSet1TableAdapters.ClienteTableAdapter();
            this.tableAdapterManager = new IntelliFactorySystem.IntelliFactoryDatabaseDataSet1TableAdapters.TableAdapterManager();
            this.clienteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.clienteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.clienteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf_CNPJTextBox = new System.Windows.Forms.TextBox();
            this.nomeCliente_RazaoSocialTextBox = new System.Windows.Forms.TextBox();
            this.enderecoClienteTextBox = new System.Windows.Forms.TextBox();
            this.telefoneClienteTextBox = new System.Windows.Forms.TextBox();
            this.emailClienteTextBox = new System.Windows.Forms.TextBox();
            this.idPedidoTextBox = new System.Windows.Forms.TextBox();
            this.totalCompraTextBox = new System.Windows.Forms.TextBox();
            this.observacaoClientePedidoTextBox = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            cpf_CNPJLabel = new System.Windows.Forms.Label();
            nomeCliente_RazaoSocialLabel = new System.Windows.Forms.Label();
            enderecoClienteLabel = new System.Windows.Forms.Label();
            telefoneClienteLabel = new System.Windows.Forms.Label();
            emailClienteLabel = new System.Windows.Forms.Label();
            idPedidoLabel = new System.Windows.Forms.Label();
            totalCompraLabel = new System.Windows.Forms.Label();
            observacaoClientePedidoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.intelliFactoryDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingNavigator)).BeginInit();
            this.clienteBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cpf_CNPJLabel
            // 
            cpf_CNPJLabel.AutoSize = true;
            cpf_CNPJLabel.BackColor = System.Drawing.Color.Transparent;
            cpf_CNPJLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cpf_CNPJLabel.Location = new System.Drawing.Point(73, 108);
            cpf_CNPJLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cpf_CNPJLabel.Name = "cpf_CNPJLabel";
            cpf_CNPJLabel.Size = new System.Drawing.Size(97, 20);
            cpf_CNPJLabel.TabIndex = 2;
            cpf_CNPJLabel.Text = "CPF/CNPJ:";
            // 
            // nomeCliente_RazaoSocialLabel
            // 
            nomeCliente_RazaoSocialLabel.AutoSize = true;
            nomeCliente_RazaoSocialLabel.BackColor = System.Drawing.Color.Transparent;
            nomeCliente_RazaoSocialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeCliente_RazaoSocialLabel.Location = new System.Drawing.Point(73, 146);
            nomeCliente_RazaoSocialLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nomeCliente_RazaoSocialLabel.Name = "nomeCliente_RazaoSocialLabel";
            nomeCliente_RazaoSocialLabel.Size = new System.Drawing.Size(257, 20);
            nomeCliente_RazaoSocialLabel.TabIndex = 4;
            nomeCliente_RazaoSocialLabel.Text = "Nome do Cliente/Razão Social:";
            // 
            // enderecoClienteLabel
            // 
            enderecoClienteLabel.AutoSize = true;
            enderecoClienteLabel.BackColor = System.Drawing.Color.Transparent;
            enderecoClienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            enderecoClienteLabel.Location = new System.Drawing.Point(73, 186);
            enderecoClienteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            enderecoClienteLabel.Name = "enderecoClienteLabel";
            enderecoClienteLabel.Size = new System.Drawing.Size(177, 20);
            enderecoClienteLabel.TabIndex = 6;
            enderecoClienteLabel.Text = "Endereço do Cliente:";
            // 
            // telefoneClienteLabel
            // 
            telefoneClienteLabel.AutoSize = true;
            telefoneClienteLabel.BackColor = System.Drawing.Color.Transparent;
            telefoneClienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telefoneClienteLabel.Location = new System.Drawing.Point(73, 226);
            telefoneClienteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            telefoneClienteLabel.Name = "telefoneClienteLabel";
            telefoneClienteLabel.Size = new System.Drawing.Size(170, 20);
            telefoneClienteLabel.TabIndex = 8;
            telefoneClienteLabel.Text = "Telefone do Cliente:";
            // 
            // emailClienteLabel
            // 
            emailClienteLabel.AutoSize = true;
            emailClienteLabel.BackColor = System.Drawing.Color.Transparent;
            emailClienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailClienteLabel.Location = new System.Drawing.Point(73, 266);
            emailClienteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            emailClienteLabel.Name = "emailClienteLabel";
            emailClienteLabel.Size = new System.Drawing.Size(144, 20);
            emailClienteLabel.TabIndex = 10;
            emailClienteLabel.Text = "Email do Cliente:";
            // 
            // idPedidoLabel
            // 
            idPedidoLabel.AutoSize = true;
            idPedidoLabel.BackColor = System.Drawing.Color.Transparent;
            idPedidoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idPedidoLabel.Location = new System.Drawing.Point(808, 103);
            idPedidoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idPedidoLabel.Name = "idPedidoLabel";
            idPedidoLabel.Size = new System.Drawing.Size(115, 20);
            idPedidoLabel.TabIndex = 12;
            idPedidoLabel.Text = "Id do Pedido:";
            // 
            // totalCompraLabel
            // 
            totalCompraLabel.AutoSize = true;
            totalCompraLabel.BackColor = System.Drawing.Color.Transparent;
            totalCompraLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            totalCompraLabel.Location = new System.Drawing.Point(808, 146);
            totalCompraLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            totalCompraLabel.Name = "totalCompraLabel";
            totalCompraLabel.Size = new System.Drawing.Size(146, 20);
            totalCompraLabel.TabIndex = 14;
            totalCompraLabel.Text = "Total da Compra:";
            // 
            // observacaoClientePedidoLabel
            // 
            observacaoClientePedidoLabel.AutoSize = true;
            observacaoClientePedidoLabel.BackColor = System.Drawing.Color.Transparent;
            observacaoClientePedidoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            observacaoClientePedidoLabel.Location = new System.Drawing.Point(808, 186);
            observacaoClientePedidoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            observacaoClientePedidoLabel.Name = "observacaoClientePedidoLabel";
            observacaoClientePedidoLabel.Size = new System.Drawing.Size(255, 20);
            observacaoClientePedidoLabel.TabIndex = 16;
            observacaoClientePedidoLabel.Text = "Observação do Cliente/Pedido:";
            // 
            // intelliFactoryDatabaseDataSet1
            // 
            this.intelliFactoryDatabaseDataSet1.DataSetName = "IntelliFactoryDatabaseDataSet1";
            this.intelliFactoryDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.intelliFactoryDatabaseDataSet1;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager.ComponenteTableAdapter = null;
            this.tableAdapterManager.ControleGarantiaTableAdapter = null;
            this.tableAdapterManager.ControlePedidoCompraTableAdapter = null;
            this.tableAdapterManager.ControleQualidadeTableAdapter = null;
            this.tableAdapterManager.FornecedorTableAdapter = null;
            this.tableAdapterManager.FuncionarioTableAdapter = null;
            this.tableAdapterManager.GarantiaTableAdapter = null;
            this.tableAdapterManager.LoginTableAdapter = null;
            this.tableAdapterManager.LoteMontagemTableAdapter = null;
            this.tableAdapterManager.ProdutoComputadorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = IntelliFactorySystem.IntelliFactoryDatabaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clienteBindingNavigator
            // 
            this.clienteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.clienteBindingNavigator.BindingSource = this.clienteBindingSource;
            this.clienteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.clienteBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.clienteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.clienteBindingNavigatorSaveItem});
            this.clienteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.clienteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.clienteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.clienteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.clienteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.clienteBindingNavigator.Name = "clienteBindingNavigator";
            this.clienteBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.clienteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.clienteBindingNavigator.Size = new System.Drawing.Size(1326, 25);
            this.clienteBindingNavigator.TabIndex = 0;
            this.clienteBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(73, 23);
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
            // clienteBindingNavigatorSaveItem
            // 
            this.clienteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clienteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("clienteBindingNavigatorSaveItem.Image")));
            this.clienteBindingNavigatorSaveItem.Name = "clienteBindingNavigatorSaveItem";
            this.clienteBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.clienteBindingNavigatorSaveItem.Text = "Save Data";
            this.clienteBindingNavigatorSaveItem.Click += new System.EventHandler(this.clienteBindingNavigatorSaveItem_Click);
            // 
            // clienteDataGridView
            // 
            this.clienteDataGridView.AutoGenerateColumns = false;
            this.clienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.clienteDataGridView.DataSource = this.clienteBindingSource;
            this.clienteDataGridView.Location = new System.Drawing.Point(52, 435);
            this.clienteDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clienteDataGridView.Name = "clienteDataGridView";
            this.clienteDataGridView.Size = new System.Drawing.Size(1220, 220);
            this.clienteDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Cpf_CNPJ";
            this.dataGridViewTextBoxColumn1.HeaderText = "Cpf_CNPJ";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NomeCliente_RazaoSocial";
            this.dataGridViewTextBoxColumn2.HeaderText = "NomeCliente_RazaoSocial";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "EnderecoCliente";
            this.dataGridViewTextBoxColumn3.HeaderText = "EnderecoCliente";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TelefoneCliente";
            this.dataGridViewTextBoxColumn4.HeaderText = "TelefoneCliente";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "EmailCliente";
            this.dataGridViewTextBoxColumn5.HeaderText = "EmailCliente";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "IdPedido";
            this.dataGridViewTextBoxColumn6.HeaderText = "IdPedido";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TotalCompra";
            this.dataGridViewTextBoxColumn7.HeaderText = "TotalCompra";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ObservacaoClientePedido";
            this.dataGridViewTextBoxColumn8.HeaderText = "ObservacaoClientePedido";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // cpf_CNPJTextBox
            // 
            this.cpf_CNPJTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Cpf_CNPJ", true));
            this.cpf_CNPJTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpf_CNPJTextBox.Location = new System.Drawing.Point(178, 100);
            this.cpf_CNPJTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cpf_CNPJTextBox.Name = "cpf_CNPJTextBox";
            this.cpf_CNPJTextBox.Size = new System.Drawing.Size(555, 26);
            this.cpf_CNPJTextBox.TabIndex = 3;
            // 
            // nomeCliente_RazaoSocialTextBox
            // 
            this.nomeCliente_RazaoSocialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "NomeCliente_RazaoSocial", true));
            this.nomeCliente_RazaoSocialTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeCliente_RazaoSocialTextBox.Location = new System.Drawing.Point(338, 140);
            this.nomeCliente_RazaoSocialTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nomeCliente_RazaoSocialTextBox.Name = "nomeCliente_RazaoSocialTextBox";
            this.nomeCliente_RazaoSocialTextBox.Size = new System.Drawing.Size(395, 26);
            this.nomeCliente_RazaoSocialTextBox.TabIndex = 5;
            // 
            // enderecoClienteTextBox
            // 
            this.enderecoClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "EnderecoCliente", true));
            this.enderecoClienteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enderecoClienteTextBox.Location = new System.Drawing.Point(261, 180);
            this.enderecoClienteTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.enderecoClienteTextBox.Name = "enderecoClienteTextBox";
            this.enderecoClienteTextBox.Size = new System.Drawing.Size(472, 26);
            this.enderecoClienteTextBox.TabIndex = 7;
            // 
            // telefoneClienteTextBox
            // 
            this.telefoneClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "TelefoneCliente", true));
            this.telefoneClienteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefoneClienteTextBox.Location = new System.Drawing.Point(251, 220);
            this.telefoneClienteTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.telefoneClienteTextBox.Name = "telefoneClienteTextBox";
            this.telefoneClienteTextBox.Size = new System.Drawing.Size(482, 26);
            this.telefoneClienteTextBox.TabIndex = 9;
            // 
            // emailClienteTextBox
            // 
            this.emailClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "EmailCliente", true));
            this.emailClienteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailClienteTextBox.Location = new System.Drawing.Point(225, 260);
            this.emailClienteTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.emailClienteTextBox.Name = "emailClienteTextBox";
            this.emailClienteTextBox.Size = new System.Drawing.Size(508, 26);
            this.emailClienteTextBox.TabIndex = 11;
            // 
            // idPedidoTextBox
            // 
            this.idPedidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "IdPedido", true));
            this.idPedidoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idPedidoTextBox.Location = new System.Drawing.Point(931, 100);
            this.idPedidoTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.idPedidoTextBox.Name = "idPedidoTextBox";
            this.idPedidoTextBox.Size = new System.Drawing.Size(353, 26);
            this.idPedidoTextBox.TabIndex = 13;
            // 
            // totalCompraTextBox
            // 
            this.totalCompraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "TotalCompra", true));
            this.totalCompraTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCompraTextBox.Location = new System.Drawing.Point(962, 140);
            this.totalCompraTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.totalCompraTextBox.Name = "totalCompraTextBox";
            this.totalCompraTextBox.Size = new System.Drawing.Size(322, 26);
            this.totalCompraTextBox.TabIndex = 15;
            // 
            // observacaoClientePedidoTextBox
            // 
            this.observacaoClientePedidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "ObservacaoClientePedido", true));
            this.observacaoClientePedidoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.observacaoClientePedidoTextBox.Location = new System.Drawing.Point(1071, 180);
            this.observacaoClientePedidoTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.observacaoClientePedidoTextBox.Multiline = true;
            this.observacaoClientePedidoTextBox.Name = "observacaoClientePedidoTextBox";
            this.observacaoClientePedidoTextBox.Size = new System.Drawing.Size(213, 106);
            this.observacaoClientePedidoTextBox.TabIndex = 17;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(1239, 31);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 33);
            this.button6.TabIndex = 27;
            this.button6.Text = "Sair";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(601, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 26);
            this.label1.TabIndex = 28;
            this.label1.Text = "CLIENTES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(34, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1260, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "_________________________________________________________________________________" +
    "__________________________________________________________";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(1197, 332);
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
            this.button4.Location = new System.Drawing.Point(931, 332);
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
            this.button3.Location = new System.Drawing.Point(653, 332);
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
            this.button2.Location = new System.Drawing.Point(351, 332);
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
            this.button1.Location = new System.Drawing.Point(52, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 35;
            this.button1.Text = "Novo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // N5Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 700);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label1);
            this.Controls.Add(cpf_CNPJLabel);
            this.Controls.Add(this.cpf_CNPJTextBox);
            this.Controls.Add(nomeCliente_RazaoSocialLabel);
            this.Controls.Add(this.nomeCliente_RazaoSocialTextBox);
            this.Controls.Add(enderecoClienteLabel);
            this.Controls.Add(this.enderecoClienteTextBox);
            this.Controls.Add(telefoneClienteLabel);
            this.Controls.Add(this.telefoneClienteTextBox);
            this.Controls.Add(emailClienteLabel);
            this.Controls.Add(this.emailClienteTextBox);
            this.Controls.Add(idPedidoLabel);
            this.Controls.Add(this.idPedidoTextBox);
            this.Controls.Add(totalCompraLabel);
            this.Controls.Add(this.totalCompraTextBox);
            this.Controls.Add(observacaoClientePedidoLabel);
            this.Controls.Add(this.observacaoClientePedidoTextBox);
            this.Controls.Add(this.clienteDataGridView);
            this.Controls.Add(this.clienteBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "N5Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.N5Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.intelliFactoryDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingNavigator)).EndInit();
            this.clienteBindingNavigator.ResumeLayout(false);
            this.clienteBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private IntelliFactoryDatabaseDataSet1 intelliFactoryDatabaseDataSet1;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private IntelliFactoryDatabaseDataSet1TableAdapters.ClienteTableAdapter clienteTableAdapter;
        private IntelliFactoryDatabaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator clienteBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton clienteBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView clienteDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox cpf_CNPJTextBox;
        private System.Windows.Forms.TextBox nomeCliente_RazaoSocialTextBox;
        private System.Windows.Forms.TextBox enderecoClienteTextBox;
        private System.Windows.Forms.TextBox telefoneClienteTextBox;
        private System.Windows.Forms.TextBox emailClienteTextBox;
        private System.Windows.Forms.TextBox idPedidoTextBox;
        private System.Windows.Forms.TextBox totalCompraTextBox;
        private System.Windows.Forms.TextBox observacaoClientePedidoTextBox;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}