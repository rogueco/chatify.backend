using Microsoft.AspNetCore.Authorization;

namespace API.Controllers
{
    public class UserController : BaseController
    {
        [AllowAnonymous]
    }
}