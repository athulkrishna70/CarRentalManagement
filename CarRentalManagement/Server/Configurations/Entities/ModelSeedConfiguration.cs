using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Server.Configurations.Entities
{
	public class ModelSeedConfiguration : IEntityTypeConfiguration<model>
	{
		public void Configure(EntityTypeBuilder<model> builder)
		{
			builder.HasData(
				new model
				{
					Id = 1,
					Name = "3 series",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				},
				new model
				{
					Id = 2,
					Name = "X5",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				},
				new model
				{
				Id = 3,
					Name = "Prius",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				},
				new model
				{
					Id = 4,
					Name = "Rav4",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				}
				);
		}
	}
}
