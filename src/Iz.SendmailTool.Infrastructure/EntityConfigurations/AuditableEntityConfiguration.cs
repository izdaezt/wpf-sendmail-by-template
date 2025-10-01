using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SharedKernel.Entities;

namespace Iz.SendmailTool.Infrastructure.EntityConfigurations;

public abstract class AuditableEntityConfiguration<T> : IEntityTypeConfiguration<T>
    where T : AuditableEntity
{
    public virtual void Configure(EntityTypeBuilder<T> builder)
    {
        builder.Property(t => t.CreatedAt)
            .HasColumnName("created_at");

        builder.Property(t => t.CreatedBy)
            .HasColumnName("created_by");

        builder.Property(t => t.UpdatedAt)
            .HasColumnName("updated_at");

        builder.Property(t => t.UpdatedBy)
            .HasColumnName("updated_by");
    }
}

public abstract class AuditableEntityConfiguration<T, TKey> : IEntityTypeConfiguration<T>
    where T : AuditableEntity<TKey>
{
    public virtual void Configure(EntityTypeBuilder<T> builder)
    {
        builder.HasKey(t => t.Id);

        builder.Property(t => t.CreatedAt)
            .HasColumnName("created_at");

        builder.Property(t => t.CreatedBy)
            .HasColumnName("created_by");

        builder.Property(t => t.UpdatedAt)
            .HasColumnName("updated_at");

        builder.Property(t => t.UpdatedBy)
            .HasColumnName("updated_by");
    }
}
