﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FileExplorerApp.Web.Startup))]
namespace FileExplorerApp.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}