using ContosoPizza.Models;
using ContosoPizza.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContosoPizza.Controllers;

[ApiController]
[Route("[controller]")]
public class PizzaController : ControllerBase
{
    public PizzaController()
{
}

//GET all action
[HttpGet]
public ActionResult<List<Pizza>> GetAll() =>
    PizzaService.GetAll();

// GET one action
[HttpGet("{id}")]
public ActionResult<Pizza> Get(int id)
{
    var pizza = PizzaService.Get(id);

    if(pizza == null)
        return NotFound();

    return pizza;
}

//POST action
[HttpPost]
public IActionResult Create(Pizza pizza)
{
    //this code will save the pizza and return a result
}

//PUT action
[HttpPut("{id}")]
public IActionResult Update(int id, Pizza pizza)
{
    // this code will update the pizza and return a result
}

//DELETE action
[HttpDelete("{id}")]
public IActionResult Delete(int id)
{
    //this code will delete the pizza and return a result
}

}