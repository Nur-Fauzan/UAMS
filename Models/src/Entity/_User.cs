namespace ASPNETMaker2024.Entities;

/**
 * Entity class for "Users" table
 */
[Table("Users")]
public class _User
{
    [Key("Id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; } = default!;

    [Column("Username")]
    public required string Username { get; set; } = default!;

    [Column("PasswordHash")]
    public required string PasswordHash { get; set; } = default!;

    [Column("Name")]
    public required string Name { get; set; } = default!;

    [Column("PreferredTimezone")]
    public required string PreferredTimezone { get; set; } = default!;
}
