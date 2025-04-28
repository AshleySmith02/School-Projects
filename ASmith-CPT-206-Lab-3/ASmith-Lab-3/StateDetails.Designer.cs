namespace ASmith_Lab_3
{
    partial class StateDetails
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label state_NameLabel;
            System.Windows.Forms.Label populationLabel;
            System.Windows.Forms.Label state_Flag_DescriptionLabel;
            System.Windows.Forms.Label state_FlowerLabel;
            System.Windows.Forms.Label state_BirdLabel;
            System.Windows.Forms.Label three_Largest_Cities_Label;
            System.Windows.Forms.Label state_CapitolLabel;
            System.Windows.Forms.Label state_Median_IncomeLabel;
            System.Windows.Forms.Label percentage_of_Computer_related_jobs_offered__Label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StateDetails));
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
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.state_NameTextBox = new System.Windows.Forms.TextBox();
            this.populationTextBox = new System.Windows.Forms.TextBox();
            this.state_Flag_DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.state_FlowerTextBox = new System.Windows.Forms.TextBox();
            this.state_BirdTextBox = new System.Windows.Forms.TextBox();
            this.three_Largest_Cities_TextBox = new System.Windows.Forms.TextBox();
            this.state_CapitolTextBox = new System.Windows.Forms.TextBox();
            this.state_Median_IncomeTextBox = new System.Windows.Forms.TextBox();
            this.percentage_of_Computer_related_jobs_offered__TextBox = new System.Windows.Forms.TextBox();
            this.btnExitDetails = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            state_NameLabel = new System.Windows.Forms.Label();
            populationLabel = new System.Windows.Forms.Label();
            state_Flag_DescriptionLabel = new System.Windows.Forms.Label();
            state_FlowerLabel = new System.Windows.Forms.Label();
            state_BirdLabel = new System.Windows.Forms.Label();
            three_Largest_Cities_Label = new System.Windows.Forms.Label();
            state_CapitolLabel = new System.Windows.Forms.Label();
            state_Median_IncomeLabel = new System.Windows.Forms.Label();
            percentage_of_Computer_related_jobs_offered__Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.statelistDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateTableBindingNavigator)).BeginInit();
            this.stateTableBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(65, 158);
            idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(21, 15);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // state_NameLabel
            // 
            state_NameLabel.AutoSize = true;
            state_NameLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            state_NameLabel.Location = new System.Drawing.Point(355, 38);
            state_NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            state_NameLabel.Name = "state_NameLabel";
            state_NameLabel.Size = new System.Drawing.Size(73, 15);
            state_NameLabel.TabIndex = 3;
            state_NameLabel.Text = "State Name:";
            // 
            // populationLabel
            // 
            populationLabel.AutoSize = true;
            populationLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            populationLabel.Location = new System.Drawing.Point(28, 235);
            populationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            populationLabel.Name = "populationLabel";
            populationLabel.Size = new System.Drawing.Size(69, 15);
            populationLabel.TabIndex = 5;
            populationLabel.Text = "Population:";
            // 
            // state_Flag_DescriptionLabel
            // 
            state_Flag_DescriptionLabel.AutoSize = true;
            state_Flag_DescriptionLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            state_Flag_DescriptionLabel.Location = new System.Drawing.Point(119, 416);
            state_Flag_DescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            state_Flag_DescriptionLabel.Name = "state_Flag_DescriptionLabel";
            state_Flag_DescriptionLabel.Size = new System.Drawing.Size(133, 15);
            state_Flag_DescriptionLabel.TabIndex = 7;
            state_Flag_DescriptionLabel.Text = "State Flag Description:";
            // 
            // state_FlowerLabel
            // 
            state_FlowerLabel.AutoSize = true;
            state_FlowerLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            state_FlowerLabel.Location = new System.Drawing.Point(831, 348);
            state_FlowerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            state_FlowerLabel.Name = "state_FlowerLabel";
            state_FlowerLabel.Size = new System.Drawing.Size(79, 15);
            state_FlowerLabel.TabIndex = 9;
            state_FlowerLabel.Text = "State Flower:";
            // 
            // state_BirdLabel
            // 
            state_BirdLabel.AutoSize = true;
            state_BirdLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            state_BirdLabel.Location = new System.Drawing.Point(811, 56);
            state_BirdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            state_BirdLabel.Name = "state_BirdLabel";
            state_BirdLabel.Size = new System.Drawing.Size(67, 15);
            state_BirdLabel.TabIndex = 11;
            state_BirdLabel.Text = "State Bird:";
            // 
            // three_Largest_Cities_Label
            // 
            three_Largest_Cities_Label.AutoSize = true;
            three_Largest_Cities_Label.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            three_Largest_Cities_Label.Location = new System.Drawing.Point(425, 174);
            three_Largest_Cities_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            three_Largest_Cities_Label.Name = "three_Largest_Cities_Label";
            three_Largest_Cities_Label.Size = new System.Drawing.Size(126, 15);
            three_Largest_Cities_Label.TabIndex = 13;
            three_Largest_Cities_Label.Text = "Three Largest Cities:";
            // 
            // state_CapitolLabel
            // 
            state_CapitolLabel.AutoSize = true;
            state_CapitolLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            state_CapitolLabel.Location = new System.Drawing.Point(355, 81);
            state_CapitolLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            state_CapitolLabel.Name = "state_CapitolLabel";
            state_CapitolLabel.Size = new System.Drawing.Size(81, 15);
            state_CapitolLabel.TabIndex = 15;
            state_CapitolLabel.Text = "State Capitol:";
            // 
            // state_Median_IncomeLabel
            // 
            state_Median_IncomeLabel.AutoSize = true;
            state_Median_IncomeLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            state_Median_IncomeLabel.Location = new System.Drawing.Point(13, 341);
            state_Median_IncomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            state_Median_IncomeLabel.Name = "state_Median_IncomeLabel";
            state_Median_IncomeLabel.Size = new System.Drawing.Size(124, 15);
            state_Median_IncomeLabel.TabIndex = 17;
            state_Median_IncomeLabel.Text = "State Median Income:";
            // 
            // percentage_of_Computer_related_jobs_offered__Label
            // 
            percentage_of_Computer_related_jobs_offered__Label.AutoSize = true;
            percentage_of_Computer_related_jobs_offered__Label.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            percentage_of_Computer_related_jobs_offered__Label.Location = new System.Drawing.Point(380, 348);
            percentage_of_Computer_related_jobs_offered__Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            percentage_of_Computer_related_jobs_offered__Label.Name = "percentage_of_Computer_related_jobs_offered__Label";
            percentage_of_Computer_related_jobs_offered__Label.Size = new System.Drawing.Size(254, 15);
            percentage_of_Computer_related_jobs_offered__Label.TabIndex = 19;
            percentage_of_Computer_related_jobs_offered__Label.Text = "Percentage of Computer-related jobs offered: ";
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
            this.stateTableBindingNavigator.BindingSource = this.stateTableBindingSource;
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
            this.stateTableBindingNavigator.Size = new System.Drawing.Size(1028, 25);
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(58, 23);
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
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stateTableBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(145, 155);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(116, 22);
            this.idTextBox.TabIndex = 2;
            // 
            // state_NameTextBox
            // 
            this.state_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stateTableBindingSource, "State Name", true));
            this.state_NameTextBox.Location = new System.Drawing.Point(451, 35);
            this.state_NameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.state_NameTextBox.Name = "state_NameTextBox";
            this.state_NameTextBox.Size = new System.Drawing.Size(116, 22);
            this.state_NameTextBox.TabIndex = 4;
            // 
            // populationTextBox
            // 
            this.populationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stateTableBindingSource, "Population", true));
            this.populationTextBox.Location = new System.Drawing.Point(145, 232);
            this.populationTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.populationTextBox.Name = "populationTextBox";
            this.populationTextBox.Size = new System.Drawing.Size(116, 22);
            this.populationTextBox.TabIndex = 6;
            // 
            // state_Flag_DescriptionTextBox
            // 
            this.state_Flag_DescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stateTableBindingSource, "State Flag Description", true));
            this.state_Flag_DescriptionTextBox.Location = new System.Drawing.Point(31, 446);
            this.state_Flag_DescriptionTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.state_Flag_DescriptionTextBox.Multiline = true;
            this.state_Flag_DescriptionTextBox.Name = "state_Flag_DescriptionTextBox";
            this.state_Flag_DescriptionTextBox.Size = new System.Drawing.Size(296, 163);
            this.state_Flag_DescriptionTextBox.TabIndex = 8;
            // 
            // state_FlowerTextBox
            // 
            this.state_FlowerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stateTableBindingSource, "State Flower", true));
            this.state_FlowerTextBox.Location = new System.Drawing.Point(775, 376);
            this.state_FlowerTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.state_FlowerTextBox.Name = "state_FlowerTextBox";
            this.state_FlowerTextBox.Size = new System.Drawing.Size(196, 22);
            this.state_FlowerTextBox.TabIndex = 10;
            // 
            // state_BirdTextBox
            // 
            this.state_BirdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stateTableBindingSource, "State Bird", true));
            this.state_BirdTextBox.Location = new System.Drawing.Point(743, 74);
            this.state_BirdTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.state_BirdTextBox.Name = "state_BirdTextBox";
            this.state_BirdTextBox.Size = new System.Drawing.Size(228, 22);
            this.state_BirdTextBox.TabIndex = 12;
            // 
            // three_Largest_Cities_TextBox
            // 
            this.three_Largest_Cities_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stateTableBindingSource, "Three Largest Cities:", true));
            this.three_Largest_Cities_TextBox.Location = new System.Drawing.Point(417, 203);
            this.three_Largest_Cities_TextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.three_Largest_Cities_TextBox.Multiline = true;
            this.three_Largest_Cities_TextBox.Name = "three_Largest_Cities_TextBox";
            this.three_Largest_Cities_TextBox.Size = new System.Drawing.Size(140, 103);
            this.three_Largest_Cities_TextBox.TabIndex = 14;
            this.three_Largest_Cities_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // state_CapitolTextBox
            // 
            this.state_CapitolTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stateTableBindingSource, "State Capitol", true));
            this.state_CapitolTextBox.Location = new System.Drawing.Point(451, 74);
            this.state_CapitolTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.state_CapitolTextBox.Name = "state_CapitolTextBox";
            this.state_CapitolTextBox.Size = new System.Drawing.Size(116, 22);
            this.state_CapitolTextBox.TabIndex = 16;
            // 
            // state_Median_IncomeTextBox
            // 
            this.state_Median_IncomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stateTableBindingSource, "State Median Income", true));
            this.state_Median_IncomeTextBox.Location = new System.Drawing.Point(145, 338);
            this.state_Median_IncomeTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.state_Median_IncomeTextBox.Name = "state_Median_IncomeTextBox";
            this.state_Median_IncomeTextBox.Size = new System.Drawing.Size(116, 22);
            this.state_Median_IncomeTextBox.TabIndex = 18;
            // 
            // percentage_of_Computer_related_jobs_offered__TextBox
            // 
            this.percentage_of_Computer_related_jobs_offered__TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stateTableBindingSource, "Percentage of Computer-related jobs offered: ", true));
            this.percentage_of_Computer_related_jobs_offered__TextBox.Location = new System.Drawing.Point(441, 387);
            this.percentage_of_Computer_related_jobs_offered__TextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.percentage_of_Computer_related_jobs_offered__TextBox.Name = "percentage_of_Computer_related_jobs_offered__TextBox";
            this.percentage_of_Computer_related_jobs_offered__TextBox.Size = new System.Drawing.Size(116, 22);
            this.percentage_of_Computer_related_jobs_offered__TextBox.TabIndex = 20;
            this.percentage_of_Computer_related_jobs_offered__TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnExitDetails
            // 
            this.btnExitDetails.Location = new System.Drawing.Point(417, 465);
            this.btnExitDetails.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExitDetails.Name = "btnExitDetails";
            this.btnExitDetails.Size = new System.Drawing.Size(164, 81);
            this.btnExitDetails.TabIndex = 21;
            this.btnExitDetails.Text = "&Exit";
            this.btnExitDetails.UseVisualStyleBackColor = true;
            this.btnExitDetails.Click += new System.EventHandler(this.btnExitDetails_Click);
            // 
            // StateDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 634);
            this.Controls.Add(this.btnExitDetails);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(state_NameLabel);
            this.Controls.Add(this.state_NameTextBox);
            this.Controls.Add(populationLabel);
            this.Controls.Add(this.populationTextBox);
            this.Controls.Add(state_Flag_DescriptionLabel);
            this.Controls.Add(this.state_Flag_DescriptionTextBox);
            this.Controls.Add(state_FlowerLabel);
            this.Controls.Add(this.state_FlowerTextBox);
            this.Controls.Add(state_BirdLabel);
            this.Controls.Add(this.state_BirdTextBox);
            this.Controls.Add(three_Largest_Cities_Label);
            this.Controls.Add(this.three_Largest_Cities_TextBox);
            this.Controls.Add(state_CapitolLabel);
            this.Controls.Add(this.state_CapitolTextBox);
            this.Controls.Add(state_Median_IncomeLabel);
            this.Controls.Add(this.state_Median_IncomeTextBox);
            this.Controls.Add(percentage_of_Computer_related_jobs_offered__Label);
            this.Controls.Add(this.percentage_of_Computer_related_jobs_offered__TextBox);
            this.Controls.Add(this.stateTableBindingNavigator);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "StateDetails";
            this.Text = "State Details";
            this.Load += new System.EventHandler(this.StateDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statelistDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateTableBindingNavigator)).EndInit();
            this.stateTableBindingNavigator.ResumeLayout(false);
            this.stateTableBindingNavigator.PerformLayout();
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
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox state_NameTextBox;
        private System.Windows.Forms.TextBox populationTextBox;
        private System.Windows.Forms.TextBox state_Flag_DescriptionTextBox;
        private System.Windows.Forms.TextBox state_FlowerTextBox;
        private System.Windows.Forms.TextBox state_BirdTextBox;
        private System.Windows.Forms.TextBox three_Largest_Cities_TextBox;
        private System.Windows.Forms.TextBox state_CapitolTextBox;
        private System.Windows.Forms.TextBox state_Median_IncomeTextBox;
        private System.Windows.Forms.TextBox percentage_of_Computer_related_jobs_offered__TextBox;
        private System.Windows.Forms.Button btnExitDetails;
    }
}