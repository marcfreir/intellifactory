namespace IntelliFactorySystem
{
    partial class N3LoteMontagem
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
            System.Windows.Forms.Label idLoteLabel;
            System.Windows.Forms.Label dataMontagemLabel;
            System.Windows.Forms.Label quantidadeComputadorLabel;
            System.Windows.Forms.Label idComputadoresRegistroLabel;
            System.Windows.Forms.Label horaMontagemLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(N3LoteMontagem));
            this.button6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.loteMontagemBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.loteMontagemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.intelliFactoryDatabaseDataSet1 = new IntelliFactorySystem.IntelliFactoryDatabaseDataSet1();
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
            this.loteMontagemBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idLoteTextBox = new System.Windows.Forms.TextBox();
            this.dataMontagemDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.quantidadeComputadorTextBox = new System.Windows.Forms.TextBox();
            this.idComputadoresRegistroTextBox = new System.Windows.Forms.TextBox();
            this.loteMontagemTableAdapter = new IntelliFactorySystem.IntelliFactoryDatabaseDataSet1TableAdapters.LoteMontagemTableAdapter();
            this.tableAdapterManager = new IntelliFactorySystem.IntelliFactoryDatabaseDataSet1TableAdapters.TableAdapterManager();
            this.horaMontagemTextBox = new System.Windows.Forms.TextBox();
            this.loteMontagemDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idLoteLabel = new System.Windows.Forms.Label();
            dataMontagemLabel = new System.Windows.Forms.Label();
            quantidadeComputadorLabel = new System.Windows.Forms.Label();
            idComputadoresRegistroLabel = new System.Windows.Forms.Label();
            horaMontagemLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loteMontagemBindingNavigator)).BeginInit();
            this.loteMontagemBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loteMontagemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intelliFactoryDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loteMontagemDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLoteLabel
            // 
            idLoteLabel.AutoSize = true;
            idLoteLabel.BackColor = System.Drawing.Color.Transparent;
            idLoteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLoteLabel.Location = new System.Drawing.Point(73, 108);
            idLoteLabel.Name = "idLoteLabel";
            idLoteLabel.Size = new System.Drawing.Size(96, 20);
            idLoteLabel.TabIndex = 35;
            idLoteLabel.Text = "Id do Lote:";
            // 
            // dataMontagemLabel
            // 
            dataMontagemLabel.AutoSize = true;
            dataMontagemLabel.BackColor = System.Drawing.Color.Transparent;
            dataMontagemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataMontagemLabel.Location = new System.Drawing.Point(73, 144);
            dataMontagemLabel.Name = "dataMontagemLabel";
            dataMontagemLabel.Size = new System.Drawing.Size(142, 20);
            dataMontagemLabel.TabIndex = 37;
            dataMontagemLabel.Text = "Data Montagem:";
            // 
            // quantidadeComputadorLabel
            // 
            quantidadeComputadorLabel.AutoSize = true;
            quantidadeComputadorLabel.BackColor = System.Drawing.Color.Transparent;
            quantidadeComputadorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            quantidadeComputadorLabel.Location = new System.Drawing.Point(73, 216);
            quantidadeComputadorLabel.Name = "quantidadeComputadorLabel";
            quantidadeComputadorLabel.Size = new System.Drawing.Size(210, 20);
            quantidadeComputadorLabel.TabIndex = 41;
            quantidadeComputadorLabel.Text = "Quantidade Computador:";
            // 
            // idComputadoresRegistroLabel
            // 
            idComputadoresRegistroLabel.AutoSize = true;
            idComputadoresRegistroLabel.BackColor = System.Drawing.Color.Transparent;
            idComputadoresRegistroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idComputadoresRegistroLabel.Location = new System.Drawing.Point(73, 252);
            idComputadoresRegistroLabel.Name = "idComputadoresRegistroLabel";
            idComputadoresRegistroLabel.Size = new System.Drawing.Size(225, 20);
            idComputadoresRegistroLabel.TabIndex = 43;
            idComputadoresRegistroLabel.Text = "Id Computadores Registro:";
            // 
            // horaMontagemLabel
            // 
            horaMontagemLabel.AutoSize = true;
            horaMontagemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            horaMontagemLabel.Location = new System.Drawing.Point(73, 180);
            horaMontagemLabel.Name = "horaMontagemLabel";
            horaMontagemLabel.Size = new System.Drawing.Size(142, 20);
            horaMontagemLabel.TabIndex = 44;
            horaMontagemLabel.Text = "Hora Montagem:";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(597, 38);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 33);
            this.button6.TabIndex = 32;
            this.button6.Text = "Sair";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(34, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(625, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "_________________________________________________________________________________" +
    "______________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 26);
            this.label1.TabIndex = 33;
            this.label1.Text = "LOTE DE MONTAGEM";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(557, 332);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 33);
            this.button5.TabIndex = 31;
            this.button5.Text = "Anterior";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(427, 332);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 33);
            this.button4.TabIndex = 30;
            this.button4.Text = "Próximo";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(301, 332);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 33);
            this.button3.TabIndex = 29;
            this.button3.Text = "Remover";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(177, 332);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 28;
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
            this.button1.TabIndex = 27;
            this.button1.Text = "Novo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // loteMontagemBindingNavigator
            // 
            this.loteMontagemBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.loteMontagemBindingNavigator.BindingSource = this.loteMontagemBindingSource;
            this.loteMontagemBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.loteMontagemBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.loteMontagemBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.loteMontagemBindingNavigatorSaveItem});
            this.loteMontagemBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.loteMontagemBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.loteMontagemBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.loteMontagemBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.loteMontagemBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.loteMontagemBindingNavigator.Name = "loteMontagemBindingNavigator";
            this.loteMontagemBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.loteMontagemBindingNavigator.Size = new System.Drawing.Size(783, 25);
            this.loteMontagemBindingNavigator.TabIndex = 35;
            this.loteMontagemBindingNavigator.Text = "bindingNavigator1";
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
            // loteMontagemBindingSource
            // 
            this.loteMontagemBindingSource.DataMember = "LoteMontagem";
            this.loteMontagemBindingSource.DataSource = this.intelliFactoryDatabaseDataSet1;
            // 
            // intelliFactoryDatabaseDataSet1
            // 
            this.intelliFactoryDatabaseDataSet1.DataSetName = "IntelliFactoryDatabaseDataSet1";
            this.intelliFactoryDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // loteMontagemBindingNavigatorSaveItem
            // 
            this.loteMontagemBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.loteMontagemBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("loteMontagemBindingNavigatorSaveItem.Image")));
            this.loteMontagemBindingNavigatorSaveItem.Name = "loteMontagemBindingNavigatorSaveItem";
            this.loteMontagemBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.loteMontagemBindingNavigatorSaveItem.Text = "Save Data";
            this.loteMontagemBindingNavigatorSaveItem.Click += new System.EventHandler(this.loteMontagemBindingNavigatorSaveItem_Click_1);
            // 
            // idLoteTextBox
            // 
            this.idLoteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loteMontagemBindingSource, "IdLote", true));
            this.idLoteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLoteTextBox.Location = new System.Drawing.Point(323, 102);
            this.idLoteTextBox.Name = "idLoteTextBox";
            this.idLoteTextBox.Size = new System.Drawing.Size(215, 26);
            this.idLoteTextBox.TabIndex = 36;
            // 
            // dataMontagemDateTimePicker
            // 
            this.dataMontagemDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.loteMontagemBindingSource, "DataMontagem", true));
            this.dataMontagemDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataMontagemDateTimePicker.Location = new System.Drawing.Point(323, 138);
            this.dataMontagemDateTimePicker.Name = "dataMontagemDateTimePicker";
            this.dataMontagemDateTimePicker.Size = new System.Drawing.Size(215, 26);
            this.dataMontagemDateTimePicker.TabIndex = 38;
            // 
            // quantidadeComputadorTextBox
            // 
            this.quantidadeComputadorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loteMontagemBindingSource, "QuantidadeComputador", true));
            this.quantidadeComputadorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantidadeComputadorTextBox.Location = new System.Drawing.Point(323, 210);
            this.quantidadeComputadorTextBox.Name = "quantidadeComputadorTextBox";
            this.quantidadeComputadorTextBox.Size = new System.Drawing.Size(215, 26);
            this.quantidadeComputadorTextBox.TabIndex = 42;
            // 
            // idComputadoresRegistroTextBox
            // 
            this.idComputadoresRegistroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loteMontagemBindingSource, "IdComputadoresRegistro", true));
            this.idComputadoresRegistroTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idComputadoresRegistroTextBox.Location = new System.Drawing.Point(323, 246);
            this.idComputadoresRegistroTextBox.Name = "idComputadoresRegistroTextBox";
            this.idComputadoresRegistroTextBox.Size = new System.Drawing.Size(215, 26);
            this.idComputadoresRegistroTextBox.TabIndex = 44;
            // 
            // loteMontagemTableAdapter
            // 
            this.loteMontagemTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.LoteMontagemTableAdapter = this.loteMontagemTableAdapter;
            this.tableAdapterManager.ProdutoComputadorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = IntelliFactorySystem.IntelliFactoryDatabaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // horaMontagemTextBox
            // 
            this.horaMontagemTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loteMontagemBindingSource, "HoraMontagem", true));
            this.horaMontagemTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horaMontagemTextBox.Location = new System.Drawing.Point(323, 174);
            this.horaMontagemTextBox.Name = "horaMontagemTextBox";
            this.horaMontagemTextBox.Size = new System.Drawing.Size(215, 26);
            this.horaMontagemTextBox.TabIndex = 45;
            // 
            // loteMontagemDataGridView
            // 
            this.loteMontagemDataGridView.AutoGenerateColumns = false;
            this.loteMontagemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loteMontagemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.loteMontagemDataGridView.DataSource = this.loteMontagemBindingSource;
            this.loteMontagemDataGridView.Location = new System.Drawing.Point(52, 400);
            this.loteMontagemDataGridView.Name = "loteMontagemDataGridView";
            this.loteMontagemDataGridView.Size = new System.Drawing.Size(580, 220);
            this.loteMontagemDataGridView.TabIndex = 45;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdLote";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdLote";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DataMontagem";
            this.dataGridViewTextBoxColumn2.HeaderText = "DataMontagem";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "HoraMontagem";
            this.dataGridViewTextBoxColumn3.HeaderText = "HoraMontagem";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "QuantidadeComputador";
            this.dataGridViewTextBoxColumn4.HeaderText = "QuantidadeComputador";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "IdComputadoresRegistro";
            this.dataGridViewTextBoxColumn5.HeaderText = "IdComputadoresRegistro";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // N3LoteMontagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IntelliFactorySystem.Properties.Resources.BACKGROUND;
            this.ClientSize = new System.Drawing.Size(783, 696);
            this.Controls.Add(this.loteMontagemDataGridView);
            this.Controls.Add(horaMontagemLabel);
            this.Controls.Add(this.horaMontagemTextBox);
            this.Controls.Add(idLoteLabel);
            this.Controls.Add(this.idLoteTextBox);
            this.Controls.Add(dataMontagemLabel);
            this.Controls.Add(this.dataMontagemDateTimePicker);
            this.Controls.Add(quantidadeComputadorLabel);
            this.Controls.Add(this.quantidadeComputadorTextBox);
            this.Controls.Add(idComputadoresRegistroLabel);
            this.Controls.Add(this.idComputadoresRegistroTextBox);
            this.Controls.Add(this.loteMontagemBindingNavigator);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "N3LoteMontagem";
            this.Text = "Lote de Montagem";
            this.Load += new System.EventHandler(this.N3LoteMontagem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loteMontagemBindingNavigator)).EndInit();
            this.loteMontagemBindingNavigator.ResumeLayout(false);
            this.loteMontagemBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loteMontagemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intelliFactoryDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loteMontagemDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private IntelliFactoryDatabaseDataSet1 intelliFactoryDatabaseDataSet1;
        private System.Windows.Forms.BindingSource loteMontagemBindingSource;
        private IntelliFactoryDatabaseDataSet1TableAdapters.LoteMontagemTableAdapter loteMontagemTableAdapter;
        private IntelliFactoryDatabaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator loteMontagemBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton loteMontagemBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idLoteTextBox;
        private System.Windows.Forms.DateTimePicker dataMontagemDateTimePicker;
        private System.Windows.Forms.TextBox quantidadeComputadorTextBox;
        private System.Windows.Forms.TextBox idComputadoresRegistroTextBox;
        private System.Windows.Forms.TextBox horaMontagemTextBox;
        private System.Windows.Forms.DataGridView loteMontagemDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}