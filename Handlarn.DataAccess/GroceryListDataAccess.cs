using Handlarn.Domain;
using Handlarn.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Handlarn.DataAccess
{
    public class GroceryListDataAccess : IGroceryListDataAccess
    {
        public GroceryList GetGroceryList(int id)
        {
            return new GroceryList
            {
                Id = id,
                Name = "Test"                
            };
        }

        public IEnumerable<GroceryList> GetGroceryLists()
        {
            return new[] { GetGroceryList(1) };
        }
    }
}
