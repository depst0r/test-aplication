# Тестовое задание.
Для запуска проекта: Window/macOS.
1. Устоновить .NET [Для всех ОС](https://learn.microsoft.com/ru-ru/dotnet/core/install/)
2. Устоновить GIT. [Для всех ОС](https://git-scm.com/book/ru/v2/%D0%92%D0%B2%D0%B5%D0%B4%D0%B5%D0%BD%D0%B8%D0%B5-%D0%A3%D1%81%D1%82%D0%B0%D0%BD%D0%BE%D0%B2%D0%BA%D0%B0-Git)
3. Склонировать репозиторий, в консоле прописать команду: `git clone https://github.com/depst0r/test-aplication`
4. Завйти в папку с клонированным репозиторием, прописать команду  `cd test-aplication`
5. Запуск проект, в консоле прописать команду `dotnet run`
6. В браузере перейти: `https://localhost:7179`

## Структура репозитория.
1. Папка ClientApp => React SPA основной контент.
2. Папка Сontrollers => CardsController.cs => Контроллеры.
3. Папка Pages => содержит стандартные View из шаблона.
4. Папка Propeties => настройки запуска проекта.
5. В файле .gitignore => перечень файлов и папок, которые не будут индексироваться с git.
6. В файле Program.cs => настройка служб необходимых приложению.
7. Файл README.md => Файлс с информацией, о запуске и структуре приложения.
8. Файл appsettings.Development.json => Настройки в режими разработки.
9. Файл appsettings.json => Продакшн настройки проект.
10. В корне репозитория data.json база данных. 
11. Файл testapplication.csproj => Конфигурация проекта и список зависимостей.

