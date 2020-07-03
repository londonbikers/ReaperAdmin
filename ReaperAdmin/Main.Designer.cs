namespace ReaperAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this._categoryTree = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._categoryStatusList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._categoryNameBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._categoryParentList = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this._addCategoryBtn = new System.Windows.Forms.ToolStripButton();
            this._refreshCategoriesBtn = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this._categoriesCountLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this._objectActionResultLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.label4 = new System.Windows.Forms.Label();
            this._categorySynonymsBox = new System.Windows.Forms.TextBox();
            this._categoryTagsBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this._saveCategoryBtn = new System.Windows.Forms.Button();
            this._cancelCategoryBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // _categoryTree
            // 
            this._categoryTree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this._categoryTree.Location = new System.Drawing.Point(0, 28);
            this._categoryTree.Name = "_categoryTree";
            this._categoryTree.Size = new System.Drawing.Size(230, 480);
            this._categoryTree.TabIndex = 1;
            this._categoryTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.CategoryTreeItemClickHandler);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this._categoryStatusList);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this._categoryNameBox);
            this.groupBox1.Location = new System.Drawing.Point(237, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(681, 79);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // _categoryStatusList
            // 
            this._categoryStatusList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._categoryStatusList.FormattingEnabled = true;
            this._categoryStatusList.Location = new System.Drawing.Point(77, 46);
            this._categoryStatusList.Name = "_categoryStatusList";
            this._categoryStatusList.Size = new System.Drawing.Size(134, 21);
            this._categoryStatusList.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // _categoryNameBox
            // 
            this._categoryNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._categoryNameBox.Location = new System.Drawing.Point(77, 19);
            this._categoryNameBox.Name = "_categoryNameBox";
            this._categoryNameBox.Size = new System.Drawing.Size(598, 20);
            this._categoryNameBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this._categoryParentList);
            this.groupBox2.Location = new System.Drawing.Point(237, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(681, 47);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parent Category";
            // 
            // _categoryParentList
            // 
            this._categoryParentList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._categoryParentList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._categoryParentList.FormattingEnabled = true;
            this._categoryParentList.Location = new System.Drawing.Point(77, 19);
            this._categoryParentList.Name = "_categoryParentList";
            this._categoryParentList.Size = new System.Drawing.Size(598, 21);
            this._categoryParentList.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._addCategoryBtn,
            this._refreshCategoriesBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(930, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // _addCategoryBtn
            // 
            this._addCategoryBtn.Image = ((System.Drawing.Image)(resources.GetObject("_addCategoryBtn.Image")));
            this._addCategoryBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._addCategoryBtn.Name = "_addCategoryBtn";
            this._addCategoryBtn.Size = new System.Drawing.Size(100, 22);
            this._addCategoryBtn.Text = "Add Category";
            this._addCategoryBtn.Click += new System.EventHandler(this.NewCategoryHandler);
            // 
            // _refreshCategoriesBtn
            // 
            this._refreshCategoriesBtn.Image = ((System.Drawing.Image)(resources.GetObject("_refreshCategoriesBtn.Image")));
            this._refreshCategoriesBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._refreshCategoriesBtn.Name = "_refreshCategoriesBtn";
            this._refreshCategoriesBtn.Size = new System.Drawing.Size(66, 22);
            this._refreshCategoriesBtn.Text = "Refresh";
            this._refreshCategoriesBtn.Click += new System.EventHandler(this.RefreshCategoriesHandler);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._categoriesCountLabel,
            this._objectActionResultLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 508);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(930, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // _categoriesCountLabel
            // 
            this._categoriesCountLabel.Name = "_categoriesCountLabel";
            this._categoriesCountLabel.Size = new System.Drawing.Size(81, 17);
            this._categoriesCountLabel.Text = "Categories: 12";
            // 
            // _objectActionResultLabel
            // 
            this._objectActionResultLabel.Name = "_objectActionResultLabel";
            this._objectActionResultLabel.Size = new System.Drawing.Size(77, 17);
            this._objectActionResultLabel.Text = "Action Result";
            this._objectActionResultLabel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Synonyms";
            // 
            // _categorySynonymsBox
            // 
            this._categorySynonymsBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._categorySynonymsBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._categorySynonymsBox.Location = new System.Drawing.Point(77, 17);
            this._categorySynonymsBox.Multiline = true;
            this._categorySynonymsBox.Name = "_categorySynonymsBox";
            this._categorySynonymsBox.Size = new System.Drawing.Size(598, 63);
            this._categorySynonymsBox.TabIndex = 1;
            // 
            // _categoryTagsBox
            // 
            this._categoryTagsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._categoryTagsBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._categoryTagsBox.Location = new System.Drawing.Point(77, 86);
            this._categoryTagsBox.Multiline = true;
            this._categoryTagsBox.Name = "_categoryTagsBox";
            this._categoryTagsBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._categoryTagsBox.Size = new System.Drawing.Size(598, 214);
            this._categoryTagsBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tags";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this._categoryTagsBox);
            this.groupBox3.Controls.Add(this._categorySynonymsBox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(237, 166);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(681, 306);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Content";
            // 
            // _saveCategoryBtn
            // 
            this._saveCategoryBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._saveCategoryBtn.Location = new System.Drawing.Point(843, 478);
            this._saveCategoryBtn.Name = "_saveCategoryBtn";
            this._saveCategoryBtn.Size = new System.Drawing.Size(75, 23);
            this._saveCategoryBtn.TabIndex = 6;
            this._saveCategoryBtn.Text = "Save";
            this._saveCategoryBtn.UseVisualStyleBackColor = true;
            this._saveCategoryBtn.Click += new System.EventHandler(this.SaveCategoryHandler);
            // 
            // _cancelCategoryBtn
            // 
            this._cancelCategoryBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._cancelCategoryBtn.Location = new System.Drawing.Point(762, 478);
            this._cancelCategoryBtn.Name = "_cancelCategoryBtn";
            this._cancelCategoryBtn.Size = new System.Drawing.Size(75, 23);
            this._cancelCategoryBtn.TabIndex = 7;
            this._cancelCategoryBtn.Text = "Cancel";
            this._cancelCategoryBtn.UseVisualStyleBackColor = true;
            this._cancelCategoryBtn.Click += new System.EventHandler(this.CancelCategoryChangesHandler);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 530);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this._cancelCategoryBtn);
            this.Controls.Add(this._saveCategoryBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._categoryTree);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "ReaperAdmin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.TreeView _categoryTree;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox _categoryNameBox;
        private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox _categoryParentList;
		private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton _addCategoryBtn;
		private System.Windows.Forms.ComboBox _categoryStatusList;
		private System.Windows.Forms.ToolStripButton _refreshCategoriesBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _categorySynonymsBox;
        private System.Windows.Forms.TextBox _categoryTagsBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button _saveCategoryBtn;
        private System.Windows.Forms.Button _cancelCategoryBtn;
        private System.Windows.Forms.ToolStripStatusLabel _categoriesCountLabel;
        private System.Windows.Forms.ToolStripStatusLabel _objectActionResultLabel;
	}
}

