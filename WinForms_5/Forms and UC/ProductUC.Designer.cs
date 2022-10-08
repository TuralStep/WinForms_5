namespace WinForms_5
{
    partial class ProductUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pBox_image = new System.Windows.Forms.PictureBox();
            this.lbl_productCost = new System.Windows.Forms.Label();
            this.cBox_productSay = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_image)).BeginInit();
            this.SuspendLayout();
            // 
            // pBox_image
            // 
            this.pBox_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBox_image.Location = new System.Drawing.Point(3, 3);
            this.pBox_image.Name = "pBox_image";
            this.pBox_image.Size = new System.Drawing.Size(90, 90);
            this.pBox_image.TabIndex = 0;
            this.pBox_image.TabStop = false;
            // 
            // lbl_productCost
            // 
            this.lbl_productCost.AutoSize = true;
            this.lbl_productCost.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_productCost.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_productCost.Location = new System.Drawing.Point(18, 68);
            this.lbl_productCost.Name = "lbl_productCost";
            this.lbl_productCost.Size = new System.Drawing.Size(51, 20);
            this.lbl_productCost.TabIndex = 1;
            this.lbl_productCost.Text = "0 AZN";
            // 
            // cBox_productSay
            // 
            this.cBox_productSay.AutoSize = true;
            this.cBox_productSay.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cBox_productSay.Location = new System.Drawing.Point(14, 99);
            this.cBox_productSay.Name = "cBox_productSay";
            this.cBox_productSay.Size = new System.Drawing.Size(68, 21);
            this.cBox_productSay.TabIndex = 2;
            this.cBox_productSay.Text = "0 eded";
            this.cBox_productSay.UseVisualStyleBackColor = true;
            // 
            // ProductUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cBox_productSay);
            this.Controls.Add(this.lbl_productCost);
            this.Controls.Add(this.pBox_image);
            this.Name = "ProductUC";
            this.Size = new System.Drawing.Size(96, 124);
            ((System.ComponentModel.ISupportInitialize)(this.pBox_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pBox_image;
        public CheckBox cBox_productSay;
        public Label lbl_productCost;
    }
}
