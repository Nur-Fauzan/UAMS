namespace ASPNETMaker2024.Entities;

/**
 * Entity class for "UserLevels" table
 */
[Table("UserLevels")]
public class _UserLevel
{
    [Key("UserLevelID")]
    public required int UserLevelId { get; set; } = default!;

    [Column("UserLevelName")]
    public required string UserLevelName { get; set; } = default!;
}
