namespace Ashley_Smith_CPT_185_A01H_Lab_9
{
    partial class ChargesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChargesForm));
            this.lblDormCharges = new System.Windows.Forms.Label();
            this.lblMealCharges = new System.Windows.Forms.Label();
            this.lblTotalCharges = new System.Windows.Forms.Label();
            this.txtDorm = new System.Windows.Forms.TextBox();
            this.txtMeal = new System.Windows.Forms.TextBox();
            this.txtTotalCharges = new System.Windows.Forms.TextBox();
            this.btnGoToAbout = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dormTotalCharges = new System.Windows.Forms.ToolTip(this.components);
            this.chargesHelpToAbout = new System.Windows.Forms.ToolStrip();
            this.chargesHelpToAboutDB = new System.Windows.Forms.ToolStripDropDownButton();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chargesHelpToAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDormCharges
            // 
            this.lblDormCharges.AutoSize = true;
            this.lblDormCharges.Location = new System.Drawing.Point(99, 53);
            this.lblDormCharges.Name = "lblDormCharges";
            this.lblDormCharges.Size = new System.Drawing.Size(92, 15);
            this.lblDormCharges.TabIndex = 0;
            this.lblDormCharges.Text = "Dorm Charges:";
            // 
            // lblMealCharges
            // 
            this.lblMealCharges.AutoSize = true;
            this.lblMealCharges.Location = new System.Drawing.Point(103, 113);
            this.lblMealCharges.Name = "lblMealCharges";
            this.lblMealCharges.Size = new System.Drawing.Size(88, 15);
            this.lblMealCharges.TabIndex = 1;
            this.lblMealCharges.Text = "Meal Charges:";
            // 
            // lblTotalCharges
            // 
            this.lblTotalCharges.AutoSize = true;
            this.lblTotalCharges.Location = new System.Drawing.Point(99, 178);
            this.lblTotalCharges.Name = "lblTotalCharges";
            this.lblTotalCharges.Size = new System.Drawing.Size(88, 15);
            this.lblTotalCharges.TabIndex = 2;
            this.lblTotalCharges.Text = "Total Charges:";
            // 
            // txtDorm
            // 
            this.txtDorm.BackColor = System.Drawing.Color.Turquoise;
            this.txtDorm.Enabled = false;
            this.txtDorm.Location = new System.Drawing.Point(219, 46);
            this.txtDorm.Name = "txtDorm";
            this.txtDorm.Size = new System.Drawing.Size(125, 22);
            this.txtDorm.TabIndex = 3;
            // 
            // txtMeal
            // 
            this.txtMeal.BackColor = System.Drawing.Color.Turquoise;
            this.txtMeal.Enabled = false;
            this.txtMeal.Location = new System.Drawing.Point(219, 106);
            this.txtMeal.Name = "txtMeal";
            this.txtMeal.Size = new System.Drawing.Size(125, 22);
            this.txtMeal.TabIndex = 4;
            // 
            // txtTotalCharges
            // 
            this.txtTotalCharges.BackColor = System.Drawing.Color.Turquoise;
            this.txtTotalCharges.Enabled = false;
            this.txtTotalCharges.Location = new System.Drawing.Point(219, 171);
            this.txtTotalCharges.Name = "txtTotalCharges";
            this.txtTotalCharges.Size = new System.Drawing.Size(125, 22);
            this.txtTotalCharges.TabIndex = 5;
            // 
            // btnGoToAbout
            // 
            this.btnGoToAbout.Location = new System.Drawing.Point(92, 244);
            this.btnGoToAbout.Name = "btnGoToAbout";
            this.btnGoToAbout.Size = new System.Drawing.Size(95, 61);
            this.btnGoToAbout.TabIndex = 6;
            this.btnGoToAbout.Text = "G&o to About";
            this.dormTotalCharges.SetToolTip(this.btnGoToAbout, "Go to About button");
            this.btnGoToAbout.UseVisualStyleBackColor = true;
            this.btnGoToAbout.Click += new System.EventHandler(this.btnGoToAbout_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(276, 244);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(95, 61);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Clo&se";
            this.dormTotalCharges.SetToolTip(this.btnClose, "Close program");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // chargesHelpToAbout
            // 
            this.chargesHelpToAbout.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chargesHelpToAboutDB});
            this.chargesHelpToAbout.Location = new System.Drawing.Point(0, 0);
            this.chargesHelpToAbout.Name = "chargesHelpToAbout";
            this.chargesHelpToAbout.Size = new System.Drawing.Size(448, 25);
            this.chargesHelpToAbout.TabIndex = 8;
            this.chargesHelpToAbout.Text = "toolStrip1";
            // 
            // chargesHelpToAboutDB
            // 
            this.chargesHelpToAboutDB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.chargesHelpToAboutDB.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.chargesHelpToAboutDB.Image = ((System.Drawing.Image)(resources.GetObject("chargesHelpToAboutDB.Image")));
            this.chargesHelpToAboutDB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.chargesHelpToAboutDB.Name = "chargesHelpToAboutDB";
            this.chargesHelpToAboutDB.Size = new System.Drawing.Size(45, 22);
            this.chargesHelpToAboutDB.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // ChargesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(448, 339);
            this.Controls.Add(this.chargesHelpToAbout);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnGoToAbout);
            this.Controls.Add(this.txtTotalCharges);
            this.Controls.Add(this.txtMeal);
            this.Controls.Add(this.txtDorm);
            this.Controls.Add(this.lblTotalCharges);
            this.Controls.Add(this.lblMealCharges);
            this.Controls.Add(this.lblDormCharges);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ChargesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dormitory Total Charges";
            this.chargesHelpToAbout.ResumeLayout(false);
            this.chargesHelpToAbout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDormCharges;
        private System.Windows.Forms.Label lblMealCharges;
        private System.Windows.Forms.Label lblTotalCharges;
        private System.Windows.Forms.TextBox txtDorm;
        private System.Windows.Forms.TextBox txtMeal;
        private System.Windows.Forms.TextBox txtTotalCharges;
        private System.Windows.Forms.Button btnGoToAbout;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ToolTip dormTotalCharges;
        private System.Windows.Forms.ToolStrip chargesHelpToAbout;
        private System.Windows.Forms.ToolStripDropDownButton chargesHelpToAboutDB;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}