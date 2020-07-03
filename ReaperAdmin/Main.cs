using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ReaperAdmin.Objects;

namespace ReaperAdmin
{
	public partial class MainForm : Form
    {
        #region constructors
        public MainForm()
		{
			InitializeComponent();
			this.InitialiseCategoryAdmin();
		}
		#endregion

		#region event handlers
		/// <summary>
		/// Handles the closing of the application.
		/// </summary>
		private void CloseProgramHandler(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion

        #region categories

        #region members
        private List<Category> _allCategories;
        private Category _selectedCategory;
        private bool _categoryListRefreshRequired;
        #endregion

        #region event handlers
        /// <summary>
        /// Handles the click action of an item in the category treeview.
        /// </summary>
        private void CategoryTreeItemClickHandler(object sender, EventArgs ea)
        {
            TreeView tree = sender as TreeView;
            Category category = tree.SelectedNode.Tag as Category;
            this._selectedCategory = category;
            this.PopulateCategoryForm(category);
        }

        /// <summary>
        /// Handles refreshing the category treeview.
        /// </summary>
        private void RefreshCategoriesHandler(object sender, EventArgs e)
        {
            this.ClearCategoryForm();
            this.InitialiseCategoryAdmin();
        }

        /// <summary>
        /// Handles the save category button click event.
        /// </summary>
        private void SaveCategoryHandler(object sender, EventArgs e)
        {
            Color labelColour;
            this._objectActionResultLabel.Visible = true;

            if (this.UpdateCategory())
            {
                // update successful.
                labelColour = Color.FromName("Black");
                this._objectActionResultLabel.Text = "Category Updated!";
                this._objectActionResultLabel.ForeColor = labelColour;
                this._cancelCategoryBtn.Enabled = false;

                if (this._categoryListRefreshRequired)
                {
                    this.InitialiseCategoryAdmin();
                    this._categoryListRefreshRequired = false;
                }
            }
            else
            {
                // unsucessfull.
                labelColour = Color.FromName("Maroon");
                this._objectActionResultLabel.Text = "Updated Failed!";
                this._objectActionResultLabel.ForeColor = labelColour;
            }
        }

        /// <summary>
        /// Reverts any changes made to the selected category.
        /// </summary>
        private void CancelCategoryChangesHandler(object sender, EventArgs e)
        {
            this.PopulateCategoryForm(this._selectedCategory);
        }

        /// <summary>
        /// Handles the new-category button click event.
        /// </summary>
        private void NewCategoryHandler(object sender, EventArgs e)
        {
            this._selectedCategory = new Category();
            this._categoryTree.SelectedNode = null;
            this.PopulateCategoryForm(this._selectedCategory);
        }
        #endregion

        #region private methods
        private void InitialiseCategoryAdmin()
        {
            this._allCategories = new List<Category>();
            Controller controller = new Controller();

            // build the categories tree-view.
            this._categoryTree.Nodes.Clear();
            this._categoryParentList.Items.Clear();
            List<Category> rootCats = controller.GetAllRootCategories();

            foreach (Category cat in rootCats)
            {
                TreeNode node = new TreeNode(cat.Name);
                node.Tag = cat;
                this._categoryTree.Nodes.Add(node);
                this._allCategories.Add(cat);

                if (cat.ChildCategories.Count > 0)
                    this.RecurseCategoryTree(node, cat);
            }

            // status bar info.
            this._categoriesCountLabel.Text = string.Format("Categories: {0}", this._allCategories.Count);

            // edit form.
            this._categoryStatusList.DataSource = Enum.GetValues(typeof(CategoryStatus));
            foreach (Category category in this._allCategories)
                this._categoryParentList.Items.Add(string.Format("{0}: {1}", category.ID, category.Name));
        }

        /// <summary>
        /// Builds a branch of the Category treeview and then kicks off any child categories.
        /// </summary>
        private void RecurseCategoryTree(TreeNode node, Category category)
        {
            foreach (Category child in category.ChildCategories)
            {
                TreeNode childNode = new TreeNode(child.Name);
                childNode.Tag = child;
                node.Nodes.Add(childNode);
                this._allCategories.Add(child);

                if (child.ChildCategories.Count > 0)
                    this.RecurseCategoryTree(childNode, child);
            }
        }

        /// <summary>
        /// Fills out the category-edit form controls for a specific category.
        /// </summary>
        private void PopulateCategoryForm(Category category)
        {
            this._cancelCategoryBtn.Enabled = true;
            this._objectActionResultLabel.Visible = false;
            this._categoryNameBox.Text = category.Name;
            this._categorySynonymsBox.Text = Utils.ListToCsv(category.Synonyms);
            this._categoryTagsBox.Text = Utils.ListToCsv(category.Tags);
            this._categoryStatusList.SelectedIndex = this._categoryStatusList.FindStringExact(category.Status.ToString());

            if (category.ParentCategory != null)
                this._categoryParentList.SelectedIndex = this._categoryParentList.FindStringExact(string.Format("{0}: {1}", category.ParentCategory.ID, category.ParentCategory.Name));
            else
                this._categoryParentList.SelectedIndex = -1;
        }

        /// <summary>
        /// Removes any details from the category editor form.
        /// </summary>
        private void ClearCategoryForm()
        {
            this._cancelCategoryBtn.Enabled = true;
            this._objectActionResultLabel.Visible = false;
            this._categoryNameBox.Text = String.Empty;
            this._categorySynonymsBox.Text = String.Empty;
            this._categoryTagsBox.Text = String.Empty;
            this._categoryParentList.SelectedIndex = -1;
        }

        /// <summary>
        /// Persists any changes to the selected category to Reaper.
        /// </summary>
        /// <returns>A bool to show if the updated was successful or not.</returns>
        private bool UpdateCategory()
        {
            // validate input.
            if (this._categoryNameBox.Text.Trim() == String.Empty ||
                this._categoryTagsBox.Text.Trim() == String.Empty)
                return false;

            this._selectedCategory.Name = this._categoryNameBox.Text.Trim();
            this._selectedCategory.Status = (CategoryStatus)Enum.Parse(typeof(CategoryStatus), this._categoryStatusList.SelectedValue.ToString());
            this._selectedCategory.Synonyms = Utils.CsvToList(this._categorySynonymsBox.Text.Trim());
            this._selectedCategory.Tags = Utils.CsvToList(this._categoryTagsBox.Text.Trim());
                        
            if (this._selectedCategory.ParentCategory == null && this._categoryParentList.SelectedItem != null)
            {
                // parent change from root.
                this._categoryListRefreshRequired = true;
                this._selectedCategory.ParentCategory = this._allCategories[this._categoryParentList.SelectedIndex];
            }
            else if (this._selectedCategory.ParentCategory != null && this._categoryParentList.SelectedItem != null && 
                int.Parse(this._categoryParentList.SelectedItem.ToString().Split(char.Parse(":"))[0]) != this._selectedCategory.ParentCategory.ID)
            {
                // parent change -- could merge into above case, but this is a bit easier to understand.
                this._categoryListRefreshRequired = true;
                this._selectedCategory.ParentCategory = this._allCategories[this._categoryParentList.SelectedIndex];
            }
            else if (this._selectedCategory.ParentCategory != null && this._categoryParentList.SelectedItem == null)
            {
                // parent change to root
                this._selectedCategory.ParentCategory = null;
                this._categoryListRefreshRequired = true;
            }

            // new cats need a list refresh.
            if (this._selectedCategory.ID < 1)
                this._categoryListRefreshRequired = true;

            Controller controller = new Controller();
            bool result = controller.UpdateCategory(this._selectedCategory);

            if (result)
            {
                // reformat the tag boxes to make it neat.
                this._categorySynonymsBox.Text = Utils.ListToCsv(this._selectedCategory.Synonyms);
                this._categoryTagsBox.Text = Utils.ListToCsv(this._selectedCategory.Tags);
            }

            return result;
        }
        #endregion
              
        #endregion
	}
}