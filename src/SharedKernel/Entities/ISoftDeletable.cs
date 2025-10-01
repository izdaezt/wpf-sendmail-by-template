using System;

namespace SharedKernel.Entities;

public interface ISoftDeletable
{
    bool IsDeleted { get; set; }
}