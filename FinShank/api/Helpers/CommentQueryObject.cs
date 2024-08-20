using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;


namespace api.Helpers
{
    public class CommentQueryObject
    {
        public string? Symbol { get; set; } = null;

        public bool IsDecsending { get; set; } = false;

    }
}