using Microsoft.AspNetCore.Mvc;
using TestAPI.Model;

namespace TestAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ItemController : ControllerBase
{
    [HttpGet(Name = "GetItems")]
    public List<Item> GetItems()
    {
        try
        {
            return new List<Item>
            {
                new()
                {
                    ItemId = 0,
                    Name = "Iphone 15 pro max",
                    Category = "Telefon"
                },
                new()
                {
                    ItemId = 1,
                    Name = "Iphone 13 pro max",
                    Category = "Telefon"
                },
                new()
                {
                    ItemId = 2,
                    Name = "Macbook Pro",
                    Category = "Bilgisayar"
                }
            };
        }
        catch (Exception _)
        {
            return new List<Item>
            {
                new()
                {
                    ItemId = 0,
                    Name = "Iphone 15 pro max",
                    Category = "Telefon"
                }
            };
        }
    } 
}