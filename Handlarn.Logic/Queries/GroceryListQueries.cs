using Handlarn.Domain;
using Handlarn.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Handlarn.Logic.Queries
{
    public class GroceryListQueries : IGroceryListQueries
    {
        private readonly IGroceryListDataAccess _groceryListDataAccess;

        public GroceryListQueries(IGroceryListDataAccess groceryListDataAccess)
        {
            _groceryListDataAccess = groceryListDataAccess;
        }

        public IEnumerable<GroceryList> GetGroceryLists(IEnumerable<string> embed)
        {
            var groceryLists = _groceryListDataAccess.GetGroceryLists();            

            return groceryLists;
        }

        public GroceryList GetGroceryList(int id, IEnumerable<string> embed)
        {
            var groceryList = _groceryListDataAccess.GetGroceryList(id);            

            return groceryList;
        }
    }
}
