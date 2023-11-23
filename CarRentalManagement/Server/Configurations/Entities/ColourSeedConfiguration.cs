using CarRentalManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Drawing;

namespace CarRentalManagement.Server.Configurations.Entities
{
	public class ColourSeedConfiguration : IEntityTypeConfiguration<colour>
	{
		public void Configure(EntityTypeBuilder<colour> builder)
		{
			builder.HasData(
				new colour
				{
					Id = 1,
					Name = "Black",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				},
				new colour
				{
					Id = 2,
					Name = "Blue",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				}
				);
		}
	}
}
