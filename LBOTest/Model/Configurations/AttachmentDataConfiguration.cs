using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LBOTest.Model.Configurations
{
    public class AttachmentDataConfiguration : IEntityTypeConfiguration<AttachmentData>
    {
        public void Configure(EntityTypeBuilder<AttachmentData> entity)
        {
            entity.ToTable("attachment", "nattachment");

            entity.HasKey(attachment => attachment.Id);

            entity.Property(e => e.Id)
                .HasColumnName("id");

            entity.Property(e => e.Data).HasColumnName("data");
        }
    }
}