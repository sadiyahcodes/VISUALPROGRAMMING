﻿namespace WinFormsApp2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Dispose method to clean up the components
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Initialize components and set up the form controls
        private void InitializeComponent()
        {
            this.lbl_size = new System.Windows.Forms.Label();
            this.cmb_size = new System.Windows.Forms.ComboBox();
            this.chk_cheese = new System.Windows.Forms.CheckBox();
            this.chk_pepperoni = new System.Windows.Forms.CheckBox();
            this.chk_mushrooms = new System.Windows.Forms.CheckBox();
            this.grp_crust = new System.Windows.Forms.GroupBox();
            this.rdb_thin = new System.Windows.Forms.RadioButton();
            this.rdb_thick = new System.Windows.Forms.RadioButton();
            this.btn_order = new System.Windows.Forms.Button();
            this.lbl_summary = new System.Windows.Forms.Label();
            this.grp_crust.SuspendLayout();
            this.SuspendLayout();

            // lbl_size
            this.lbl_size.AutoSize = true;
            this.lbl_size.Location = new System.Drawing.Point(20, 20);
            this.lbl_size.Name = "lbl_size";
            this.lbl_size.Size = new System.Drawing.Size(62, 15);
            this.lbl_size.TabIndex = 0;
            this.lbl_size.Text = "Pizza Size:";

            // cmb_size
            this.cmb_size.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_size.FormattingEnabled = true;
            this.cmb_size.Items.AddRange(new object[] { "Small", "Medium", "Large" });
            this.cmb_size.Location = new System.Drawing.Point(20, 50);
            this.cmb_size.Name = "cmb_size";
            this.cmb_size.Size = new System.Drawing.Size(200, 23);
            this.cmb_size.TabIndex = 1;

            // chk_cheese
            this.chk_cheese.AutoSize = true;
            this.chk_cheese.Location = new System.Drawing.Point(20, 90);
            this.chk_cheese.Name = "chk_cheese";
            this.chk_cheese.Size = new System.Drawing.Size(64, 19);
            this.chk_cheese.TabIndex = 2;
            this.chk_cheese.Text = "Cheese";
            this.chk_cheese.UseVisualStyleBackColor = true;

            // chk_pepperoni
            this.chk_pepperoni.AutoSize = true;
            this.chk_pepperoni.Location = new System.Drawing.Point(20, 120);
            this.chk_pepperoni.Name = "chk_pepperoni";
            this.chk_pepperoni.Size = new System.Drawing.Size(77, 19);
            this.chk_pepperoni.TabIndex = 3;
            this.chk_pepperoni.Text = "Pepperoni";
            this.chk_pepperoni.UseVisualStyleBackColor = true;

            // chk_mushrooms
            this.chk_mushrooms.AutoSize = true;
            this.chk_mushrooms.Location = new System.Drawing.Point(20, 150);
            this.chk_mushrooms.Name = "chk_mushrooms";
            this.chk_mushrooms.Size = new System.Drawing.Size(87, 19);
            this.chk_mushrooms.TabIndex = 4;
            this.chk_mushrooms.Text = "Mushrooms";
            this.chk_mushrooms.UseVisualStyleBackColor = true;

            // grp_crust
            this.grp_crust.Controls.Add(this.rdb_thin);
            this.grp_crust.Controls.Add(this.rdb_thick);
            this.grp_crust.Location = new System.Drawing.Point(20, 180);
            this.grp_crust.Name = "grp_crust";
            this.grp_crust.Size = new System.Drawing.Size(200, 70);
            this.grp_crust.TabIndex = 5;
            this.grp_crust.TabStop = false;
            this.grp_crust.Text = "Crust Type";

            // rdb_thin
            this.rdb_thin.AutoSize = true;
            this.rdb_thin.Location = new System.Drawing.Point(10, 20);
            this.rdb_thin.Name = "rdb_thin";
            this.rdb_thin.Size = new System.Drawing.Size(45, 19);
            this.rdb_thin.TabIndex = 0;
            this.rdb_thin.TabStop = true;
            this.rdb_thin.Text = "Thin";
            this.rdb_thin.UseVisualStyleBackColor = true;

            // rdb_thick
            this.rdb_thick.AutoSize = true;
            this.rdb_thick.Location = new System.Drawing.Point(10, 40);
            this.rdb_thick.Name = "rdb_thick";
            this.rdb_thick.Size = new System.Drawing.Size(51, 19);
            this.rdb_thick.TabIndex = 1;
            this.rdb_thick.TabStop = true;
            this.rdb_thick.Text = "Thick";
            this.rdb_thick.UseVisualStyleBackColor = true;

            // btn_order
            this.btn_order.Location = new System.Drawing.Point(20, 270);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(75, 25);
            this.btn_order.TabIndex = 6;
            this.btn_order.Text = "Place Order";
            this.btn_order.UseVisualStyleBackColor = true;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);

            // lbl_summary
            this.lbl_summary.AutoSize = true;
            this.lbl_summary.Location = new System.Drawing.Point(20, 310);
            this.lbl_summary.Name = "lbl_summary";
            this.lbl_summary.Size = new System.Drawing.Size(0, 15);
            this.lbl_summary.TabIndex = 7;

            // Form1
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.lbl_summary);
            this.Controls.Add(this.btn_order);
            this.Controls.Add(this.grp_crust);
            this.Controls.Add(this.chk_mushrooms);
            this.Controls.Add(this.chk_pepperoni);
            this.Controls.Add(this.chk_cheese);
            this.Controls.Add(this.cmb_size);
            this.Controls.Add(this.lbl_size);
            this.Name = "Form1";
            this.Text = "Pizza Order Form";
            this.grp_crust.ResumeLayout(false);
            this.grp_crust.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lbl_size;
        private System.Windows.Forms.ComboBox cmb_size;
        private System.Windows.Forms.CheckBox chk_cheese;
        private System.Windows.Forms.CheckBox chk_pepperoni;
        private System.Windows.Forms.CheckBox chk_mushrooms;
        private System.Windows.Forms.GroupBox grp_crust;
        private System.Windows.Forms.RadioButton rdb_thin;
        private System.Windows.Forms.RadioButton rdb_thick;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.Label lbl_summary;
    }
}
