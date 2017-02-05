using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Handlarn.Api.Contracts
{
    public class GroceryListItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public Uri GroceryType { get; set; }        
    }
}
