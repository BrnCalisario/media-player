using CleanArch.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration
{
    public class BlobFileConfiguration : IEntityTypeConfiguration<BlobFile>
    {
        public void Configure(EntityTypeBuilder<BlobFile> builder)
        {
            builder.ToTable("BlobFile");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("Id");

            builder.Property(x => x.Name)
                .HasColumnName("Name")
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(x => x.ContentType)
                .HasColumnName("ContentType")
                .HasMaxLength(255)
                .IsRequired();
        }
    }
}