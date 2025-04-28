namespace Ashley_Smith_CPT_185_A01H_Lab_9
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
            this.selectDormBox = new System.Windows.Forms.GroupBox();
            this.radioPike = new System.Windows.Forms.RadioButton();
            this.radioFarthing = new System.Windows.Forms.RadioButton();
            this.radioUniversity = new System.Windows.Forms.RadioButton();
            this.radioAllen = new System.Windows.Forms.RadioButton();
            this.selectMealPlanBox = new System.Windows.Forms.GroupBox();
            this.radio7Meals = new System.Windows.Forms.RadioButton();
            this.radio14Meals = new System.Windows.Forms.RadioButton();
            this.radioUnlimitedMeals = new System.Windows.Forms.RadioButton();
            this.btnDisplayTotal = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dormMealPlanTip = new System.Windows.Forms.ToolTip(this.components);
            this.sideTitleStrip = new System.Windows.Forms.ToolStrip();
            this.helpToAboutDB = new System.Windows.Forms.ToolStripDropDownButton();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectDormBox.SuspendLayout();
            this.selectMealPlanBox.SuspendLayout();
            this.sideTitleStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectDormBox
            // 
            this.selectDormBox.Controls.Add(this.radioPike);
            this.selectDormBox.Controls.Add(this.radioFarthing);
            this.selectDormBox.Controls.Add(this.radioUniversity);
            this.selectDormBox.Controls.Add(this.radioAllen);
            this.selectDormBox.Location = new System.Drawing.Point(64, 69);
            this.selectDormBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selectDormBox.Name = "selectDormBox";
            this.selectDormBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selectDormBox.Size = new System.Drawing.Size(331, 218);
            this.selectDormBox.TabIndex = 0;
            this.selectDormBox.TabStop = false;
            this.selectDormBox.Text = "Select a Dorm:";
            // 
            // radioPike
            // 
            this.radioPike.AutoSize = true;
            this.radioPike.Location = new System.Drawing.Point(115, 93);
            this.radioPike.Name = "radioPike";
            this.radioPike.Size = new System.Drawing.Size(77, 19);
            this.radioPike.TabIndex = 3;
            this.radioPike.Text = "Pike Hall";
            this.dormMealPlanTip.SetToolTip(this.radioPike, "Pike Hall button");
            this.radioPike.UseVisualStyleBackColor = true;
            // 
            // radioFarthing
            // 
            this.radioFarthing.AutoSize = true;
            this.radioFarthing.Location = new System.Drawing.Point(115, 141);
            this.radioFarthing.Name = "radioFarthing";
            this.radioFarthing.Size = new System.Drawing.Size(99, 19);
            this.radioFarthing.TabIndex = 4;
            this.radioFarthing.Text = "Farthing Hall";
            this.dormMealPlanTip.SetToolTip(this.radioFarthing, "Farthing Hall button");
            this.radioFarthing.UseVisualStyleBackColor = true;
            // 
            // radioUniversity
            // 
            this.radioUniversity.AutoSize = true;
            this.radioUniversity.Location = new System.Drawing.Point(115, 184);
            this.radioUniversity.Name = "radioUniversity";
            this.radioUniversity.Size = new System.Drawing.Size(107, 19);
            this.radioUniversity.TabIndex = 5;
            this.radioUniversity.Text = "University Hall";
            this.dormMealPlanTip.SetToolTip(this.radioUniversity, "University Hall button");
            this.radioUniversity.UseVisualStyleBackColor = true;
            // 
            // radioAllen
            // 
            this.radioAllen.AutoSize = true;
            this.radioAllen.Checked = true;
            this.radioAllen.Location = new System.Drawing.Point(115, 46);
            this.radioAllen.Name = "radioAllen";
            this.radioAllen.Size = new System.Drawing.Size(81, 19);
            this.radioAllen.TabIndex = 2;
            this.radioAllen.TabStop = true;
            this.radioAllen.Text = "Allen Hall";
            this.dormMealPlanTip.SetToolTip(this.radioAllen, "Allen Hall button");
            this.radioAllen.UseVisualStyleBackColor = true;
            // 
            // selectMealPlanBox
            // 
            this.selectMealPlanBox.Controls.Add(this.radio7Meals);
            this.selectMealPlanBox.Controls.Add(this.radio14Meals);
            this.selectMealPlanBox.Controls.Add(this.radioUnlimitedMeals);
            this.selectMealPlanBox.Location = new System.Drawing.Point(486, 81);
            this.selectMealPlanBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selectMealPlanBox.Name = "selectMealPlanBox";
            this.selectMealPlanBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selectMealPlanBox.Size = new System.Drawing.Size(310, 191);
            this.selectMealPlanBox.TabIndex = 1;
            this.selectMealPlanBox.TabStop = false;
            this.selectMealPlanBox.Text = "Select a Meal Plan:";
            // 
            // radio7Meals
            // 
            this.radio7Meals.AutoSize = true;
            this.radio7Meals.Location = new System.Drawing.Point(115, 48);
            this.radio7Meals.Name = "radio7Meals";
            this.radio7Meals.Size = new System.Drawing.Size(119, 19);
            this.radio7Meals.TabIndex = 6;
            this.radio7Meals.TabStop = true;
            this.radio7Meals.Text = "7 meals per week";
            this.dormMealPlanTip.SetToolTip(this.radio7Meals, "7 meals per week button");
            this.radio7Meals.UseVisualStyleBackColor = true;
            // 
            // radio14Meals
            // 
            this.radio14Meals.AutoSize = true;
            this.radio14Meals.Location = new System.Drawing.Point(115, 99);
            this.radio14Meals.Name = "radio14Meals";
            this.radio14Meals.Size = new System.Drawing.Size(126, 19);
            this.radio14Meals.TabIndex = 7;
            this.radio14Meals.TabStop = true;
            this.radio14Meals.Text = "14 meals per week";
            this.dormMealPlanTip.SetToolTip(this.radio14Meals, "14 meals per week button");
            this.radio14Meals.UseVisualStyleBackColor = true;
            // 
            // radioUnlimitedMeals
            // 
            this.radioUnlimitedMeals.AutoSize = true;
            this.radioUnlimitedMeals.Location = new System.Drawing.Point(115, 148);
            this.radioUnlimitedMeals.Name = "radioUnlimitedMeals";
            this.radioUnlimitedMeals.Size = new System.Drawing.Size(113, 19);
            this.radioUnlimitedMeals.TabIndex = 8;
            this.radioUnlimitedMeals.TabStop = true;
            this.radioUnlimitedMeals.Text = "Unlimited meals";
            this.dormMealPlanTip.SetToolTip(this.radioUnlimitedMeals, "Unlimited meals button");
            this.radioUnlimitedMeals.UseVisualStyleBackColor = true;
            // 
            // btnDisplayTotal
            // 
            this.btnDisplayTotal.Location = new System.Drawing.Point(179, 358);
            this.btnDisplayTotal.Name = "btnDisplayTotal";
            this.btnDisplayTotal.Size = new System.Drawing.Size(141, 85);
            this.btnDisplayTotal.TabIndex = 2;
            this.btnDisplayTotal.Text = "Dis&play Total";
            this.dormMealPlanTip.SetToolTip(this.btnDisplayTotal, "Display Total button");
            this.btnDisplayTotal.UseVisualStyleBackColor = true;
            this.btnDisplayTotal.Click += new System.EventHandler(this.btnDisplayTotal_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(402, 358);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(141, 85);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "C&lear";
            this.dormMealPlanTip.SetToolTip(this.btnClear, "Clear button");
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(626, 358);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(141, 85);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.dormMealPlanTip.SetToolTip(this.btnExit, "Exit Program");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // sideTitleStrip
            // 
            this.sideTitleStrip.BackColor = System.Drawing.SystemColors.Window;
            this.sideTitleStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToAboutDB});
            this.sideTitleStrip.Location = new System.Drawing.Point(0, 0);
            this.sideTitleStrip.Name = "sideTitleStrip";
            this.sideTitleStrip.Size = new System.Drawing.Size(926, 25);
            this.sideTitleStrip.TabIndex = 5;
            this.sideTitleStrip.Text = "toolStrip1";
            // 
            // helpToAboutDB
            // 
            this.helpToAboutDB.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToAboutDB.Name = "helpToAboutDB";
            this.helpToAboutDB.Size = new System.Drawing.Size(45, 22);
            this.helpToAboutDB.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(926, 462);
            this.Controls.Add(this.sideTitleStrip);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDisplayTotal);
            this.Controls.Add(this.selectMealPlanBox);
            this.Controls.Add(this.selectDormBox);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dorm and Meal Plan Calculator";
            this.selectDormBox.ResumeLayout(false);
            this.selectDormBox.PerformLayout();
            this.selectMealPlanBox.ResumeLayout(false);
            this.selectMealPlanBox.PerformLayout();
            this.sideTitleStrip.ResumeLayout(false);
            this.sideTitleStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox selectDormBox;
        private System.Windows.Forms.GroupBox selectMealPlanBox;
        private System.Windows.Forms.RadioButton radioPike;
        private System.Windows.Forms.RadioButton radioFarthing;
        private System.Windows.Forms.RadioButton radioUniversity;
        private System.Windows.Forms.RadioButton radioAllen;
        private System.Windows.Forms.RadioButton radio7Meals;
        private System.Windows.Forms.RadioButton radio14Meals;
        private System.Windows.Forms.RadioButton radioUnlimitedMeals;
        private System.Windows.Forms.Button btnDisplayTotal;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolTip dormMealPlanTip;
        private System.Windows.Forms.ToolStrip sideTitleStrip;
        private System.Windows.Forms.ToolStripDropDownButton helpToAboutDB;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

