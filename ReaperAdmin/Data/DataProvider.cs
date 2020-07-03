using System;
using System.Data;
using System.Data.SqlClient;
using ReaperAdmin.Objects;
using FrameworkData = MediaPanther.Framework.Data;

namespace ReaperAdmin.Data
{
	/// <summary>
	/// DAL: Handles all data transactions with Reaper.
	/// </summary>
	abstract class DataProvider
	{
		#region constructors
		/// <summary>
		/// Returns a new DataProvider object that domain objects can use to interact with Reaper.
		/// </summary>
		internal DataProvider()
		{
		}
		#endregion

		#region public methods
		#region categories
		/// <summary>
		/// Retrieves a raw list of all the categories within Reaper.
		/// </summary>
		public DataTable GetAllRootCategories()
		{
			SqlConnection connection = this.GetConnection();
			SqlCommand command = connection.CreateCommand();
			command.CommandType = CommandType.StoredProcedure;
			command.CommandText = "AO_GetAllRootCategories";

			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable categoriesTable = new DataTable();
			adapter.Fill(categoriesTable);
			return categoriesTable;
		}

		/// <summary>
		/// Retrieves a raw list of all the categories for that belong to another category.
		/// </summary>
		public DataTable GetCategoriesForParent(int parentID)
		{
			SqlConnection connection = this.GetConnection();
			SqlCommand command = connection.CreateCommand();
			command.CommandType = CommandType.StoredProcedure;
			command.CommandText = "AO_GetAllCategoriesForParent";
			command.Parameters.Add(new SqlParameter("@ParentCategoryID", parentID));

			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable categoriesTable = new DataTable();
			adapter.Fill(categoriesTable);
			return categoriesTable;
		}

		/// <summary>
		/// Constructs and returns a new Category object from a DataRow with all the values in.
		/// </summary>
		public Category InitialiseCategory(DataRow row)
		{
			Category cat = new Category();
			cat = new Category();
			cat.ID = (int)row["ID"];
			cat.Name = row["Name"] as string;
			cat.Status = (CategoryStatus)(byte)row["Status"];

			if (row["Synonyms"] != DBNull.Value)
				cat.Synonyms = Utils.CsvToList(row["Synonyms"] as string);

			if (row["Tags"] != DBNull.Value)
				cat.Tags = Utils.CsvToList(row["Tags"] as string);

			return cat;
		}

        /// <summary>
        /// Persists the category object back to Reaper.
        /// </summary>
        public bool UpdateCategory(Category category)
        {
            SqlConnection connection = this.GetConnection();
            SqlCommand command = connection.CreateCommand();
            
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "AO_UpdateCategory";

            command.Parameters.Add(new SqlParameter("@ID", category.ID));
            command.Parameters.Add(new SqlParameter("@Name", FrameworkData.Data.ToSql(category.Name)));
            command.Parameters.Add(new SqlParameter("@Synonyms", FrameworkData.Data.ToSql(Utils.ListToCsv(category.Synonyms))));
            command.Parameters.Add(new SqlParameter("@Tags", FrameworkData.Data.ToSql(Utils.ListToCsv(category.Tags))));
            command.Parameters.Add(new SqlParameter("@Status", (int)category.Status));

            if (category.ParentCategory == null)
                command.Parameters.Add(new SqlParameter("@ParentCategoryID", int.Parse("0")));
            else
                command.Parameters.Add(new SqlParameter("@ParentCategoryID", category.ParentCategory.ID));

            try
            {
                connection.Open();
                category.ID = int.Parse(command.ExecuteScalar().ToString());
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }
		#endregion

		#region sources
		#endregion
		#endregion

		#region private methods
		/// <summary>
		/// Retrieves a connection to the Reaper database.
		/// </summary>
		/// <returns>An open connection. Must close after use.</returns>
		private SqlConnection GetConnection()
		{
			SqlConnection connection = new SqlConnection(Properties.Settings.Default.ReaperConnectionString);
			return connection;
		}
		#endregion
	}
}