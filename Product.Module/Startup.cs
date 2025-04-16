using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.ContentManagement;
using OrchardCore.Data.Migration;
using OrchardCore.Modules;
using Product.Module.Migrations;

namespace Product.Module;

public sealed class Startup : StartupBase
{

    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddScoped<IDataMigration, ProductMigrations>();
    }

    public override void Configure(IApplicationBuilder builder, IEndpointRouteBuilder routes, IServiceProvider serviceProvider)
    {

        routes.MapAreaControllerRoute(
            name: "Home",
            areaName: "Product.Module",
            pattern: "Home/Index",
            defaults: new { controller = "Home", action = "Index" }
        );

        routes.MapAreaControllerRoute(
            name: "Product",
            areaName: "Product.Module",
            pattern: "product", // re write url 
            defaults: new { controller = "Product", action = "Index" }
        );

        routes.MapAreaControllerRoute(
            name: "ProductCreate",
            areaName: "Product.Module",
            pattern: "product/create", // re write url 
            defaults: new { controller = "Product", action = "Create" }
        );
    }
}

