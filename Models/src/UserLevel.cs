namespace ASPNETMaker2024.Models;

// Partial class
public partial class UAMS_20250216_1835 {
    /// <summary>
    /// User level class
    /// </summary>
    public class UserLevel
    {
        // User level ID
        [Column("UserLevelID")]
        public int Id { set; get; }

        // Name
        [Column("UserLevelName")]
        public string Name { set; get; } = "";
    }
} // End Partial class
