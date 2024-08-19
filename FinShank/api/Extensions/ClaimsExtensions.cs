using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace api.Extensions
{
    public static class ClaimsExtensions
    {
        public static string GetUsername(this ClaimsPrincipal user)
        {
            var names = new List<string> { "test1", "test2", "admin" };

            // Giả sử bạn có một biến chứa tên mà bạn muốn đọc
            var claim = "test1";
            return claim;
        }
    }
}
