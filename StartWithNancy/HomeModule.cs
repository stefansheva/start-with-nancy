using System;
using Nancy;

namespace StartWithNancy
{
    public class HomeModule: NancyModule
    {
        public HomeModule()
        {
            Get["/"] = p => "Hello World";
            Get["/show-html"] = p => View["index.html"];
        }
    }
}
