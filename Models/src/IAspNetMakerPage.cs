namespace ASPNETMaker2024.Models;

// Partial class
public partial class UAMS_20250216_1835 {
    // IAspNetMakerPage interface // DN
    public interface IAspNetMakerPage
    {
        Task<IActionResult> Run();
        IActionResult Terminate(string url = "");
    }
} // End Partial class
