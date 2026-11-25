# Gulomova

Лабораторная работа: Entity Framework + UserControl (Windows Forms, .NET Framework 4.7.2).
Программа подключается к БД `MotorbikeDB`, показывает таблицу `Table_Motorbike` плитками (2 `UserControl`) с листанием кнопками `<` и `>`.
Дополнительное задание: фильтрация по модели, бренду, цене, мощности (л.с.), пробегу.

## Запуск
1. В SSMS выполнить `Database/MotorbikeDB.sql` (создаёт БД, таблицу и 20 записей).
2. Открыть `Gulomova.sln` в Visual Studio, восстановить NuGet-пакеты (EntityFramework 6.4.4).
3. При необходимости поправить строку подключения в `Gulomova/App.config` (по умолчанию `.\SQLEXPRESS`).
4. Собрать (Ctrl+Shift+B) и запустить. Папка `Pictures` копируется в `bin\Debug` автоматически.
