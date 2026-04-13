using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.TicketManagement.Application
{
    
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(cfg => cfg.LicenseKey = "eyJhbGciOiJSUzI1NiIsImtpZCI6Ikx1Y2t5UGVubnlTb2Z0d2FyZUxpY2Vuc2VLZXkvYmJiMTNhY2I1OTkwNGQ4OWI0Y2IxYzg1ZjA4OGNjZjkiLCJ0eXAiOiJKV1QifQ.eyJpc3MiOiJodHRwczovL2x1Y2t5cGVubnlzb2Z0d2FyZS5jb20iLCJhdWQiOiJMdWNreVBlbm55U29mdHdhcmUiLCJleHAiOiIxNzg4OTEyMDAwIiwiaWF0IjoiMTc1NzQ0MDI4OCIsImFjY291bnRfaWQiOiIwMTk5MmY5OTA2NGM3ODc5OTQ2ZDExMTQ5OTQ3Y2IwNiIsImN1c3RvbWVyX2lkIjoiY3RtXzAxazRxc245YnphNXd2ZnZkMDRoYWU0YTRyIiwic3ViX2lkIjoiLSIsImVkaXRpb24iOiIwIiwidHlwZSI6IjIifQ.BwGGgBCeoWxg_gpleiaH2JLkuWRadJW6M0_K2CS5miIBto91fG-da2CoOq3-OEwAV2jeKLuSanRoS1NtfmFbU0GyzwQ_O1ag2htti-Icix5cDQWkK5okiMIlC0r2NR9QNBDcBQ0Q383_dmAj5BoE1kM3ib7PQnTyGIcQsceXOYjVaTQrMU_tAnVBMignCUGOWDLCnUQpdG1sX2txaK0ets6kxvZXLgQEPxmCOAuFBNc_kiXGeWtqmVoZNj2oAvV78Js1NapF5qh5T6f8yAWMu7H7QMbQr6XQSuKT4A5jnbyPrVWB5zX97recdh6M1srH0oR2LVVvwRY5kZTNMWkDyA",
                AppDomain.CurrentDomain.GetAssemblies());
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()));

            return services;
        }
    }
}
