﻿using System.Web;
using System.Web.Mvc;

namespace Campus_Social_Network
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
