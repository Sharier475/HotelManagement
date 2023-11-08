using HotelManagement.Model;
using HotelManagement.Shared.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelManagement.Infrustructure.Persistence.Configuration;

internal class GuestConfiguration : IEntityTypeConfiguration<Guest>
{

    public void Configure(EntityTypeBuilder<Guest> builder)
    {
        builder.ToTable("Guest");
        builder.HasKey(x => x.Id);
        builder.HasData(new
        {
            Id = 1,
            GuestName = "Shakil",
            RoomPrice = 1200.00,
            RoomType = "Single-Bed",
            Created = DateTimeOffset.Now,
            CreatedBy ="1",
            Status = EntityStatus.Created
        });
    }
}
