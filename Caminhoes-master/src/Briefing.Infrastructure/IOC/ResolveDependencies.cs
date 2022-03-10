using caminhoes.Domain.Interfaces.Mediatrs;
using caminhoes.Domain.Mediatrs;
using caminhoes.Infrastructure.AutoMapper;
using caminhoes.Infrastructure.Swagger;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Diagnostics.CodeAnalysis;
using AutoMapper;
using caminhoes.Domain.Interfaces.Repositories;
using caminhoes.Infrastructure.Data.Repositories;
using caminhoes.Infrastructure.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using caminhoes.Application.Commands;
using caminhoes.Application.Queries;

namespace caminhoes.Infrastructure.IOC
{
    [ExcludeFromCodeCoverage]
    public static class ResolveDependencies
    {
        public static IServiceCollection Register(this IServiceCollection services, IConfiguration configuration)
        {
            services.SwaggerAdd();

            services.AddScoped<ICaminhaoQueries, caminhaoQueries>();
            
            services.AddScoped<IRequestHandler<CaminhaoCommand,bool>, CaminhaoCommandHandler>();

            services.AddScoped<ICaminhaoRepository, CaminhaoRepository>();
            services.AddDbContext<QuizContext>(options => options.UseSqlServer(configuration.GetConnectionString("caminhoesConnection")));
            services.AddAutoMapper(
                typeof(ViewModelToCommandMappingProfile),
                typeof(ViewModelToDomainMappingProfile));

            var assembly = AppDomain.CurrentDomain.Load("caminhoes.Application");
            services.AddMediatR(assembly);
            services.AddTransient<IMediatrHandler, MediatrHandler>();

            return services;
        }
        public static IApplicationBuilder Register(this IApplicationBuilder app)
        {
            app.SwaggerAdd();
            return app;
        }
    }
}
