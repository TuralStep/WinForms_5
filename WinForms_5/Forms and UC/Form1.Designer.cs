namespace WinForms_5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel_products = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_cost = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.lbl_qaliq = new System.Windows.Forms.Label();
            this.lbl_daxil = new System.Windows.Forms.Label();
            this.btn_10azn = new System.Windows.Forms.Button();
            this.btn_5azn = new System.Windows.Forms.Button();
            this.btn_1azn = new System.Windows.Forms.Button();
            this.btn_50qep = new System.Windows.Forms.Button();
            this.btn_20qep = new System.Windows.Forms.Button();
            this.btn_10qep = new System.Windows.Forms.Button();
            this.txt_pul = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_products
            // 
            this.panel_products.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_products.Location = new System.Drawing.Point(0, 0);
            this.panel_products.Name = "panel_products";
            this.panel_products.Size = new System.Drawing.Size(531, 356);
            this.panel_products.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(135, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pulu daxil edin";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_cost);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.lbl_qaliq);
            this.panel1.Controls.Add(this.lbl_daxil);
            this.panel1.Controls.Add(this.btn_10azn);
            this.panel1.Controls.Add(this.btn_5azn);
            this.panel1.Controls.Add(this.btn_1azn);
            this.panel1.Controls.Add(this.btn_50qep);
            this.panel1.Controls.Add(this.btn_20qep);
            this.panel1.Controls.Add(this.btn_10qep);
            this.panel1.Controls.Add(this.txt_pul);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(533, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 356);
            this.panel1.TabIndex = 2;
            // 
            // lbl_cost
            // 
            this.lbl_cost.AutoSize = true;
            this.lbl_cost.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_cost.Location = new System.Drawing.Point(21, 148);
            this.lbl_cost.Name = "lbl_cost";
            this.lbl_cost.Size = new System.Drawing.Size(100, 17);
            this.lbl_cost.TabIndex = 12;
            this.lbl_cost.Text = "Mebleg : 0 AZN";
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::WinForms_5.Properties.Resources.pngtree_vector_receipt_icon_png_image_1577284;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.Location = new System.Drawing.Point(21, 247);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(86, 81);
            this.button6.TabIndex = 11;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.getReceipt_Click);
            // 
            // lbl_qaliq
            // 
            this.lbl_qaliq.AutoSize = true;
            this.lbl_qaliq.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_qaliq.Location = new System.Drawing.Point(21, 204);
            this.lbl_qaliq.Name = "lbl_qaliq";
            this.lbl_qaliq.Size = new System.Drawing.Size(86, 17);
            this.lbl_qaliq.TabIndex = 10;
            this.lbl_qaliq.Text = "Qaliq : 0 AZN";
            // 
            // lbl_daxil
            // 
            this.lbl_daxil.AutoSize = true;
            this.lbl_daxil.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_daxil.Location = new System.Drawing.Point(21, 176);
            this.lbl_daxil.Name = "lbl_daxil";
            this.lbl_daxil.Size = new System.Drawing.Size(176, 17);
            this.lbl_daxil.TabIndex = 9;
            this.lbl_daxil.Text = "Daxil edilmis mebleg : 0 AZN";
            // 
            // btn_10azn
            // 
            this.btn_10azn.BackgroundImage = global::WinForms_5.Properties.Resources._10manat;
            this.btn_10azn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_10azn.Location = new System.Drawing.Point(238, 247);
            this.btn_10azn.Name = "btn_10azn";
            this.btn_10azn.Size = new System.Drawing.Size(128, 81);
            this.btn_10azn.TabIndex = 8;
            this.btn_10azn.Tag = "manat10";
            this.btn_10azn.UseVisualStyleBackColor = true;
            this.btn_10azn.Click += new System.EventHandler(this.DefaultQiymetClick);
            // 
            // btn_5azn
            // 
            this.btn_5azn.BackgroundImage = global::WinForms_5.Properties.Resources._5manat;
            this.btn_5azn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_5azn.Location = new System.Drawing.Point(238, 160);
            this.btn_5azn.Name = "btn_5azn";
            this.btn_5azn.Size = new System.Drawing.Size(128, 81);
            this.btn_5azn.TabIndex = 7;
            this.btn_5azn.Tag = "manat5";
            this.btn_5azn.UseVisualStyleBackColor = true;
            this.btn_5azn.Click += new System.EventHandler(this.DefaultQiymetClick);
            // 
            // btn_1azn
            // 
            this.btn_1azn.BackgroundImage = global::WinForms_5.Properties.Resources._1manat;
            this.btn_1azn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_1azn.Location = new System.Drawing.Point(238, 73);
            this.btn_1azn.Name = "btn_1azn";
            this.btn_1azn.Size = new System.Drawing.Size(128, 81);
            this.btn_1azn.TabIndex = 6;
            this.btn_1azn.Tag = "manat1";
            this.btn_1azn.UseVisualStyleBackColor = true;
            this.btn_1azn.Click += new System.EventHandler(this.DefaultQiymetClick);
            // 
            // btn_50qep
            // 
            this.btn_50qep.BackgroundImage = global::WinForms_5.Properties.Resources._50qepik;
            this.btn_50qep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_50qep.Location = new System.Drawing.Point(171, 73);
            this.btn_50qep.Name = "btn_50qep";
            this.btn_50qep.Size = new System.Drawing.Size(50, 50);
            this.btn_50qep.TabIndex = 5;
            this.btn_50qep.Tag = "qepik50";
            this.btn_50qep.UseVisualStyleBackColor = true;
            this.btn_50qep.Click += new System.EventHandler(this.DefaultQiymetClick);
            // 
            // btn_20qep
            // 
            this.btn_20qep.BackgroundImage = global::WinForms_5.Properties.Resources._20qepik;
            this.btn_20qep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_20qep.Location = new System.Drawing.Point(96, 73);
            this.btn_20qep.Name = "btn_20qep";
            this.btn_20qep.Size = new System.Drawing.Size(50, 50);
            this.btn_20qep.TabIndex = 4;
            this.btn_20qep.Tag = "qepik20";
            this.btn_20qep.UseVisualStyleBackColor = true;
            this.btn_20qep.Click += new System.EventHandler(this.DefaultQiymetClick);
            // 
            // btn_10qep
            // 
            this.btn_10qep.BackgroundImage = global::WinForms_5.Properties.Resources._10qepik;
            this.btn_10qep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_10qep.Location = new System.Drawing.Point(21, 73);
            this.btn_10qep.Name = "btn_10qep";
            this.btn_10qep.Size = new System.Drawing.Size(50, 50);
            this.btn_10qep.TabIndex = 3;
            this.btn_10qep.Tag = "qepik10";
            this.btn_10qep.UseVisualStyleBackColor = true;
            this.btn_10qep.Click += new System.EventHandler(this.DefaultQiymetClick);
            // 
            // txt_pul
            // 
            this.txt_pul.Location = new System.Drawing.Point(3, 27);
            this.txt_pul.Name = "txt_pul";
            this.txt_pul.Size = new System.Drawing.Size(370, 23);
            this.txt_pul.TabIndex = 2;
            this.txt_pul.TextChanged += new System.EventHandler(this.txt_pul_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 356);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_products);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(925, 395);
            this.MinimumSize = new System.Drawing.Size(925, 395);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aparat";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel panel_products;
        private Label label1;
        private Panel panel1;
        private Button btn_50qep;
        private Button btn_20qep;
        private Button btn_10qep;
        private TextBox txt_pul;
        private Button btn_1azn;
        private Button btn_10azn;
        private Button btn_5azn;
        private Button button6;
        private Label lbl_qaliq;
        private Label lbl_daxil;
        private Label lbl_cost;
    }
}