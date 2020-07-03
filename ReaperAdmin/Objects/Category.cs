using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using ReaperAdmin.Data;

namespace ReaperAdmin.Objects
{
	class Category : DataProvider
	{
		#region members
		private int _id;
		private string _name;
		private List<string> _synonyms;
		private List<string> _tags;
		private List<Category> _childCategories;
		private Category _parentCategory;
		private CategoryStatus _status;
		#endregion

		#region accessors
		public int ID { get { return this._id; } set { this._id = value; } }
		public string Name { get { return this._name; } set { this._name = value; } }
		public List<string> Synonyms { get { return this._synonyms; } set { this._synonyms = value; } }
		public List<string> Tags { get { return this._tags; } set { this._tags = value; } }
		public Category ParentCategory { get { return this._parentCategory; } set { this._parentCategory = value; } }
		public CategoryStatus Status { get { return this._status; } set { this._status = value; } }
		public List<Category> ChildCategories
		{
			get
			{
				if (this._childCategories == null)
					this.GetChildrenCategories();

				return this._childCategories;
			}
		}
		#endregion

		#region constructors
		public Category()
		{
			this._synonyms = new List<string>();
			this._tags = new List<string>();
			this._status = CategoryStatus.Inactive;
		}
		#endregion

        #region private methods
        /// <summary>
		/// Retrieves all child categories for this one and populates the property member.
		/// </summary>
		private void GetChildrenCategories()
		{
			this._childCategories = new List<Category>();
			DataTable table = base.GetCategoriesForParent(this.ID);
			foreach (DataRow row in table.Rows)
			{
				Category child = base.InitialiseCategory(row);
				child.ParentCategory = this;
				this._childCategories.Add(child);
			}
		}
		#endregion
	}

	public enum CategoryStatus
	{
		Inactive = 0,
		Active = 1
	}
}