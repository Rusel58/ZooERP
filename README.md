# ZooERP - Система учёта животных и инвентаря Московского зоопарка

---

## Описание проекта
ZooERP - это консольное приложение, позволяющее вести учёт животных и инвентаря зоопарка.
Приложение следует принципам SOLID и использует Dependency Injection (DI) для управления зависимостями.

---

## Структура проекта
```plaintext
ZooERP/
│── Core/
│   ├── Interfaces/
│   │   ├── IAlive.cs
│   │   ├── IInventory.cs
│   ├── Models/
│   │   ├── Animals/
│   │   │   ├── Animal.cs
│   │   │   ├── Herbo.cs
│   │   │   ├── Monkey.cs
│   │   │   ├── Predator.cs
│   │   │   ├── Rabbit.cs
│   │   │   ├── Tiger.cs
│   │   │   ├── Wolf.cs
│   │   ├── Inventory/
│   │   │   ├── Thing.cs
│   │   │   ├── Table.cs
│   │   │   ├── Computer.cs
│── DependencyInjection/
│   ├── DependencyInjectionConfig.cs
│── Services/
│   ├── ReportService.cs
│   ├── VeterinaryClinic.cs
│   ├── ZooService.cs
│── Tests/
│── Program.cs
│── README.md
│── ZooERP.sln
```
---

## Принципы SOLID в проекте
### S - Single Responsibility Principle (Принцип единственной ответственности)
Каждый класс в системе отвечает только за одну задачу:
- `ZooService` - управляет списком животных.
- `VeterinaryClinic` - проверяет здоровье животных.
- `ReportService` - отвечает за генерацию отчётов.
- `DependencyInjectionConfig` - настраивает DI-контейнер.

Этот подход позволяет избежать перегрузки классов ненужной логикой и делает код более читаемым и поддерживаемым.

---

### O - Open/Closed Principle (Принцип открытости/закрытости)
Код открыт для расширения, но закрыт для модификации:
- Можно добавить новые классы животных без изменения `Animal`.
- Можно расширить `ReportService`, добавив новые типы отчётов, не меняя его существующую логику.

Это достигается за счёт наследования и использования интерфейсов.

---

### L - Liskov Substitution Principle (Принцип подстановки Барбары Лисков)
Дочерние классы (`Rabbit`, `Tiger`) могут заменять родительский `Animal` без изменения кода:
```csharp
Animal animal = new Rabbit(3, 102, 6);
```
Код работает независимо от того, какое животное передаётся, что делает его гибким.

---

### I - Interface Segregation Principle (Принцип разделения интерфейсов)
Вместо одного большого интерфейса используются раздельные интерфейсы:
- `IAlive` определяет свойство `Food`, нужное только для живых существ.
- `IInventory` определяет `Number`, нужное для учёта инвентаря.

Такой подход позволяет не перегружать классы ненужными методами.

---

### D - Dependency Inversion Principle (Принцип инверсии зависимостей)
Вместо создания зависимостей внутри классов они внедряются через DI-контейнер:
```csharp
var serviceProvider = DependencyInjectionConfig.Configure();
var zooService = serviceProvider.GetService<ZooService>();
```
Благодаря этому:
- Легко заменить реализацию (`Mock-объекты` в тестах).
- Улучшается масштабируемость.

---

## Запуск проекта
### 1. Установка зависимостей
Перед запуском установите пакет DI в консоли NuGet:
```powershell
Install-Package Microsoft.Extensions.DependencyInjection
```

### 2. Компиляция и запуск
Запустите Visual Studio и выполните:
```
Ctrl + F5
```
Программа запустится и выведет данные о зоопарке.
