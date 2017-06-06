using System;
using Microsoft.AspNetCore.Mvc.Razor;

namespace QLHH.Extentions
{
    public abstract class CustomRazorPage<T>:RazorPage<T>
    {
        public string IsActiveClass(string url)
        {
            var currentPath = Context.Request.Path;
            return currentPath == url ? "active" : String.Empty;
        }
    }
}
