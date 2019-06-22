namespace IntelliFactorySystem
{
    partial class N1Componente
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
            System.Windows.Forms.Label codigoComponenteLabel;
            System.Windows.Forms.Label nomeComponenteLabel;
            System.Windows.Forms.Label quantidadeComponenteLabel;
            System.Windows.Forms.Label descricaoComponenteLabel;
            System.Windows.Forms.Label localizacaoComponenteLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(N1Componente));
            this.intelliFactoryDatabaseDataSet1 = new IntelliFactorySystem.IntelliFactoryDatabaseDataSet1();
            this.componenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.componenteTableAdapter = new IntelliFactorySystem.IntelliFactoryDatabaseDataSet1TableAdapters.ComponenteTableAdapter();
            this.tableAdapterManager = new IntelliFactorySystem.IntelliFactoryDatabaseDataSet1TableAdapters.TableAdapterManager();
            this.componenteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.componenteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.codigoComponenteTextBox = new System.Windows.Forms.TextBox();
            this.nomeComponenteTextBox = new System.Windows.Forms.TextBox();
            this.quantidadeComponenteTextBox = new System.Windows.Forms.TextBox();
            this.descricaoComponenteTextBox = new System.Windows.Forms.TextBox();
            this.localizacaoComponenteTextBox = new System.Windows.Forms.TextBox();
            this.componenteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            codigoComponenteLabel = new System.Windows.Forms.Label();
            nomeComponenteLabel = new System.Windows.Forms.Label();
            quantidadeComponenteLabel = new System.Windows.Forms.Label();
            descricaoComponenteLabel = new System.Windows.Forms.Label();
            localizacaoComponenteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.intelliFactoryDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componenteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componenteBindingNavigator)).BeginInit();
            this.componenteBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.componenteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoComponenteLabel
            // 
            codigoComponenteLabel.AutoSize = true;
            codigoComponenteLabel.BackColor = System.Drawing.Color.Transparent;
            codigoComponenteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codigoComponenteLabel.Location = new System.Drawing.Point(73, 108);
            codigoComponenteLabel.Name = "codigoComponenteLabel";
            codigoComponenteLabel.Size = new System.Drawing.Size(202, 20);
            codigoComponenteLabel.TabIndex = 1;
            codigoComponenteLabel.Text = "Código do Componente:";
            // 
            // nomeComponenteLabel
            // 
            nomeComponenteLabel.AutoSize = true;
            nomeComponenteLabel.BackColor = System.Drawing.Color.Transparent;
            nomeComponenteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeComponenteLabel.Location = new System.Drawing.Point(73, 144);
            nomeComponenteLabel.Name = "nomeComponenteLabel";
            nomeComponenteLabel.Size = new System.Drawing.Size(192, 20);
            nomeComponenteLabel.TabIndex = 3;
            nomeComponenteLabel.Text = "Nome do Componente:";
            // 
            // quantidadeComponenteLabel
            // 
            quantidadeComponenteLabel.AutoSize = true;
            quantidadeComponenteLabel.BackColor = System.Drawing.Color.Transparent;
            quantidadeComponenteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            quantidadeComponenteLabel.Location = new System.Drawing.Point(73, 180);
            quantidadeComponenteLabel.Name = "quantidadeComponenteLabel";
            quantidadeComponenteLabel.Size = new System.Drawing.Size(239, 20);
            quantidadeComponenteLabel.TabIndex = 5;
            quantidadeComponenteLabel.Text = "Quantidade do Componente:";
            // 
            // descricaoComponenteLabel
            // 
            descricaoComponenteLabel.AutoSize = true;
            descricaoComponenteLabel.BackColor = System.Drawing.Color.Transparent;
            descricaoComponenteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descricaoComponenteLabel.Location = new System.Drawing.Point(73, 216);
            descricaoComponenteLabel.Name = "descricaoComponenteLabel";
            descricaoComponenteLabel.Size = new System.Drawing.Size(226, 20);
            descricaoComponenteLabel.TabIndex = 7;
            descricaoComponenteLabel.Text = "Descrição do Componente:";
            // 
            // localizacaoComponenteLabel
            // 
            localizacaoComponenteLabel.AutoSize = true;
            localizacaoComponenteLabel.BackColor = System.Drawing.Color.Transparent;
            localizacaoComponenteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            localizacaoComponenteLabel.Location = new System.Drawing.Point(73, 252);
            localizacaoComponenteLabel.Name = "localizacaoComponenteLabel";
            localizacaoComponenteLabel.Size = new System.Drawing.Size(241, 20);
            localizacaoComponenteLabel.TabIndex = 9;
            localizacaoComponenteLabel.Text = "Localização do Componente:";
            // 
            // intelliFactoryDatabaseDataSet1
            // 
            this.intelliFactoryDatabaseDataSet1.DataSetName = "IntelliFactoryDatabaseDataSet1";
            this.intelliFactoryDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // componenteBindingSource
            // 
            this.componenteBindingSource.DataMember = "Componente";
            this.componenteBindingSource.DataSource = this.intelliFactoryDatabaseDataSet1;
            // 
            // componenteTableAdapter
            // 
            this.componenteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.ComponenteTableAdapter = this.componenteTableAdapter;
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
            // componenteBindingNavigator
            // 
            this.componenteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.componenteBindingNavigator.BindingSource = this.componenteBindingSource;
            this.componenteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.componenteBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.componenteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.componenteBindingNavigatorSaveItem});
            this.componenteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.componenteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.componenteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.componenteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.componenteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.componenteBindingNavigator.Name = "componenteBindingNavigator";
            this.componenteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.componenteBindingNavigator.Size = new System.Drawing.Size(684, 25);
            this.componenteBindingNavigator.TabIndex = 0;
            this.componenteBindingNavigator.Text = "bindingNavigator1";
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
            // componenteBindingNavigatorSaveItem
            // 
            this.componenteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.componenteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("componenteBindingNavigatorSaveItem.Image")));
            this.componenteBindingNavigatorSaveItem.Name = "componenteBindingNavigatorSaveItem";
            this.componenteBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.componenteBindingNavigatorSaveItem.Text = "Save Data";
            this.componenteBindingNavigatorSaveItem.Click += new System.EventHandler(this.componenteBindingNavigatorSaveItem_Click_1);
            // 
            // codigoComponenteTextBox
            // 
            this.codigoComponenteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.componenteBindingSource, "CodigoComponente", true));
            this.codigoComponenteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoComponenteTextBox.Location = new System.Drawing.Point(325, 102);
            this.codigoComponenteTextBox.Name = "codigoComponenteTextBox";
            this.codigoComponenteTextBox.Size = new System.Drawing.Size(200, 26);
            this.codigoComponenteTextBox.TabIndex = 2;
            // 
            // nomeComponenteTextBox
            // 
            this.nomeComponenteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.componenteBindingSource, "NomeComponente", true));
            this.nomeComponenteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeComponenteTextBox.Location = new System.Drawing.Point(325, 138);
            this.nomeComponenteTextBox.Name = "nomeComponenteTextBox";
            this.nomeComponenteTextBox.Size = new System.Drawing.Size(200, 26);
            this.nomeComponenteTextBox.TabIndex = 4;
            // 
            // quantidadeComponenteTextBox
            // 
            this.quantidadeComponenteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.componenteBindingSource, "QuantidadeComponente", true));
            this.quantidadeComponenteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantidadeComponenteTextBox.Location = new System.Drawing.Point(325, 174);
            this.quantidadeComponenteTextBox.Name = "quantidadeComponenteTextBox";
            this.quantidadeComponenteTextBox.Size = new System.Drawing.Size(200, 26);
            this.quantidadeComponenteTextBox.TabIndex = 6;
            // 
            // descricaoComponenteTextBox
            // 
            this.descricaoComponenteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.componenteBindingSource, "DescricaoComponente", true));
            this.descricaoComponenteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoComponenteTextBox.Location = new System.Drawing.Point(325, 210);
            this.descricaoComponenteTextBox.Name = "descricaoComponenteTextBox";
            this.descricaoComponenteTextBox.Size = new System.Drawing.Size(200, 26);
            this.descricaoComponenteTextBox.TabIndex = 8;
            // 
            // localizacaoComponenteTextBox
            // 
            this.localizacaoComponenteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.componenteBindingSource, "LocalizacaoComponente", true));
            this.localizacaoComponenteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localizacaoComponenteTextBox.Location = new System.Drawing.Point(325, 246);
            this.localizacaoComponenteTextBox.Name = "localizacaoComponenteTextBox";
            this.localizacaoComponenteTextBox.Size = new System.Drawing.Size(200, 26);
            this.localizacaoComponenteTextBox.TabIndex = 10;
            // 
            // componenteDataGridView
            // 
            this.componenteDataGridView.AllowUserToOrderColumns = true;
            this.componenteDataGridView.AutoGenerateColumns = false;
            this.componenteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.componenteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.componenteDataGridView.DataSource = this.componenteBindingSource;
            this.componenteDataGridView.Location = new System.Drawing.Point(52, 400);
            this.componenteDataGridView.Name = "componenteDataGridView";
            this.componenteDataGridView.Size = new System.Drawing.Size(580, 220);
            this.componenteDataGridView.TabIndex = 11;
            this.componenteDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.componenteDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CodigoComponente";
            this.dataGridViewTextBoxColumn1.HeaderText = "CodigoComponente";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NomeComponente";
            this.dataGridViewTextBoxColumn2.HeaderText = "NomeComponente";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "QuantidadeComponente";
            this.dataGridViewTextBoxColumn3.HeaderText = "QuantidadeComponente";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DescricaoComponente";
            this.dataGridViewTextBoxColumn4.HeaderText = "DescricaoComponente";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "LocalizacaoComponente";
            this.dataGridViewTextBoxColumn5.HeaderText = "LocalizacaoComponente";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(52, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 12;
            this.button1.Text = "Novo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(177, 332);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 13;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(301, 332);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 33);
            this.button3.TabIndex = 14;
            this.button3.Text = "Remover";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(427, 332);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 33);
            this.button4.TabIndex = 15;
            this.button4.Text = "Próximo";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(557, 332);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 33);
            this.button5.TabIndex = 16;
            this.button5.Text = "Anterior";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(597, 38);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 33);
            this.button6.TabIndex = 17;
            this.button6.Text = "Sair";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 26);
            this.label1.TabIndex = 25;
            this.label1.Text = "COMPONENTE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(34, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(625, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "_________________________________________________________________________________" +
    "______________________";
            // 
            // N1Componente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IntelliFactorySystem.Properties.Resources.BACKGROUND;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.componenteDataGridView);
            this.Controls.Add(codigoComponenteLabel);
            this.Controls.Add(this.codigoComponenteTextBox);
            this.Controls.Add(nomeComponenteLabel);
            this.Controls.Add(this.nomeComponenteTextBox);
            this.Controls.Add(quantidadeComponenteLabel);
            this.Controls.Add(this.quantidadeComponenteTextBox);
            this.Controls.Add(descricaoComponenteLabel);
            this.Controls.Add(this.descricaoComponenteTextBox);
            this.Controls.Add(localizacaoComponenteLabel);
            this.Controls.Add(this.localizacaoComponenteTextBox);
            this.Controls.Add(this.componenteBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "N1Componente";
            this.Text = "Componente";
            this.Load += new System.EventHandler(this.NComponente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.intelliFactoryDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componenteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componenteBindingNavigator)).EndInit();
            this.componenteBindingNavigator.ResumeLayout(false);
            this.componenteBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.componenteDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private IntelliFactoryDatabaseDataSet1 intelliFactoryDatabaseDataSet1;
        private System.Windows.Forms.BindingSource componenteBindingSource;
        private IntelliFactoryDatabaseDataSet1TableAdapters.ComponenteTableAdapter componenteTableAdapter;
        private IntelliFactoryDatabaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator componenteBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton componenteBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox codigoComponenteTextBox;
        private System.Windows.Forms.TextBox nomeComponenteTextBox;
        private System.Windows.Forms.TextBox quantidadeComponenteTextBox;
        private System.Windows.Forms.TextBox descricaoComponenteTextBox;
        private System.Windows.Forms.TextBox localizacaoComponenteTextBox;
        private System.Windows.Forms.DataGridView componenteDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}