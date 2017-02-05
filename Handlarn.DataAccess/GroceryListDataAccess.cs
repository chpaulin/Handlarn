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

        public IEnumerable<GroceryListItem> GetGroceryListItems(int id)
        {
            return new []{
                new GroceryListItem
                {
                    Count = 1,
                    GroceryTypeId = 1,
                    Id = 1,
                    Name = "Mjölk"
                }
            };
        }

        public IEnumerable<GroceryList> GetGroceryLists()
        {
            return new[] { GetGroceryList(1) };
        }
    }
}
