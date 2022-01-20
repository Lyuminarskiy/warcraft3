# Объектно-ориентированное программирование

Используемые шаблоны проектирования:
- Порождающие:
    - Одиночка - [`Game.UI.Cursor`](Game/Game/UI/Cursor.cs)
    - Абстрактная фабрика - [`Game.Entities.Units.Base.IUnitFactory`](Game/Game/Entities/Units/Base/IUnitFactory.cs)
- Структурные:
- Поведенческие:
    - Наблюдатель - [`Game.UI.Cursor`](Game/Game/UI/Cursor.cs), [`Game.UI.Screen`](Game/Game/UI/Screen.cs)
    - Стратегия - [`Game.UI.Screen`](Game/Game/UI/Screen.cs)