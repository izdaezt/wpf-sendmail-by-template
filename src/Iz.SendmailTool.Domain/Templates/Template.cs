using SharedKernel.Entities;

namespace Iz.SendmailTool.Domain.Templates;

public class Template : AuditableEntity, ISoftDeletable
{
    public string Name { get; set; }
    public string From { get; set; }
    public string To { get; set; }
    public string Cc { get; set; }
    public string Subject { get; set; }
    public string Content { get; set; }
    public string PrimaryColumn { get; set; }  
    public bool IsDeleted { get; set; }
}
