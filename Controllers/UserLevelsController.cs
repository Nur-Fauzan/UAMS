namespace ASPNETMaker2024.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // list
    [Route("UserLevelsList/{UserLevelID?}", Name = "UserLevelsList-UserLevels-list")]
    [Route("Home/UserLevelsList/{UserLevelID?}", Name = "UserLevelsList-UserLevels-list-2")]
    public async Task<IActionResult> UserLevelsList()
    {
        // Create page object
        userLevelsList = new GLOBALS.UserLevelsList(this);
        userLevelsList.Cache = _cache;

        // Run the page
        return await userLevelsList.Run();
    }

    // add
    [Route("UserLevelsAdd/{UserLevelID?}", Name = "UserLevelsAdd-UserLevels-add")]
    [Route("Home/UserLevelsAdd/{UserLevelID?}", Name = "UserLevelsAdd-UserLevels-add-2")]
    public async Task<IActionResult> UserLevelsAdd()
    {
        // Create page object
        userLevelsAdd = new GLOBALS.UserLevelsAdd(this);

        // Run the page
        return await userLevelsAdd.Run();
    }

    // view
    [Route("UserLevelsView/{UserLevelID?}", Name = "UserLevelsView-UserLevels-view")]
    [Route("Home/UserLevelsView/{UserLevelID?}", Name = "UserLevelsView-UserLevels-view-2")]
    public async Task<IActionResult> UserLevelsView()
    {
        // Create page object
        userLevelsView = new GLOBALS.UserLevelsView(this);

        // Run the page
        return await userLevelsView.Run();
    }

    // edit
    [Route("UserLevelsEdit/{UserLevelID?}", Name = "UserLevelsEdit-UserLevels-edit")]
    [Route("Home/UserLevelsEdit/{UserLevelID?}", Name = "UserLevelsEdit-UserLevels-edit-2")]
    public async Task<IActionResult> UserLevelsEdit()
    {
        // Create page object
        userLevelsEdit = new GLOBALS.UserLevelsEdit(this);

        // Run the page
        return await userLevelsEdit.Run();
    }

    // delete
    [Route("UserLevelsDelete/{UserLevelID?}", Name = "UserLevelsDelete-UserLevels-delete")]
    [Route("Home/UserLevelsDelete/{UserLevelID?}", Name = "UserLevelsDelete-UserLevels-delete-2")]
    public async Task<IActionResult> UserLevelsDelete()
    {
        // Create page object
        userLevelsDelete = new GLOBALS.UserLevelsDelete(this);

        // Run the page
        return await userLevelsDelete.Run();
    }
}
