namespace ASPNETMaker2024.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // list
    [Route("UserLevelPermissionsList/{UserLevelID?}/{_TableName?}", Name = "UserLevelPermissionsList-UserLevelPermissions-list")]
    [Route("Home/UserLevelPermissionsList/{UserLevelID?}/{_TableName?}", Name = "UserLevelPermissionsList-UserLevelPermissions-list-2")]
    public async Task<IActionResult> UserLevelPermissionsList()
    {
        // Create page object
        userLevelPermissionsList = new GLOBALS.UserLevelPermissionsList(this);
        userLevelPermissionsList.Cache = _cache;

        // Run the page
        return await userLevelPermissionsList.Run();
    }

    // add
    [Route("UserLevelPermissionsAdd/{UserLevelID?}/{_TableName?}", Name = "UserLevelPermissionsAdd-UserLevelPermissions-add")]
    [Route("Home/UserLevelPermissionsAdd/{UserLevelID?}/{_TableName?}", Name = "UserLevelPermissionsAdd-UserLevelPermissions-add-2")]
    public async Task<IActionResult> UserLevelPermissionsAdd()
    {
        // Create page object
        userLevelPermissionsAdd = new GLOBALS.UserLevelPermissionsAdd(this);

        // Run the page
        return await userLevelPermissionsAdd.Run();
    }

    // view
    [Route("UserLevelPermissionsView/{UserLevelID?}/{_TableName?}", Name = "UserLevelPermissionsView-UserLevelPermissions-view")]
    [Route("Home/UserLevelPermissionsView/{UserLevelID?}/{_TableName?}", Name = "UserLevelPermissionsView-UserLevelPermissions-view-2")]
    public async Task<IActionResult> UserLevelPermissionsView()
    {
        // Create page object
        userLevelPermissionsView = new GLOBALS.UserLevelPermissionsView(this);

        // Run the page
        return await userLevelPermissionsView.Run();
    }

    // edit
    [Route("UserLevelPermissionsEdit/{UserLevelID?}/{_TableName?}", Name = "UserLevelPermissionsEdit-UserLevelPermissions-edit")]
    [Route("Home/UserLevelPermissionsEdit/{UserLevelID?}/{_TableName?}", Name = "UserLevelPermissionsEdit-UserLevelPermissions-edit-2")]
    public async Task<IActionResult> UserLevelPermissionsEdit()
    {
        // Create page object
        userLevelPermissionsEdit = new GLOBALS.UserLevelPermissionsEdit(this);

        // Run the page
        return await userLevelPermissionsEdit.Run();
    }

    // delete
    [Route("UserLevelPermissionsDelete/{UserLevelID?}/{_TableName?}", Name = "UserLevelPermissionsDelete-UserLevelPermissions-delete")]
    [Route("Home/UserLevelPermissionsDelete/{UserLevelID?}/{_TableName?}", Name = "UserLevelPermissionsDelete-UserLevelPermissions-delete-2")]
    public async Task<IActionResult> UserLevelPermissionsDelete()
    {
        // Create page object
        userLevelPermissionsDelete = new GLOBALS.UserLevelPermissionsDelete(this);

        // Run the page
        return await userLevelPermissionsDelete.Run();
    }
}
