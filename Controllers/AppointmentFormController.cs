namespace ASPNETMaker2024.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // Appointment Form (custom)
    [Route("AppointmentForm/{**key}", Name = "AppointmentForm-Appointment_Form-custom")]
    [Route("Home/AppointmentForm/{**key}", Name = "AppointmentForm-Appointment_Form-custom-2")]
    public async Task<IActionResult> AppointmentForm()
    {
        // Create page object
        appointmentForm = new GLOBALS.AppointmentForm(this);

        // Run the page
        return await appointmentForm.Run();
    }
}
