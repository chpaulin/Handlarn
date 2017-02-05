using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Handlarn.Api
{
    public static class GroceryListExtensions
    {
        public static Contract.GroceryList ToContract(this Domain.GroceryList groceryList, string itemsUrl)
        {
            return new Contract.GroceryList
            {
                Id = groceryList.Id,
                Name = groceryList.Name,
                Items = new Uri(itemsUrl, UriKind.Relative)
            };
        }

        public static Contract.GroceryListItem ToContract(this Domain.GroceryListItem groceryListItem, string groceryTypesUrl)
        {
            return new Contract.GroceryListItem
            {
                Id = groceryListItem.Id,
                Name = groceryListItem.Name,
                Count = groceryListItem.Count,
                GroceryType = new Uri($"{groceryTypesUrl}/{groceryListItem.GroceryTypeId}", UriKind.Relative)
            };
        }
    }
}
