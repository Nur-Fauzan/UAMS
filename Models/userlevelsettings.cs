namespace ASPNETMaker2024.Models;

// Partial class
public partial class project1 {
    // Configuration
    public static partial class Config
    {
        //
        // ASP.NET Maker 2024 user level settings
        //

        // User level info
        public static List<UserLevel> UserLevels = [
            new() { Id = -2, Name = "Anonymous" }
        ];

        // User level priv info
        public static List<UserLevelPermission> UserLevelPermissions = [
            new() { Table = "{B73364AA-7E30-4718-8997-141A815ECA58}Users", Id = -2, Permission = 0 },
            new() { Table = "{B73364AA-7E30-4718-8997-141A815ECA58}Appointments", Id = -2, Permission = 0 },
            new() { Table = "{B73364AA-7E30-4718-8997-141A815ECA58}Participants", Id = -2, Permission = 0 },
            new() { Table = "{B73364AA-7E30-4718-8997-141A815ECA58}RefreshTokens", Id = -2, Permission = 0 }
        ];

        // User level table info // DN
        public static List<UserLevelTablePermission> UserLevelTablePermissions = [
            new() { TableName = "Users", TableVar = "Users", Caption = "Users", Allowed = true, ProjectId = "{B73364AA-7E30-4718-8997-141A815ECA58}", Url = "UsersList" },
            new() { TableName = "Appointments", TableVar = "Appointments", Caption = "Appointments", Allowed = true, ProjectId = "{B73364AA-7E30-4718-8997-141A815ECA58}", Url = "AppointmentsList" },
            new() { TableName = "Participants", TableVar = "Participants", Caption = "Participants", Allowed = true, ProjectId = "{B73364AA-7E30-4718-8997-141A815ECA58}", Url = "ParticipantsList" },
            new() { TableName = "RefreshTokens", TableVar = "RefreshTokens", Caption = "Refresh Tokens", Allowed = true, ProjectId = "{B73364AA-7E30-4718-8997-141A815ECA58}", Url = "RefreshTokensList" }
        ];
    }
} // End Partial class
