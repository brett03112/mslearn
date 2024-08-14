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

    // GET all action
    [HttpGet]
    public ActionResult<List<Pizza>> GetAll() =>
        PizzaService.GetAll();
    /*
    The preceding action:

        Responds only to the HTTP GET verb, as denoted by the [HttpGet] attribute.

        Returns an ActionResult instance of type List<Pizza>. 
            The ActionResult type is the base class for all action results in ASP.NET Core.

        Queries the service for all pizza and automatically 
            returns data with a Content-Type value of application/json.
    */    

    // GET by Id action
    [HttpGet("{id}")]
    public ActionResult<Pizza> Get(int id)
    {
        var pizza = PizzaService.Get(id);

        if(pizza == null)
            return NotFound();

        return pizza;    
    }
    /*
    The preceding action:

        Responds only to the HTTP GET verb, as denoted by the [HttpGet] attribute.

        Requires that the id parameter's value is included in the URL segment after pizza/. 
            Remember, the controller-level [Route] attribute defined the /pizza pattern.
        
        Queries the database for a pizza that matches the provided id parameter.

        Each ActionResult instance used in the preceding action is mapped 
            to the corresponding HTTP status code in the following table:

        ASP.NET Core        HTTP status code	Description 
        action result
        _______________________________________________________________________________________________________________________
        ok is implied:      200 OK              A product that matches the provided id parameter exists in the in-memory cache.
                                                The product is included in the response body in the media type, 
                                                as defined in the accept HTTP request header (JSON by default).	

        NotFound            404 Not Found       A product that matches the provided {id} parameter 
                                                does not exist in the in-memory cache.                                           
    */

    // POST action

    // PUT action

    // DELETE action
}