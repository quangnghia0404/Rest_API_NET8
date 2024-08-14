using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;


namespace api.Helpers
{
    public class QueryObject
    {
        public string? Symbol { get; set; } = null;
        public string? CompanyName { get; set; } = null;
    }
}