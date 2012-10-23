using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy.ModelBinding;
using gozinta.Models;

namespace gozinta.Modules
{
    public class HomeModule : NancyModule
    {
        SearchModel search = new SearchModel();

        public HomeModule()
        {
            Get["/"] = parameters =>
            {
                return View["Index"];
            };

            Post["/ISBN"] = parameters =>
            {
                search = this.Bind();

                var ISBN = search.ISBN;

                return 200;
            };
        }
    }
}