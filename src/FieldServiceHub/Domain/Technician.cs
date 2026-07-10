namespace FieldServiceHub.Domain;


public record Technician(
    Guid Id,
    string Name,
    List<string> Skills,
    string HomeCity
);