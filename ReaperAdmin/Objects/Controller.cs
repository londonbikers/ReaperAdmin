using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using ReaperAdmin.Data;

namespace ReaperAdmin.Objects
{
	class Controller : DataProvider
	{
		#region constructors
		public Controller()
		{
		}
		#endregion

		#region public methods
		/// <summary>
		/// Returns a real-time collection of all the categories in Reaper.
		/// </summary>
		public new List<Category> GetAllRootCategories()
		{
			List<Category> categories = new List<Category>();
			DataTable table = base.GetAllRootCategories();

			foreach (DataRow row in table.Rows)
				categories.Add(base.InitialiseCategory(row));

			return categories;
		}

        /// <summary>
        /// Persists any changes to a category object back to Reaper.
        /// </summary>
        public new bool UpdateCategory(Category category)
        {
            return base.UpdateCategory(category);
        }
		#endregion
	}
}