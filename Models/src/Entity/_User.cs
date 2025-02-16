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

    [Column("PreferredTimezoneID")]
    public required int? PreferredTimezoneId { get; set; }

    [Column("UserLevelID")]
    public int? UserLevelId { get; set; }
}
