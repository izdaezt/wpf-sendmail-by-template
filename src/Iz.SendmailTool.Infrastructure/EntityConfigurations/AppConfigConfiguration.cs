using System.Text.Json;
using Iz.SendmailTool.Domain.AppConfigs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Iz.SendmailTool.Infrastructure.EntityConfigurations;

public class CaseConfiguration : IEntityTypeConfiguration<AppConfig>
{
    public void Configure(EntityTypeBuilder<AppConfig> builder)
    {       
        builder.ToTable("app_config")
            .HasKey(t => t.Key);

        builder.Property(t => t.Key)
            .HasColumnName("key");

        builder.Property(t => t.Value)
            .HasColumnName("Value")           
            .IsRequired();
    }
}

