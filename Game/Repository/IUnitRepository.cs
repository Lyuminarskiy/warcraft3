using Game.Entity;
using Game.Entity.Type;

namespace Game.Repository;

public interface IUnitRepository
{
    Unit Get(Units type);
}