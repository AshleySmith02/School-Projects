namespace Ashley_Smith_CPT_185_A01H_Lab_9
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.btnExit = new System.Windows.Forms.Button();
            this.aboutTip = new System.Windows.Forms.ToolTip(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDorms = new System.Windows.Forms.Label();
            this.lblMealPlans = new System.Windows.Forms.Label();
            this.mealsPictureBox = new System.Windows.Forms.PictureBox();
            this.dormPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mealsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dormPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(363, 632);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(168, 104);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "&Exit";
            this.aboutTip.SetToolTip(this.btnExit, "Exit Form button");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(84, 28);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(774, 111);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = resources.GetString("lblTitle.Text");
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDorms
            // 
            this.lblDorms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDorms.Location = new System.Drawing.Point(32, 454);
            this.lblDorms.Name = "lblDorms";
            this.lblDorms.Size = new System.Drawing.Size(321, 168);
            this.lblDorms.TabIndex = 2;
            this.lblDorms.Text = "Cost of Dormitories:\r\n\r\nAllen Hall = $1,500 per semester\r\n\r\nPike Hall = $1,600 pe" +
    "r semester\r\n\r\nFarthering Hall = $1,800 per semester\r\n\r\nUniversity Hall = $2,500 " +
    "per semester";
            this.lblDorms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMealPlans
            // 
            this.lblMealPlans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMealPlans.Location = new System.Drawing.Point(534, 454);
            this.lblMealPlans.Name = "lblMealPlans";
            this.lblMealPlans.Size = new System.Drawing.Size(298, 168);
            this.lblMealPlans.TabIndex = 3;
            this.lblMealPlans.Text = "Cost of Meal Plans:\r\n\r\n7 meals per week = $600 per semester\r\n\r\n14 meals per week " +
    "= $1,200 per semester\r\n\r\nUnlimited meals = $1,700 per semester";
            this.lblMealPlans.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mealsPictureBox
            // 
            this.mealsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("mealsPictureBox.Image")));
            this.mealsPictureBox.Location = new System.Drawing.Point(594, 127);
            this.mealsPictureBox.Name = "mealsPictureBox";
            this.mealsPictureBox.Size = new System.Drawing.Size(200, 300);
            this.mealsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mealsPictureBox.TabIndex = 4;
            this.mealsPictureBox.TabStop = false;
            this.aboutTip.SetToolTip(this.mealsPictureBox, "Meals Image");
            // 
            // dormPictureBox
            // 
            this.dormPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("dormPictureBox.Image")));
            this.dormPictureBox.Location = new System.Drawing.Point(71, 142);
            this.dormPictureBox.Name = "dormPictureBox";
            this.dormPictureBox.Size = new System.Drawing.Size(367, 268);
            this.dormPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dormPictureBox.TabIndex = 5;
            this.dormPictureBox.TabStop = false;
            this.aboutTip.SetToolTip(this.dormPictureBox, "Dorm Image");
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(862, 742);
            this.Controls.Add(this.dormPictureBox);
            this.Controls.Add(this.mealsPictureBox);
            this.Controls.Add(this.lblMealPlans);
            this.Controls.Add(this.lblDorms);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnExit);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.mealsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dormPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolTip aboutTip;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDorms;
        private System.Windows.Forms.Label lblMealPlans;
        private System.Windows.Forms.PictureBox mealsPictureBox;
        private System.Windows.Forms.PictureBox dormPictureBox;
    }
}