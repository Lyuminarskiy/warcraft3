using Game.Entity;
using Game.Entity.Type;
using Game.Repository;

var players = new List<Player>
{
    new (Race.Human, false),
    new ( false),
    new (Race.Orc),
    new ()
};

var game = new Game.Game();
game.Start(players);

IUnitRepository repository = new UnitRepository();
var unit = repository.Get(Units.Sorceress);
var ability = unit.Abilities.First(ability => ability.Position == 9);

Console.WriteLine();