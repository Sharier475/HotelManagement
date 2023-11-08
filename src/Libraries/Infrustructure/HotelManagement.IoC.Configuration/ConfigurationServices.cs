using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using HotelManagement.Infrustructure;
using Microsoft.EntityFrameworkCore;
using HotelManagement.Core.Mapper;
using HotelManagement.Repositories.Interface;
using HotelManagement.Repositories.Base;
using HotelManagement.Core;

namespace HotelManagement.IoC.Configuration;

public static class ConfigurationServices
{
    public static IServiceCollection AddExtention(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<HotelManagementDbContext>(options =>
        options.UseSqlServer(configuration.GetConnectionString("DbConn")));
        services.AddAutoMapper(typeof(CommonMapper).Assembly);

        services.AddTransient<IGuestRepository, GuestRepository>();
        services.AddMediatR(options =>
        options.RegisterServicesFromAssemblies(typeof(ICore).Assembly));

        return services;
    }
    
}
