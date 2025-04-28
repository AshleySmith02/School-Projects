namespace Ashley_Smith_CPT_185_Final_Project
{
    partial class MainForm
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
            this.lstDisplayOrder = new System.Windows.Forms.ListBox();
            this.btnDisplayOrderList = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.menuGroupBox = new System.Windows.Forms.GroupBox();
            this.radioDeckCardsButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radioFiveThouButton = new System.Windows.Forms.RadioButton();
            this.radioBurgerButton = new System.Windows.Forms.RadioButton();
            this.radioComputerButton = new System.Windows.Forms.RadioButton();
            this.radioClothesButton = new System.Windows.Forms.RadioButton();
            this.radioCarButton = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnClearOrderMenu = new System.Windows.Forms.Button();
            this.btnClearOrderWindow = new System.Windows.Forms.Button();
            this.btnPrintWindowOrder = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.warehouseTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstDisplayOrder
            // 
            this.lstDisplayOrder.FormattingEnabled = true;
            this.lstDisplayOrder.ItemHeight = 15;
            this.lstDisplayOrder.Items.AddRange(new object[] {
            "Name\t\tMenu Item\t\tPrice\t\t\tSale Tax\t\t\tTotal",
            "_________________________________________________________________________________" +
                "__________________________________________________"});
            this.lstDisplayOrder.Location = new System.Drawing.Point(552, 74);
            this.lstDisplayOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstDisplayOrder.Name = "lstDisplayOrder";
            this.lstDisplayOrder.Size = new System.Drawing.Size(699, 424);
            this.lstDisplayOrder.TabIndex = 6;
            // 
            // btnDisplayOrderList
            // 
            this.btnDisplayOrderList.Location = new System.Drawing.Point(43, 387);
            this.btnDisplayOrderList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDisplayOrderList.Name = "btnDisplayOrderList";
            this.btnDisplayOrderList.Size = new System.Drawing.Size(141, 91);
            this.btnDisplayOrderList.TabIndex = 0;
            this.btnDisplayOrderList.Text = "&Display Order Window";
            this.warehouseTip.SetToolTip(this.btnDisplayOrderList, "Display Order Window");
            this.btnDisplayOrderList.UseVisualStyleBackColor = true;
            this.btnDisplayOrderList.Click += new System.EventHandler(this.btnDisplayOrderList_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(448, 591);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 79);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "&Exit";
            this.warehouseTip.SetToolTip(this.btnExit, "Exit button");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // menuGroupBox
            // 
            this.menuGroupBox.Controls.Add(this.radioDeckCardsButton);
            this.menuGroupBox.Controls.Add(this.label1);
            this.menuGroupBox.Controls.Add(this.radioFiveThouButton);
            this.menuGroupBox.Controls.Add(this.radioBurgerButton);
            this.menuGroupBox.Controls.Add(this.radioComputerButton);
            this.menuGroupBox.Controls.Add(this.radioClothesButton);
            this.menuGroupBox.Controls.Add(this.radioCarButton);
            this.menuGroupBox.Controls.Add(this.txtName);
            this.menuGroupBox.Controls.Add(this.lblName);
            this.menuGroupBox.Location = new System.Drawing.Point(13, 77);
            this.menuGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.menuGroupBox.Name = "menuGroupBox";
            this.menuGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.menuGroupBox.Size = new System.Drawing.Size(431, 289);
            this.menuGroupBox.TabIndex = 5;
            this.menuGroupBox.TabStop = false;
            this.menuGroupBox.Text = "Menu:";
            // 
            // radioDeckCardsButton
            // 
            this.radioDeckCardsButton.AutoSize = true;
            this.radioDeckCardsButton.Location = new System.Drawing.Point(299, 235);
            this.radioDeckCardsButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioDeckCardsButton.Name = "radioDeckCardsButton";
            this.radioDeckCardsButton.Size = new System.Drawing.Size(103, 19);
            this.radioDeckCardsButton.TabIndex = 6;
            this.radioDeckCardsButton.TabStop = true;
            this.radioDeckCardsButton.Text = "Deck of Cards";
            this.warehouseTip.SetToolTip(this.radioDeckCardsButton, "Deck of Cards");
            this.radioDeckCardsButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select choices:";
            // 
            // radioFiveThouButton
            // 
            this.radioFiveThouButton.AutoSize = true;
            this.radioFiveThouButton.Location = new System.Drawing.Point(30, 235);
            this.radioFiveThouButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioFiveThouButton.Name = "radioFiveThouButton";
            this.radioFiveThouButton.Size = new System.Drawing.Size(139, 19);
            this.radioFiveThouButton.TabIndex = 3;
            this.radioFiveThouButton.TabStop = true;
            this.radioFiveThouButton.Text = "$5 Thousand Dollars";
            this.warehouseTip.SetToolTip(this.radioFiveThouButton, "$5 Thousand Dollars");
            this.radioFiveThouButton.UseVisualStyleBackColor = true;
            // 
            // radioBurgerButton
            // 
            this.radioBurgerButton.AutoSize = true;
            this.radioBurgerButton.Location = new System.Drawing.Point(299, 195);
            this.radioBurgerButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioBurgerButton.Name = "radioBurgerButton";
            this.radioBurgerButton.Size = new System.Drawing.Size(106, 19);
            this.radioBurgerButton.TabIndex = 5;
            this.radioBurgerButton.TabStop = true;
            this.radioBurgerButton.Text = "Burger Combo";
            this.warehouseTip.SetToolTip(this.radioBurgerButton, "Burger Combo");
            this.radioBurgerButton.UseVisualStyleBackColor = true;
            // 
            // radioComputerButton
            // 
            this.radioComputerButton.AutoSize = true;
            this.radioComputerButton.Location = new System.Drawing.Point(299, 150);
            this.radioComputerButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioComputerButton.Name = "radioComputerButton";
            this.radioComputerButton.Size = new System.Drawing.Size(100, 19);
            this.radioComputerButton.TabIndex = 4;
            this.radioComputerButton.TabStop = true;
            this.radioComputerButton.Text = "Computer Set";
            this.warehouseTip.SetToolTip(this.radioComputerButton, "Computer Set");
            this.radioComputerButton.UseVisualStyleBackColor = true;
            // 
            // radioClothesButton
            // 
            this.radioClothesButton.AutoSize = true;
            this.radioClothesButton.Location = new System.Drawing.Point(30, 195);
            this.radioClothesButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioClothesButton.Name = "radioClothesButton";
            this.radioClothesButton.Size = new System.Drawing.Size(159, 19);
            this.radioClothesButton.TabIndex = 2;
            this.radioClothesButton.TabStop = true;
            this.radioClothesButton.Text = "Clothes (shirt and pants)";
            this.warehouseTip.SetToolTip(this.radioClothesButton, "Clothes");
            this.radioClothesButton.UseVisualStyleBackColor = true;
            // 
            // radioCarButton
            // 
            this.radioCarButton.AutoSize = true;
            this.radioCarButton.Location = new System.Drawing.Point(30, 150);
            this.radioCarButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioCarButton.Name = "radioCarButton";
            this.radioCarButton.Size = new System.Drawing.Size(72, 19);
            this.radioCarButton.TabIndex = 2;
            this.radioCarButton.TabStop = true;
            this.radioCarButton.Text = "New Car";
            this.warehouseTip.SetToolTip(this.radioCarButton, "New Car");
            this.radioCarButton.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(135, 42);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(237, 22);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(70, 45);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(42, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // btnClearOrderMenu
            // 
            this.btnClearOrderMenu.Location = new System.Drawing.Point(285, 387);
            this.btnClearOrderMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClearOrderMenu.Name = "btnClearOrderMenu";
            this.btnClearOrderMenu.Size = new System.Drawing.Size(130, 91);
            this.btnClearOrderMenu.TabIndex = 1;
            this.btnClearOrderMenu.Text = "&Clear Order Menu";
            this.warehouseTip.SetToolTip(this.btnClearOrderMenu, "Clear Order Menu");
            this.btnClearOrderMenu.UseVisualStyleBackColor = true;
            this.btnClearOrderMenu.Click += new System.EventHandler(this.btnClearOrderMenu_Click);
            // 
            // btnClearOrderWindow
            // 
            this.btnClearOrderWindow.Location = new System.Drawing.Point(1035, 507);
            this.btnClearOrderWindow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClearOrderWindow.Name = "btnClearOrderWindow";
            this.btnClearOrderWindow.Size = new System.Drawing.Size(111, 91);
            this.btnClearOrderWindow.TabIndex = 4;
            this.btnClearOrderWindow.Text = "&Clear Order Window";
            this.warehouseTip.SetToolTip(this.btnClearOrderWindow, "Clear Order Window");
            this.btnClearOrderWindow.UseVisualStyleBackColor = true;
            this.btnClearOrderWindow.Click += new System.EventHandler(this.btnClearOrderWindow_Click);
            // 
            // btnPrintWindowOrder
            // 
            this.btnPrintWindowOrder.Location = new System.Drawing.Point(709, 516);
            this.btnPrintWindowOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPrintWindowOrder.Name = "btnPrintWindowOrder";
            this.btnPrintWindowOrder.Size = new System.Drawing.Size(111, 91);
            this.btnPrintWindowOrder.TabIndex = 3;
            this.btnPrintWindowOrder.Text = "&Print Window Order";
            this.warehouseTip.SetToolTip(this.btnPrintWindowOrder, "Print Window Order");
            this.btnPrintWindowOrder.UseVisualStyleBackColor = true;
            this.btnPrintWindowOrder.Click += new System.EventHandler(this.btnPrintWindowOrder_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(422, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(293, 62);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Ash\'s Supply Warehouse";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnPrintWindowOrder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1278, 724);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnPrintWindowOrder);
            this.Controls.Add(this.btnClearOrderWindow);
            this.Controls.Add(this.btnClearOrderMenu);
            this.Controls.Add(this.menuGroupBox);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDisplayOrderList);
            this.Controls.Add(this.lstDisplayOrder);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuGroupBox.ResumeLayout(false);
            this.menuGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstDisplayOrder;
        private System.Windows.Forms.Button btnDisplayOrderList;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox menuGroupBox;
        private System.Windows.Forms.Button btnClearOrderMenu;
        private System.Windows.Forms.Button btnClearOrderWindow;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnPrintWindowOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioFiveThouButton;
        private System.Windows.Forms.RadioButton radioBurgerButton;
        private System.Windows.Forms.RadioButton radioComputerButton;
        private System.Windows.Forms.RadioButton radioClothesButton;
        private System.Windows.Forms.RadioButton radioCarButton;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RadioButton radioDeckCardsButton;
        private System.Windows.Forms.ToolTip warehouseTip;
    }
}

