using System;
using hobbimatchapi.Models;
using Microsoft.EntityFrameworkCore;

namespace hobbimatchapi.Data
{
	public class GroupDbContext : DbContext
	{
		public GroupDbContext(DbContextOptions<GroupDbContext> options) : base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<GroupMember>().HasKey(ce => new { ce.GroupId, ce.UserId });

		}

		public DbSet<Group> Groups { get; set; }
		public DbSet<GroupMember> GroupMembers { get; set; }
		public DbSet<GroupOwner> GroupOwners { get; set; }
		public DbSet<InvitationRequest> InvitationRequests { get; set; }
		public DbSet<JoinRequest> JoinRequests { get; set; }

	}
}