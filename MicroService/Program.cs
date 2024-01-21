using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using MicroService;
using MicroService.Abstractions;
using MicroService.Mapper;
using MicroService.Mutation;
using MicroService.Query;
using MicroService.Services;

internal class Program
{
    private static void Main(string[] args)
    {

        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddMemoryCache();
        builder.Services.AddAutoMapper(typeof(MapperProfile));
        builder.Services.AddTransient<IProductServices, ProductServices>();
        builder.Services.AddTransient<IStorageServices, StorageServices>();
        builder.Services.AddTransient<ICategoryServices, CategoryServices>();
        builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
        builder.Host.ConfigureContainer<ContainerBuilder>(cb =>
        {
            cb.Register(c => new AppDbContext(builder.Configuration.GetConnectionString("DB"))).InstancePerDependency();
        });
        builder.Services.AddGraphQLServer().AddQueryType<MySimpleQuery>().AddMutationType<MySimpleMutation>();

        var app = builder.Build();
        app.MapGraphQL();
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        app.Run();
    }
}