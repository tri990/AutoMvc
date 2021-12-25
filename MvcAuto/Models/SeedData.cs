using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcAuto.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcAuto.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcAutoContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcAutoContext>>()))
            {
                // Look for any movies.
                if (context.Auto.Any())
                {
                    return;   // DB has been seeded
                }
                context.Manufacturer.AddRange(
                    new Manufacturer
                    {
                        Name = "Kia",
                        Address = "Югорский тракт, 1",
                        Email = "Kia@mail.ru",
                    },
                    new Manufacturer
                    {
                        Name = "Nissan",
                        Address = "Профсоюзов, 1/3",
                        Email = "Nissan@mail.ru",
                    },
                    new Manufacturer
                    {
                        Name = "Toyota",
                        Address = "Энергостроителей, 3",
                        Email = "Toyota@mail.ru",
                    }
                );

                context.Auto.AddRange(
                    new Auto
                    {
                        Name = "Rio",
                        Body = "Седан",
                        Color = "Оранжевый",
                        ManufacturerName = "Kia"
                    },
                    new Auto
                    {
                        Name = "Camry",
                        Body = "Седан",
                        Color = "Чёрный",
                        ManufacturerName = "Toyota"
                    },
                    new Auto
                    {
                        Name = "Qushqai",
                        Body = "Внедорожник",
                        Color = "Синий",
                        ManufacturerName = "Nissan"
                    },
                    new Auto
                    {
                        Name = "Highlander",
                        Body = "Внедорожник",
                        Color = "Красный",
                        ManufacturerName = "Toyota"
                    },
                    new Auto
                    {
                        Name = "Elgrand",
                        Body = "Минивэн",
                        Color = "Чёрный",
                        ManufacturerName = "Nissan"
                    },
                    new Auto
                    {
                        Name = "Sportage",
                        Body = "Внедорожник",
                        Color = "Белый",
                        ManufacturerName = "Kia"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
