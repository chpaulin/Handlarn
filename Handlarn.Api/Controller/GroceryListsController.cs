using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

            return Ok(groceryLists.Select(g => g.ToContract($"/grocerylists/{g.Id}/items")));
        }

        [HttpGet("{id}")]
        public IActionResult GetGroceryList(int id)
        {
            var groceryList = _groceryListQueries.GetGroceryList(id);

            return Ok(groceryList.ToContract($"/grocerylists/{id}/items"));

        }

        //[HttpGet("{id}/items")]
        //public IActionResult GetGroceryListItems(int id)
        //{
        //    return Ok(new[]{
        //        new GroceryListItemShallow
        //        {
        //            Id = id,
        //            Name = "Test",
        //            Count = 1,
        //            GroceryType = $"/Groceries/1"
        //        }
        //    });
        //}
    }
}
