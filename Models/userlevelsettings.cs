namespace ASPNETMaker2024.Models;

// Partial class
public partial class UAMS_20250216_1835 {
    // Configuration
    public static partial class Config
    {
        //
        // ASP.NET Maker 2024 user level settings
        //

        // User level info
        public static List<UserLevel> UserLevels = [
            new() { Id = -2, Name = "Anonymous" },
            new() { Id = 0, Name = "Default" }
        ];

        // User level priv info
        public static List<UserLevelPermission> UserLevelPermissions = [
            new() { Table = "{EE5ECABA-974C-4BD5-866A-C63F74CCEED2}Users", Id = -2, Permission = 0 },
            new() { Table = "{EE5ECABA-974C-4BD5-866A-C63F74CCEED2}Users", Id = 0, Permission = 0 },
            new() { Table = "{EE5ECABA-974C-4BD5-866A-C63F74CCEED2}Appointments", Id = -2, Permission = 0 },
            new() { Table = "{EE5ECABA-974C-4BD5-866A-C63F74CCEED2}Appointments", Id = 0, Permission = 0 },
            new() { Table = "{EE5ECABA-974C-4BD5-866A-C63F74CCEED2}Participants", Id = -2, Permission = 0 },
            new() { Table = "{EE5ECABA-974C-4BD5-866A-C63F74CCEED2}Participants", Id = 0, Permission = 0 },
            new() { Table = "{EE5ECABA-974C-4BD5-866A-C63F74CCEED2}RefreshTokens", Id = -2, Permission = 0 },
            new() { Table = "{EE5ECABA-974C-4BD5-866A-C63F74CCEED2}RefreshTokens", Id = 0, Permission = 0 },
            new() { Table = "{EE5ECABA-974C-4BD5-866A-C63F74CCEED2}Timezones", Id = -2, Permission = 0 },
            new() { Table = "{EE5ECABA-974C-4BD5-866A-C63F74CCEED2}Timezones", Id = 0, Permission = 0 },
            new() { Table = "{EE5ECABA-974C-4BD5-866A-C63F74CCEED2}UserLevels", Id = -2, Permission = 0 },
            new() { Table = "{EE5ECABA-974C-4BD5-866A-C63F74CCEED2}UserLevels", Id = 0, Permission = 0 },
            new() { Table = "{EE5ECABA-974C-4BD5-866A-C63F74CCEED2}UserLevelPermissions", Id = -2, Permission = 0 },
            new() { Table = "{EE5ECABA-974C-4BD5-866A-C63F74CCEED2}UserLevelPermissions", Id = 0, Permission = 0 }
        ];

        // User level table info // DN
        public static List<UserLevelTablePermission> UserLevelTablePermissions = [
            new() { TableName = "Users", TableVar = "Users", Caption = "Users", Allowed = true, ProjectId = "{EE5ECABA-974C-4BD5-866A-C63F74CCEED2}", Url = "UsersList" },
            new() { TableName = "Appointments", TableVar = "Appointments", Caption = "Appointments", Allowed = true, ProjectId = "{EE5ECABA-974C-4BD5-866A-C63F74CCEED2}", Url = "AppointmentsList" },
            new() { TableName = "Participants", TableVar = "Participants", Caption = "Participants", Allowed = true, ProjectId = "{EE5ECABA-974C-4BD5-866A-C63F74CCEED2}", Url = "ParticipantsList" },
            new() { TableName = "RefreshTokens", TableVar = "RefreshTokens", Caption = "Refresh Tokens", Allowed = true, ProjectId = "{EE5ECABA-974C-4BD5-866A-C63F74CCEED2}", Url = "RefreshTokensList" },
            new() { TableName = "Timezones", TableVar = "Timezones", Caption = "Timezones", Allowed = true, ProjectId = "{EE5ECABA-974C-4BD5-866A-C63F74CCEED2}", Url = "TimezonesList" },
            new() { TableName = "UserLevels", TableVar = "UserLevels", Caption = "User Levels", Allowed = true, ProjectId = "{EE5ECABA-974C-4BD5-866A-C63F74CCEED2}", Url = "UserLevelsList" },
            new() { TableName = "UserLevelPermissions", TableVar = "UserLevelPermissions", Caption = "User Level Permissions", Allowed = true, ProjectId = "{EE5ECABA-974C-4BD5-866A-C63F74CCEED2}", Url = "UserLevelPermissionsList" }
        ];
    }
} // End Partial class
