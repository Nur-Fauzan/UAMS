namespace ASPNETMaker2024.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // list
    [Route("RefreshTokensList/{Id?}", Name = "RefreshTokensList-RefreshTokens-list")]
    [Route("Home/RefreshTokensList/{Id?}", Name = "RefreshTokensList-RefreshTokens-list-2")]
    public async Task<IActionResult> RefreshTokensList()
    {
        // Create page object
        refreshTokensList = new GLOBALS.RefreshTokensList(this);
        refreshTokensList.Cache = _cache;

        // Run the page
        return await refreshTokensList.Run();
    }

    // add
    [Route("RefreshTokensAdd/{Id?}", Name = "RefreshTokensAdd-RefreshTokens-add")]
    [Route("Home/RefreshTokensAdd/{Id?}", Name = "RefreshTokensAdd-RefreshTokens-add-2")]
    public async Task<IActionResult> RefreshTokensAdd()
    {
        // Create page object
        refreshTokensAdd = new GLOBALS.RefreshTokensAdd(this);

        // Run the page
        return await refreshTokensAdd.Run();
    }

    // view
    [Route("RefreshTokensView/{Id?}", Name = "RefreshTokensView-RefreshTokens-view")]
    [Route("Home/RefreshTokensView/{Id?}", Name = "RefreshTokensView-RefreshTokens-view-2")]
    public async Task<IActionResult> RefreshTokensView()
    {
        // Create page object
        refreshTokensView = new GLOBALS.RefreshTokensView(this);

        // Run the page
        return await refreshTokensView.Run();
    }

    // edit
    [Route("RefreshTokensEdit/{Id?}", Name = "RefreshTokensEdit-RefreshTokens-edit")]
    [Route("Home/RefreshTokensEdit/{Id?}", Name = "RefreshTokensEdit-RefreshTokens-edit-2")]
    public async Task<IActionResult> RefreshTokensEdit()
    {
        // Create page object
        refreshTokensEdit = new GLOBALS.RefreshTokensEdit(this);

        // Run the page
        return await refreshTokensEdit.Run();
    }

    // delete
    [Route("RefreshTokensDelete/{Id?}", Name = "RefreshTokensDelete-RefreshTokens-delete")]
    [Route("Home/RefreshTokensDelete/{Id?}", Name = "RefreshTokensDelete-RefreshTokens-delete-2")]
    public async Task<IActionResult> RefreshTokensDelete()
    {
        // Create page object
        refreshTokensDelete = new GLOBALS.RefreshTokensDelete(this);

        // Run the page
        return await refreshTokensDelete.Run();
    }
}
