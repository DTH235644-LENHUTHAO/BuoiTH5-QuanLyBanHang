using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QuanLyBanHang.Helpers
{
    public static class StringExtensions
    {
        public static string GenerateSlug(this string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return string.Empty;

            input = input.ToLowerInvariant();

            // Bỏ dấu tiếng Việt
            input = Regex.Replace(input, @"[àáạảãâầấậẩẫăằắặẳẵ]", "a");
            input = Regex.Replace(input, @"[èéẹẻẽêềếệểễ]", "e");
            input = Regex.Replace(input, @"[ìíịỉĩ]", "i");
            input = Regex.Replace(input, @"[òóọỏõôồốộổỗơờớợởỡ]", "o");
            input = Regex.Replace(input, @"[ùúụủũưừứựửữ]", "u");
            input = Regex.Replace(input, @"[ỳýỵỷỹ]", "y");
            input = Regex.Replace(input, @"đ", "d");

            // Bỏ ký tự đặc biệt
            input = Regex.Replace(input, @"[^a-z0-9\s-]", "");
            input = Regex.Replace(input, @"\s+", "-").Trim('-');

            return input;
        }
    }
}
