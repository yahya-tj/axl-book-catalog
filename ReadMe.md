﻿ <img align="left" width="116" height="116" src="https://raw.githubusercontent.com/jasontaylordev/CleanArchitecture/main/.github/icon.png" />

# AXL Book Catalog with Clean Architecture Solution

## Запуск проекта
Для успешного запуска проекта необходимо настроить конфигурацию проекта Client API и Admin API



## Technologies

* [ASP.NET Core 3.1](https://docs.microsoft.com/en-us/aspnet/core/)
* [Entity Framework Core 5](https://docs.microsoft.com/en-us/ef/core/)
* [MediatR](https://github.com/jbogard/MediatR)
* [AutoMapper](https://automapper.org/)
* [FluentValidation](https://fluentvalidation.net/)

## Overview

### Domain

This will contain all entities, enums, exceptions, interfaces, types and logic specific to the domain layer.

### Application

This layer contains all application logic. It is dependent on the domain layer, but has no dependencies on any other layer or project. This layer defines interfaces that are implemented by outside layers. For example, if the application need to access a notification service, a new interface would be added to application and an implementation would be created within infrastructure.

### Infrastructure

This layer contains classes for accessing external resources such as file systems, web services, smtp, and so on. These classes should be based on interfaces defined within the application layer.

### WebAPI

You description here


### Упорядочение кода в рамках чистой архитектуры
В решении с чистой архитектурой для каждого проекта четко определены обязанности. Фактически, каждому проекту будут принадлежать определенные типы, а в проектах будут представлены соответствующие этим типам папки.

### Ядро приложения
Ядро приложения содержит бизнес-модель, которая включает в себя сущности, службы и интерфейсы. Такие интерфейсы включают абстракции для операций, которые будут выполняться с использованием архитектуры, включая операции доступа к данным или файловой системе, сетевые вызовы и т. д. В некоторых случаях службы или интерфейсы, определенные в этом слое, должны работать с типами, не являющимися типами сущностей, которые не имеют зависимостей от пользовательского интерфейса или инфраструктуры. Они могут определяться как простые объекты передачи данных.

Типы ядра приложения
* Сущности (сохраняемые классы бизнес-модели)
* Агрегаты (группы сущностей).
* Интерфейсы
* Доменные службы
* Спецификации
* Пользовательские исключения и предложения условий.
* События домена и обработчики.
* Инфраструктура 

Как правило, проект инфраструктуры включает реализацию доступа к данным. В типовом веб-приложении ASP.NET Core эта реализация включает Entity Framework (EF) DbContext, любые определенные объекты Migration EF Core, а также классы реализации доступа к данным. Наиболее распространенный подход к абстрагированию кода реализации доступа к данным заключается в использовании конструктивного шаблона репозитория.

Помимо реализации доступа к данным, проект инфраструктуры должен также включать реализации служб, которые должны взаимодействовать с инфраструктурными задачами. Эти службы должны реализовывать интерфейсы, определенные в ядре приложения. Таким образом, инфраструктура должна содержать ссылку на проект ядра приложения.

### Типы инфраструктуры
* Типы EF Core (DbContext, Migration)
* Типы реализации доступа к данным (репозитории)
* Службы, связанные с инфраструктурой (например, FileLogger или SmtpNotifier)
* Уровень пользовательского интерфейса
Слой пользовательского интерфейса в приложении MVC ASP.NET Core выступает в качестве точки входа для приложения. Этот проект должен ссылаться на слой ядра приложения, а его типы должны взаимодействовать с инфраструктурой строго через интерфейсы, определенные в ядре приложения. В слое пользовательского интерфейса не должны разрешаться прямое создание экземпляров для типов слоя инфраструктуры, а также их статические вызовы.

### Уровень пользовательского интерфейса
Слой пользовательского интерфейса в приложении MVC ASP.NET Core выступает в качестве точки входа для приложения. Этот проект должен ссылаться на слой ядра приложения, а его типы должны взаимодействовать с инфраструктурой строго через интерфейсы, определенные в ядре приложения. В слое пользовательского интерфейса не должны разрешаться прямое создание экземпляров для типов слоя инфраструктуры, а также их статические вызовы.

### Типы слоев пользовательского интерфейса
* Контроллеры
* Настраиваемые фильтры
* Пользовательское ПО промежуточного слоя.
* Представления
* Модели представлений
* Запуск

Класс Startup или файл Program.cs отвечает за настройку приложения и связывание типов реализации с интерфейсами. Расположение, где выполняется эта логика, называется корнем композиции приложения. Он обеспечивает правильное внедрение зависимостей во время выполнения.