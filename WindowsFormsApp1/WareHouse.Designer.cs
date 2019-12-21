using WindowsFormsApp1.Services;

namespace WindowsFormsApp1
{
    partial class WareHouse
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Банан");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Апельсин");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Продукты", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Бумага");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Другие товары", new System.Windows.Forms.TreeNode[] {
            treeNode9});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.Info;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeView1.ForeColor = System.Drawing.Color.DimGray;
            this.treeView1.Location = new System.Drawing.Point(-1, 1);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Узел5";
            treeNode1.Text = new GetterGoods().GetStringProduct(ProductType.Apple);
            treeNode2.Name = "Узел6";
            treeNode2.Text = new GetterGoods().GetStringProduct(ProductType.Orange);
            treeNode8.Name = "Продукты";
            treeNode8.Text = "Продукты";
            treeNode9.Name = "Бумага";
            treeNode9.Text = new GetterGoods().GetStringProduct(ProductType.Papper);
            treeNode10.Name = "Другие товары";
            treeNode10.Text = "Другие товары";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode10});
            this.treeView1.Size = new System.Drawing.Size(806, 449);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1_AfterSelect);
            // 
            // WareHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 362);
            this.Controls.Add(this.treeView1);
            this.Name = "WareHouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Склад";
            this.Load += new System.EventHandler(this.WareHouse_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
    }
}