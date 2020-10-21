using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using P3.Challenge.FileSystemApp.Contract;
using P3.Challenge.FileSystemApp.Model.Repositories;
using P3.Challenge.FileSystemApp.Repository;
using P3.Challenge.FileSystemApp.Service;
using P3.Challenge.FileSystemApp.Service.Mapping;

namespace P3.Challenge.FileSystemApp.IOC
{
    public static class ServiceConfiguration
    {
        public static void ConfigureServices(this IServiceCollection services, IConfiguration configuration)
        {
            ConfigureApplicationServices(services, configuration);
            ConfigureRepositories(services, configuration);
        }

        private static void ConfigureApplicationServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IFileService, FileService>();
            services.AddTransient<IFolderService, FolderService>();

            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new FileMappingProfile());
                mc.AddProfile(new FolderMappingProfile());
            });

            services.AddSingleton(mappingConfig.CreateMapper());
        }

        private static void ConfigureRepositories(IServiceCollection services, IConfiguration configuration)
        {
            var dbConfig = configuration.GetSection(nameof(DbConfig)).Get<DbConfig>();
            services.AddDbContext<P3DbContext>(options =>
            {
                options.UseSqlServer(dbConfig.ConnectionString);
            });

            services.AddTransient<IFolderRepository, FolderRepository>();
        }
    }
}
