namespace ASPNETMaker2024.Entities;

/**
 * Entity class for "Appointments" table
 */
[Table("Appointments")]
public class Appointment
{
    [Key("Id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; } = default!;

    [Column("Title")]
    public required string Title { get; set; } = default!;

    [Column("Description")]
    public string? Description { get; set; }

    [Column("StartTime")]
    public required DateTime StartTime { get; set; } = default!;

    [Column("EndTime")]
    public required DateTime EndTime { get; set; } = default!;

    [Column("CreatedBy")]
    public required int CreatedBy { get; set; } = default!;

    [Column("Timezone")]
    public required string Timezone { get; set; } = default!;
}
