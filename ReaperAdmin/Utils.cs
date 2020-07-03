using System;
using System.Collections.Generic;
using System.Text;

namespace ReaperAdmin
{
	/// <summary>
	/// Temporary class until the MP Framework is plummed in.
	/// </summary>
	class Utils
	{
		public static List<string> CsvToList(string csv)
		{
			List<string> list = new List<string>();
			string[] parts = csv.Split(char.Parse(","));
            string finalPart;

            foreach (string part in parts)
            {
                finalPart = part.Trim().ToLower();
                if (!list.Contains(finalPart))
                    list.Add(finalPart);
            }

			return list;
		}

		public static string ListToCsv(List<string> list)
		{
			StringBuilder builder = new StringBuilder();
			for (int i = 0; i < list.Count; i++)
			{
				builder.Append(list[i]);
				if (i < list.Count - 1)
					builder.Append(", ");
			}

			return builder.ToString();
		}
	}
}