using System;
namespace hobbimatchapi.Models
{
	public class Group
	{

		public string Name { get; set; }
		public string Description { get; set; }
		public string HeaderImageUrl { get; set; }
		public GroupType groupType { get; set; }
		public string OwnerId { get; set; }
		public string Id { get; set; }

		public enum GroupType { Public, Private };

	}
}

