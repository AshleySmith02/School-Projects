namespace ASmith_Lab_3
{
    partial class StateData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StateData));
            this.statelistDataSet = new ASmith_Lab_3.StatelistDataSet();
            this.stateTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stateTableTableAdapter = new ASmith_Lab_3.StatelistDataSetTableAdapters.StateTableTableAdapter();
            this.tableAdapterManager = new ASmith_Lab_3.StatelistDataSetTableAdapters.TableAdapterManager();
            this.stateTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.stateTableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.stateTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.populationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateFlagDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateFlowerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateBirdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.threeLargestCitiesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateCapitolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateMedianIncomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentageOfComputerrelatedJobsOfferedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnShowDetails = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnFilterMedian = new System.Windows.Forms.Button();
            this.selectNamePanel = new System.Windows.Forms.Panel();
            this.stateNamebox = new System.Windows.Forms.ComboBox();
            this.filterMedianPanel = new System.Windows.Forms.Panel();
            this.stateMedianCB = new System.Windows.Forms.ComboBox();
            this.searchSNPanel = new System.Windows.Forms.Panel();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.lblSelectName = new System.Windows.Forms.Label();
            this.lblOR = new System.Windows.Forms.Label();
            this.lblTypeStateName = new System.Windows.Forms.Label();
            this.lblFilterMedian = new System.Windows.Forms.Label();
            this.statelistDataSet1 = new ASmith_Lab_3.StatelistDataSet();
            this.stateTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.statelistDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateTableBindingNavigator)).BeginInit();
            this.stateTableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stateTableDataGridView)).BeginInit();
            this.selectNamePanel.SuspendLayout();
            this.filterMedianPanel.SuspendLayout();
            this.searchSNPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statelistDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateTableBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // statelistDataSet
            // 
            this.statelistDataSet.DataSetName = "StatelistDataSet";
            this.statelistDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stateTableBindingSource
            // 
            this.stateTableBindingSource.DataMember = "StateTable";
            this.stateTableBindingSource.DataSource = this.statelistDataSet;
            // 
            // stateTableTableAdapter
            // 
            this.stateTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StateTableTableAdapter = this.stateTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = ASmith_Lab_3.StatelistDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // stateTableBindingNavigator
            // 
            this.stateTableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.stateTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.stateTableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.stateTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.stateTableBindingNavigatorSaveItem});
            this.stateTableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.stateTableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.stateTableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.stateTableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.stateTableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.stateTableBindingNavigator.Name = "stateTableBindingNavigator";
            this.stateTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.stateTableBindingNavigator.Size = new System.Drawing.Size(1370, 25);
            this.stateTableBindingNavigator.TabIndex = 0;
            this.stateTableBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            // stateTableBindingNavigatorSaveItem
            // 
            this.stateTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stateTableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("stateTableBindingNavigatorSaveItem.Image")));
            this.stateTableBindingNavigatorSaveItem.Name = "stateTableBindingNavigatorSaveItem";
            this.stateTableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.stateTableBindingNavigatorSaveItem.Text = "Save Data";
            this.stateTableBindingNavigatorSaveItem.Click += new System.EventHandler(this.stateTableBindingNavigatorSaveItem_Click);
            // 
            // stateTableDataGridView
            // 
            this.stateTableDataGridView.AutoGenerateColumns = false;
            this.stateTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stateTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.stateTableDataGridView.DataSource = this.stateTableBindingSource;
            this.stateTableDataGridView.Location = new System.Drawing.Point(97, 40);
            this.stateTableDataGridView.Name = "stateTableDataGridView";
            this.stateTableDataGridView.Size = new System.Drawing.Size(1179, 274);
            this.stateTableDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "State Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "State Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Population";
            this.dataGridViewTextBoxColumn3.HeaderText = "Population";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "State Flag Description";
            this.dataGridViewTextBoxColumn4.HeaderText = "State Flag Description";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 167;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "State Flower";
            this.dataGridViewTextBoxColumn5.HeaderText = "State Flower";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "State Bird";
            this.dataGridViewTextBoxColumn6.HeaderText = "State Bird";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Three Largest Cities:";
            this.dataGridViewTextBoxColumn7.HeaderText = "Three Largest Cities:";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "State Capitol";
            this.dataGridViewTextBoxColumn8.HeaderText = "State Capitol";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "State Median Income";
            this.dataGridViewTextBoxColumn9.HeaderText = "State Median Income";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Percentage of Computer-related jobs offered: ";
            this.dataGridViewTextBoxColumn10.HeaderText = "Percentage of Computer-related jobs offered: ";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 256;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stateNameDataGridViewTextBoxColumn
            // 
            this.stateNameDataGridViewTextBoxColumn.DataPropertyName = "State Name";
            this.stateNameDataGridViewTextBoxColumn.HeaderText = "State Name";
            this.stateNameDataGridViewTextBoxColumn.Name = "stateNameDataGridViewTextBoxColumn";
            // 
            // populationDataGridViewTextBoxColumn
            // 
            this.populationDataGridViewTextBoxColumn.DataPropertyName = "Population";
            this.populationDataGridViewTextBoxColumn.HeaderText = "Population";
            this.populationDataGridViewTextBoxColumn.Name = "populationDataGridViewTextBoxColumn";
            // 
            // stateFlagDescriptionDataGridViewTextBoxColumn
            // 
            this.stateFlagDescriptionDataGridViewTextBoxColumn.DataPropertyName = "State Flag Description";
            this.stateFlagDescriptionDataGridViewTextBoxColumn.HeaderText = "State Flag Description";
            this.stateFlagDescriptionDataGridViewTextBoxColumn.Name = "stateFlagDescriptionDataGridViewTextBoxColumn";
            // 
            // stateFlowerDataGridViewTextBoxColumn
            // 
            this.stateFlowerDataGridViewTextBoxColumn.DataPropertyName = "State Flower";
            this.stateFlowerDataGridViewTextBoxColumn.HeaderText = "State Flower";
            this.stateFlowerDataGridViewTextBoxColumn.Name = "stateFlowerDataGridViewTextBoxColumn";
            // 
            // stateBirdDataGridViewTextBoxColumn
            // 
            this.stateBirdDataGridViewTextBoxColumn.DataPropertyName = "State Bird";
            this.stateBirdDataGridViewTextBoxColumn.HeaderText = "State Bird";
            this.stateBirdDataGridViewTextBoxColumn.Name = "stateBirdDataGridViewTextBoxColumn";
            // 
            // threeLargestCitiesDataGridViewTextBoxColumn
            // 
            this.threeLargestCitiesDataGridViewTextBoxColumn.DataPropertyName = "Three Largest Cities:";
            this.threeLargestCitiesDataGridViewTextBoxColumn.HeaderText = "Three Largest Cities:";
            this.threeLargestCitiesDataGridViewTextBoxColumn.Name = "threeLargestCitiesDataGridViewTextBoxColumn";
            // 
            // stateCapitolDataGridViewTextBoxColumn
            // 
            this.stateCapitolDataGridViewTextBoxColumn.DataPropertyName = "State Capitol";
            this.stateCapitolDataGridViewTextBoxColumn.HeaderText = "State Capitol";
            this.stateCapitolDataGridViewTextBoxColumn.Name = "stateCapitolDataGridViewTextBoxColumn";
            // 
            // stateMedianIncomeDataGridViewTextBoxColumn
            // 
            this.stateMedianIncomeDataGridViewTextBoxColumn.DataPropertyName = "State Median Income";
            this.stateMedianIncomeDataGridViewTextBoxColumn.HeaderText = "State Median Income";
            this.stateMedianIncomeDataGridViewTextBoxColumn.Name = "stateMedianIncomeDataGridViewTextBoxColumn";
            // 
            // percentageOfComputerrelatedJobsOfferedDataGridViewTextBoxColumn
            // 
            this.percentageOfComputerrelatedJobsOfferedDataGridViewTextBoxColumn.DataPropertyName = "Percentage of Computer-related jobs offered: ";
            this.percentageOfComputerrelatedJobsOfferedDataGridViewTextBoxColumn.HeaderText = "Percentage of Computer-related jobs offered: ";
            this.percentageOfComputerrelatedJobsOfferedDataGridViewTextBoxColumn.Name = "percentageOfComputerrelatedJobsOfferedDataGridViewTextBoxColumn";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(819, 337);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(142, 85);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnShowDetails
            // 
            this.btnShowDetails.Location = new System.Drawing.Point(605, 336);
            this.btnShowDetails.Name = "btnShowDetails";
            this.btnShowDetails.Size = new System.Drawing.Size(142, 85);
            this.btnShowDetails.TabIndex = 3;
            this.btnShowDetails.Text = "&Show Details";
            this.btnShowDetails.UseVisualStyleBackColor = true;
            this.btnShowDetails.Click += new System.EventHandler(this.btnShowDetails_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(16, 97);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(142, 85);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(242, 97);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(142, 85);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnFilterMedian
            // 
            this.btnFilterMedian.Location = new System.Drawing.Point(12, 13);
            this.btnFilterMedian.Name = "btnFilterMedian";
            this.btnFilterMedian.Size = new System.Drawing.Size(142, 85);
            this.btnFilterMedian.TabIndex = 6;
            this.btnFilterMedian.Text = "&Filter Median";
            this.btnFilterMedian.UseVisualStyleBackColor = true;
            this.btnFilterMedian.Click += new System.EventHandler(this.btnFilterMedian_Click);
            // 
            // selectNamePanel
            // 
            this.selectNamePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectNamePanel.Controls.Add(this.stateNamebox);
            this.selectNamePanel.Location = new System.Drawing.Point(156, 375);
            this.selectNamePanel.Name = "selectNamePanel";
            this.selectNamePanel.Size = new System.Drawing.Size(253, 61);
            this.selectNamePanel.TabIndex = 7;
            // 
            // stateNamebox
            // 
            this.stateNamebox.DataSource = this.stateTableBindingSource;
            this.stateNamebox.DisplayMember = "State Name";
            this.stateNamebox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateNamebox.FormattingEnabled = true;
            this.stateNamebox.Location = new System.Drawing.Point(37, 14);
            this.stateNamebox.Name = "stateNamebox";
            this.stateNamebox.Size = new System.Drawing.Size(169, 27);
            this.stateNamebox.TabIndex = 9;
            this.stateNamebox.ValueMember = "State Name";
            // 
            // filterMedianPanel
            // 
            this.filterMedianPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterMedianPanel.Controls.Add(this.stateMedianCB);
            this.filterMedianPanel.Controls.Add(this.btnFilterMedian);
            this.filterMedianPanel.Location = new System.Drawing.Point(1022, 409);
            this.filterMedianPanel.Name = "filterMedianPanel";
            this.filterMedianPanel.Size = new System.Drawing.Size(336, 214);
            this.filterMedianPanel.TabIndex = 8;
            // 
            // stateMedianCB
            // 
            this.stateMedianCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateMedianCB.FormattingEnabled = true;
            this.stateMedianCB.Items.AddRange(new object[] {
            "$10,000.00 - $19,999.00",
            "$20,000.00 - $29,999.00",
            "$30,000.00 - $39,999.00",
            "$40,000.00 - $49,999.00",
            "$50,000.00 - $59,999.00",
            "$60,000.00 - $69,000.00",
            "None"});
            this.stateMedianCB.Location = new System.Drawing.Point(178, 25);
            this.stateMedianCB.Name = "stateMedianCB";
            this.stateMedianCB.Size = new System.Drawing.Size(141, 27);
            this.stateMedianCB.TabIndex = 10;
            // 
            // searchSNPanel
            // 
            this.searchSNPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchSNPanel.Controls.Add(this.txtSearchBox);
            this.searchSNPanel.Controls.Add(this.btnSearch);
            this.searchSNPanel.Controls.Add(this.btnClear);
            this.searchSNPanel.Location = new System.Drawing.Point(80, 549);
            this.searchSNPanel.Name = "searchSNPanel";
            this.searchSNPanel.Size = new System.Drawing.Size(400, 188);
            this.searchSNPanel.TabIndex = 8;
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Location = new System.Drawing.Point(88, 29);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(242, 26);
            this.txtSearchBox.TabIndex = 6;
            // 
            // lblSelectName
            // 
            this.lblSelectName.AutoSize = true;
            this.lblSelectName.Location = new System.Drawing.Point(211, 337);
            this.lblSelectName.Name = "lblSelectName";
            this.lblSelectName.Size = new System.Drawing.Size(138, 19);
            this.lblSelectName.TabIndex = 9;
            this.lblSelectName.Text = "Select State Name:";
            this.lblSelectName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOR
            // 
            this.lblOR.AutoSize = true;
            this.lblOR.Location = new System.Drawing.Point(258, 469);
            this.lblOR.Name = "lblOR";
            this.lblOR.Size = new System.Drawing.Size(33, 19);
            this.lblOR.TabIndex = 10;
            this.lblOR.Text = "OR";
            this.lblOR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTypeStateName
            // 
            this.lblTypeStateName.AutoSize = true;
            this.lblTypeStateName.Location = new System.Drawing.Point(219, 514);
            this.lblTypeStateName.Name = "lblTypeStateName";
            this.lblTypeStateName.Size = new System.Drawing.Size(130, 19);
            this.lblTypeStateName.TabIndex = 11;
            this.lblTypeStateName.Text = "Type State Name:";
            this.lblTypeStateName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFilterMedian
            // 
            this.lblFilterMedian.AutoSize = true;
            this.lblFilterMedian.Location = new System.Drawing.Point(1165, 375);
            this.lblFilterMedian.Name = "lblFilterMedian";
            this.lblFilterMedian.Size = new System.Drawing.Size(106, 19);
            this.lblFilterMedian.TabIndex = 12;
            this.lblFilterMedian.Text = "Filter Median:";
            // 
            // statelistDataSet1
            // 
            this.statelistDataSet1.DataSetName = "StatelistDataSet";
            this.statelistDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stateTableBindingSource1
            // 
            this.stateTableBindingSource1.DataMember = "StateTable";
            this.stateTableBindingSource1.DataSource = this.statelistDataSet1;
            // 
            // StateData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.lblFilterMedian);
            this.Controls.Add(this.lblTypeStateName);
            this.Controls.Add(this.lblOR);
            this.Controls.Add(this.lblSelectName);
            this.Controls.Add(this.searchSNPanel);
            this.Controls.Add(this.filterMedianPanel);
            this.Controls.Add(this.selectNamePanel);
            this.Controls.Add(this.btnShowDetails);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.stateTableDataGridView);
            this.Controls.Add(this.stateTableBindingNavigator);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StateData";
            this.Text = "State\'s Database";
            this.Load += new System.EventHandler(this.StateData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statelistDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateTableBindingNavigator)).EndInit();
            this.stateTableBindingNavigator.ResumeLayout(false);
            this.stateTableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stateTableDataGridView)).EndInit();
            this.selectNamePanel.ResumeLayout(false);
            this.filterMedianPanel.ResumeLayout(false);
            this.searchSNPanel.ResumeLayout(false);
            this.searchSNPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statelistDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateTableBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StatelistDataSet statelistDataSet;
        private System.Windows.Forms.BindingSource stateTableBindingSource;
        private StatelistDataSetTableAdapters.StateTableTableAdapter stateTableTableAdapter;
        private StatelistDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator stateTableBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton stateTableBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView stateTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn populationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateFlagDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateFlowerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateBirdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn threeLargestCitiesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateCapitolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateMedianIncomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentageOfComputerrelatedJobsOfferedDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnShowDetails;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnFilterMedian;
        private System.Windows.Forms.Panel selectNamePanel;
        private System.Windows.Forms.Panel filterMedianPanel;
        private System.Windows.Forms.Panel searchSNPanel;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.ComboBox stateNamebox;
        private System.Windows.Forms.ComboBox stateMedianCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Label lblSelectName;
        private System.Windows.Forms.Label lblOR;
        private System.Windows.Forms.Label lblTypeStateName;
        private System.Windows.Forms.Label lblFilterMedian;
        private StatelistDataSet statelistDataSet1;
        private System.Windows.Forms.BindingSource stateTableBindingSource1;
    }
}