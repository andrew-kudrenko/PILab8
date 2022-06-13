namespace PILab8
{
    partial class CarsForm
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
            this.HierarchyTree = new System.Windows.Forms.TreeView();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.BrandTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DriveComboBox = new System.Windows.Forms.ComboBox();
            this.GearBoxComboBox = new System.Windows.Forms.ComboBox();
            this.GearBoxLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HierarchyTree
            // 
            this.HierarchyTree.Location = new System.Drawing.Point(12, 12);
            this.HierarchyTree.Name = "HierarchyTree";
            this.HierarchyTree.Size = new System.Drawing.Size(338, 299);
            this.HierarchyTree.TabIndex = 0;
            this.HierarchyTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.OnNodeClick);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(360, 288);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(110, 23);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.OnAdd);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(475, 288);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(98, 23);
            this.RemoveButton.TabIndex = 6;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.OnRemove);
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Location = new System.Drawing.Point(360, 66);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(213, 20);
            this.ModelTextBox.TabIndex = 2;
            // 
            // BrandTextBox
            // 
            this.BrandTextBox.Location = new System.Drawing.Point(360, 27);
            this.BrandTextBox.Name = "BrandTextBox";
            this.BrandTextBox.Size = new System.Drawing.Size(213, 20);
            this.BrandTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Brand";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "GearBox";
            // 
            // DriveComboBox
            // 
            this.DriveComboBox.FormattingEnabled = true;
            this.DriveComboBox.ItemHeight = 13;
            this.DriveComboBox.Items.AddRange(new object[] {
            "Manual 5",
            "Manual 6",
            "Automatic 6"});
            this.DriveComboBox.Location = new System.Drawing.Point(360, 106);
            this.DriveComboBox.Name = "DriveComboBox";
            this.DriveComboBox.Size = new System.Drawing.Size(213, 21);
            this.DriveComboBox.TabIndex = 3;
            // 
            // GearBoxComboBox
            // 
            this.GearBoxComboBox.FormattingEnabled = true;
            this.GearBoxComboBox.ItemHeight = 13;
            this.GearBoxComboBox.Items.AddRange(new object[] {
            "Manual 5",
            "Manual 6",
            "Automatic 6"});
            this.GearBoxComboBox.Location = new System.Drawing.Point(360, 147);
            this.GearBoxComboBox.Name = "GearBoxComboBox";
            this.GearBoxComboBox.Size = new System.Drawing.Size(213, 21);
            this.GearBoxComboBox.TabIndex = 4;
            // 
            // GearBoxLabel
            // 
            this.GearBoxLabel.AutoSize = true;
            this.GearBoxLabel.Location = new System.Drawing.Point(356, 90);
            this.GearBoxLabel.Name = "GearBoxLabel";
            this.GearBoxLabel.Size = new System.Drawing.Size(32, 13);
            this.GearBoxLabel.TabIndex = 10;
            this.GearBoxLabel.Text = "Drive";
            // 
            // CarsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 323);
            this.Controls.Add(this.GearBoxComboBox);
            this.Controls.Add(this.GearBoxLabel);
            this.Controls.Add(this.DriveComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BrandTextBox);
            this.Controls.Add(this.ModelTextBox);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.HierarchyTree);
            this.Name = "CarsForm";
            this.Text = "CarsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView HierarchyTree;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.TextBox BrandTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox DriveComboBox;
        private System.Windows.Forms.ComboBox GearBoxComboBox;
        private System.Windows.Forms.Label GearBoxLabel;
    }
}