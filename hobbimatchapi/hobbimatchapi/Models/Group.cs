using System;
namespace hobbimatchapi.Models
{
	public class Group
	{
		public Group(string name, string description, string headerImageUrl)
		{
			Name = name;
			Description = description;
			HeaderImageUrl = headerImageUrl;
		}

		public string Name { get; set; }
		public string Description { get; set; }
		public string HeaderImageUrl { get; set; }

	}
}

