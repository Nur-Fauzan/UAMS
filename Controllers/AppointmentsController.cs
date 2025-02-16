namespace ASPNETMaker2024.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // list
    [Route("AppointmentsList/{Id?}", Name = "AppointmentsList-Appointments-list")]
    [Route("Home/AppointmentsList/{Id?}", Name = "AppointmentsList-Appointments-list-2")]
    public async Task<IActionResult> AppointmentsList()
    {
        // Create page object
        appointmentsList = new GLOBALS.AppointmentsList(this);
        appointmentsList.Cache = _cache;

        // Run the page
        return await appointmentsList.Run();
    }

    // add
    [Route("AppointmentsAdd/{Id?}", Name = "AppointmentsAdd-Appointments-add")]
    [Route("Home/AppointmentsAdd/{Id?}", Name = "AppointmentsAdd-Appointments-add-2")]
    public async Task<IActionResult> AppointmentsAdd()
    {
        // Create page object
        appointmentsAdd = new GLOBALS.AppointmentsAdd(this);

        // Run the page
        return await appointmentsAdd.Run();
    }

    // view
    [Route("AppointmentsView/{Id?}", Name = "AppointmentsView-Appointments-view")]
    [Route("Home/AppointmentsView/{Id?}", Name = "AppointmentsView-Appointments-view-2")]
    public async Task<IActionResult> AppointmentsView()
    {
        // Create page object
        appointmentsView = new GLOBALS.AppointmentsView(this);

        // Run the page
        return await appointmentsView.Run();
    }

    // edit
    [Route("AppointmentsEdit/{Id?}", Name = "AppointmentsEdit-Appointments-edit")]
    [Route("Home/AppointmentsEdit/{Id?}", Name = "AppointmentsEdit-Appointments-edit-2")]
    public async Task<IActionResult> AppointmentsEdit()
    {
        // Create page object
        appointmentsEdit = new GLOBALS.AppointmentsEdit(this);

        // Run the page
        return await appointmentsEdit.Run();
    }

    // delete
    [Route("AppointmentsDelete/{Id?}", Name = "AppointmentsDelete-Appointments-delete")]
    [Route("Home/AppointmentsDelete/{Id?}", Name = "AppointmentsDelete-Appointments-delete-2")]
    public async Task<IActionResult> AppointmentsDelete()
    {
        // Create page object
        appointmentsDelete = new GLOBALS.AppointmentsDelete(this);

        // Run the page
        return await appointmentsDelete.Run();
    }
}
