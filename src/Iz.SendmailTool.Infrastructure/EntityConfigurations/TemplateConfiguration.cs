using Iz.SendmailTool.Domain.Templates;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Iz.SendmailTool.Infrastructure.EntityConfigurations;

public class TemplateConfiguration : AuditableEntityConfiguration<Template>
{
    public override void Configure(EntityTypeBuilder<Template> builder)
    {
        base.Configure(builder);

        builder.ToTable("templates")
            .HasKey(t => t.Id);

        builder.Property(t => t.Id)
            .HasColumnName("id")
            .ValueGeneratedOnAdd();

        builder.Property(t => t.Name)
            .HasColumnName("name")
            .IsRequired();

        builder.Property(t => t.From)
           .HasColumnName("from");

        builder.Property(t => t.To)
           .HasColumnName("to")
           .IsRequired();

        builder.Property(t => t.Cc)
           .HasColumnName("cc");

        builder.Property(t => t.Subject)
           .HasColumnName("subject")
           .IsRequired();

        builder.Property(t => t.Content)
           .HasColumnName("content")
           .IsRequired();


    }
}

