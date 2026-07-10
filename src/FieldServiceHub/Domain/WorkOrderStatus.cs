namespace FieldServiceHub.Domain;

public enum WorkOrderStatus
{
    Created = 0,
    Scheduled = 1,

    InProgress = 2,
    Completed = 3,
    Canceled = 4
}
