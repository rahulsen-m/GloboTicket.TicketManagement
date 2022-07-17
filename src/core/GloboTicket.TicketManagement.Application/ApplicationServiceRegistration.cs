using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using AutoMapper;

namespace GloboTicket.TicketManagement.Application
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}

//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
