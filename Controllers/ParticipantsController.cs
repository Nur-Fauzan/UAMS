namespace ASPNETMaker2024.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // list
    [Route("ParticipantsList/{Id?}", Name = "ParticipantsList-Participants-list")]
    [Route("Home/ParticipantsList/{Id?}", Name = "ParticipantsList-Participants-list-2")]
    public async Task<IActionResult> ParticipantsList()
    {
        // Create page object
        participantsList = new GLOBALS.ParticipantsList(this);
        participantsList.Cache = _cache;

        // Run the page
        return await participantsList.Run();
    }

    // add
    [Route("ParticipantsAdd/{Id?}", Name = "ParticipantsAdd-Participants-add")]
    [Route("Home/ParticipantsAdd/{Id?}", Name = "ParticipantsAdd-Participants-add-2")]
    public async Task<IActionResult> ParticipantsAdd()
    {
        // Create page object
        participantsAdd = new GLOBALS.ParticipantsAdd(this);

        // Run the page
        return await participantsAdd.Run();
    }

    // view
    [Route("ParticipantsView/{Id?}", Name = "ParticipantsView-Participants-view")]
    [Route("Home/ParticipantsView/{Id?}", Name = "ParticipantsView-Participants-view-2")]
    public async Task<IActionResult> ParticipantsView()
    {
        // Create page object
        participantsView = new GLOBALS.ParticipantsView(this);

        // Run the page
        return await participantsView.Run();
    }

    // edit
    [Route("ParticipantsEdit/{Id?}", Name = "ParticipantsEdit-Participants-edit")]
    [Route("Home/ParticipantsEdit/{Id?}", Name = "ParticipantsEdit-Participants-edit-2")]
    public async Task<IActionResult> ParticipantsEdit()
    {
        // Create page object
        participantsEdit = new GLOBALS.ParticipantsEdit(this);

        // Run the page
        return await participantsEdit.Run();
    }

    // delete
    [Route("ParticipantsDelete/{Id?}", Name = "ParticipantsDelete-Participants-delete")]
    [Route("Home/ParticipantsDelete/{Id?}", Name = "ParticipantsDelete-Participants-delete-2")]
    public async Task<IActionResult> ParticipantsDelete()
    {
        // Create page object
        participantsDelete = new GLOBALS.ParticipantsDelete(this);

        // Run the page
        return await participantsDelete.Run();
    }
}
