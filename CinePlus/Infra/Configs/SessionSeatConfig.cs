using CinePlus.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinePlus.Infra.Configs;

public class SessionSeatConfig : IEntityTypeConfiguration<SessionSeat>
{
    public void Configure(EntityTypeBuilder<SessionSeat> builder)
    {
        builder.HasKey(sessionSeat => sessionSeat.Id);

        builder.HasOne(sessionSeat => sessionSeat.Session)
            .WithMany(session => session.SessionSeats)
            .HasForeignKey(seat => seat.SessionId);
    }
}
