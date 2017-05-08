﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using RSMuseum.MVC.Models;
using RSMuseum.Services;
using SimpleInjector;
using SimpleInjector.Integration.Web.Mvc;

namespace RSMuseum.MVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            UnityConfig.RegisterComponents();
            AreaRegistration.RegisterAllAreas();


            UnityServicesSetup.RegisterComponents();
            GlobalConfiguration.Configure(WebApiConfig.Register);


            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            HttpConfiguration config = GlobalConfiguration.Configuration;

            config.Formatters.JsonFormatter
                        .SerializerSettings
                        .ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            // Instantiere vores DI container
            // new DI();



            //Dont uncomment and run please
            //var generateFakeData = DI.Container.GetInstance<GenerateFakeData>();
            // DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(DI.Container));

            UnityConfig.RegisterComponents();
        }
    }
}