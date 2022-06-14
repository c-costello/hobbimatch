using System;
namespace hobbimatchapi.Models
{
	public class InvitationRequest
	{
		public InvitationRequest()
		{
		}

		public string GroupOwnerId { get; set; }
		public string GroupId { get; set; }
		public string InviteeId { get; set; }
		public DateTime InvitedOn { get; set; }
		public string Message { get; set; }
	}
}

