using Microsoft.AspNetCore.Mvc;
using MVC.Domain.Services.Interfaces;

namespace ProyectoMVCTraine.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUserServices _userServices;

        public UsuarioController(IUserServices userServices)
        {
            _userServices = userServices;
        }
        public IActionResult Index()
        {
            var users = _userServices.GetAllUser();
            return View(users);
        }
    }
}
