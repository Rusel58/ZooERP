using System;
using Microsoft.Extensions.DependencyInjection;
using ZooERP.Core.Models.Animals;
using ZooERP.DependencyInjection;
using ZooERP.Services;

class Program
{
    static void Main()
    {
        // Настройка DI-контейнера.
        var serviceProvider = DependencyInjectionConfig.Configure();

        // Получение сервисов.
        var zooService = serviceProvider.GetService<ZooService>();
        var vetClinic = serviceProvider.GetService<VeterinaryClinic>();
        var reportService = serviceProvider.GetService<ReportService>();

        // Проверка, что сервисы не null.
        if (zooService == null || vetClinic == null || reportService == null)
        {
            Console.WriteLine("Ошибка: один или несколько сервисов не были инициализированы.");
            return;
        }

        // Добавление животных.
        var rabbit = new Rabbit(2, 101, 7);
        zooService.AddAnimal(rabbit, vetClinic);

        var monkey = new Monkey(4, 100, 4);
        zooService.AddAnimal(monkey, vetClinic);

        var tiger = new Tiger(10, 102);
        zooService.AddAnimal(tiger, vetClinic);

        // Вывод отчёта.
        reportService.PrintFoodReport(zooService);
    }
}
