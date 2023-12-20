using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Resturant.Entities;

namespace Resturant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromForm] MyModel model)
        {
            string modelContex = $"food name: {model.FoodName}    food type: {model.FoodType}    is available: {model.IsAvailable}     side dishes: {model.haveTomato} {model.havePickledCucumber}";

            System.IO.File.WriteAllText(model.FoodName + ".txt", modelContex);

            return Ok();
        }
    }

    public class MyModel
    {
        public string? FoodName { get; set; }
        public string? FoodType { get; set; }
        public string? IsAvailable { get; set; }
        public string? haveTomato { get; set; }
        public string? havePickledCucumber { get; set; }
    }
}
