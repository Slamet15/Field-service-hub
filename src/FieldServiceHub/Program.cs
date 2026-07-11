using FieldServiceHub.Domain;
namespace FieldServiceHub
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkOrder workOrder = new WorkOrder
            {
                Title = "Super man",
                Status = WorkOrderStatus.Completed,
                Priority = WorkOrderPriority.Critical,
                ScheduledFor = DateTimeOffset.Now,
            };
            Console.WriteLine(Describe(workOrder));

            WorkOrder workOrder2 = new WorkOrder
            {
                Title = "Super man",
                Status = WorkOrderStatus.Completed,
                Priority = WorkOrderPriority.Low,
               // ScheduledFor = DateTimeOffset.Now,
            };
            Console.WriteLine(Describe(workOrder2));

            WorkOrder workorder3 = workOrder with
            {
                Status = WorkOrderStatus.Created
            };

            Console.WriteLine(Describe(workorder3));

        }

        static string Describe(WorkOrder wo) => wo switch
        {
            { Priority: WorkOrderPriority.High or WorkOrderPriority.Critical, Status: not WorkOrderStatus.Completed } => $"URGENT: {wo.Title}",
            { ScheduledFor: DateTimeOffset date} => $"Scheduled for {date}",
            _ => "Backlog",
        };
    }
}


