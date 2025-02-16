namespace ASPNETMaker2024.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // list
    [Route("TimezonesList/{TimezoneID?}", Name = "TimezonesList-Timezones-list")]
    [Route("Home/TimezonesList/{TimezoneID?}", Name = "TimezonesList-Timezones-list-2")]
    public async Task<IActionResult> TimezonesList()
    {
        // Create page object
        timezonesList = new GLOBALS.TimezonesList(this);
        timezonesList.Cache = _cache;

        // Run the page
        return await timezonesList.Run();
    }

    // add
    [Route("TimezonesAdd/{TimezoneID?}", Name = "TimezonesAdd-Timezones-add")]
    [Route("Home/TimezonesAdd/{TimezoneID?}", Name = "TimezonesAdd-Timezones-add-2")]
    public async Task<IActionResult> TimezonesAdd()
    {
        // Create page object
        timezonesAdd = new GLOBALS.TimezonesAdd(this);

        // Run the page
        return await timezonesAdd.Run();
    }

    // view
    [Route("TimezonesView/{TimezoneID?}", Name = "TimezonesView-Timezones-view")]
    [Route("Home/TimezonesView/{TimezoneID?}", Name = "TimezonesView-Timezones-view-2")]
    public async Task<IActionResult> TimezonesView()
    {
        // Create page object
        timezonesView = new GLOBALS.TimezonesView(this);

        // Run the page
        return await timezonesView.Run();
    }

    // edit
    [Route("TimezonesEdit/{TimezoneID?}", Name = "TimezonesEdit-Timezones-edit")]
    [Route("Home/TimezonesEdit/{TimezoneID?}", Name = "TimezonesEdit-Timezones-edit-2")]
    public async Task<IActionResult> TimezonesEdit()
    {
        // Create page object
        timezonesEdit = new GLOBALS.TimezonesEdit(this);

        // Run the page
        return await timezonesEdit.Run();
    }

    // delete
    [Route("TimezonesDelete/{TimezoneID?}", Name = "TimezonesDelete-Timezones-delete")]
    [Route("Home/TimezonesDelete/{TimezoneID?}", Name = "TimezonesDelete-Timezones-delete-2")]
    public async Task<IActionResult> TimezonesDelete()
    {
        // Create page object
        timezonesDelete = new GLOBALS.TimezonesDelete(this);

        // Run the page
        return await timezonesDelete.Run();
    }
}
