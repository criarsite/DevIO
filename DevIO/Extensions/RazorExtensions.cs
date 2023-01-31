using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Razor;

namespace DevIO.Extensions
{
    public static class RazorExtensions
    {
        public static string FormataDcumento (this RazorPage page, int tipoPessoa, string documento)
        {
            return tipoPessoa ==1 ? Convert.ToUInt64(documento).ToString(@"000\.000\.000\-00") : Convert.ToUInt64(documento).ToString(@"00\.000\.000\/0000\-00");

        }
    }
}
