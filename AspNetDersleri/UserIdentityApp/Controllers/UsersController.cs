using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace UserIdentityApp.Controllers
{
    public class UsersController : Controller{

        private UserManager<IdentityUser> _userManager;

        public UsersController(UserManager<IdentityUser> userManager){
            _userManager = userManager;
        }

        public IActionResult Index (){

            return View(_userManager.Users);
        }
    }
}