using HotelManagement.Shared.Enum;

namespace HotelManagement.Shared.Common;

public class BaseEntity
{
    public DateTimeOffset Created { get; set; } = DateTimeOffset.UtcNow;
    public string CreatedBy { get; set; } = string.Empty;

    public DateTimeOffset? LastModified { get; set; }

    public string? LastModifiedby { get; set; }

    public EntityStatus Status { get; set; }
}
