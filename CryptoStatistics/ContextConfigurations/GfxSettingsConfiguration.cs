using CryptoStatistics.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CryptoStatistics.ContextConfigurations
{
    public class GfxSettingsConfiguration : IEntityTypeConfiguration<GfxSettings>
    {
        public void Configure(EntityTypeBuilder<GfxSettings> builder)
        {
            builder
                .HasKey(x => x.Id);

            #region Properties
            builder
                    .Property(x => x.Id)
                    .ValueGeneratedOnAdd()
                    .IsRequired();

            builder
                .Property(g => g.ClockFrequency)
                .IsRequired();

            builder
                .Property(g => g.MemoryFrequency)
                .IsRequired();

            builder
                .Property(g => g.Voltage)
                .IsRequired();

            builder
                .Property(g => g.Name)
                .IsRequired();

            builder
                .Property(g => g.Wattage)
                .IsRequired();
            #endregion

            #region Relations
            builder
                    .HasMany(g => g.Sessions)
                    .WithOne(s => s.GfxSettings); 
            #endregion
        }
    }
}
