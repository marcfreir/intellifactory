namespace IntelliFactorySystem
{
    partial class N8Garantia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(N8Garantia));
            System.Windows.Forms.Label idProdutoLabel;
            System.Windows.Forms.Label nomeProdutoLabel;
            System.Windows.Forms.Label dataCompraLabel;
            System.Windows.Forms.Label localCompraLabel;
            System.Windows.Forms.Label tempoGarantiaLabel;
            System.Windows.Forms.Label observacoesGarantiaLabel;
            this.intelliFactoryDatabaseDataSet1 = new IntelliFactorySystem.IntelliFactoryDatabaseDataSet1();
            this.garantiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.garantiaTableAdapter = new IntelliFactorySystem.IntelliFactoryDatabaseDataSet1TableAdapters.GarantiaTableAdapter();
            this.tableAdapterManager = new IntelliFactorySystem.IntelliFactoryDatabaseDataSet1TableAdapters.TableAdapterManager();
            this.garantiaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.garantiaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.garantiaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idProdutoTextBox = new System.Windows.Forms.TextBox();
            this.nomeProdutoTextBox = new System.Windows.Forms.TextBox();
            this.dataCompraTextBox = new System.Windows.Forms.TextBox();
            this.localCompraTextBox = new System.Windows.Forms.TextBox();
            this.tempoGarantiaTextBox = new System.Windows.Forms.TextBox();
            this.observacoesGarantiaTextBox = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            idProdutoLabel = new System.Windows.Forms.Label();
            nomeProdutoLabel = new System.Windows.Forms.Label();
            dataCompraLabel = new System.Windows.Forms.Label();
            localCompraLabel = new System.Windows.Forms.Label();
            tempoGarantiaLabel = new System.Windows.Forms.Label();
            observacoesGarantiaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.intelliFactoryDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.garantiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.garantiaBindingNavigator)).BeginInit();
            this.garantiaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.garantiaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // intelliFactoryDatabaseDataSet1
            // 
            this.intelliFactoryDatabaseDataSet1.DataSetName = "IntelliFactoryDatabaseDataSet1";
            this.intelliFactoryDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // garantiaBindingSource
            // 
            this.garantiaBindingSource.DataMember = "Garantia";
            this.garantiaBindingSource.DataSource = this.intelliFactoryDatabaseDataSet1;
            // 
            // garantiaTableAdapter
            // 
            this.garantiaTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.GarantiaTableAdapter = this.garantiaTableAdapter;
            this.tableAdapterManager.LoginTableAdapter = null;
            this.tableAdapterManager.LoteMontagemTableAdapter = null;
            this.tableAdapterManager.ProdutoComputadorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = IntelliFactorySystem.IntelliFactoryDatabaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // garantiaBindingNavigator
            // 
            this.garantiaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.garantiaBindingNavigator.BindingSource = this.garantiaBindingSource;
            this.garantiaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.garantiaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.garantiaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.garantiaBindingNavigatorSaveItem});
            this.garantiaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.garantiaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.garantiaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.garantiaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.garantiaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.garantiaBindingNavigator.Name = "garantiaBindingNavigator";
            this.garantiaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.garantiaBindingNavigator.Size = new System.Drawing.Size(692, 25);
            this.garantiaBindingNavigator.TabIndex = 0;
            this.garantiaBindingNavigator.Text = "bindingNavigator1";
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
            // garantiaBindingNavigatorSaveItem
            // 
            this.garantiaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.garantiaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("garantiaBindingNavigatorSaveItem.Image")));
            this.garantiaBindingNavigatorSaveItem.Name = "garantiaBindingNavigatorSaveItem";
            this.garantiaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.garantiaBindingNavigatorSaveItem.Text = "Save Data";
            this.garantiaBindingNavigatorSaveItem.Click += new System.EventHandler(this.garantiaBindingNavigatorSaveItem_Click);
            // 
            // garantiaDataGridView
            // 
            this.garantiaDataGridView.AutoGenerateColumns = false;
            this.garantiaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.garantiaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.garantiaDataGridView.DataSource = this.garantiaBindingSource;
            this.garantiaDataGridView.Location = new System.Drawing.Point(52, 400);
            this.garantiaDataGridView.Name = "garantiaDataGridView";
            this.garantiaDataGridView.Size = new System.Drawing.Size(580, 220);
            this.garantiaDataGridView.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DataCompra";
            this.dataGridViewTextBoxColumn3.HeaderText = "DataCompra";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "LocalCompra";
            this.dataGridViewTextBoxColumn4.HeaderText = "LocalCompra";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TempoGarantia";
            this.dataGridViewTextBoxColumn5.HeaderText = "TempoGarantia";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ObservacoesGarantia";
            this.dataGridViewTextBoxColumn6.HeaderText = "ObservacoesGarantia";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(597, 38);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 33);
            this.button6.TabIndex = 28;
            this.button6.Text = "Sair";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(625, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "_________________________________________________________________________________" +
    "______________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 26);
            this.label1.TabIndex = 26;
            this.label1.Text = "GARANTIA";
            // 
            // idProdutoLabel
            // 
            idProdutoLabel.AutoSize = true;
            idProdutoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idProdutoLabel.Location = new System.Drawing.Point(73, 108);
            idProdutoLabel.Name = "idProdutoLabel";
            idProdutoLabel.Size = new System.Drawing.Size(98, 20);
            idProdutoLabel.TabIndex = 28;
            idProdutoLabel.Text = "Id Produto:";
            // 
            // idProdutoTextBox
            // 
            this.idProdutoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.garantiaBindingSource, "IdProduto", true));
            this.idProdutoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idProdutoTextBox.Location = new System.Drawing.Point(177, 105);
            this.idProdutoTextBox.Name = "idProdutoTextBox";
            this.idProdutoTextBox.Size = new System.Drawing.Size(389, 26);
            this.idProdutoTextBox.TabIndex = 29;
            // 
            // nomeProdutoLabel
            // 
            nomeProdutoLabel.AutoSize = true;
            nomeProdutoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeProdutoLabel.Location = new System.Drawing.Point(73, 144);
            nomeProdutoLabel.Name = "nomeProdutoLabel";
            nomeProdutoLabel.Size = new System.Drawing.Size(128, 20);
            nomeProdutoLabel.TabIndex = 30;
            nomeProdutoLabel.Text = "Nome Produto:";
            // 
            // nomeProdutoTextBox
            // 
            this.nomeProdutoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.garantiaBindingSource, "NomeProduto", true));
            this.nomeProdutoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeProdutoTextBox.Location = new System.Drawing.Point(207, 141);
            this.nomeProdutoTextBox.Name = "nomeProdutoTextBox";
            this.nomeProdutoTextBox.Size = new System.Drawing.Size(359, 26);
            this.nomeProdutoTextBox.TabIndex = 31;
            // 
            // dataCompraLabel
            // 
            dataCompraLabel.AutoSize = true;
            dataCompraLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataCompraLabel.Location = new System.Drawing.Point(73, 180);
            dataCompraLabel.Name = "dataCompraLabel";
            dataCompraLabel.Size = new System.Drawing.Size(120, 20);
            dataCompraLabel.TabIndex = 32;
            dataCompraLabel.Text = "Data Compra:";
            // 
            // dataCompraTextBox
            // 
            this.dataCompraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.garantiaBindingSource, "DataCompra", true));
            this.dataCompraTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataCompraTextBox.Location = new System.Drawing.Point(203, 177);
            this.dataCompraTextBox.Name = "dataCompraTextBox";
            this.dataCompraTextBox.Size = new System.Drawing.Size(363, 26);
            this.dataCompraTextBox.TabIndex = 33;
            // 
            // localCompraLabel
            // 
            localCompraLabel.AutoSize = true;
            localCompraLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            localCompraLabel.Location = new System.Drawing.Point(73, 216);
            localCompraLabel.Name = "localCompraLabel";
            localCompraLabel.Size = new System.Drawing.Size(124, 20);
            localCompraLabel.TabIndex = 34;
            localCompraLabel.Text = "Local Compra:";
            // 
            // localCompraTextBox
            // 
            this.localCompraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.garantiaBindingSource, "LocalCompra", true));
            this.localCompraTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localCompraTextBox.Location = new System.Drawing.Point(203, 213);
            this.localCompraTextBox.Name = "localCompraTextBox";
            this.localCompraTextBox.Size = new System.Drawing.Size(363, 26);
            this.localCompraTextBox.TabIndex = 35;
            // 
            // tempoGarantiaLabel
            // 
            tempoGarantiaLabel.AutoSize = true;
            tempoGarantiaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tempoGarantiaLabel.Location = new System.Drawing.Point(73, 252);
            tempoGarantiaLabel.Name = "tempoGarantiaLabel";
            tempoGarantiaLabel.Size = new System.Drawing.Size(143, 20);
            tempoGarantiaLabel.TabIndex = 36;
            tempoGarantiaLabel.Text = "Tempo Garantia:";
            // 
            // tempoGarantiaTextBox
            // 
            this.tempoGarantiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.garantiaBindingSource, "TempoGarantia", true));
            this.tempoGarantiaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempoGarantiaTextBox.Location = new System.Drawing.Point(222, 249);
            this.tempoGarantiaTextBox.Name = "tempoGarantiaTextBox";
            this.tempoGarantiaTextBox.Size = new System.Drawing.Size(344, 26);
            this.tempoGarantiaTextBox.TabIndex = 37;
            // 
            // observacoesGarantiaLabel
            // 
            observacoesGarantiaLabel.AutoSize = true;
            observacoesGarantiaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            observacoesGarantiaLabel.Location = new System.Drawing.Point(73, 289);
            observacoesGarantiaLabel.Name = "observacoesGarantiaLabel";
            observacoesGarantiaLabel.Size = new System.Drawing.Size(193, 20);
            observacoesGarantiaLabel.TabIndex = 38;
            observacoesGarantiaLabel.Text = "Observacoes Garantia:";
            // 
            // observacoesGarantiaTextBox
            // 
            this.observacoesGarantiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.garantiaBindingSource, "ObservacoesGarantia", true));
            this.observacoesGarantiaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.observacoesGarantiaTextBox.Location = new System.Drawing.Point(272, 286);
            this.observacoesGarantiaTextBox.Name = "observacoesGarantiaTextBox";
            this.observacoesGarantiaTextBox.Size = new System.Drawing.Size(294, 26);
            this.observacoesGarantiaTextBox.TabIndex = 39;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(557, 342);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 33);
            this.button7.TabIndex = 44;
            this.button7.Text = "Anterior";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(427, 342);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 33);
            this.button8.TabIndex = 43;
            this.button8.Text = "Próximo";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(301, 342);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 33);
            this.button9.TabIndex = 42;
            this.button9.Text = "Remover";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(177, 342);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 33);
            this.button10.TabIndex = 41;
            this.button10.Text = "Salvar";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(52, 342);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 33);
            this.button11.TabIndex = 40;
            this.button11.Text = "Novo";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // N8Garantia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IntelliFactorySystem.Properties.Resources.BACKGROUND;
            this.ClientSize = new System.Drawing.Size(692, 685);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(idProdutoLabel);
            this.Controls.Add(this.idProdutoTextBox);
            this.Controls.Add(nomeProdutoLabel);
            this.Controls.Add(this.nomeProdutoTextBox);
            this.Controls.Add(dataCompraLabel);
            this.Controls.Add(this.dataCompraTextBox);
            this.Controls.Add(localCompraLabel);
            this.Controls.Add(this.localCompraTextBox);
            this.Controls.Add(tempoGarantiaLabel);
            this.Controls.Add(this.tempoGarantiaTextBox);
            this.Controls.Add(observacoesGarantiaLabel);
            this.Controls.Add(this.observacoesGarantiaTextBox);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.garantiaDataGridView);
            this.Controls.Add(this.garantiaBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "N8Garantia";
            this.Text = "Garantia";
            this.Load += new System.EventHandler(this.N8Garantia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.intelliFactoryDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.garantiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.garantiaBindingNavigator)).EndInit();
            this.garantiaBindingNavigator.ResumeLayout(false);
            this.garantiaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.garantiaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private IntelliFactoryDatabaseDataSet1 intelliFactoryDatabaseDataSet1;
        private System.Windows.Forms.BindingSource garantiaBindingSource;
        private IntelliFactoryDatabaseDataSet1TableAdapters.GarantiaTableAdapter garantiaTableAdapter;
        private IntelliFactoryDatabaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator garantiaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton garantiaBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView garantiaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idProdutoTextBox;
        private System.Windows.Forms.TextBox nomeProdutoTextBox;
        private System.Windows.Forms.TextBox dataCompraTextBox;
        private System.Windows.Forms.TextBox localCompraTextBox;
        private System.Windows.Forms.TextBox tempoGarantiaTextBox;
        private System.Windows.Forms.TextBox observacoesGarantiaTextBox;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
    }
}