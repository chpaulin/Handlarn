using System.Collections.Generic;

namespace Handlarn.Domain.Interfaces
{
    public interface IGroceryListQueries
    {
        IEnumerable<GroceryList> GetGroceryLists(IEnumerable<string> embed);
        GroceryList GetGroceryList(int id, IEnumerable<string> embed);
    }
}