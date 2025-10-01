using Microsoft.AspNetCore.Mvc;
using practica_Mvc.Models;

namespace practica_Mvc.Controllers;

public class ClientController : Controller
{
    public IActionResult Index()
    {
        List<Client> clients_list = new List<Client>
        {
            new Client {Id = 1, Name = "Camilo", Lastname = "Bolton", Dni = "108543212"},
            new Client {Id = 2, Name = "Andres", Lastname = "Klauss", Dni = "1085234222"},
            new Client {Id = 3, Name = "Edison", Lastname = "Marx", Dni = "1085465612"},
            new Client {Id = 4, Name = "Carlos", Lastname = "Herrera", Dni = "1023443212"},
            new Client {Id = 5, Name = "Diego", Lastname = "Bustamante", Dni = "906543212"},
            new Client {Id = 6, Name = "Silvio", Lastname = "Vallejo", Dni = "55443212"}
        };
        
        return View(clients_list);
    }
}