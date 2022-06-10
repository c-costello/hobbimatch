using System;
namespace hobbimatchapi.Models
{
	public class JoinRequest
	{
		public JoinRequest()
		{
		}

		public string GroupOwnerId { get; set; }
		public string GroupId { get; set; }
		public string RequesterId { get; set; }
		public DateTime RequestedOn { get; set; }
		public string Message { get; set; }
	}
}

