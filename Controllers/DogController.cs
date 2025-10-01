using Microsoft.AspNetCore.Mvc;
using practica_Mvc.Models;

namespace practica_Mvc.Controllers;

public class DogController : Controller
{
    public IActionResult Index()
    {
        List<Dog> dogs_list = new List<Dog>
        
        {
            new Dog {Id=1, Breed = "Dalmata", Gender = "Male", Name = "Pichirilo", Age = 15, Sick = true},
            new Dog {Id=2, Breed = "Boxer", Gender = "Female", Name = "Firulaisa", Age = 4, Sick = false},
            new Dog {Id=3, Breed = "Chandosín", Gender = "Male", Name = "Pachito", Age = 6, Sick = true},
            new Dog {Id=4, Breed = "Pastor Alemán", Gender = "Male", Name = "Adolf", Age = 8, Sick = false},
            new Dog {Age=5, Breed = "Meztizo", Id = 5, Sick = true, Name = "Afrodita", Gender = "Female"}
        };

        return View(dogs_list);
    }
}