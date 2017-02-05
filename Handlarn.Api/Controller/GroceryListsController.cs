using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Handlarn.Domain.Interfaces;
using Handlarn.Logic.Queries;
using Handlarn.DataAccess;

namespace Handlarn.Api.Controllers
{
    [Route("grocerylists")]
    public class GroceryListsController : Controller
    {
        private readonly IGroceryListQueries _groceryListQueries;

        //public GroceryListsController(IGroceryListQueries groceryListQueries)
        //{
        //    _groceryListQueries = groceryListQueries;
        //}

        public GroceryListsController()
        {
            var dataAccess = new GroceryListDataAccess();

            _groceryListQueries = new GroceryListQueries(dataAccess);
        }

        [HttpGet]
        public IActionResult GetGroceryLists()
        {
            var groceryLists = _groceryListQueries.GetGroceryLists();

            return Ok(groceryLists.Select(l => l.ToContract($"/grocerylists/{l.Id}/items")));
        }

        [HttpGet("{id}")]
        public IActionResult GetGroceryList(int id)
        {
            var groceryList = _groceryListQueries.GetGroceryList(id);

            return Ok(groceryList.ToContract($"/grocerylists/{id}/items"));

        }

        [HttpGet("{id}/items")]
        public IActionResult GetGroceryListItems(int id)
        {
            var items = _groceryListQueries.GetGroceryListItems(id);

            return Ok(items.Select(i => i.ToContract("/groceries")));
        }
    }
}
