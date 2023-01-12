using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private static List<Product> Products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Title = "one",
                Description = "p1",
                ImageURL = "https://eldenring.wiki.fextralife.com/file/Elden-Ring/radahn-2-hq-enemy-elden-ring-wiki.jpg",
                Price = 9.99m
            },
            new Product
            {
                Id = 2,
                Title = "two",
                Description = "p2",
                ImageURL = "https://res.cloudinary.com/cook-becker/image/fetch/q_auto:eco,f_auto,w_1920,e_sharpen/https://candb.com/site/candb/images/artwork/starscourge-radahn_elden-ring_bandai-namco.jpg",
                Price = 19.99m
            },
            new Product
            {
                Id = 3,
                Title = "three",
                Description = "p3",
                ImageURL = "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/645fd3c5-6089-4f57-b77d-9b73809492a9/dexw8j8-78180856-e1a2-4c58-a8e6-75380aa62956.png/v1/fill/w_1920,h_2304,q_80,strp/general_radahn_by_sirjimb_dexw8j8-fullview.jpg?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7ImhlaWdodCI6Ijw9MjMwNCIsInBhdGgiOiJcL2ZcLzY0NWZkM2M1LTYwODktNGY1Ny1iNzdkLTliNzM4MDk0OTJhOVwvZGV4dzhqOC03ODE4MDg1Ni1lMWEyLTRjNTgtYThlNi03NTM4MGFhNjI5NTYucG5nIiwid2lkdGgiOiI8PTE5MjAifV1dLCJhdWQiOlsidXJuOnNlcnZpY2U6aW1hZ2Uub3BlcmF0aW9ucyJdfQ.thj-azy-A0zUlh_qLjzs93oqZ5uuO7KKNhgnInxDUS4",
                Price = 49.59m
            }
        };

        [HttpGet]
        public async Task<IActionResult> GetProduct()
        {
            return Ok(Products);
        }
    }
}
