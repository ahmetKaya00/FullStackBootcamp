using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UserIdentityApp.Models;
using UserIdentityApp.ViewModels;

namespace UserIdentityApp.Controllers
{
    public class AccountController:Controller{

        private readonly RoleManager<AppRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;
        private SignInManager<AppUser> _signInManager;

        public AccountController(RoleManager<AppRole> roleManager, UserManager<AppUser> userManager,SignInManager<AppUser> signInManager){
            _roleManager = roleManager;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Login(){
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model){

            var user = await _userManager.FindByEmailAsync(model.Email);

            if(user != null){
                await _signInManager.SignOutAsync();

                var result = await _signInManager.PasswordSignInAsync(user,model.Password,model.RememberMe,true);

                if(result.Succeeded){
                    await _userManager.ResetAccessFailedCountAsync(user);
                    await _userManager.SetLockoutEndDateAsync(user,null);

                    return RedirectToAction ("Index","Home");
                }
                else if(result.IsLockedOut){
                    var lockouteDate = await _userManager.GetLockoutEndDateAsync(user);
                    var timeLeft = lockouteDate.Value - DateTime.UtcNow;
                    ModelState.AddModelError("", $"Hesabınız kilitlendi, {timeLeft.Minutes} dakika sonra tekrar deneyiniz!");
                }else{
                ModelState.AddModelError("","Hatalı Email ya da Parola");
            }
            }else{
                ModelState.AddModelError("","Bu email adresiyle bir hesap bulunamadı");
            }
            return View(model);
        } 
    }
}