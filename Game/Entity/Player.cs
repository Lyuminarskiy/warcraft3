namespace Game.Entity;

public class Player
{
    
    public readonly Race Race;
    public readonly IList<Unit> Units = new List<Unit>();
    // private readonly IUnitFactory _unitFactory;

    public double Gold = 500;
    public double Lumber = 150;
    // public double CurrentFood => Units.Aggregate(0, (acc, unit) => acc += unit.GetFoodCost());
    public double FoodCap { get; }

    public readonly bool Computer;

    public Player(Race race, bool computer = true)
    {
        Race = race;
        // _unitFactory = Race.GetUnitFactory();
        Computer = computer;

        var builders = new List<Unit>
        {
            // _unitFactory.createBuilder(),
            // _unitFactory.createBuilder(),
            // _unitFactory.createBuilder(),
            // _unitFactory.createBuilder(),
            // _unitFactory.createBuilder()
        };
        builders.ForEach(unit => Units.Add(unit));
    }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="Player"/> со случайной расой <see cref="Race"/>.
    /// </summary>
    /// <param name="computer">Компьютерный игрок.</param>
    public Player(bool computer = true): this(GetRandomRace(), computer) {}

    private static Race GetRandomRace()
    {
        Array races = Enum.GetValues(typeof(Race));
        return (Race) races.GetValue(new Random().Next(races.Length))!;
    }
}