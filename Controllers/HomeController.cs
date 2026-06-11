using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using paginapandita.Models;
using panditaAS.Models;

namespace paginapandita.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ObtenerPersonajes()
        {
            var bibliotecaAnimes = new List<Personaje>
            {
                new Personaje {
                    Nombre = "Naruto Shippuden",
                    Rol = "Poderes y Secretos",
                    Poder = "Chakra de Nueve Colas / Sabio",
                    Descripcion = "Domina el Rasengan y las técnicas de la Aldea de la Hoja.",
                    ImagenUrl = "/images/naruto.jpg"
                },
                new Personaje {
                    Nombre = "Jujutsu Kaisen",
                    Rol = "Poderes y Secretos",
                    Poder = "Expansión de Dominio / Energía",
                    Descripcion = "Rituales malditos de los hechiceros de la academia de Tokio.",
                    ImagenUrl = "/images/jujutsu.jpg"
                },
                new Personaje {
                    Nombre = "One Piece",
                    Rol = "Poderes y Secretos",
                    Poder = "Frutas del Diablo / Haki",
                    Descripcion = "Acompaña a Luffy en sus transformaciones Gear en el mar.",
                    ImagenUrl = "/images/onepiece.jpg"
                }
            };
            return PartialView("_PersonajesPartial", bibliotecaAnimes);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}