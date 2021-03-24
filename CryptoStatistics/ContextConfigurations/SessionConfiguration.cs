using CryptoStatistics.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CryptoStatistics.ContextConfigurations
{
    public class SessionConfiguration : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(s => s.Id)
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder
                .Property(s => s.MegaHashesPerSecond)
                .IsRequired();

            builder
                .Property(s => s.NumberOfCompletions)
                .IsRequired();

            builder
                .Property(s => s.NumberOfErrors)
                .IsRequired();

            builder
                .Property(s => s.NumberOfStales)
                .IsRequired();

            //builder
            //    .Property(s => s.SessionEnd)
            //    .IsRequired(false);

            builder
                .Property(s => s.SessionStart)
                .IsRequired();
        }
    }
}
