namespace ASPNETMaker2024.Entities;

/**
 * Entity class for "Timezones" table
 */
[Table("Timezones")]
public class Timezone
{
    [Key("TimezoneID")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int TimezoneId { get; set; } = default!;

    [Column("TimezoneName")]
    public required string TimezoneName { get; set; } = default!;

    [Column("UtcOffset")]
    public required string UtcOffset { get; set; } = default!;
}
