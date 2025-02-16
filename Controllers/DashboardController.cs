namespace ASPNETMaker2024.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // Dashboard (custom)
    [Route("Dashboard/{**key}", Name = "Dashboard-Dashboard-custom")]
    [Route("Home/Dashboard/{**key}", Name = "Dashboard-Dashboard-custom-2")]
    public async Task<IActionResult> Dashboard()
    {
        // Create page object
        dashboard = new GLOBALS.Dashboard(this);

        // Run the page
        return await dashboard.Run();
    }
}
