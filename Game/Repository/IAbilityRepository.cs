using Game.Entity;
using Game.Entity.Type;

namespace Game.Repository;

public interface IAbilityRepository
{
    Ability Get(Abilities type);
}