using System.Collections.Generic;

namespace Handlarn.Domain.Interfaces
{
    public interface IGroceryListDataAccess
    {
        IEnumerable<GroceryList> GetGroceryLists();
        GroceryList GetGroceryList(int id);
        IEnumerable<GroceryListItem> GetGroceryListItems(int id);
    }
}