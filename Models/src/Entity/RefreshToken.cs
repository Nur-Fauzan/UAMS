namespace ASPNETMaker2024.Entities;

/**
 * Entity class for "RefreshTokens" table
 */
[Table("RefreshTokens")]
public class RefreshToken
{
    [Key("Id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; } = default!;

    [Column("UserId")]
    public required int UserId { get; set; } = default!;

    [Column("Token")]
    public required string Token { get; set; } = default!;

    [Column("ExpiryDate")]
    public required DateTime ExpiryDate { get; set; } = default!;
}
