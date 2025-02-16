namespace ASPNETMaker2024.Entities;

/**
 * Entity class for "Participants" table
 */
[Table("Participants")]
public class Participant
{
    [Key("Id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; } = default!;

    [Column("UserId")]
    public required int UserId { get; set; } = default!;

    [Column("AppointmentId")]
    public required int AppointmentId { get; set; } = default!;

    [Column("Status")]
    public string? Status { get; set; }
}
