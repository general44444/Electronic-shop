namespace Electronic_shop
{
    partial class Home
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.ManageData = new Guna.UI2.WinForms.Guna2ImageButton();
            this.AddProduct = new Guna.UI2.WinForms.Guna2ImageButton();
            this.WishList = new Guna.UI2.WinForms.Guna2ImageButton();
            this.AllProducts = new System.Windows.Forms.Panel();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "label11111111111";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.guna2ImageButton1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1305, 62);
            this.panel1.TabIndex = 14;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(35, 35);
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Image = global::Electronic_shop.Properties.Resources.remove_button1;
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.Location = new System.Drawing.Point(1257, 0);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageRotate = 20F;
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(46, 43);
            this.guna2ImageButton1.TabIndex = 2;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(605, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Shop111111";
            // 
            // ManageData
            // 
            this.ManageData.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ManageData.CheckedState.Parent = this.ManageData;
            this.ManageData.HoverState.ImageSize = new System.Drawing.Size(42, 42);
            this.ManageData.HoverState.Parent = this.ManageData;
            this.ManageData.Image = global::Electronic_shop.Properties.Resources._3211;
            this.ManageData.ImageRotate = 0F;
            this.ManageData.ImageSize = new System.Drawing.Size(40, 40);
            this.ManageData.Location = new System.Drawing.Point(134, 68);
            this.ManageData.Name = "ManageData";
            this.ManageData.PressedState.ImageSize = new System.Drawing.Size(42, 42);
            this.ManageData.PressedState.Parent = this.ManageData;
            this.ManageData.Size = new System.Drawing.Size(50, 46);
            this.ManageData.TabIndex = 17;
            this.ManageData.Click += new System.EventHandler(this.ManageData_Click);
            // 
            // AddProduct
            // 
            this.AddProduct.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.AddProduct.CheckedState.Parent = this.AddProduct;
            this.AddProduct.HoverState.ImageSize = new System.Drawing.Size(42, 42);
            this.AddProduct.HoverState.Parent = this.AddProduct;
            this.AddProduct.Image = global::Electronic_shop.Properties.Resources._23;
            this.AddProduct.ImageRotate = 0F;
            this.AddProduct.ImageSize = new System.Drawing.Size(40, 40);
            this.AddProduct.Location = new System.Drawing.Point(69, 68);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.PressedState.ImageSize = new System.Drawing.Size(42, 42);
            this.AddProduct.PressedState.Parent = this.AddProduct;
            this.AddProduct.Size = new System.Drawing.Size(50, 46);
            this.AddProduct.TabIndex = 16;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // WishList
            // 
            this.WishList.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.WishList.CheckedState.Parent = this.WishList;
            this.WishList.HoverState.ImageSize = new System.Drawing.Size(42, 42);
            this.WishList.HoverState.Parent = this.WishList;
            this.WishList.Image = global::Electronic_shop.Properties.Resources._123;
            this.WishList.ImageRotate = 0F;
            this.WishList.ImageSize = new System.Drawing.Size(40, 40);
            this.WishList.Location = new System.Drawing.Point(4, 68);
            this.WishList.Name = "WishList";
            this.WishList.PressedState.ImageSize = new System.Drawing.Size(42, 42);
            this.WishList.PressedState.Parent = this.WishList;
            this.WishList.Size = new System.Drawing.Size(50, 46);
            this.WishList.TabIndex = 15;
            this.WishList.Click += new System.EventHandler(this.WishList_Click);
            // 
            // AllProducts
            // 
            this.AllProducts.AutoScroll = true;
            this.AllProducts.AutoScrollMinSize = new System.Drawing.Size(10, 10);
            this.AllProducts.Location = new System.Drawing.Point(197, 68);
            this.AllProducts.Name = "AllProducts";
            this.AllProducts.Size = new System.Drawing.Size(1108, 764);
            this.AllProducts.TabIndex = 18;
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.HoverState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.ItemsAppearance.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Location = new System.Drawing.Point(12, 154);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.ShadowDecoration.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Size = new System.Drawing.Size(172, 36);
            this.guna2ComboBox1.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Categories:";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1305, 832);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.guna2ComboBox1);
            this.Controls.Add(this.WishList);
            this.Controls.Add(this.ManageData);
            this.Controls.Add(this.AllProducts);
            this.Controls.Add(this.AddProduct);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Trader";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private System.Windows.Forms.Label label2;
        public Guna.UI2.WinForms.Guna2ImageButton WishList;
        public Guna.UI2.WinForms.Guna2ImageButton AddProduct;
        public Guna.UI2.WinForms.Guna2ImageButton ManageData;
        public System.Windows.Forms.Panel AllProducts;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private System.Windows.Forms.Label label9;
    }
}