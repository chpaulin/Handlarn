using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Handlarn.Api.Contract
{
    public class GroceryList
    {
        public int Id { get; set; }
        public string Name { get; set; }                
        public Uri Items { get; set; }
    }   
}
