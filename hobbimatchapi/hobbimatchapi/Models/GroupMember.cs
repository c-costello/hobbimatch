using System;
namespace hobbimatchapi.Models
{
	public class GroupMember
	{
		public GroupMember()
		{
		}

		public GroupMember(string userId, string groupId)
        {
			UserId = userId;
			GroupId = groupId;
        }

		public string UserId { get; set; }
		public string GroupId { get; set; }
		public DateTime MemberSince { get; set; }

	}
}

