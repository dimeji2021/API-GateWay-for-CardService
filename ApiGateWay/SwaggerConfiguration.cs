using Microsoft.OpenApi.Models;

namespace ApiGateWay
{
    public static class SwaggerConfiguration
    {
        public static void AddSwaggerConfiguration(this IServiceCollection services)
        {
            //Some swagger UI settings
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "1",
                    Title = "Card Service API",
                    Description = "Gateway for microservices",
                    //Contact = new OpenApiContact
                    //{
                    //    Name = "fintech.africa.net@gmail.com",
                    //    Url = new Uri("mailto:fintech.africa.net@gmail.com")
                    //}
                });
                c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
            });
        }
    }
}
