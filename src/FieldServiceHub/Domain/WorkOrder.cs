namespace FieldServiceHub.Domain;

public record class WorkOrder
{
    public Guid Id { get; init; }
    public string Title { get; init; } = string.Empty;
    public string? Description { get; init; }
    public string City { get; init; } = string.Empty;
    public string RequiredSkill { get; init; } = string.Empty;
    public WorkOrderStatus Status { get; init; } = WorkOrderStatus.Created;
    public WorkOrderPriority Priority { get; init; } = WorkOrderPriority.Medium;
    public DateTimeOffset CreatedAt { get; init; } = DateTimeOffset.UtcNow;
    public DateTimeOffset? ScheduledFor { get; init; }
    public Guid? AssignedTechnicianId { get; init; }
}