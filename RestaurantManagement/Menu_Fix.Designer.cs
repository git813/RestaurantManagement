namespace TestSQL
{
    partial class Menu_Fix
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bAddFood = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.lbDelete = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 32);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(787, 483);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // bAddFood
            // 
            this.bAddFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bAddFood.Location = new System.Drawing.Point(843, 391);
            this.bAddFood.Name = "bAddFood";
            this.bAddFood.Size = new System.Drawing.Size(151, 55);
            this.bAddFood.TabIndex = 1;
            this.bAddFood.Text = "Thêm món";
            this.bAddFood.UseVisualStyleBackColor = true;
            this.bAddFood.Click += new System.EventHandler(this.bAddFood_Click);
            // 
            // bDelete
            // 
            this.bDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bDelete.Location = new System.Drawing.Point(843, 472);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(151, 53);
            this.bDelete.TabIndex = 2;
            this.bDelete.Text = "Xóa";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // lbDelete
            // 
            this.lbDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDelete.AutoSize = true;
            this.lbDelete.BackColor = System.Drawing.Color.Gold;
            this.lbDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDelete.Location = new System.Drawing.Point(435, -2);
            this.lbDelete.Name = "lbDelete";
            this.lbDelete.Size = new System.Drawing.Size(365, 31);
            this.lbDelete.TabIndex = 3;
            this.lbDelete.Text = "Nhấn đúp vào món ăn để xóa";
            // 
            // Menu_Fix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1006, 537);
            this.Controls.Add(this.lbDelete);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bAddFood);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Menu_Fix";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FixMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button bAddFood;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Label lbDelete;
    }
}