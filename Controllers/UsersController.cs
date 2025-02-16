namespace ASPNETMaker2024.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // list
    [Route("UsersList/{Id?}", Name = "UsersList-Users-list")]
    [Route("Home/UsersList/{Id?}", Name = "UsersList-Users-list-2")]
    public async Task<IActionResult> UsersList()
    {
        // Create page object
        usersList = new GLOBALS.UsersList(this);
        usersList.Cache = _cache;

        // Run the page
        return await usersList.Run();
    }

    // add
    [Route("UsersAdd/{Id?}", Name = "UsersAdd-Users-add")]
    [Route("Home/UsersAdd/{Id?}", Name = "UsersAdd-Users-add-2")]
    public async Task<IActionResult> UsersAdd()
    {
        // Create page object
        usersAdd = new GLOBALS.UsersAdd(this);

        // Run the page
        return await usersAdd.Run();
    }

    // view
    [Route("UsersView/{Id?}", Name = "UsersView-Users-view")]
    [Route("Home/UsersView/{Id?}", Name = "UsersView-Users-view-2")]
    public async Task<IActionResult> UsersView()
    {
        // Create page object
        usersView = new GLOBALS.UsersView(this);

        // Run the page
        return await usersView.Run();
    }

    // edit
    [Route("UsersEdit/{Id?}", Name = "UsersEdit-Users-edit")]
    [Route("Home/UsersEdit/{Id?}", Name = "UsersEdit-Users-edit-2")]
    public async Task<IActionResult> UsersEdit()
    {
        // Create page object
        usersEdit = new GLOBALS.UsersEdit(this);

        // Run the page
        return await usersEdit.Run();
    }

    // delete
    [Route("UsersDelete/{Id?}", Name = "UsersDelete-Users-delete")]
    [Route("Home/UsersDelete/{Id?}", Name = "UsersDelete-Users-delete-2")]
    public async Task<IActionResult> UsersDelete()
    {
        // Create page object
        usersDelete = new GLOBALS.UsersDelete(this);

        // Run the page
        return await usersDelete.Run();
    }
}
