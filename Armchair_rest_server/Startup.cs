﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Armchair_rest_server.Providers;

[assembly: OwinStartup(typeof(Armchair_rest_server.Startup))]
namespace Armchair_rest_server
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureOAuth(app);
            HttpConfiguration config = new HttpConfiguration();
            WebApiConfig.Register(config);
            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);
            app.UseWebApi(config);
        }

        public void ConfigureOAuth(IAppBuilder app)
        {
            OAuthAuthorizationServerOptions OAuthServerOptions = new OAuthAuthorizationServerOptions()
            {
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/token"),
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(1),
                Provider = new SimpleAuthorizationServerProvider()
            };

            // Token Generation
            app.UseOAuthAuthorizationServer(OAuthServerOptions);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());

        }
    }

}