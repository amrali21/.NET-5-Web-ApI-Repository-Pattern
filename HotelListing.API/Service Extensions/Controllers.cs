using HotelListing.API.Contracts;
using HotelListing.API.Repository;
using Microsoft.Extensions.Configuration;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class Controllers
    {
        public static IServiceCollection AddRepoServices(
        this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<ICountriesRepository, CountriesRepository>();
            services.AddScoped<IHotelsRepository, HotelsRepository>();

            return services;
        }
    }
}
